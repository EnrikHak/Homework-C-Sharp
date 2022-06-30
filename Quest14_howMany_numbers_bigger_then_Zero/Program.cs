int[] FillArray() {
    
    Console.WriteLine("Введите число символов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] array = new int [n];

    for (int i = 0; i < n; i++) {
        Console.WriteLine($"Введите элемент массива {0+i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int[] arr = FillArray();

void PrintArray(int[] array) {

    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
        if (array[i] > 0) {
            count = count + 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine(count);
}
Console.WriteLine();
PrintArray(arr);