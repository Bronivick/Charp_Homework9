Console.WriteLine("Введите число");
int Num = int.Parse(Console.ReadLine());

int EndNum = 1;

Console.WriteLine(PrintNumber(Num,EndNum));

string PrintNumber(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return (start + "," + PrintNumber(start-1, end));
}