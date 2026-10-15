using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StealthMode.Forms
{
    public partial class MiniForm : Form
    {
        public MiniForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.AutoSize = false;
            this.ControlBox = false;
            this.Size = new Size(2, 2);
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.BackColor = Color.White;
        }
    }
}
