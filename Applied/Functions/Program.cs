namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Function ProtoType , Calling
            // Function Paramenters Can Take Default Values 
            // Can Call Value Without Make Arguement in order 
            //ptintshapes(Shape : "///***/, Count : 8)
            //static void PrintShapes(int Count=5,string Shape="**/\\**")
            //    {
            //        for (int i=1;i<=Count;i++)
            //        {
            //            Console.WriteLine(Shape);
            //        }
            //    }

            //    PrintShapes(); 
            #endregion

            #region Passing By Value

            //int x = 5;int y = 10;
            //static void Swap(int A ,int B)
            //{
            //    int temp = A;
            //    A = B;
            //    B = temp;
            //}
            //Swap(x, y);
            //Console.WriteLine(x);
            //Console.WriteLine(y); 
            #endregion

            #region passin gby Ref
            //int x = 5;
            //int y = 50;
            //static void Swap(ref int A, ref int B)
            //{
            //    int temp = A;
            //    A = B;
            //    B = temp;
            //}
            //Swap(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y); 
            #endregion

            #region passing Refrance by value
            /*Referance by value*/

            //int[] numbers = { 1, 2, 3, 4 };

            //static void Sum( int[] nums)
            //{
            //    int summation = 0;
            //    nums =new int[] {6,8,9,10};

            //}
            //Sum( numbers);
            //Console.WriteLine(numbers[0]);

            #endregion

            #region passing Referance by Ref
            // int[] numbers = { 1, 2, 3, 4 };

            //static void Sum(ref int[] nums)
            //{
            //    int summation = 0;
            //    nums = new int[] { 6, 8, 9, 10 };

            //}
            //Sum(ref numbers);
            //Console.WriteLine(numbers[0]);

            #endregion

        }
    }
    }
