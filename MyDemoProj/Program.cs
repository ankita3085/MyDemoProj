namespace MyDemoProj
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Do the coding here...");
            // Make an random array and use Random to pick values from that array and print them out.
            // In a For Loop!

            Random random = new Random();
            int[] val = { 1, 4, 6, 8, 0 };

            for (int i = 0; i < 5; i++)
            {
                int ran = random.Next(val.Length);
                Console.WriteLine(val[ran]);
            }

            // Use val array again and print by using Foreach loop.

            foreach (var i in val)
            {
                Console.WriteLine(i);
            }

            // Add a switch case statement that checks the value of a variable and prints out a message based on the value.
            int value = 5;

            switch (value)
            {
                case 1:
                    Console.WriteLine($"Value is {value}");
                    break;

                case 2:
                    Console.WriteLine($"Value is {value}");
                    break;
                case 3:
                    Console.WriteLine($"Value is {value}");
                    break;
                case 4:
                    Console.WriteLine($"Value is {value}");
                    break;
                case 5:
                    Console.WriteLine($"Value is {value}");
                    break;
                default:
                    Console.WriteLine("Value is not 1, 2, 3, 4, or 5");
                    break;
            }
        }
    }
}