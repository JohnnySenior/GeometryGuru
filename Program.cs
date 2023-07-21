Console.WriteLine("This console app calculate the area of shapes as follow:");
Console.WriteLine();
Console.WriteLine("1. Circle");
Console.WriteLine("2. Triangle");
Console.WriteLine();
Console.Write("Choose shape: ");

string stringOption = Console.ReadLine();
int option = int.Parse(stringOption);

if (option == 1)
{
    Console.Write("Enter the radius: ");
    double radius = double.Parse(Console.ReadLine());
    const double pi = Math.PI;

    Console.WriteLine($"Area: {pi} * ({radius} * {radius}) = {pi * Math.Pow(radius, 2)}");
}
else if (option == 2)
{
    Console.WriteLine("We should validate triangle.");
    Console.WriteLine("Because we use Heron's formula to calculate the area.");

    Console.Write("First side: ");
    double side1 = double.Parse(Console.ReadLine());

    Console.Write("Second side: ");
    double side2 = double.Parse(Console.ReadLine());

    Console.Write("Third side: ");
    double side3 = double.Parse(Console.ReadLine());

    if((side1 + side2 > side3) && (side1 + side3 > side2) && (side3 + side2 > side1))
    {
        Console.WriteLine("Successfully validated !!!");
        double semiPerimetr = (side1 + side2 + side3) / 2;
        double area = Math.Sqrt(semiPerimetr * (semiPerimetr - side1) 
                                             * (semiPerimetr - side2) 
                                             * (semiPerimetr - side3));
        Console.WriteLine($"Area: {area}");
    }
    else
        Console.WriteLine("No such triangle exists.");

}
else
    Console.WriteLine("We have only two shapes, try again.");


