using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Ball : Body3D
    {
        public double R { get; set; }
        public Ball(double R)
        {
            this.R = R;
        }
        public override double GetSquare() => 4 * Math.PI * Math.Pow(R, 2);
        public override double GetVolume() => (4 / 3) * Math.PI * Math.Pow(R, 3);
        public override double GetSumEdge() => Math.PI * Math.Pow(R, 2); //площадь основания шарового сегмента
    }
}
