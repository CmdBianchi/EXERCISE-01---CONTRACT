using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;
namespace Entities {
    //------------------------------- START -------------------------------//
     abstract class AbstractShape : IShape {
        public Color Color { get; set; }
        public abstract double Area();
    }
    //-------------------------------- END -------------------------------//
}
