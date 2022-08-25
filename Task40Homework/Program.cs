// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool TriangleInequalityTheorem(int a, int b, int c) { bool check = false; if (a < b + c && b < a + c && c < a + b) { check = true; } return check; }

Console.WriteLine("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

bool res = TriangleInequalityTheorem(firstNum, secondNum, thirdNum);
Console.WriteLine($"Ответ: {res}.");


// bool TriangleInequalityTheorem2(int[] array) //Проверка ИЗ МАССИВА Теоремы о неравенстве треугольника.
// {
//     bool check = false;
//     if (array[0] < array[1] + array[2] && array[1] < array[0] + array[2] && array[2] < array[0] + array[1]) { check = true; }
//     return check;
// }

// Console.WriteLine("Введите 3 числa через пробел: "); /
// int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

// if (array.Length != 3)
// {
//     Console.WriteLine("Ошибка! Нужно ввести 3 числа!");
//     return;
// }
// bool res = TriangleInequalityTheorem2(array);
// Console.WriteLine(res);
