using StealthMode.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StealthMode.Core
{
    public class MousePlayer : IDisposable
    {
        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
        }

        private CancellationTokenSource _cts;
        private static readonly Random _random = new Random();

        public bool IsPlaying { get; private set; }

        public static void PerformClick(string button, int x, int y)
        {
            SetCursorPos(x, y);
            Thread.Sleep(30);

            if (string.Equals(button, "Right Button", StringComparison.OrdinalIgnoreCase))
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                Thread.Sleep(20);
                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
            }
            else
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                Thread.Sleep(20);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            }
        }

        public async Task PlayAsync(
            decimal interval = 10,
            Action<string> onStatusUpdate = null)
        {
            // Dispose previous CancellationTokenSource if it exists
            _cts?.Dispose();
            _cts = new CancellationTokenSource();

            CancellationToken token = _cts.Token;

            IsPlaying = true;
            try
            {
                await Task.Run(() => StealthMode(token, interval, onStatusUpdate), token);
            }
            catch (OperationCanceledException)
            {
                // Handle expected cancellation from timeout or manual stop
            }
            finally
            {
                IsPlaying = false;
            }
        }

        public void Stop()
        {
            if (IsPlaying && _cts != null && !_cts.IsCancellationRequested)
            {
                _cts.Cancel();
                IsPlaying = false;
            }
        }

        private void StealthMode(CancellationToken token, decimal interval, Action<string> onStatusUpdate = null)
        {
            while (!token.IsCancellationRequested)
            {
                if (GetCursorPos(out POINT originalPos))
                {
                    Form targetForm = ActivateTargetForm(originalPos);

                    // Move cursor relative to original position
                    int targetX = originalPos.X + 1;
                    int targetY = originalPos.Y + 1;
                    SetCursorPos(targetX, targetY);
                    onStatusUpdate?.Invoke($"Stealth Move: ({targetX}, {targetY})");

                    if (token.WaitHandle.WaitOne(300)) break;
                    if (token.WaitHandle.WaitOne(100)) break;

                    PerformClick("Left Button", targetX, targetY);

                    if (token.WaitHandle.WaitOne(100)) break;

                    // Safely hide target form across UI threads
                    if (targetForm != null && !targetForm.IsDisposed)
                    {
                        if (targetForm.InvokeRequired)
                            targetForm.Invoke(new Action(() => targetForm.Hide()));
                        else
                            targetForm.Hide();
                    }

                    //WindowFocusManager.EnsureProcessFocused(handle);

                    // Check if the user manually moved the mouse
                    if (GetCursorPos(out POINT originalPosNew))
                    {
                        if (originalPosNew.X != targetX || originalPosNew.Y != targetY)
                        {
                            // User moved the mouse — cancel restore and exit
                            return;
                        }
                    }

                    // Restore cursor position
                    SetCursorPos(originalPos.X, originalPos.Y);
                    onStatusUpdate?.Invoke($"Stealth Return: ({originalPos.X}, {originalPos.Y})");
                }

                // Wait for the specified interval with instant cancellation support
                if (token.WaitHandle.WaitOne(TimeSpan.FromSeconds(Convert.ToDouble(interval))))
                {
                    break;
                }
            }
        }

        private Form ActivateTargetForm(POINT originalPos)
        {
            Form targetForm = null;

            if (Application.OpenForms.Count > 0 && Application.OpenForms[0].InvokeRequired)
            {
                Application.OpenForms[0].Invoke(new Action(() =>
                {
                    targetForm = GetOrCreateMiniForm(originalPos);
                }));
            }
            else
            {
                targetForm = GetOrCreateMiniForm(originalPos);
            }

            return targetForm;
        }

        public MiniForm GetOrCreateMiniForm(POINT pos)
        {
            MiniForm form = Application.OpenForms["MiniForm"] as MiniForm;
            if (form == null || form.IsDisposed)
            {
                form = new MiniForm();
            }

            form.Location = new Point(pos.X, pos.Y);
            form.Size = new Size(3, 3);
            form.Show();
            form.Activate();
            return form;
        }

        public void Dispose()
        {
            _cts?.Cancel();
            _cts?.Dispose();
        }

        private struct MouseFrame
        {
            public long ElapsedMs;
            public int X;
            public int Y;
        }
    }
}
