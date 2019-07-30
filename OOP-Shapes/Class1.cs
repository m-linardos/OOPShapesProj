using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shapes {
    public class Quad {

        // PROPERTIES
        private int side1 { get; set; }
        private int side2 { get; set; }
        private int side3 { get; set; }
        private int side4 { get; set; }
        //private int perimeter = side1 + side2 + side3 + side4;

        //public int GetPerimeter() {       // public - called outside of class  / new popular naming convention - noun defining method / -->  Perimeter()- gets value; Perimeter(intp)- ets the value
        //    int perimeter = side1 + side2 + side3 + side4;      // prof. devs tend not to create variables when not needed
        //    return perimeter;

        public int GetPerimeter() {       // public - called outside of class  / new popular naming convention - noun defining method / -->  Perimeter()- gets value; Perimeter(intp)- ets the value
            return side1 + side2 + side3 + side4;      // prof. devs tend not to create variables when not needed
        }

        public Quad(int side_a, int side_b, int side_c, int side_d) {             // constructors have no return type / has to have same name as class
            this.side1 = side_a; // taking value passed in first interger & storing in side1
            this.side2 = side_b; // constructors only used with 'new' (it is a special method)
            this.side3 = side_c;
            this.side4 = side_d;
        }
    }
}
