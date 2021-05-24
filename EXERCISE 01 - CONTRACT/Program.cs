﻿using System;
using Entities;
using Enums;
namespace EXERCISE_01___CONTRACT {
    //-----> START
    ///////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
            Console.WriteLine(s1);
            Console.WriteLine("\n"+s2);
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
