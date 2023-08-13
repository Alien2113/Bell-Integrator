namespace ArrayUtils
{
    public static class Extensions
    {


        public static void Print2DArray<T>(T [,] array, int N)
        {
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++)
                { 
                    Console.Write(array[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}