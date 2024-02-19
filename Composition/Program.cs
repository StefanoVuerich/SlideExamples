namespace Composition
{
    using System;

    class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine started");
        }
    }

    class Car
    {
        private Engine e; // Composizione: Car contiene un oggetto Engine

        public Car()
        {
            e = new Engine(); // Inizializzazione dell'oggetto Engine all'interno del costruttore
        }

        public void StartCar()
        {
            e.Start(); // Chiamata al metodo Start del motore
        }
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            Car myCar = new Car(); // Creazione di un'istanza della classe Car
            myCar.StartCar(); // Avvio dell'auto
        }
    }
}
