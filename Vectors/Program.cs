using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {

            Body3D[] myOBody3Ds = new Body3D[3];
            myOBody3Ds[0] = new Ball(5);
            myOBody3Ds[1] = new Tetrahedron(10);
            myOBody3Ds[2] = new Cuboid(5, 10, 15);

            foreach (Body3D obj in myOBody3Ds)
            {
                Console.WriteLine("Объект: {3} \n Площадь: {0}, Объем: {1}, Сумма ребер: {2}\n", obj.GetSquare(), obj.GetVolume(),
                    obj.GetSumEdge(), obj);
            }

            Console.ReadLine();
        }
    }
}
