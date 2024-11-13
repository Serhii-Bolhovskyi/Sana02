Console.WriteLine("Enter the value of a: ");
double.TryParse(Console.ReadLine(), out double a);
Console.WriteLine("Enter the value of b: ");
double.TryParse(Console.ReadLine(), out double b);
Console.WriteLine("Enter the value of c: ");
double.TryParse(Console.ReadLine(), out double c);

double discriminant = b * b - 4 * a * c;
Console.WriteLine($"Discriminant = {discriminant:F2}");

if (discriminant > 0)
{
    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    Console.WriteLine($"The root of x1 = {x1:F2} and x2 = {x2:F2}");
} else if (discriminant == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine($"The root of x = {x:F2}");
}
else if(discriminant < 0)
{
    Console.WriteLine("There are no roots for current equation ");
}
