//Exemplo 01 - Mod.05-Sub-01 Und. 01 a 04
Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"{random.Next(1, 100)}");
    }

    Console.WriteLine();
}