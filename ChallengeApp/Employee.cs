

namespace ChallengeApp
{
    public class Employee : Person
    {
        
        private List<double> grades = new List<double>();
        public double Result
        {
            get
            {
                return grades.Sum();
            }
        }

        public Employee(string name) : this(name, "no surname")
        {
        }
        public Employee(string name, string surname) : base(name, surname, 0)
        {
        }
        public Employee(string name, string surname, int age) : base(name, surname, age)
        {
        }
        public Employee(string name, string surname, int age, char sex) : base(name, surname, age, sex)
        {
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
        public void AddGrade(string grade)
        {
            if (grade != "")
            {
                if (double.TryParse(grade, out double tmpValue))
                {
                    this.AddGrade(tmpValue);
                }
                else
                {
                    if(grade.Length == 1)
                    {
                        this.AddGrade((char)grade[0]);
                    }
                    else
                    {
                        throw new Exception("Grade is not a value.");
                    }
                    
                }
            }
            else
            {
                throw new Exception("Grade has no value");
            }
        }
        public void AddGrade(char grade)
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
        public Statistics GetStatisticsWithForEach()
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
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i = 0; i < grades.Count; i++)
            {
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Average += grades[i];

            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            int i = 0;
            do
            {
                if (grades.Count == 0)
                {
                    break;
                }
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Average += grades[i];
                i++;

            } while (i < grades.Count);

            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            int i = 0;
            while (i < grades.Count)
            {
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Average += grades[i];
                i++;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
