using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Abstract.Models
{
    class Rectangular:Figure
    {
        private int _width;
        private int _length;

        public int Width 
        {
            get
            {
                return _width; 
            }
            set
            {
                if (!(value > 0))
                {
                    Console.WriteLine("Width value can't be negative!");
                    return;
                }
                _width = value;

            } 
        }
        public int Length 
        {
            get
            {
                return _length;
            }
            set
            {
                if (!(value > 0))
                {
                    Console.WriteLine("Length value can't be negative!");
                    return;
                }
                _length = value;

            } 
        }
        public Rectangular(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public override void CalcArea()
        {

            int Recarea;
            Recarea = Width * Length;
            Console.WriteLine($"Area of the Rectangular: {Recarea}");
            Console.WriteLine("*****************************");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Width: {Width} \n" +
                $"Length: {Length}");
        }
    }
}
