namespace Inheritance
{
    using System;

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    // Sottoclasse che eredita dalla classe base
    class Circle : Shape
    {
        public string PropSpecificaDelCerchio { get; set; }
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    // Altra sottoclasse che eredita dalla classe base
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            Circle circle = new Circle(); // Possiamo creare un oggetto Circle e assegnarlo a una variabile di tipo Shape
            Shape shape2 = new Rectangle(); // Possiamo creare un oggetto Rectangle e assegnarlo a una variabile di tipo Shape

            circle.Draw(); // Chiama il metodo Draw() dell'oggetto Circle
            shape2.Draw(); // Chiama il metodo Draw() dell'oggetto Rectangle

            Shape upcasted = (Shape)circle;
            Circle downcasted = (Circle)s;
            var x = downcasted.PropSpecificaDelCerchio;

        }
    }
}
