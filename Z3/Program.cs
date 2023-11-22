Console.Clear();
Console.Write("Введите число от 10 до 99 ");
int number = int.Parse(Console.ReadLine()!);
int firstnumber = number / 10;
int secondnumber = number % 10;
if (firstnumber > secondnumber)
    Console.WriteLine(firstnumber);
else
    Console.WriteLine(secondnumber);

