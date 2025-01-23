using System.Threading.Channels;
using System.Transactions;

namespace Details_of_Students
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter Your Name : ");
            string Name = Console.ReadLine();
            Console.WriteLine($"Hello : {Name}");
            Console.Write("( Choose : 1 For New Account     2 : For Login ) : ");
            int choosen; int.TryParse(Console.ReadLine(), out choosen);
            if (choosen ==1)
            {
                Console.Write("Enter First Name : ");
                string FirstName = Console.ReadLine();
                Console.Write("Enter Your Age : ");
                int Age =int.Parse(Console.ReadLine());
                Console.Write("Enter Your Level As :  1 For Level 1 ,And 2 For Level2 : ");
                int Level = int .Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Account Created .");
                Console.WriteLine("      Enjoy       ");
                Main();
            }else if (choosen==2)
            {
                Console.WriteLine($"Hello {Name} ");
                Console.Write("(Choose 1 For Degrees || 2 For information Of You )");
                int ch=int.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    Console.WriteLine("You DEgrees is : \n Arabic : 20 \n English : 50"); ;
                }
                else if (ch == 2) 
                {           
                    Console.WriteLine("Your Information Is : PhoneNumber : 01503032660\nEmail : heshammathana1@gmail.com ");
                } 
                else 
                {
                    Console.Write("(Choose 1 For Degrees || 2 For information Of You )");
                    ch = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                Console.Write("( Choose : 1 For New Account     2 : For Login ) : ");
                 int.TryParse(Console.ReadLine(), out choosen);
            }
            
        }
    }
}
