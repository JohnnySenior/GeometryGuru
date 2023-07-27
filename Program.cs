Console.WriteLine("This console app calculate the area check your knowlage of Geometry.");
Console.WriteLine("App give you values, you have to find area !");
Console.WriteLine("Note: Area(result) will be rounded !");
Console.WriteLine();
Console.WriteLine("1. Circle");
Console.WriteLine("2. Triangle");
Console.WriteLine();
Console.Write("Choose shape: ");

Random random = new Random();

string stringOption = Console.ReadLine();
int option = int.Parse(stringOption);

switch (option)
{
    case 1:
        double radius = random.Next(1, 10);
        const double pi = 3.14;
        double area = pi * Math.Pow(radius, 2);
        double roundedArea = Math.Round(area);
        double userArea;
        do
        {
            Console.WriteLine($"Radius: {radius}");

            Console.Write($"Calculate the area: ");
            userArea = double.Parse(Console.ReadLine());

            if (roundedArea == userArea)
                Console.WriteLine("Bingoo, You are awsome.");
            else
                Console.WriteLine("Wrong answer, you can do it, try again");
        } while (roundedArea != userArea);
        break;
    case 2:
        Console.WriteLine("We should validate triangle.");
        Console.WriteLine("Because we use Heron's formula to calculate the area.");

    key1: Console.Write("First side: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Second side: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Third side: ");
        double side3 = double.Parse(Console.ReadLine());

        if ((side1 + side2 > side3) && (side1 + side3 > side2) && (side3 + side2 > side1))
        {
            Console.WriteLine("Successfully validated !!!");
            double semiPerimetr = (side1 + side2 + side3) / 2;
            double areaTriangle = Math.Sqrt(semiPerimetr * (semiPerimetr - side1)
                                                 * (semiPerimetr - side2)
                                                 * (semiPerimetr - side3));
            Console.WriteLine($"Area: {areaTriangle}");
        }
        else
        {
            Console.WriteLine("No such triangle exists. Enter right numbers.");
            goto key1;
        }
        break;

    default:
        Console.WriteLine("We have only two shapes, try again.");
        break;
}


