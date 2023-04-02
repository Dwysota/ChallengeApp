

namespace ChallengeApp.Tests
{
    public class SupervisorTests
    {
        [Test]
        public void WhenSupervisorCollectGrades_SchouldeReturnCorrectResult()
        {
            // arrange
            var supervisor = new Supervisor("Dawid", "W");

            supervisor.AddGrade("-2");
            supervisor.AddGrade("2+");
            supervisor.AddGrade("2");
            // act  
            var result = supervisor.Result;

            // assert
            Assert.AreEqual(60, result);
        }
    }

}
