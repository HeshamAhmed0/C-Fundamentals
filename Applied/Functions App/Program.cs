namespace Functions_App
{
    internal class Program
    {
        static void SumMul(int num1,int num2,out int Mul,out int Sum)
        {

            Mul = num1 * num2;
            Sum = num1 + num2;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter Number 1 : ");
             int num1; 
             bool flag1= int.TryParse(Console.ReadLine(), out num1);

            Console.Write("Enter Number 2 : ");

            int num2;
             bool flag2= int.TryParse(Console.ReadLine(), out num2);
            if (flag1 == false&& flag2 == false)
            {
                Console.WriteLine("Nums is not Correct");
                Console.Write("Enter Number 1 : ");
                flag1 = int.TryParse(Console.ReadLine(), out num1);
                Console.Write("Enter Number 2 : ");
                 flag2 = int.TryParse(Console.ReadLine(), out num2);
            }
            else if (flag1 == false)
            {
                Console.WriteLine("Num1 Is Not Correct ");
                flag1 = int.TryParse(Console.ReadLine(), out num1);

            }
            else if (flag2 == false) {
                Console.WriteLine("Num2 Is Not Correct ");
                flag2 = int.TryParse(Console.ReadLine(), out num2);
            }
            int Mul, Sum;
            SumMul(num1,num2,out Mul,out Sum);

            Console.WriteLine($"Mul : {Mul}");
            Console.WriteLine($"Sum : {Sum}");
        }
    }
}
