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
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(Math.Round(grade, 2));
            }
            else
            {
                Console.WriteLine("Invalid grade value: " + grade);
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
                        Console.WriteLine("Grade is not a value.");
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("Grade has no value");
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
                        Console.WriteLine("Grade is not a value.");
                        break;
                }
                

            }
            else
            {
                Console.WriteLine("Grade has no value");
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
