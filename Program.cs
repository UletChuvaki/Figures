using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    
            struct Figures
        {
            public string name;
            public int coordinate_x;
            public int coordinate_y;
            public void Display()
            {
                Console.WriteLine($"Name: {name} , Coordinate_x: {coordinate_x} , Coordinate_y: {coordinate_y}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Figures figures;
                figures.name = "triangle";
                figures.coordinate_x = 3;
                figures.coordinate_y = 5;
                figures.Display();

                Figures figures2;
                figures2.name = "square";
                figures2.coordinate_x = 4;
                figures2.coordinate_y = 4;
                figures.Display();
                Console.ReadKey();
            }
        }
    }
    

