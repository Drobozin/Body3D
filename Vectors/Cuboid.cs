using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Cuboid : Body3D
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Cuboid(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public override double GetSquare() => 2 * (A * B + B * A + B * C);
        public override double GetVolume() => A * B * C;
        public override double GetSumEdge() => 4 * (A + B + C);
    }
}
