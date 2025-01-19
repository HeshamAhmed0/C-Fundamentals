namespace Switch_C_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object number = new Person() { Id=1,Name="Hesham"};
            switch (number) { 

            case int value when value>50:
                    Console.WriteLine("int");
                    break;

               
            case string value:
                    Console.WriteLine("String");
                    break;
             case double value:
                    Console.WriteLine("double");
                    break;

            case decimal value:
                    Console.WriteLine("Deciamal");
                    break;
            case Person value when value.Id==1 &&value.Name=="Hesham":
                    Console.WriteLine($"Person : {value.Name}");
                    break;
            default :
                    Console.WriteLine("No Matching");
                    break;
            }

        }
    }
}
