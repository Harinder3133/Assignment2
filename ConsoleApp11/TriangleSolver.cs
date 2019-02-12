using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public static class TriangleSolver
    {
        public static string Analyze(int l, int b, int h)
        {

            int Sidei = l + b;
            int Sidej = b + h;
            int Sidek = h + l;

            if (Sidei > h && Sidej > l && Sidek > b)
            {
                if ((l == b) && (b == h))
                    return "This is an Equilateral Triangle";
                else if ((l == b) || (l == h) || (b == h))
                    return "This is an Isosceles Triangle";

                else return "This is a Scalene Triangle";
            }
            else return "Triangle cannot be possible";
        }
    }
}
