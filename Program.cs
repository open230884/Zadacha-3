// начинаем писать на основе ранее созданных программ

Console.WriteLine("Введите число, с которым будем работать:");

int n = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Диапазон состоит из чисел:");

for ( int i = -n; i <= n; i++)
{
       Console.WriteLine(i);
}