int n;
bool isValid;
double a = 0, b, c;

do
{
    Console.Write("Enter n: ");
    isValid = int.TryParse(Console.ReadLine(), out n);
    if(!isValid || n < 1)
        Console.WriteLine("Please enter a valid positive integer!");
} while(!isValid || n < 1);

for (int i = 1; i <= n; i++)
    a += Math.Pow(-1, i) / (2 * i + 1);

Console.WriteLine($"a = {a:F4}");