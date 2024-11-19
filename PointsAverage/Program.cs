double[] grades = new double[5];

for (int i = 0; i < grades.Length; i++)
{
    Console.Write("Enter student grades on a 100-point scale: ");
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out double grade) && grade >= 0 && grade <= 100)
        {
            grades[i] = grade;
            break;
        } else 
            Console.Write("Invalid input! Please enter number between 0 and 100: ");
    }
}

double averagePoints = grades.Average();
Console.WriteLine($"Average points grade: {averagePoints:F1}");
if (averagePoints >= 50)
{
    Console.WriteLine("Student are admitted to exam");
}
else
{
    Console.WriteLine("Student are not admitted to exam");
}
