void FillArray(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i ,j] = new Random().Next(1,100);
        }
    }
}

void PrintArray(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i ,j]} ");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] arr, int it, int jt) {

    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
        if (it <= arr.GetLength(0) && jt <= arr.GetLength(1)) {
            Console.WriteLine($"Число {number} присутствует");
        } else {
            Console.WriteLine("Такого числа нет");
        }
    }

Console.WriteLine("Введите количество строк: ");
int it = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int jt = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray(int it, int jt) {
    return new int [it, jt];
}

int[,] arr = CreateArray(it, jt);

FillArray(arr);
PrintArray(arr);
FindNumber(arr, it, jt);
