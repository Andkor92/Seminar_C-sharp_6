// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int[] RemaindersFromDividingValueBy2(int value) //Массив из остатков от деления значения на 2. ВАРИАНТ 1
{
    int valueLenght = (int)Math.Log2(value) + 1; int[] array = new int[valueLenght]; int i;
    for (i = 0; value > 1; i++) { array[i] = value % 2; value /= 2; }
    array[i] = 1; return array;
}
void ArrayReversal(int[] array) //Разворот массива.
{
    for (int i = 0; i < array.Length / 2; i++) { int temp = array[i]; array[i] = array[array.Length - 1 - i]; array[array.Length - 1 - i] = temp; }
}

Console.WriteLine("Введите десятичное число: ");
int value = Convert.ToInt32(Console.ReadLine());
int[] array = RemaindersFromDividingValueBy2(value);
ArrayReversal(array);
int reverseValue = Int32.Parse(string.Join("", array));
Console.WriteLine("Ответ: Число " + value + " в двоичной системе равно " + reverseValue + ".");



int DecimalToBinary(int v) { if (v == 0 || v == 1) return v % 2; return DecimalToBinary(v / 2) * 10 + v % 2; } // ВАРИАНТ 2

Console.WriteLine("Введите десятичное число: ");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ответ: Число {value} в двоичной системе равно {DecimalToBinary(value)}.");
