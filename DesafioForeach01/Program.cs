int[] num = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

Console.WriteLine($"Sua cont possui {num.Length} números: ");

foreach(int n in num)
{
    Console.Write($"{n*2}, ");
}