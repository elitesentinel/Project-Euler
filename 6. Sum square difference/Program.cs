var maxNumber = 100;
double sumSquared = 0;
double squaredSum = 0;
double result;

for (int i = 1; i <= maxNumber; i++)
{
    squaredSum += Math.Pow(i, 2);
    sumSquared += i;
}
sumSquared = Math.Pow(sumSquared, 2);

result = sumSquared - squaredSum;

Console.WriteLine(result);
Console.ReadKey();