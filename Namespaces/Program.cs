using twoD=NamespacesExamples.TwoD;
using threeD=NamespacesExamples.ThreeD;

namespace Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            twoD::Point p2D=new twoD::Point();
            p2D.X = 1;
            p2D.Y = 2;

            threeD::Point p3D=new threeD::Point();
            p3D.X = 3;
            p3D.Y = 4;
            p3D.Z = 5;

            Console.WriteLine("Hello, World!");
        }
    }
}