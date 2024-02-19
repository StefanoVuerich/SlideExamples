namespace EnumExample
{
    using System;

    internal class Program
    {
        enum Colors { Red, Green, Blue, Yellow };
        enum Styles { Plaid = 0, Striped = 23, Tartan = 65, Corduroy = 78 };

        public static void Main()
        {
            var myColor = Colors.Yellow;
            if(myColor == Colors.Blue)
            {

            }

            Console.WriteLine("The values of the Colors Enum are:");
            foreach (int i in Enum.GetValues(typeof(Colors)))
                Console.WriteLine(i);

            Console.WriteLine();

            Console.WriteLine("The values of the Styles Enum are:");
            foreach (int i in Enum.GetValues(typeof(Styles)))
                Console.WriteLine(i);

            Console.WriteLine();

            Console.WriteLine("The values of the Styles Enum to string are:");
            foreach (var i in Enum.GetValues(typeof(Styles)))
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
