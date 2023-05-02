using System.Random
int[] mas = new int[10];
Random r = new Random();
for (int b = 0; b < mas.Length; b++)
{
    mas[b] = r.Next(20);
    Console.WriteLine(mas[b]);
}
