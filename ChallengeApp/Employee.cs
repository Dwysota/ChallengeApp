namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        private List<double> grades = new List<double>();
        public double Result
        {
            get
            {
                return grades.Sum();
            }
        }
        public Employee()
        {
            this.grades.Add(0);
        }
        public Employee(string name)
        {
            this.Name = name; ;
        }
        public Employee(string name, string surname)
        {
            this.Surname = surname;
        }
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public void AddGrade(double grade)
        {
            this.grades.Add(grade);

        }
        public string getData()
        {
            return this.Name + ", " + this.Surname + ", lat " + this.Age + ", punkty: " + this.Result;
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average += grade;

            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

    }
}
