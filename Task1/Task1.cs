using ArrayUtils;

Console.Write("Введите N (N>=2): ");
int N = Convert.ToInt32(Console.ReadLine());
while (N<2) {
    Console.Write("Вы неправильно ввели N, попробуйте ещё раз");
    Console.Write("Введите N (N>=2): ");
    N = Convert.ToInt32(Console.ReadLine()); 
}
int[,] array = new int[N, N];

for (int i = 0; i < N; i++)
    {
        array[i, i] = i+1;
        array[i, N-i-1] = i+1;
    }

if (N % 2 != 0)//не чётное
{
    int centr = (N - 1) / 2;
    array[centr, centr] = 0;   
}

Extensions.Print2DArray(array,N);