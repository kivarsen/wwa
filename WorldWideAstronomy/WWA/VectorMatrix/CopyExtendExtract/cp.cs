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
        /// Copy a p-vector.
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
        /// Given:
        /// <param name="p">p-vector to be copied</param>
        /// Returned:
        /// <param name="c">copy</param>
        public static void wwaCp(double[] p, double[] c)
        {
            if (c == null)
                c = new double[3];

            Array.Copy(p, c, p.Length);

            //c[0] = p[0];
            //c[1] = p[1];
            //c[2] = p[2];

            return;
        }
    }
}
