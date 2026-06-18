namespace Repository
{
    public class Fruits
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }


        public void GetPersonDetails()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Address);
            Console.WriteLine(Zipcode);
        }
    }
}
// A class can contain either Properties/ Objects or Methods.