namespace Switch_with_c__9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 person = new Class1() { id= 1 ,name="Hesham"};
            int? number;
            string message = person switch
            {
                { id : 1,name : "Hesham"} => $"Hello {person.name}",
                { id : 3} => $"Hello",
                { id : 2} => $"Hello {person.name}",

            };
            Console.WriteLine(message);
        }
    }
}
