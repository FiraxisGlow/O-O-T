using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApplication
{
    class Program
    {
        static void Main(string[] args)
        {
         // DrawingObject do = new DrawingObject(); ei voi tehä
         Circle circle = new Circle();
            circle.Name = "My Circle";
            circle.Draw();

            Square square = new Square();
            square.Name = "My Square";
            square.Draw();


            //create a List collection for Drawing Objects

            List<DrawingObject> drawingObjects = new List<DrawingObject>();
            //add new objects to collection
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());

            //loop collection and draw objects
            Console.WriteLine("Drawing objects in a List:");
            foreach(DrawingObject drawingObject in drawingObjects)
            {
                drawingObject.Draw();
            }

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
