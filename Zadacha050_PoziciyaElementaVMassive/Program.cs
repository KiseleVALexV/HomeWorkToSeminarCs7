// Напишите программу, которая будет принимать от пользователя позицию (M, N)
// двумерного массива и возвращать значение элемента, 
// стоящего в этой позиции. Если такой позиции в массиве нет, 
// то сообщить об этом пользователю. Сгенерировать массив случайным образом.
// Размерность массива определить самостоятельно. 
// Использование методов для заполнения массива обязательно.
// Остальное можно реализовать в главной программе.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// M = 1, N = 7 -> В массиве отсутствует элемент в такой позиции

int[,] InputArray()
{ 
    int m = 5;
    int n = 6;
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

void SearchIndex(int[,] arrays, int M, int N)
{
    if (M < arrays.GetLength(0) && N < arrays.GetLength(1))
    {
        Console.WriteLine($"В позиции [{M},{N}] находится элемент : {arrays[M,N]}");
    }
    else
    {
        Console.WriteLine("В массиве отсутствует элемент в такой позиции :");
    }
}

Console.WriteLine("Введите индексы элемента массива :");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
SearchIndex(InputArray(), m, n);

Console.ReadKey();
