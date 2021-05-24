using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;
namespace Entities {
    //------------------------------- START -------------------------------//
    class Rectangle : AbstractShape {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area() {
            return Width * Height;
        }

        public override string ToString() {
            return "Rectangle color = " + Color + ", width " + Width.ToString("F2") + ", height" + Height.ToString("F2") + ", area = " + Area().ToString("F2");
        }
    }
    //------------------------------- END -------------------------------//
}
