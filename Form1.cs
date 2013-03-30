using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayRotator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
            this.ActiveControl = this.doNothingButton;
        }

        private void doNothingButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rot90cwButton_Click(object sender, EventArgs e)
        {

        }

        private void rot180Button_Click(object sender, EventArgs e)
        {

        }

        private void rot90ccwButton_Click(object sender, EventArgs e)
        {

        }
    }
}
