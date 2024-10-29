
int [] arrayNumeros1 = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
int [] arrayNumeros2 = {02, 04, 06, 08, 10, 12, 14, 16, 18, 20};

for (int i = 0; i < arrayNumeros1.Length; i++)
{
    if (i %2 == 0)
    {
    Console.WriteLine($"{arrayNumeros1 [i]}");        
    } else {
    Console.WriteLine($"{arrayNumeros2 [i]}");
    }

    // Console.WriteLine($"{arrayNumeros2 [i]}");
    // Console.WriteLine($"{arrayNumeros1 [i]}");        
}