namespace Session3_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degree;
            degree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(degree<10?"Just Cold":degree>30?"Very Hot":"Cool");
        }
    }
}
