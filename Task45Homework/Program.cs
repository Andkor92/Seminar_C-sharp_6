//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CopyArray(int[] array) //Копия заданного массива с помощью поэлементного копирования.
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++) { newArray[i] = array[i]; }
    return newArray;
}

Console.WriteLine("Введите числa через пробел: ");
int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] newArray = CopyArray(array);
Console.WriteLine(string.Join(", ", newArray));
