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
    public partial class RotatorForm : Form {

        /// <summary>
        /// Ctor
        /// </summary>
        public RotatorForm() {
            InitializeComponent();
            this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
            this.ActiveControl = this.doNothingButton;

            // Use the button tags to specify relative rotation in x90°
            this.doNothingButton.Tag = 0;
            this.rot90ccwButton.Tag = 1;
            this.rot180Button.Tag = 2;
            this.rot90cwButton.Tag = 3;

            // TODO: Button Icons

        }

        /// <summary>
        /// The rotate 0° button simply closes the form
        /// </summary>
        /// <param name="sender">not used</param>
        /// <param name="e">not used</param>
        private void doNothingButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// Close the form when it loses the focus
        /// </summary>
        /// <param name="sender">not used</param>
        /// <param name="e">not used</param>
        private void form_Deactivate(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// Relative rotation requested
        /// </summary>
        /// <param name="sender">The button requesting the relative rotation</param>
        /// <param name="e">not used</param>
        private void rotButton_Click(object sender, EventArgs e) {
            int relRot = (int)((Button)sender).Tag;

            DisplayOrientation ori = PInvoke.GetCurrentDisplayRotation();

            // Because I know (not very nice)
            ori = (DisplayOrientation)(((int)ori + relRot) % 4);

            PInvoke.SetDisplayRotation(ori);
            this.Close();
        }
    }
}
