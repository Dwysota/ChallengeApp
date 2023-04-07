
namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        private List<double> grades = new List<double>();
        public double Result
        {
            get
            {
                return grades.Sum();
            }
        }
        public Supervisor(string name, string surname) { 
            this.Name = name;
            this.Surname = surname; 
        }
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(Math.Round(grade, 2));
            }
            else
            {
                throw new Exception("Invalid grade value: " + grade);
            }


        }
        public void AddGrade(char grade)
        {

        }
        public void AddGrade(float grade)
        {
            this.AddGrade((double)grade);
        }

        public void AddGrade(int grade)
        {
            this.AddGrade((double)grade);
        }

        public void AddGrade(long grade)
        {
            this.AddGrade((double)grade);
        }

        public void AddGrade(string grade)
        {
            if (!string.IsNullOrEmpty(grade))
            {
                int diff = 0;
                int index = 0;
                if (grade.Length > 1)
                {
                    if (grade[0] == '-' || grade[grade.Length-1] == '-')
                    {
                        diff = -5;
                        if(grade[0] == '-')
                        {
                            index = 1;
                        }
                        else
                        {
                            index = 0;
                        }
                    }
                    else if (grade[0] == '+' || grade[grade.Length - 1] == '+')
                    {
                        diff = 5;
                        if (grade[0] == '+')
                        {
                            index = 1;
                        }
                        else
                        {
                            index = 0;
                        }
                    }
                }
                switch (grade[index])
                {
                    case '6':
                            this.AddGrade(100 + diff);
                        break;
                    case '5':
                        this.AddGrade(80 + diff);
                        break;
                    case '4':
                        this.AddGrade(60 + diff);
                        break;
                    case '3':
                        this.AddGrade(40 + diff);
                        break;
                    case '2':
                        this.AddGrade(20 + diff);
                        break;
                    case '1':
                            this.AddGrade(0 + diff);
                        break;
                    default:
                        throw new Exception("Grade has wrong value.");
                }
               
            }
            else
            {
                throw new Exception("Grade has no value");
            }
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
