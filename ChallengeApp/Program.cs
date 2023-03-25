String name = "Ewa";
char sex = 'K'; // K - kobieta, M - mezczyzna
int age = 33;

if (age >= 0)
{
    if (sex == 'K')
    {
        if (name == "Ewa" && age == 33)
        {
            Console.WriteLine(name + ", lat " + age);
        }
        else if (age < 33)
        {
            Console.WriteLine("Kobieta ponizej 33 lat.");
        }
        else
        {
            Console.WriteLine("Kobieta o imieniu " + name + ", lat " + age);
        }
    }
    else if (sex == 'M')
    {
        if (age < 18)
        {
            Console.WriteLine("Niepelnoletni mezczyzna");
        }
        else
        {
            Console.WriteLine("Mezczyzna, o imieniu " + name + ", lat " + age);
        }
    }
    else
    {
        Console.WriteLine("Niepoprawna plec (M - mezczyzna, K - kobieta)");
    }
}
else
{
    Console.WriteLine("Niepoprawny wiek (wiek nie moze byc ujemny");
}
