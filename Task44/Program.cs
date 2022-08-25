// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] Fibonachi = new int[N];
Fibonachi[0] = 0;
Fibonachi[1] = 1;
for (int i = 2; i < N; i++)
{
    Fibonachi[i] = Fibonachi[i - 1] + Fibonachi[i - 2];
}
Console.WriteLine(string.Join(" ", Fibonachi));
