Console.Write("Enter number between 0 and 9: ");

if (int.TryParse(Console.ReadLine(), out int number))
{
    switch (number)
    {
        case 0:
            Console.WriteLine($"{number} - zero.");
            break;
        case 1:
            Console.WriteLine($"{number} - one.");
            break;
        case 2:
            Console.WriteLine($"{number} - two.");
            break;
        case 3:
            Console.WriteLine($"{number} - three.");
            break;
        case 4:
            Console.WriteLine($"{number} - four.");
            break;
        case 5:
            Console.WriteLine($"{number} - five.");
            break;
        case 6:
            Console.WriteLine($"{number} - six.");
            break;
        case 7:
            Console.WriteLine($"{number} - seven.");
            break;
        case 8:
            Console.WriteLine($"{number} - eight.");
            break;
        case 9:
            Console.WriteLine($"{number} - nine.");
            break;
        default:
            Console.WriteLine("Enter a valid number between 0 and 9: ");
            break;
    }
}
else Console.WriteLine("Invalid input. Please enter a number.");


