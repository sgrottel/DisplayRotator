using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayRotator {

    /// <summary>
    /// The application main form
    /// </summary>
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
            this.ActiveControl = this.doNothingButton;
        }

        private void doNothingButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Form1_Deactivate(object sender, EventArgs e) {
            this.Close();
        }

        private void rot90cwButton_Click(object sender, EventArgs e) {
            //Orientation or = (Orientation)((Button)sender).Tag;
            //this.setOrientation(or);
            //this.Close();
        }

        private void rot180Button_Click(object sender, EventArgs e) {
            //Orientation or = (Orientation)((Button)sender).Tag;
            //this.setOrientation(or);
            //this.Close();
        }

        private void rot90ccwButton_Click(object sender, EventArgs e) {
            //Orientation or = (Orientation)((Button)sender).Tag;
            //this.setOrientation(or);
            //this.Close();
        }

        private void Form1_Shown(object sender, EventArgs e) {
            //DEVMODE dm = new DEVMODE();
            //EnumDisplaySettings(null, -1, ref dm);
            //Orientation curOr = (Orientation)dm.dmDisplayOrientation;

            //this.doNothingButton.Tag = curOr;
            //this.rot90cwButton.Tag = (Orientation)(((int)curOr + 1) % 4);
            //this.rot180Button.Tag = (Orientation)(((int)curOr + 2) % 4);
            //this.rot90ccwButton.Tag = (Orientation)(((int)curOr + 3) % 4);

        }

    }
}
