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

    }

}
