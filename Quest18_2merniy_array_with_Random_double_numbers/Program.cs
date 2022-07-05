void FillArray(double[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = (new Random().NextDouble()) * (new Random().Next(-10,10));
        }
    }
}

void PrintArray(double[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{Math.Round(array[i, j], 2)} ");
        }
        Console.WriteLine();
    }
}

double[,] CreateArray(int m, int n) {
    return new double [m, n];
}

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = CreateArray(m, n);

FillArray(arr);
PrintArray(arr);