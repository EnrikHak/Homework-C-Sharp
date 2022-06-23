int[] FillArray() {

    int[] array = new int [10];
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(99,1000);
    }
    return array;
}

int[] arr = FillArray();

void PrintArray(int[] array) {
    
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void EvenNamber(int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            count = count + 1;
        }
    }
    Console.Write(count);
}

PrintArray(arr);
EvenNamber(arr);
Console.WriteLine();