using System.Text;

namespace Session_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ex.5

            ///*Write C# program that Assigning one value type variable to another and 
            //  modifying the value of one variable and mention what will happen*/
            //int num1 = 20;
            //int num2 = num1;
            //Console.WriteLine($"Before Modifying num1 : {num1} And Num2 : {num2}");
            //num2 = 50;
            //Console.WriteLine($"After Modifying num1 : {num1} And Num2 : {num2}"); 
            #endregion

            #region Ex.6
            /*Write C# program that Assigning one reference type variable to another
            //  and modifying the object through one variable and mention what will happen */
            //string Name01 = "Hesham";
            //string Name02 = Name01;
            //Console.WriteLine($"Before Modify Name01 : {Name01} And Name02 : {Name02}");
            //Name01 = "Hamed";
            //Console.WriteLine($"After Modify Name01 : {Name01} And Name02 : {Name02}");

            #endregion

            #region Ex.7
            /*Write C# program that take two string variables and print them as one variable */
            //StringBuilder FullName = new StringBuilder();

            //Console.Write("Enter First  Name : ");
            //FullName.Append(Console.ReadLine());
            //Console.Write("Enter Second Name : ");
            //FullName.Append(Console.ReadLine());
            //Console.Write("Enter Third  Name : ");
            //FullName.Append(Console.ReadLine());
            //Console.Write("Enter Last   Name : ");
            //FullName.Append(Console.ReadLine());
            //Console.WriteLine($"FullName : {FullName}");
            #endregion

            #region Ex.8
            /*Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
            //          Note : The formula for simple interest is Interest = (principal * rate * time ) /100.*/
            //Console.Write("Enter principal : ");
            //int principal; int.TryParse(Console.ReadLine(),out principal);

            //Console.Write("Enter Rate : ");
            //int Rate; int.TryParse(Console.ReadLine(), out Rate);

            //Console.Write("Enter Time : ");
            //int Time ; int .TryParse(Console.ReadLine(),out Time);

            //Console.Clear();

            //var Interest = (principal * Rate * Time) / 100;
            //Console.WriteLine($"Interest : {Interest}");
            #endregion

            #region Ex.9
            //int Temprory = 10;
            //string result = Temprory > 30 ? "Just Hot" : Temprory < 10 ? "Just Cold" : "Just good";
            //Console.WriteLine(result);


            #endregion

            #region FormatOfDay
            Console.Write("Enter Date : ");
            string? Date =Console.ReadLine();
            if (Date is null)
            {
                Console.Write("Enter Date : ");
                 Date = Console.ReadLine();

            }
            else
            {
                string[] Parts =Date.Split(' ');
                string result01 =string.Join(",", Parts);
                string result02 =string.Join("/", Parts);
                string result03 =string.Join("-", Parts);
                Console.WriteLine(result01);
                Console.WriteLine(result02);
                Console.WriteLine(result03);
                 

            }

            #endregion
        }
    }
}
