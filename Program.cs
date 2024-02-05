// author: Rod M
// task: Unit 4 - Lab 1

using CircleCalculator;

Console.WriteLine("------ Welcome to Circle Calculator! ------");
Console.WriteLine("Enter your circle radius (integer or double)");

Circle newCircle;

while(true)
{
    if(double.TryParse(Console.ReadLine(), out double newRadius))
    {

        if (newRadius <= 0) {
            Console.WriteLine("Invalid Radius. Please try a positive value");
        }
        else
        {
            newCircle = new Circle(newRadius);

            Console.WriteLine("Diameter: {0}", newCircle.GetDiameter());
            Console.WriteLine("Circumference: {0}", newCircle.GetCircumference());
            Console.WriteLine("Area: {0}", newCircle.GetArea());


            break;
        }


    }
    else
    {
        Console.WriteLine("Invalid Radius. Please try a new value");
    }
}

while(true)
{
    Console.WriteLine();
    Console.WriteLine("Should the circle grow? y/n");

    string choice = Console.ReadLine();
    choice = choice.ToLower().Trim();
    if (choice.Contains("y"))
    {
        newCircle.Grow();
        Console.WriteLine("Diameter: {0}", newCircle.GetDiameter());
        Console.WriteLine("Circumference: {0}", newCircle.GetCircumference());
        Console.WriteLine("Area: {0}", newCircle.GetArea());
        break;
    }
    else if (choice.Contains("n"))
    {
        Console.WriteLine();
        Console.WriteLine("The circle's final radius is {0}", newCircle.GetRadius());
        break;
    }

}
