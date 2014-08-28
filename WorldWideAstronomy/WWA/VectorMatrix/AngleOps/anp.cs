using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldWideAstronomy
{
    public static partial class WWA
    {
        /// <summary>
        /// Normalize angle into the range 0 <= a < 2pi.
        /// </summary>
        /// 
        /// <remarks>
        /// This function is derived from the International Astronomical Union's
        /// SOFA (Standards of Fundamental Astronomy) software collection.
        /// http://www.iausofa.org
        /// The code does not itself constitute software provided by and/or endorsed by SOFA.
        /// This version is intended to retain identical functionality to the SOFA library, but
        /// made distinct through different function names (prefixes) and C# language specific
        /// modifications in code.
        /// </remarks>
        /// <param name="a">angle (radians)</param>
        /// <returns>angle in range 0-2pi</returns>
        public static double wwaAnp(double a)
        {
            double w;

            //w = fmod(a, D2PI);
            w = Math.IEEERemainder(a, D2PI);

            if (w < 0) w += D2PI;

            return w;
        }
    }
}
