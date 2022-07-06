
// ЗАДАЧА 56

void FillArray(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = new Random().Next(1,10);
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

void MinSum(int[,] arr) {

    int sum = 0;
    int minstr = 0;
    int stringNumber = 0;
    
    for (int i = 0; i < 1; i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            sum = sum + arr[i, j];
        }
    }
    for (int i = 1; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            minstr = minstr + arr[i , j];
        }
        if (minstr < sum) {
            sum = minstr;
            stringNumber = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма {sum}");
    Console.WriteLine($"Строка с наименьшей суммой: {stringNumber}");
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
MinSum(arr);