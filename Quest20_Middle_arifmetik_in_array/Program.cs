void FillArray(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MiddleArifm(int[,] arr, int m, int n) {

    int[] num = new int [n] ;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < n; j++)
        {
            num[j] = num[j] + arr[i, j];
        }
    }

    for (int i = 0; i < n; i++) {
        Console.WriteLine($"Среднее арифметическое {num[i]} в столбце {i}");
    }
}

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray(int m, int n) {
    return new int [m, n];
}

int[,] arr = CreateArray(m, n);

FillArray(arr);
PrintArray(arr);
MiddleArifm(arr, m, n);