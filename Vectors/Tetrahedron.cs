using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Tetrahedron : Body3D
    {
        public double A { set; get; }

        public Tetrahedron(double A)
        {
            this.A = A;
        }
        public override double GetSquare() => Math.Pow(A, 2) * Math.Sqrt(3);
        public override double GetVolume() => (Math.Pow(A, 3) / 12) * Math.Sqrt(2);
        public override double GetSumEdge() => A * 6;
    }
}
