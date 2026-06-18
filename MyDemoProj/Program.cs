
namespace MyDemoProj
{
    public class Program
    {
        public static void Main()
        {
            TestClass test = new TestClass();



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

            // Now use above switch case code and pass an array val then using a for each loop to check each value and print it.

            int[] values = { 1, 4, 5, 7, 9 };
            foreach (int i in values)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine($"Value is {i}");
                        break;
                    case 2:
                        Console.WriteLine($"Value is {i}");
                        break;
                    case 3:
                        Console.WriteLine($"Value is {i}");
                        break;
                    case 4:
                        Console.WriteLine($"Value is {i}");
                        break;
                    case 5:
                        Console.WriteLine($"Value is {i}");
                        break;
                    default:
                        Console.WriteLine($"Value is {i}");
                        break;
                }
            }

            // Use same array val and use conditions if/else to print the value like if, else if, else if, else

            foreach (var i in values)
            {
                if (i == 1)
                {
                    Console.WriteLine($"Value is {i}");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"Value is {i}");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"Value is {i}");
                }
                else
                {
                    Console.WriteLine($"Value is {i}");
                }
            }


            // cREATE A NEW PROJECT Models, Services, Repository
            // Create a new User Class in model project with objects in it Name, Age, Address, ZipCode - DONE
            // Create new Class in Services -> UserService, insert a new object and assign values
            // Create a new class in Repository- UserRepository, call database and add it.

        }
    }
}