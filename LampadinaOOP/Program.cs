// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var lampadina = new Lampadina(10);

for(int i = 0; i < 11; i++)
{
    lampadina.Click();
}

Console.ReadKey();
