namespace sup0
{
    internal class Program
    {
        private int num1, num2, num3;
        private string fullname;
        private float raduis;
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Enter your full name: ");
                fullname = Console.ReadLine();
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
            // This is a comment in the code
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

                    Console.WriteLine($"Average: {Math.round(average, 2)}");
                    Console.WriteLine($"Product: {Math.round(product, 2)}");
                    break;
                }
            }
            while (true)
            {
                Console.Write("Enter the volume of a sphere: ");
                if (float.TryParse(Console.ReadLine(), out float raduis) && raduis > 0)
                {
                    float volume = (4.0f / 3.0f) * MathF.PI * MathF.Pow(raduis, 3);
                    Console.WriteLine($"Volume of the sphere with radius {Math.round(raduis, 2)} is: {Math.round(volume, 4)}");
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
