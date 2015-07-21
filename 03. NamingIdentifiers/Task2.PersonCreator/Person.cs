namespace Task2.PersonCreator
{
    public class Person
    {
        public Person(int age)
        {
            this.Age = age;
            if (age % 2 == 0)
            {
                this.Name = "Peter";
                this.PersonGender = Gender.Male;
            }
            else
            {
                this.Name = "Maria";
                this.PersonGender = Gender.Female;
            }
        }

        public enum Gender 
        {
            Male,
            Female
        }

        public Gender PersonGender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
