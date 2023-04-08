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
        public virtual void AddGrade(char grade)
        {
            if (grade != null)
            {
                switch (char.ToLower(grade))
                {
                    case 'a':
                        this.AddGrade(100);
                        break;
                    case 'b':
                        this.AddGrade(80);
                        break;
                    case 'c':
                        this.AddGrade(60);
                        break;
                    case 'd':
                        this.AddGrade(40);
                        break;
                    case 'e':
                        this.AddGrade(20);
                        break;
                    default:
                        throw new Exception("Grade is not a value.");
                }


            }
            else
            {
                throw new Exception("Grade has no value");
            }
        }
        public virtual Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach(var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }



            return statistics;
        }
    }
}
