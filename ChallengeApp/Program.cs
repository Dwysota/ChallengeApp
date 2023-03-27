using ChallengeApp;

var employee = new Employee("Dawid", "W");
var ran = new Random();
for(int i = 0; i < 10; i++)
{
    double val = ran.NextDouble()*100;
    employee.AddGrade(val);
    Console.Write($"{val:N2}; ");
}

var statistics = employee.GetStatistics();  
Console.WriteLine($"\n\nAverage: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");


