using ArrayUtils;

Console.Write("Введите N (N>=3 и должно быть нечётным): ");
int N = Convert.ToInt32(Console.ReadLine());
while ((N<3)&&(N%2==0))
{
    Console.Write("Вы неправильно ввели N, попробуйте ещё раз");
    Console.Write("Введите N (N>=3 и должно быть нечётным): ");
    N = Convert.ToInt32(Console.ReadLine());
}

double [,] array=new double[N,N];

Random rnd = new Random();
for (int i = 0; i < N; i++) {
    for (int j = 0; j < N; j++) {
       array[i, j] = Convert.ToDouble(rnd.Next(0, 100))/100;
    }
}

Extensions.Print2DArray(array, N);

double min = double.MaxValue;
for (int i = 0; i < N; i++)
{
    if ((array[i, N-i-1] < min) &&(i!=(N-1)/2)) 
        min = array[i,N-i-1];
}

Console.Write("Минимальное значение - "+min);