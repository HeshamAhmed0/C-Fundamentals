namespace Array_2D_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] GradesStudents = new int[3, 4];
            bool flag;

            for (int i=0;i<GradesStudents.GetLength(0);i++)
            {
                Console.WriteLine($"Enter Grade of Student : {i+1}");
                for (int j=0;j<GradesStudents.GetLength(1);)
                {
                    Console.Write($"Enter Grade of Subjecr : {j+1}>>>> ");
                    flag = int.TryParse(Console.ReadLine(),out GradesStudents[i,j]);
                    if (flag==true)
                    {
                        j++;
                    }
                }
            }

            for (int i = 0; i < GradesStudents.GetLength(0); i++)
            {
                Console.WriteLine($"Grade Of Student : {i + 1}");
                for (int j = 0; j < GradesStudents.GetLength(1); j++)
                {
                    Console.WriteLine($"Subject {j + 1} = {GradesStudents[i, j]}");
                }
            }

        }
    }
}
