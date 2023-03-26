
using ChallengeApp;

List<Employee> employees = new List<Employee> { new("Adam", "K", 35), new("Dawid", "W", 36), new("Agnieszka", "O", 33) };

foreach (Employee employee in employees)
{
    employee.addScore(new Random().Next(1, 11));
    employee.addScore(new Random().Next(1, 11));
    employee.addScore(new Random().Next(1, 11));
}
Employee bestEmpolyee = new();
foreach (Employee employee in employees)
{
    if (bestEmpolyee.Result < employee.Result)
    {
        bestEmpolyee = employee;
    }
}
Console.WriteLine("Pracownik z najwieksza iloscia punktow: \n " + bestEmpolyee.getData());
