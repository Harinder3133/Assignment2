using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, l = 0, b = 0, h = 0, i = 0;
            // initialize quantities

            do
            {

                Console.WriteLine("Enter  the correct choice: ");
                Console.WriteLine("1.Enter  dimensions of triangle");
                Console.WriteLine("2.Exit");
                if ((!int.TryParse(Console.ReadLine(), out choice) || choice <= 0 || choice > 2)) // check user input
                {
                    Console.WriteLine("Please Enter the Correct choice: ");
                    continue;
                }

                switch (choice)
                {

                    case 1:


                        do
                        {
                            do
                            {
                                Console.WriteLine("Please Enter the 1st Side of the Triangle: ");

                            } while (!int.TryParse(Console.ReadLine(), out l));

                        } while (l <= 0);



                        do
                        {

                            do
                            {
                                Console.WriteLine("Please Enter the 2nd Side of the Triangle: ");

                            } while (!int.TryParse(Console.ReadLine(), out b));
                        } while (b <= 0);
                        do
                        {
                            do
                            {
                                Console.WriteLine("Please Enter the 3rd Side of the Triangle: ");

                            } while (!int.TryParse(Console.ReadLine(), out h));
                        } while (h <= 0);
                        break;

                    case 2:
                        Environment.Exit(0);
                        break;
                }
                i++;

                Console.WriteLine(TriangleSolver.Analyze(l, b, h));
            } while (choice != 2);
        }
    }
}
