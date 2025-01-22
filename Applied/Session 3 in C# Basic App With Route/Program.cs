namespace Session_3_in_C__Basic_App_With_Route
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ex.1
            /*Write a program that allows the user to enter a number then print it. */

            //Console.Write( "Enter The Number You Want To Update For it : ");

            //int? num1=int.Parse(Console.ReadLine());
            //if (num1.HasValue)
            //{
            //    num1 += 10;

            //}
            //else
            //{
            //    num1.GetValueOrDefault();
            //}
            //Console.WriteLine(num1);
            #endregion

            #region Ex.2
            /*Write C# program that converts a string to an integer, but the string 
                contains non-numeric characters. And mention what will happen*/

            //string input = "Hesham";
            ////int number =int.Parse(input);
            //// in this case will be exception error
            //int number;
            //int.TryParse(input, out number);
            //// in this case will take the default value for int =====0
            //Console.WriteLine(number);
            #endregion

            #region Ex.3
            ///*Write C# program that Perform a simple arithmetic operation
            // * with floating-point numbers And mention what will happen*/
            //Console.Write("Enter Float Number01 : ");
            //float Number01 = float.Parse(Console.ReadLine());
            //Console.Write("Enter Float Number02 : ");
            //float Number02 = float.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Choose 1 If You Want ( * )");
            //Console.WriteLine("Choose 2 If You Want ( + )");
            //Console.WriteLine("Choose 3 If You Want ( - )");
            //Console.WriteLine("Choose 4 If You Want ( / )");
            //Console.Write("Enter OPeration You Want To Make : ");
            //int Choosen; 
            //int.TryParse(Console.ReadLine(),out Choosen);
            //string result = Choosen switch
            //{
            //    1 => $"Number01 * Number02 = {Number01 * Number02}",
            //    2 => $"Number01 + Number02 = {Number01 + Number02}",
            //    3 => $"Number01 - Number02 = {Number01 - Number02}",
            //    4 => $"Number01 / Number02 = {Number01 / Number02}",
            //};
            //Console.WriteLine(result);




            #endregion

            #region Ex.4
            /*Write C# program that Extract a substring from a given string.*/
            //Console.Write("Enter String : ");
            //string input = Console.ReadLine();
            
            //Console.WriteLine(input.Substring(1,3));
            #endregion
        }
    }
}
