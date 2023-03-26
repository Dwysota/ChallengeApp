
int number = 147147147;
List<char> numbers_List = number.ToString().ToList<char>();
int[] count_numbers = new int[10];

foreach (char digitChar in numbers_List)
{
    int digit;
    if (int.TryParse(digitChar.ToString(), out digit))
    {
        for (int i = 0; i < count_numbers.Length; i++)
        {

            if (i == digit)
            {
                count_numbers[i]++;
            }

        }
    }

}

for (int i = 0; i < count_numbers.Length; i++)
{
    Console.WriteLine(i + " => " + count_numbers[i]);
}
