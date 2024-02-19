namespace CreazioneOggetti
{
    internal class Program
    {
        class MyClass
        {
            public int MyProperty { get; set; }

            public int Incrementa(int i)
            {
                return i + 1;
            }

            public void Test(MyClass theClass2)
            {

            }
        }

        struct MyStruct
        {
            public int MyProperty { get; set; }

            public int NomeProprieta { get; set; }

        }

        static void Main(string[] args)
        {

            //value types stack RAM
            int theInt = 1;
            MyStruct theStruct = new MyStruct();
            theStruct.MyProperty = 666;

            //reference type heap RAM
            string theString = "I'm a string";
            MyClass theClass = new MyClass();
            theClass.Incrementa(5);

            MyClass theClass2 = new MyClass();
            theClass.Test(theClass2);

        }
    }
}
