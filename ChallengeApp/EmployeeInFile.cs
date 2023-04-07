namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeInMemory
    {
        private const string fileNameStatistics = "statistics.txt";
        public EmployeeInFile(string name, string surname) : base(name, surname)
        {
            if (File.Exists(fileNameStatistics))
            {
                using (var file = File.OpenText(fileNameStatistics))
                {
                    var line = file.ReadLine();
                    while (line != null)
                    {
                        base.AddGrade(double.Parse(line));
                        line = file.ReadLine();
                    }
                }
            }

        }

        public override void AddGrade(double grade)
        {
            base.AddGrade(grade);
            using (var file = File.AppendText(fileNameStatistics))
            {
                file.WriteLine(grade);
            }
        }

        public override void AddGrade(float grade)
        {
            AddGrade(grade);
        }

        public override void AddGrade(int grade)
        {
            AddGrade(grade);
        }

        public override Svoid AddGrade(long grade)
        {
            AddGrade(grade);
        }

        public override void AddGrade(string grade)
        {
            base.AddGrade(grade);
        }

        public override void AddGrade(char grade)
        {
            base.AddGrade(grade);
        }

        public override Statistics GetStatistics()
        {
            return base.GetStatistics();
        }
    }
}
