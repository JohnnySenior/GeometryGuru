Console.WriteLine("This console app calculate the area of Circle");

Console.Write("Enter the radius: ");
var radius = double.Parse(Console.ReadLine());
var pi = Math.PI;

Console.WriteLine($"Area: {pi} * ({radius} * {radius}) = {pi * Math.Pow(radius, 2)}");