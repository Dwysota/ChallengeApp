using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void AddGradeMsg(Object sender, EventArgs args);
        public event AddGradeMsg AddGradeEvent;
        private List<double> grades = new List<double>();
        public double Result
        {
            get
            {
                return grades.Sum();
            }
        }
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public virtual void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(Math.Round(grade, 2));
                if(AddGradeEvent != null)
                {
                    this.AddGradeEvent(this, new EventArgs());
                }

            }
            else
            {
                throw new Exception("Invalid grade value: " + grade);
            }
        }

        public abstract void AddGrade(float grade);
        public abstract void AddGrade(int grade);

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(string grade);
        public abstract void AddGrade(char grade);
        public virtual Statistics GetStatistics()
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

            switch (statistics.Average)
            {
                case var stat when stat > 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var stat when stat > 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var stat when stat > 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var stat when stat > 20:
                    statistics.AverageLetter = 'D';
                    break;
                case var stat when stat > 0:
                    statistics.AverageLetter = 'E';
                    break;
            }


            return statistics;
        }
    }
}
