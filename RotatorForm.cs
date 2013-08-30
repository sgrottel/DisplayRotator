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

            DisplayOrientation ori = PInvoke.GetCurrentDisplayRotation();

            //ori = DisplayOrientation.Horiz_0; // debugging!
            //ori = DisplayOrientation.Vert_90;
            //ori = DisplayOrientation.Horiz_180;
            //ori = DisplayOrientation.Vert_270;

            for (int i = 0; i < 4; i++) {
                Bitmap bmp = new Bitmap(Properties.Resources.DisplayRotator_Device);
                Bitmap dsk = new Bitmap(
                    (((((int)ori) + i) % 2) == 1)
                    ? Properties.Resources.DisplayRotator_DesktopVert
                    : Properties.Resources.DisplayRotator_DesktopHoriz);
                int xoff = 0;
                int yoff = 0;
                switch (((int)ori) * 4 + i) {
                    case 0: break;
                    case 1:
                        dsk.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        yoff = -5;
                        break;
                    case 2:
                        dsk.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        yoff = -5;
                        break;
                    case 3: break;
                    case 4:
                        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        dsk.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        xoff = 5;
                        break;
                    case 5:
                        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        dsk.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        xoff = 5;
                        break;
                    case 6:
                        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        dsk.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    case 7:
                        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        dsk.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    case 8:
                        bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        yoff = 5;
                        break;
                    case 9:
                        bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        dsk.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        break;
                    case 10:
                        bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        dsk.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        break;
                    case 11:
                        bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        yoff = 5;
                        break;
                    case 12:
                        bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        dsk.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        //xoff = 5;
                        break;
                    case 13:
                        bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        dsk.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        //xoff = 5;
                        break;
                    case 14:
                        bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        dsk.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        xoff = -5;
                        break;
                    case 15:
                        bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        dsk.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        xoff = -5;
                        break;
                }

                using (Graphics g = Graphics.FromImage(bmp)) {
                    g.DrawImageUnscaled(dsk, xoff, yoff, 80, 80);
                }
                switch (i) {
                    case 0: this.doNothingButton.Image = bmp; break;
                    case 1: this.rot90ccwButton.Image = bmp; break;
                    case 2: this.rot180Button.Image = bmp; break;
                    case 3: this.rot90cwButton.Image = bmp; break;
                    default: throw new Exception();
                }
            }
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
            ori = ori.Rotate(relRot);
            PInvoke.SetDisplayRotation(ori);
            this.Close();
        }

    }

}
