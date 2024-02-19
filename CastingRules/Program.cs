namespace CastingRules
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        // Classe base
        class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Making a generic sound");
            }
        }

        // Sottoclasse che eredita dalla classe base
        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Barking");
            }

            public void WagTail()
            {
                Console.WriteLine("Tail wagging");
            }
        }


        static void Main(string[] args)
        {
            // Upcasting
            Dog dog = new Dog();
            Animal animal = dog; // Upcasting: un oggetto di una classe derivata viene assegnato a una variabile di tipo classe base

            animal.MakeSound(); // Chiama il metodo MakeSound() della classe Dog

            // Downcasting
            Animal animal2 = new Dog();
            Dog dog2 = (Dog)animal2; // Downcasting: una variabile di tipo classe base viene convertita in una variabile di tipo classe derivata
            dog2.WagTail(); // Possiamo chiamare i metodi specifici della classe Dog dopo il downcasting

            // Errore in downcasting
            Animal animal3 = new Animal();
            ((Dog)animal3).WagTail();
        }
    }
}
