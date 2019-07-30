using System;

namespace OOP_Shapes {
    class Program {
        static void Main(string[] args) {
            
            var quad1 = new Quad();
            //quad1.side1 = 5;          /// not needed if you initialize it in the constructor
            //quad1.side2 = 7;
            //quad1.side3 = 13;
            //quad1.side4 = 6;
            var perimeter = quad1.GetPerimeter();

            

            Console.WriteLine($"The perimeter is {perimeter}");
        }
    }
}
