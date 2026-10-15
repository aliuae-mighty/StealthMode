using StealthMode.Configuration;
using StealthMode.Core;
using StealthMode.Extensions;
using StealthMode.Forms;
using StealthMode.Services;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StealthMode
{
    public partial class MainForm : Form
    {        
        private GlobalHotkeyManager _hotkeyManager;
        private OverlayForm _overlayForm;
        private ScheduledTurnOffService _turnOffService;
        private CancellationTokenSource _automationCts;
        private MousePlayer _mousePlayer;

        public AppConfig ConfigManager { get; set; }
        public string ApplicationStatus { get; private set; }

        public MainForm()
        {
            InitializeComponent();

            _turnOffService = new ScheduledTurnOffService();
            _turnOffService.Triggered += TurnOffService_Triggered;
            _mousePlayer = new MousePlayer();
        }

        private void TurnOffService_Triggered(object sender, EventArgs e)
        {
            StopAllActivities("Turn Off All Events time reached.");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateConfigManager();
            
            Form mini = _mousePlayer.GetOrCreateMiniForm(new MousePlayer.POINT { X = 0, Y = 0 });
            mini.Hide();
            this.Activate();
        }

        public void UpdateConfigManager()
        {
            ConfigManager = Configuration.ConfigManager.Load();
            Configuration.ConfigManager.ApplyToParentForm(this, ConfigManager);
        }

        private void StopAutomation()
        {
            _turnOffService.Stop();
            _mousePlayer.Stop();
            _automationCts?.Cancel();
            HideOverlay();
            UpdateStatusLabel("Playback stopped.");
        }

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = !(btnStop.Enabled = true);
            if (_automationCts != null)
            {
                StopAutomation();
                return;
            }

            _automationCts = new CancellationTokenSource();
            CancellationToken token = _automationCts.Token;

            _turnOffService.StartIfEnabled(ConfigManager); 

            ShowOverlay("▶ Running... Press Ctrl + F6 to Stop");
            HideOrCloseApplication();

            try
            {
                do
                {
                    token.ThrowIfCancellationRequested();

                    using (var rowCts = CancellationTokenSource.CreateLinkedTokenSource(token))
                    {
                        try
                        {
                            await DoScenarioActionAsync(rowCts.Token);
                        }
                        catch (OperationCanceledException)
                        {
                            token.ThrowIfCancellationRequested();
                            UpdateStatusLabel($"Duration reached.");
                        }
                    }

                    if (ConfigManager.SettingsTurnOff)
                        UpdateStatusLabel("Looping sequence execution...");

                } while (!token.IsCancellationRequested);

                UpdateStatusLabel("Sequence finished successfully.");
            }
            catch (OperationCanceledException ex)
            {
                UpdateStatusLabel("Sequence stopped by user.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Automation error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _turnOffService.Stop();
                _automationCts?.Dispose();
                _automationCts = null;
                HideOverlay();
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            HideOverlay();
            btnStop.Enabled = !(btnPlay.Enabled = true);
            StopAutomation();
        }

        private async Task DoScenarioActionAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    // Передаем весь scenarioAction в PlayAsync
                    await _mousePlayer.PlayAsync(ConfigManager.Interval, status => UpdateStatusLabel(status));
                }
                catch (Exception ex)
                {
                    if (ex is OperationCanceledException) throw;
                    MessageBox.Show($"Mouse playback error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormManager.ShowOrActivateForm<AppSettingsForm>(null,
                controlName => new AppSettingsForm(this, null));
        }

        protected override void WndProc(ref Message m)
        {
            if (_hotkeyManager != null)
            {
                _hotkeyManager.ProcessMessage(m);
            }
            base.WndProc(ref m);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            _hotkeyManager = new GlobalHotkeyManager(this.Handle);

            // Сначала подписка
            _hotkeyManager.OnStartRequested += () => this.Invoke(new Action(async () => btnPlay_Click(this, EventArgs.Empty)));
            _hotkeyManager.OnStopRequested += () => this.Invoke(new Action(() => btnStop_Click(this, EventArgs.Empty)));

            // Затем регистрация
            _hotkeyManager.RegisterHotkeys();
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            _turnOffService?.Dispose();
            _hotkeyManager?.Dispose();


            if (_overlayForm != null && !_overlayForm.IsDisposed)
            {
                _overlayForm.HideOverlay();
                _overlayForm.Close();
                _overlayForm.Dispose();
            }
            base.OnHandleDestroyed(e);
        }

        private void HideOrCloseApplication()
        {
            if (ConfigManager.SettingsMinimizeOnPlay && ConfigManager.SettingsMinimizeToTray)
                this.Hide();
            if (ConfigManager.SettingsMinimizeOnPlay)
                this.WindowState = FormWindowState.Minimized;
        }

        private void UpdateStatusLabel(string text)
        {
            ApplicationStatus = text;
        }

        private void StopAllActivities(string reason)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => StopAllActivities(reason)));
                return;
            }
            StopAutomation();
            HideOverlay();
            UpdateStatusLabel(reason);
        }

        private void ShowOverlay(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ShowOverlay(message)));
                return;
            }

            if (_overlayForm == null || _overlayForm.IsDisposed)
                _overlayForm = new OverlayForm();

            _overlayForm.SetLabelTitle(message);

            if (!_overlayForm.Visible)
            {
                if (ConfigManager.SettingsShowStatusOverlay)
                    _overlayForm.ShowOverlay(message);
            }
        }

        private void HideOverlay()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(HideOverlay));
                return;
            }
            if (_overlayForm != null && !_overlayForm.IsDisposed)
            { 
                _overlayForm.HideOverlay();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;

            if (ConfigManager.SettingsMinimizeToTray)
            {
                e.Cancel = true;
                this.Hide();
                return;
            }

            DialogResult result = MessageBox.Show(
                 "Are you sure you want to exit?",
                 "Confirm Exit",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
             );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsDonateLabel_Click(object sender, EventArgs e)
        {
            FormManager.ShowOrActivateForm<DonateForm>(null,
                controlName => new DonateForm(this, null));
        }


    }
}