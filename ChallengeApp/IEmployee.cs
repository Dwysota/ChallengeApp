

using System.Globalization;

namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get;  }
        void AddGrade(double grade);
        void AddGrade(float grade);
        void AddGrade(int grade);
        void AddGrade(long grade);
        void AddGrade(string grade);
        Statistics GetStatistics();
    }
}
