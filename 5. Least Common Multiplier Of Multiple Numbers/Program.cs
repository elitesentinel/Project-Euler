var totalMultiplication = 1;
Console.Write("enter the number:");
int value = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[value];
int[] array2 = new int[value];

for (int i = 0; i < value; i++)
{
    array1[i] = i + 1;
}

for (int i = 1; i < value; i++)
{
    var number = 2;

    while (number <= array1[i] + 1)
    {
        int howManyTimes = 0;
        while (array1[i] % number == 0)
        {
            array1[i] = array1[i] / number;
            howManyTimes += 1;
        }

        if (array2[number - 1] < howManyTimes)
        {
            array2[number - 1] = howManyTimes;
        }

        number += 1;

    }
}

for (int j = 2; j <= value; j++)
{
    if (array2[j - 1] != 0)
    {
        for (int x = 0; x < array2[j - 1]; x++)
        {
            totalMultiplication = totalMultiplication * j;
        }
    }
}

Console.WriteLine(totalMultiplication);
Console.ReadKey();