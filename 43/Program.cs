// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] coff = new double[2, 2];
double[] x = new double[2];

void InputCoefficients()
{
    for (int i = 0; i < coff.GetLength(0); i++)
    {
        Console.WriteLine($"Введите значения {i + 1}-го уравнения!");

        for (int j = 0; j < coff.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"k: ");
            else Console.Write($"b: ");
            coff[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Decision(double[,] cof)
{
    x[0] = (cof[1, 1] - cof[0, 1]) / (cof[0, 0] - cof[1, 0]);
    x[1] = x[0] * cof[0, 0] + cof[0, 1];
    return x;
}

InputCoefficients();



if (coff[0, 0] == coff[1, 0] && coff[0, 1] == coff[1, 1]) Console.WriteLine("Пересечения линий нет!!!");

else
{
    Decision(coff);
    Console.WriteLine($"Точка пересечения прямых: ({x[0]}, {x[1]})");
}