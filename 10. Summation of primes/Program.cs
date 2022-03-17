
Int64 sumOfPrimes = 0;


for (int i = 2; i <= 2000000; i++)  
{
    int number = 2;

    while (number <= i)
    {

        if (i % number == 0 && i != number)
        {
            break;
        }
        if (number == i)
        {
            sumOfPrimes += number;
        }
        number++; 
    }
       
}
Console.WriteLine(sumOfPrimes);
Console.ReadKey();