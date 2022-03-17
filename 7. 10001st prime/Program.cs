var primeNumbers = 0;
var number = 1;
while (primeNumbers < 10001)
{
    number++;
    for (int i = 2; i <= number; i++)
    {
        if (number % i == 0 && number != i)
        {
            break;
        }

        if (number == i)
        {
            primeNumbers++;
        }

        
    }

    
}
Console.WriteLine(number);
Console.WriteLine(primeNumbers);
Console.ReadKey();
