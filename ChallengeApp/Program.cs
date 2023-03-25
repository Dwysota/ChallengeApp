String name = "Ewa";
char sex = 'M'; // K - kobieta, M - mezczyzna
int age = 17;

if (sex == 'K')
{
    if (name == "Ewa" && age == 33) Console.WriteLine(name + ", lat " + age);
    else if (age < 33) Console.WriteLine("Kobieta ponizej 30 lat.");
    else Console.WriteLine("Kobieta o imieniu " + name + ", lat " + age);
}
else
{
    if (age < 18) Console.WriteLine("Niepelnoletni mezczyzna");
    else Console.WriteLine("Mezczyzna, o imieniu " + name + ", lat " + age);
}