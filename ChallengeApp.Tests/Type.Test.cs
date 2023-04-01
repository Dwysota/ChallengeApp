
namespace ChallengeApp.Tests
{
    public class TypeTest
    {

        
        [Test]
        public void CompareTwoReferncesVariables()
        {
            // arrange
            Employee emp1 = GetEmployee("Adam");
            Employee emp2 = GetEmployee("Dawid");

            // act  

            // assert
            Assert.AreNotEqual(emp1, emp2);
        }
        
        [Test]
        public void CompareTwoValuesVariables()
        {
            //  arrange
            string name1 = "Adam";
            string name2 = "Adam";

            // assert
            Assert.AreEqual(name1, name2);  
        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
