// Запросите от пользователя размерности двумерного массива.
// Напишите метод для заполнения массива случайными числами. 
// Напишите метод для поиска ср. арифметического значения каждого столбца.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] InputArray()
{ 
    Console.WriteLine("Введите размерность массива :");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10); 
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

void FindArithmetic(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i,j]; 
        }
        Console.Write($" {average / array.GetLength(0)} ");
    }   
}

FindArithmetic(InputArray());
Console.ReadKey();