using System.Text;
namespace StringBuilderr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder Message = new StringBuilder();
            Message.AppendLine(" Hesham Ahmed Hassan");
            Message.AppendLine("Ali");
            Message.Replace("Ahmed","hany");
            Message.AppendFormat("{0} : {1}","hesham","Ahmed");
            Message.AppendJoin(" ", " Khaled", "hady");
            Console.WriteLine(Message.GetHashCode());
            Console.WriteLine(Message.Length);
            Message.Insert(1, " hami ");

            Console.WriteLine(Message);
        }
    }
}
