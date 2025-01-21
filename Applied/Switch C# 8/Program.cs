namespace Switch_C__8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int? number = int.Parse(Console.ReadLine());
                
            string Message = number switch
            {
                null => "nullable type",
                0=>"Zero",
                int x when x>0 =>"positive number",
                int x when x<0 =>"negative number",

            };
            Console.WriteLine(Message);

        }
    }
}
