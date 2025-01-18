namespace Route_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting
            #region Implicit Casting
            //int x = 200;
            //long y = x;

            #endregion

            #region Explicit Casting
            //double z = 50.5;
            //int n = (int)z;   /////   50
            //long u = 15151515151515151;
            //int r = (int)u;     // Random int



            #endregion
            #endregion

            #region Parsing
            #region Parse(Convert From string to any data type)
            //Console.WriteLine("Hello In My Program");

            //Console.Write("Enter Your Name : ");
            //string name =Console.ReadLine();

            //Console.Write("Enter Your Age : ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.Write("Enter Your Salary : ");
            //double Salary =double.Parse(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("Your Name Is : "+ name);
            //Console.WriteLine("Your Age Is : "+ Age);
            //Console.WriteLine("Your Salary Is : "+ Salary);

            #endregion

            #region  Covert(Convert From Any Data Type to Any DataType)

            //Console.WriteLine("Welcome To My Program");

            //Console.Write("Enter Your Name : ");
            //string name = Console.ReadLine();

            //Console.Write("Enter Your Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Your Salary : ");
            //double Salary = Convert.ToDouble(Console.ReadLine());

            //Console.Clear();    

            //Console.WriteLine("Your Name Is : " + name);
            //Console.WriteLine("Your Age Is : " + Age);
            //Console.WriteLine("Your Salary Is : " + Salary);

            #endregion
            #endregion

            #region OPERATORS
            #region  Unary Operator
            // this category deel with one variable
            int x = 20;
            /// Post fix[print then encrement]
            //Console.WriteLine(x++);  //20
            //Console.WriteLine(x);    // 21

            // pre fix increment[increment then print]
            //Console.WriteLine(++x);  // 21
            //Console.WriteLine(x);    //21

            /// Post fix[print then decrement]
            //Console.WriteLine(x--); //20
            //Console.WriteLine(x); //19


            // pre fix increment[increment then print]

            //Console.WriteLine(--x); //19
            //Console.WriteLine(x); //19

            #endregion

            #region Ternary Operator
            //string message = 4 > 3 ? "Yes" : "No";
            //Console.WriteLine(message);
            #endregion
            #endregion

            #region TryParse
            string input = "1234";
            int f;
            int.TryParse(input, out f);
            Console.WriteLine(f);
            #endregion
        }
    }
}
