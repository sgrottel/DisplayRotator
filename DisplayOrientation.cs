using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRotator {

    /// <summary>
    /// Possible display rotations
    /// </summary>
    public enum DisplayOrientation : int {

        /// <summary>
        /// The neurtral horizontal orientation (0°)
        /// </summary>
        Horiz_0 = PInvoke.DMDO_DEFAULT,

        /// <summary>
        /// The vertical orientation (90°)
        /// </summary>
        Vert_90 = PInvoke.DMDO_90,

        /// <summary>
        /// The rotated horizontal orientation (180°)
        /// </summary>
        Horiz_180 = PInvoke.DMDO_180,

        /// <summary>
        /// The vertical orientation (270°)
        /// </summary>
        Vert_270 = PInvoke.DMDO_270

    };

    /// <summary>
    /// Class hosting extension methods for the DisplayOrientation enum
    /// </summary>
    public static class DisplayOrientationExtension {

        /// <summary>
        /// Rotates the orientation
        /// </summary>
        /// <param name="o">The orientation</param>
        /// <param name="relRot">The relative clockwise rotation in multiples of 90°</param>
        /// <returns>The new orientation</returns>
        public static DisplayOrientation Rotate(this DisplayOrientation o, int relRot) {
            if (relRot < 0) relRot = 0; // not nice, but ok for now
            return (DisplayOrientation)(((int)o + relRot) % 4);
        }

    };

}
