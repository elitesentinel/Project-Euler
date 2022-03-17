string dataSet = File.ReadAllText(@"E:\Projects\projecteuler.net\8. Largest product in a series\dataset.txt");
char[] charArray = new char [dataSet.Length];
for (int i = 0; i < dataSet.Length; i++)
{
    charArray[i] = dataSet[i];
}
int[] intArray = Array.ConvertAll(charArray, c => (int)Char.GetNumericValue(c));
Int64 multiplication = 1;

for (int i = 0; i <= 987; i++)
{
    Int64 variable = 1;
    for (int j = 0; j < 13; j++)
    {
        variable = variable * intArray[i+j];

        if (variable == 0)
        {
            variable = 1;
        }

        if (variable > multiplication)
        {
            multiplication = variable;
        }

    }    
}
Console.WriteLine(multiplication);
Console.ReadKey();


