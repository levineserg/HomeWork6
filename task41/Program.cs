// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.Write("Введите длинну массива ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
FillArray(array);
Console.Write("Ваш массив: ");
Console.WriteLine(string.Join(", ", array));
int positiveNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        positiveNumbers += 1;
    }
}
Console.Write($"В этом  массиве {positiveNumbers} положительных");