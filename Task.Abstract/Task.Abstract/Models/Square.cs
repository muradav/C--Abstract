using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Abstract.Models
{
    class Square : Figure
    {
        private int _side;
        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (!(value > 0))
                {
                    Console.WriteLine("Side value can't be negative!");
                    return;
                }
                _side = value;
            }
        }

        public override void CalcArea()
        {

            
            int Squarea;
            Squarea = Side * Side;
            Console.WriteLine($"Area of the Squarea is: {Squarea} ");
            Console.WriteLine("*****************************");



        }
        



        


        public void GetInfo()
        {
            Console.WriteLine($"Side: {Side}");
        }
    }
    
}
