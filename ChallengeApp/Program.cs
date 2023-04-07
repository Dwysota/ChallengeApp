using ChallengeApp;

var employee = new EmployeeInFile("Dawid", "W");
Console.WriteLine("Program do oceny pracownika");
Console.WriteLine("---------------------------");
while(true)
{
    Console.WriteLine("Podaj ocene pracownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    
}

var statistics = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Average letter: {statistics.AverageLetter:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");


