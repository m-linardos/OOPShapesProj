using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shapes {
    public class Rect : Quad {       // Quad constructor takes 4 parameters, but Rect

        public Rect(int side_a, int side_b) : base(side_a, side_b, side_a, side_b) {                    // use base set rect(side x,side y) equal to quad(side a, side b, side c, side d)

            
        }
        public int /*double*/ GetArea() {       // -->  Perimeter()- gets value; Perimeter(intp)- ets the value
            return this.side_a * this.side2;                                  //    throw new NotImplementedException("Can't calc area of quad!);
                                             //}
        
    }
    }
}
