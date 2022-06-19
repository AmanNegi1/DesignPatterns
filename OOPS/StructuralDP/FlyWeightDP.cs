using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP
{
    interface Pen
    {
        public void setColor(String color);
        public void draw(String content);
    }
    enum BrushSize
    {
        THIN, MEDIUM, THICK
    }

    class ThickPen : Pen
    {

         BrushSize brushSize = BrushSize.THICK;    //intrinsic state - shareable
         private String color = null;                    //extrinsic state - supplied by client

        public void setColor(String color)
        {
            this.color = color;
        }


        public void draw(String content)
        {
            Console.WriteLine("Drawing THICK content in color : " + color);
        }
    }
    class ThinPen : Pen
    {

         BrushSize brushSize = BrushSize.THIN;
         private String color = null;

         public void setColor(String color)
         {
            this.color = color;
         }

        public void draw(String content)
        {
            Console.WriteLine("Drawing THIN content in color : " + color);
        }
    }
    class MediumPen : Pen
    {

         BrushSize brushSize = BrushSize.MEDIUM;//make it final
        private String color = null;

        public void setColor(String color)
        {
            this.color = color;
        }

        public void draw(String content)
        {
            Console.WriteLine("Drawing MEDIUM content in color : " + color);
        }
    }
    class PenFactory
    {
        private static  Dictionary<string, Pen> pensMap = new Dictionary<string, Pen>();

        public static Pen getThickPen(String color)
        {
            String key = color + "-THICK";
            Pen pen=null;
            if (pensMap.ContainsKey(key)) { 
             pen = pensMap[key];
            }
            if (pen != null)
            {
                return pen;
            }
            else
            {
                pen = new ThickPen();
                pen.setColor(color);
                pensMap.Add(key, pen);
            }

            return pen;
        }

        public static Pen getThinPen(String color)
        {
            String key = color + "-THIN";

            Pen pen = null;
            if (pensMap.ContainsKey(key))
            {
                pen = pensMap[key];
            }
            if (pen != null)
            {
                return pen;
            }
            else
            {
                pen = new ThinPen();
                pen.setColor(color);
                pensMap.Add(key, pen);
            }

            return pen;
        }

        public static Pen getMediumPen(String color)
        {
            String key = color + "-MEDIUM";

            Pen pen = null;
            if (pensMap.ContainsKey(key))
            {
                pen = pensMap[key];
            }
            if (pen != null)
            {
                return pen;
            }
            else
            {
                pen = new MediumPen();
                pen.setColor(color);
                pensMap.Add(key, pen);
            }

            return pen;
        }
    }

    internal class FlyWeightDP
    {
        public static void test()
        {
            Pen yellowThinPen1 = PenFactory.getThickPen("YELLOW");  //created new pen
            yellowThinPen1.draw("Hello World !!");

            Pen yellowThinPen2 = PenFactory.getThickPen("YELLOW");  //pen is shared
            yellowThinPen2.draw("Hello World !!");

            Pen blueThinPen = PenFactory.getThickPen("BLUE");       //created new pen
            blueThinPen.draw("Hello World !!");

            Console.WriteLine(yellowThinPen1.GetHashCode());
            Console.WriteLine(yellowThinPen2.GetHashCode());

            Console.WriteLine(blueThinPen.GetHashCode());
        }
    }
}
