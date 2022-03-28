using System;
using Task.Abstract.Models;

namespace Task.Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            do
            {
                Console.WriteLine("Press 1 for calculate area of square");
                Console.WriteLine("Press 2 for calculate area of rectangular");
                Console.WriteLine("Press 0 for close the program");


                input = int.Parse(Console.ReadLine());
                Console.Clear();

            
                switch (input)
                {
                    case 1:

                        Console.WriteLine("Please enter side of the square: ");
                        int side = int.Parse(Console.ReadLine());
                        Console.Clear();

                        Square square = new Square();
                        square.Side = side;
                        square.CalcArea();




                        break;





                    case 2:

                        Console.WriteLine("Please enter width of the Rectangular: ");
                        int width = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter length of the Rectangular: ");
                        int length = int.Parse(Console.ReadLine());
                        Console.Clear();

                        Rectangular rectangular = new Rectangular(width, length);
                        rectangular.CalcArea();



                        break;


                    case 0:

                        Console.Clear();
                        break;

                }
            } while (input!=0);

                
            
            
        }
    }
}
