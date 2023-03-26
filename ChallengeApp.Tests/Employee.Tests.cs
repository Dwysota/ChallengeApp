namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoSetOfPoints_SchouldeturnCorrectResult()
        {
            // arrange
            var employ = new Employee("Dawid", "W", 33);
            int score = 0;
            int sum  = 0;   
            for (int i = 10; i<10; i++)
            {
                score = new Random().Next(-10, 11);
                employ.addScore(score);
                sum += score;
            }
            
            // act  
            var result = employ.Result;
            // assert
            Assert.AreEqual(sum, result);
        }
    }
}