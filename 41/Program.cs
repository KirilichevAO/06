// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int m = 5;
int[] array = new int[m];

for (int i = 0; i < m; i++)
{
    Console.Write($"Введите число № {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int PositiveNombers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count = count + 1;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
}

PrintArray(array);
Console.WriteLine($" -> {PositiveNombers(array)}");