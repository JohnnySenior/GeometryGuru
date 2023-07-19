Console.WriteLine("This console app calculate the area of Circle");

Console.Write("Enter the radius: ");
double radius = double.Parse(Console.ReadLine());
double pi = Math.PI;

Console.WriteLine($"Area: {pi} * ({radius} * {radius}) = {pi * Math.Pow(radius, 2)}");

    