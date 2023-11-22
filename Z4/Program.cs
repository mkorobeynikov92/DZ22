Console.Clear();
Console.Write("Введите число N ");
int n = int.Parse(Console.ReadLine()!);
if (n < 10)
    Console.WriteLine(n);
else
while (n > 0)
{
int t = n % 10;
n = n / 10;
if(n > 0)
Console.Write($"{t},");
else
Console.WriteLine(t);
}