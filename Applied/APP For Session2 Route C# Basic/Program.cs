using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace APP_For_Session2_Route_C__Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ex.1
            //Console.Write("Hello In My Progect ::: Please Enter Number : ");
            //int number;
            //int.TryParse(Console.ReadLine(),out number);
            //Console.WriteLine($"Number You Enter : {number}"); 

            #endregion

            #region Ex.2
            /*Write C# program that Assigning one value type variable to another and 
                modifying the value of one variable and mention what will happen */


            //int x = 20;
            //Int32 y;
            //y = x;
            //Console.WriteLine(y);


            /* Will Happen 8 bytes allocate in the stack 
             * the first 4 bytes allocate will incide it x and his value 20;
             * and the second 4 bytes will incide it y without any iitialize 
             * then the value of x will copy in the value of y
             */

            #endregion

            #region Ex.3
            //string name01 = "Hesham"; 
            //// in this step will allocate 4 byte in the stack and will allocate 12 byte in the heap 
            //// the 4 byte incide it will have name01 <Reference To heap>
            //// 12 bytes incide it value "Hesham"
            ////name01 refer to Hesham in the heap
            
            //string name02 = "Hassan";
            //// the sam e staps happen in the step 1

            //name01 = name02;
            //// in this case  name01 will Refer to the same reference name02 refer to it 
            //// then name01 ane name02 refere to the same reference 
            // and "hesham" will be un reasehed and the garbige collector will delete it
            #endregion





        }
    }
}
