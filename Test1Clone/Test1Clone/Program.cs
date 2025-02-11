int[] rand = new int[10];
Random rnd = new Random();
int sum = 0;
for (int i = 0; i < rand.Length; i++)
{
    rand[i] = rnd.Next(-10, 10);
    Console.WriteLine($"Massive so vsemi indeksami {i}: {rand[i]}");
}
Console.WriteLine("");
for (int i = 0; i < rand.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"Parniy indeks {i}: {rand[i]}");
        sum += rand[i];
    }
}
if (sum > 0)
{
    Console.WriteLine($"summa: {sum}");
}
else
{
    Console.WriteLine($"Summa otricatelna: {sum}");
}