using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    abstract class Body3D
    {
        
        public abstract double GetSquare();
        public abstract double GetVolume();
        public abstract double GetSumEdge();
    }
}
