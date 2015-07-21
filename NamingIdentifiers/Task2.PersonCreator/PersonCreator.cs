namespace Task2.PersonCreator
{
    using System;

    public class PersonCreator
    {
        public static void Main()
        {
            Person personFirst = new Person(23);
            Person personSecond = new Person(34);

            Console.WriteLine("First person's info");
            Console.WriteLine("Name: {0} Age: {1} Gender: {2}", personFirst.Name, personFirst.Age, personFirst.PersonGender);
            Console.WriteLine("Second person's info");
            Console.WriteLine("Name: {0} Age: {1} Gender: {2}", personSecond.Name, personSecond.Age, personSecond.PersonGender);
        }
    }
}
