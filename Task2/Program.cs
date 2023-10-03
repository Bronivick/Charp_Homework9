Console.WriteLine("Введите значение M: ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

SumFromMToN(M, N);

void SumFromMToN(int M, int N)
{
 Console.Write(SumMN(M - 1, N));
}

int SumMN(int M, int N)
{
    int result = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        result = M + SumMN(M, N);
        return result;
    }
}