namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectGrades_SchouldereturnCorrectResult()
        {
            // arrange
            var employ = new Employee("Dawid", "W", 33);
            double sum  = 0;   
            for (int i = 0; i<10; i++)
            {
                double grade = new Random().NextDouble()*100;
                employ.AddGrade(grade);
                sum += grade;
            }
            
            // act  
            var result = employ.Result;

            // assert
            Assert.That(result, Is.EqualTo(sum));
        }
        [Test]
        public void WhenEmployeeCollectGrades_SchouldeReturnCorrectMinValue()
        {
            // arrange
            var employ = new Employee("Dawid", "W", 33);
            double min = double.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                double grade = new Random().NextDouble() * 100;
                employ.AddGrade(grade);
                min = Math.Min(min, grade);
            }

            // act  
            var statistic = employ.GetStatistics();

            // assert
            Assert.That(statistic.Min, Is.EqualTo(min));
        }
        [Test]
        public void WhenEmployeeCollectGrades_SchouldeReturnCorrectMaxValue()
        {
            // arrange
            var employ = new Employee("Dawid", "W", 33);
            double max = double.MinValue;
            for (int i = 0; i < 10; i++)
            {
                double grade = new Random().NextDouble() * 100;
                employ.AddGrade(grade);
                max = Math.Max(max, grade);
            }

            // act  
            var statistic = employ.GetStatistics();

            // assert
            Assert.That(statistic.Max, Is.EqualTo(max));
        }
        [Test]
        public void WhenEmployeeCollectGrades_SchouldeReturnCorrectAverageValue()
        {
            // arrange
            var employ = new Employee("Dawid", "W", 33);
            double sum = 0;
            int i = 0;
            for (; i < 10; i++)
            {
                double grade = new Random().NextDouble() * 100;
                employ.AddGrade(grade);
                sum += grade;
            }

            // act  
            var statistic = employ.GetStatistics();

            // assert
            Assert.That(statistic.Average, Is.EqualTo(sum/i));
        }
    }
}