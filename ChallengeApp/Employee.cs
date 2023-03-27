namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        private List<int> scores = new List<int>();
        public int Result
        {
            get
            {
                return scores.Sum();
            }
        }
        public Employee()
        {
            this.scores.Add(0);
        }
        public Employee(string name)
        {
            this.Name = name; ;
        }
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public void addScore(int score)
        {
                this.scores.Add(score);

        }
        public string getData()
        {
            return this.Name + ", " + this.Surname + ", lat " + this.Age + ", punkty: " + this.Result;
        }

    }
}
