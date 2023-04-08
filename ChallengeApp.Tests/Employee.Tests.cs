namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectGrades_SchouldereturnCorrectResult()
        {
            // arrange
            var employ = new EmployeeInMemory("Dawid", "W");
            double sum  = 0;   
            for (int i = 0; i<10; i++)
            {
                double grade = Math.Round(new Random().NextDouble()*100, 2);
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
            var employ = new EmployeeInMemory("Dawid", "W");
            double min = double.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                double grade = Math.Round(new Random().NextDouble() * 100, 2);
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
            var employ = new EmployeeInMemory("Dawid", "W");
            double max = double.MinValue;
            for (int i = 0; i < 10; i++)
            {
                double grade = Math.Round(new Random().NextDouble() * 100, 2);
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
            var employ = new EmployeeInMemory("Dawid", "W");
            double sum = 0;
            int i = 0;
            for (; i < 10; i++)
            {
                double grade = Math.Round(new Random().NextDouble() * 100, 2);
                employ.AddGrade(grade);
                sum += grade;
            }

            // act  
            var statistic = employ.GetStatistics();

            // assert
            Assert.That(statistic.Average, Is.EqualTo(sum/i));
        }
        [Test]
        public void OverlodingFunctions()
        {
            //  arrange
            string gradeStr = "5";
            double gradeDouble = 5;
            float gradeFloat = 5;
            int gradeInt = 5;
            long gradeLong = 5;
            EmployeeInMemory employee = new EmployeeInMemory("Dawid", "W");

            //act
            employee.AddGrade(gradeStr);
            employee.AddGrade(gradeDouble);
            employee.AddGrade(gradeFloat);
            employee.AddGrade(gradeInt);
            employee.AddGrade(gradeLong);

            // assert
            Assert.AreEqual(25, employee.Result);
        }

        [Test]
        public void WhenWeAddedGradesLetter_SchouldReturnCorrectStatisticValue()
        {
            // arrange
            EmployeeInMemory employee = new EmployeeInMemory("Dawid", "W");
            employee.AddGrade('a');
            employee.AddGrade('b');
            employee.AddGrade('c');
            employee.AddGrade('d');
            employee.AddGrade('e');
            // act
            var statistic = employee.GetStatistics();
            // assert
            Assert.AreEqual(statistic.Average, 60);
        }
        [Test]
        public void WhenWeAddedGrades_SchouldReturnCorrectStatisticValueLetter()
        {
            // arrange
            EmployeeInMemory employee = new EmployeeInMemory("Dawid", "W");
            employee.AddGrade(20);
            employee.AddGrade(40);
            employee.AddGrade(60);
            employee.AddGrade(80);
            employee.AddGrade(100);
            // act
            var statistic = employee.GetStatistics();
            // assert
            Assert.AreEqual(statistic.AverageLetter, 'C');
        }
    }
}