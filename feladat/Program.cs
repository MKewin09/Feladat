Console.WriteLine("Adjon meg egy számot!");
int n = Convert.ToInt16(Console.ReadLine());
int j = 0;
int db = 0;

Console.Write("A szám osztói: ");

for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        Console.WriteLine(i);
        j += i;
        db++;
    }

}
    Console.WriteLine("Az adot szám osztoinak száma: " + db);
