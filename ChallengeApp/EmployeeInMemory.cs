namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {


        public EmployeeInMemory(string name, string surname) : base(name, surname)
        {
        }
        public override void AddGrade(double grade)
        {
            base.AddGrade(grade);
        }
        public override void AddGrade(string grade)
        {
            if (grade != "")
            {
                if (double.TryParse(grade, out double tmpValue))
                {
                    this.AddGrade(tmpValue);
                }
                else
                {
                    if (grade.Length == 1)
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

        public override void AddGrade(char grade)
        {
            base.AddGrade(grade);
        }
        public override void AddGrade(float grade)
        {
            this.AddGrade((double)grade);
        }
        public override void AddGrade(int grade)
        {

            this.AddGrade((double)grade);
        }
        public override void AddGrade(long grade)
        {

            this.AddGrade((double)grade);
        }
        public string getData()
        {
            return this.Name + ", " + this.Surname + ", punkty: " + this.Result;
        }
        public override Statistics GetStatistics()
        {
            return base.GetStatistics();
        }
    }
}
