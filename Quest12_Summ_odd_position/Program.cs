int[] FillArray() {

    int[] array = new int [12];
    for (int i = 0; i < array.Length; i++) { 
        array[i] = new Random().Next(-99,100);
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

void SummOdd(int[] array) {

    int summ = 0;
    for (int i = 0; i < array.Length; i++) {
        if (i % 2 == 1) {
            summ = summ + array[i];
        }
    }
    Console.WriteLine(summ);
}

PrintArray(arr);
SummOdd(arr);
Console.WriteLine();