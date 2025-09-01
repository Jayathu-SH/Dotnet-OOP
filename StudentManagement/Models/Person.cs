namespace StudentManagement.Models
{
    public class Person
    {
        public string Name { get; private set; }//encapsulation
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void ShowInfo()//polymorphism
        {
            System.Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}