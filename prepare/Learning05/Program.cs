using System;
using System.Drawing;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
       //Square//
        Square squ = new Square("", 0.0);
        squ.SetColor("Red");
        squ.SetSquareSide(15.5);

        //Rectangle//
        Rectangle rec = new Rectangle("", 0, 0);
        rec.SetColor("Blue");
        rec.SetLength(5.45);
        rec.SetWidth(7.85);


        //Circle//
        Circle cir = new Circle("", 0);
        cir.SetColor("Pink");
        cir.SetRadius(8.34);

        
        

        List<Shape> shapes = new List<Shape>();
        shapes.Add(squ);
        shapes.Add(rec);
        shapes.Add(cir);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The Color is: {color}");
            Console.WriteLine($"The Area is: {area}");
            Console.WriteLine("");
        }
    }

    
}