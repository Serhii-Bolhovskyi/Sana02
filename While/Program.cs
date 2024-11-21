int n;
int factorial = 1;
bool isValid;
double a = 0, b = 1, c = 0;

do
{
    Console.Write("Enter n: ");
    isValid = int.TryParse(Console.ReadLine(), out n);
    if(!isValid || n < 1)
        Console.WriteLine("Please enter a valid positive integer!");
} while(!isValid || n < 1);

// a
for (int i = 1; i <= n; i++)
    a += Math.Pow(-1, i) / (2 * i + 1);

Console.WriteLine($"a = {a:F3}");

// b
for(int i = 1; i <= n; i++)
    b += 1.0/Math.Pow(i, 2);
Console.WriteLine($"b = {b:F3}");

//c
for (int i = 1; i <= n; i++)
{
    factorial *= i;
    c = factorial;
}
Console.WriteLine($"c = {c:F1}");