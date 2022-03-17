for (int c = 3; c <= 1000; c++)
{
    int b = 2;
    while (b < c)
    {
        int a = 1;
        while (a < b)
        {
            if (Math.Pow(c,2) == Math.Pow(b,2)+ Math.Pow(a,2) && a + b + c == 1000)
            {
                Console.WriteLine($"A = {a}, B = {b}, C = {c}");
                Console.WriteLine($"Product of A + B = C is:{a*b*c}");
            }
            a++;
        }
        b++;
    }
}
Console.ReadKey();