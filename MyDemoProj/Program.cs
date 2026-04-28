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

            // Further programming here....
        }
    }
}