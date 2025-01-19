namespace Array_2D_Rectanglar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Marks = new int[2, 3] { { 10, 20, 30 }, { 30, 40, 50 } };

            for (int i = 0; i < Marks.GetLength(0)/*2*/;i++)
            {
                if (i!=0)
                {
                    Console.WriteLine($"Grades Of Student No({i + 1}) : {Marks[i, 0]} , {Marks[i,  1]} , {Marks[i ,  2]}");

                }
                else
                    Console.WriteLine($"Grades Of Student No({i + 1}) : {Marks[i, i]} , {Marks[i, i + 1]} , {Marks[i, i + 2]}");


            }
        }
    }
}
