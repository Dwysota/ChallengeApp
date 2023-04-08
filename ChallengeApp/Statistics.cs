using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Statistics
    {
        public double Min { get; private set; }
        public double Max { get; private set; }
        public double Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }
        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var stat when stat > 80:
                        return 'A';
                    case var stat when stat > 60:
                        return 'B';
                    case var stat when stat > 40:
                        return 'C';
                    case var stat when stat > 20:
                        return 'D';
                    default:
                        return 'E';
                }

            }
        }
        public double Sum { get; private set; }
        public int Count { get; private set; }

        public Statistics()
        {
            this.Sum = 0;
            this.Count = 0;
            this.Max = double.MinValue;
            this.Min = double.MaxValue;

        }
        public void AddGrade(double grade)
        {
            this.Count++;
            this.Sum += grade;

            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);

        }
    }
}
