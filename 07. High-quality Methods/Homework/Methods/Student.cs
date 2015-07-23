namespace Methods
{
    using System;

    internal class Student
    {
        private string firstName;

        private string lastName; 

        public Student(string firstName, string lastName, DateTime dateOfBirth, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.OtherInfo = otherInfo;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (!this.IsNameValid(value))
                {
                    throw new ArgumentException("The first name must be betwwen 3 and 30 symbols long");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (!this.IsNameValid(value))
                {
                    throw new ArgumentException("The last name must be betwwen 3 and 30 symbols long");
                }

                this.lastName = value;
            }
        }

        public string OtherInfo { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool IsOlderThan(Student otherStudent)
        {
            DateTime firstDate = this.DateOfBirth;
            DateTime secondDate = otherStudent.DateOfBirth;

            return firstDate < secondDate;
        }

        private bool IsNameValid(string name)
        {
            if (name == null)
            {
                return false;
            }

            if (name.Length < 3 || name.Length > 30)
            {
                return false;
            }

            return true;
        }
    }
}
