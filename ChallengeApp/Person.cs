

namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name, string surname, int age )
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public Person(string name, string surname, int age, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Sex = sex;
        }
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public readonly char Sex = 'N';

    }
}
