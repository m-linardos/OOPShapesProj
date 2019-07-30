using System;

namespace OOP_Shapes {
    class Program {
        static void Main(string[] args) {
            
            var quad1 = new Quad(5, 7, 13, 6);
            //quad1.side1 = 5;          /// not needed if you initialize it in the constructor
            //quad1.side2 = 7;
            //quad1.side3 = 13;
            //quad1.side4 = 6;
            var perimeter = quad1.GetPerimeter();

            

            Console.WriteLine($"The perimeter is {perimeter}");

            var rect1 = new Rect(5, 13);

            perimeter = rect1.GetPerimeter();


            Console.WriteLine($"The rect perimeter is {perimeter}");
        }
    }
}
