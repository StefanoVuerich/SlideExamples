namespace ListaArgomentiVariabili
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Print("Hi");
            Print("Hello", "from", "world");
        }

        static void Print(params string[] args)
        {
            foreach(string s in args)
            {
                Console.WriteLine(s);
            };
        }
     }
}
