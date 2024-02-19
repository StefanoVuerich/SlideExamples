namespace Association
{
    using System;

    class Teacher
    {
        public string Name { get; set; }

        public Teacher(string name)
        {
            Name = name;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; } // Associazione con l'oggetto Teacher

        public Student(string name, Teacher teacher)
        {
            Name = name;
            Teacher = teacher;
        }

        public void PrintTeacherName()
        {
            Console.WriteLine($"{Name}'s teacher is {Teacher.Name}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creiamo un insegnante
            Teacher teacher = new Teacher("Mr. Smith");

            // Creiamo uno studente associato all'insegnante
            Student student = new Student("John", teacher);

            // Stampiamo il nome dell'insegnante dello studente
            student.PrintTeacherName(); // Output: "John's teacher is Mr. Smith"

        }
    }
}
