// Запросите от пользователя размерности двумерного массива.
// Напишите метод для заполнения массива случайными числами. 
// Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво).
// Округлите значения, генерируемые Random до двух знаков после запятой.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] InputArray()
{ 
    Console.WriteLine("Введите размерность массива :");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-1000,1000)/100.00; 
        }
    }
    return array;
}

void PrintArray(double[,] array)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]} ");
        }
    Console.WriteLine();
    }
}

PrintArray(InputArray());

Console.ReadKey();
