//namespace Sum_Array
//{
//    internal class Program
//    {
//        static int SwmOfArray(int[] Arr)
//        {
//            int sum = 0;
//            for (int i=0;i<Arr.Length;i++)
//            {
//                sum+= Arr[i];
//            }
//            return sum;
//        }
//        static void Main(string[] args)
//        {
//            int[] Arr = { 1, 2, 3, 4, 5 };
//            int total= SwmOfArray(Arr);
//            Console.WriteLine($"Sum Of Total Number In Array Is : {total}");
//        }
//    }
//}
namespace Sum_Array
{
    internal class Program
    {
        static int SwmOfArray(params int[] Arr)
        {
            int sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //int[] Arr = { 1, 2, 3, 4, 5 };
            int total = SwmOfArray(1,2,3,4,5,6,7,8);
            Console.WriteLine($"Sum Of Total Number In Array Is : {total}");
        }
    }
}
