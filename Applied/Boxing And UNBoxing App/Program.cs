using System.Security.AccessControl;

namespace Boxing_And_UNBoxing_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boking
            int x = 50;
            Object obj = x;
            obj = x;
            obj = 100;
            obj = "Aj";
            Console.WriteLine(obj);
            #endregion
        }
    }
}
