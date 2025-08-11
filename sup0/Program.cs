namespace sup0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name 
            while (true)
            {
                Console.Write("Enter your full name: ");
                string fullname = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(fullname))
                {
                    Console.WriteLine("Full name cannot be empty. Please try again.");
                }
                else
                {
                    Console.WriteLine($"Hello, <{fullname}>!");
                    break;
                }
            }
            //Entering Numbers and Calculating Average and Product
            while (true)
            {                   
                Console.Write("Enter First Number: ");
                int.TryParse(Console.ReadLine(), out int num1);
                Console.Write("Enter Second Number: ");
                int.TryParse(Console.ReadLine(), out int num2);
                Console.Write("Enter Third Number: ");
                int.TryParse(Console.ReadLine(), out int num3);
                if (num1 == 0 || num2 == 0 || num3 == 0)
                {
                    Console.WriteLine("One of the numbers is zero, please try again.");
                }
                else { 
                float average = (num1 + num2 + num3) / 3.0f;
                float product = num1 * num2 * num3;

                    Console.WriteLine($"Average: {Math.Round(average, 2)}");
                    Console.WriteLine($"Product: {Math.Round(product, 2)}");
                    break;
                }
            }
            //Calculating Volume of a Sphere
            while (true)
            {
                Console.Write("Enter the volume of a sphere: ");
                if (float.TryParse(Console.ReadLine(), out float raduis) && raduis > 0)
                {
                    float volume = (4.0f / 3.0f) * MathF.PI * MathF.Pow(raduis, 3);
                    Console.WriteLine($"Volume of the sphere with radius {Math.Round(raduis, 2)} is: {Math.Round(volume, 4)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input for radius. Please enter a positive number.");
                }
            }
        }
    }
}
