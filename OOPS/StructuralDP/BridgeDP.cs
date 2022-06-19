using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP
{
    interface Color
    {
        String fill();
    }
    class Blue : Color
    {
        
        public string fill()
        {
            return "Color is Blue";
        }

    }
    class Red : Color
    {
        public string fill()
        {
            return "Color is Red";
        }
    }
    abstract class Shape
    {
        protected Color color;

        //standard constructors
        public Shape(Color color)
        {
            this.color = color;
        }
        abstract public String draw();
    }
    class Square : Shape
    {

        public Square(Color color):base(color)
        {
            
        }
        public override string draw()
        {
            return "Square drawn. " + color.fill();
        }
    }
internal class BridgeDP
    {
        public static void  test()
        {
            Shape square = new Square(new Blue());
            Console.WriteLine(square.draw());
        }
    }
}
