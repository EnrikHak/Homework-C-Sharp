
// ЗАДАЧА 58


int[,] CreateMatrix(int m, int n) {
    return new int [m, n];
}

void FillMatrix(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintMatrix(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ProizArray(int[,] matrix1, int[,] matrix2, int[,] matrix3) {

    for (int i = 0; i < matrix1.GetLength(0); i++ ) {
        for (int j = 0; j < matrix2.GetLength(1); j++) {
            for (int p = 0; p < matrix3.GetLength(1); p++) {
                matrix3[i, j] = matrix1[i, p] * matrix2[p, j];
            }
        }
    }
    return matrix3;
}

Console.WriteLine("Введите количество строк первой матрицы: ");
int str1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int stlb1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк второй матрицы: ");
int str2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int stlb2 = Convert.ToInt32(Console.ReadLine());

if (str1 != stlb2) {
    Console.WriteLine("Error!!!");
} else {
    int[,] arr1 = CreateMatrix(str1, stlb1);
    FillMatrix(arr1);
    PrintMatrix(arr1);
    Console.WriteLine();

    int[,] arr2 = CreateMatrix(str2, stlb2);
    FillMatrix(arr2);
    PrintMatrix(arr2);
    Console.WriteLine();

    int[,] arr3 = CreateMatrix(str1, stlb2);
    PrintMatrix(ProizArray(arr1, arr2, arr3));
}