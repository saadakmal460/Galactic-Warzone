using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class WiningScreenForm : Form
    {
        public WiningScreenForm()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void WiningScreenForm_Load(object sender, EventArgs e)
        {

        }

        public void UpdateLabel(string text)
        {
            label1.Text = text;
        }
    }
}
