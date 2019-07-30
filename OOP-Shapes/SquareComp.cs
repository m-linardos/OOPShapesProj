using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shapes {
    //class SquareComp : Rect{      //inheritance / Every property is bound tightly to the parent class; if parent changes, all children have to change
    public class SquareComp {

        //private Rect rect;              // 'rect' is property of sqr
        private Quad quad;              // 'quad' is property of sqrcreating instance of
        public int GetPerimeter();   {       // use getter along with composition to get Perimeter
            return rect.GetPerimeter();
        }

        public int GetArea();   {       // use getter along with composition to get Area
                return quad.side1 * quad.side1;
            }
        public SquareComp(int sides) {          // Composition / in composition, you don't get anything automatically
            rect = new Rect(sides, sides);
        }

    }
}
