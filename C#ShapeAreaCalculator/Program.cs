//Following this tutorial => https://youtu.be/vxJ4TIQrjt8?si=LWVGG66vcc7HVt0r

namespace C_ShapeAreaCalculator
{
    //Remove internal from the class name!
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result;
            Console.WriteLine("What shape would you like to find the area of?\n");
            Console.WriteLine("Please enter...\n\nr) Rectangle\nany other key) Circle\n");
            answer = Console.ReadLine();

            if (answer == "r" )
            {
                Console.WriteLine("\nPlease enter the height of the rectangle.");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("\nPlease enter the width of the rectangle.");
                float width = float.Parse(Console.ReadLine());

                result = height * width;
            }
            else 
            {
                Console.WriteLine("\nPlease enter the radius of the circle.");
                float radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * (radius * radius);
            }

            Console.WriteLine("The result is " + result);
            Console.ReadKey();
        }
    }
}
