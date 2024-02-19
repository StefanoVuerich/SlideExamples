namespace AttributiCostanti
{
    internal class Program
    {
        class MyClass
        {
            const string LaCostante = "Sono una costante";
            private readonly string _laReadOnly;

            public MyClass(string laReadOnly)
            {
                _laReadOnly = laReadOnly;
            }
        }

        static void Main(string[] args)
        {
            MyClass theClass = new MyClass("Hello world");
        }
    }
}
