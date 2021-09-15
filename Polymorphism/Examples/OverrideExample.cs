using System;
using System.Collections.Generic;

namespace Polymorphism.Examples
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Perfoming base class drawing tasks");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
        }
    } 
    
    public class OverrideExample
    {
        public static void Start()
        {
            var shapes = new List<Shape>
            {
                new Circle(),
                new Rectangle(),
                new Triangle()
            };

            foreach (var shape in shapes)
            {
                shape.Draw(); // Несмотря на наличие Draw() в классе Shape будет вызван Draw() их дочерних классов
            }
        }
    }
}