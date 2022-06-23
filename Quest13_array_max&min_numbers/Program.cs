double[] FillArray() {

    double[] array = new double [10];
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(-99,100) + new Random().NextDouble();
    }
    return array;
}

double[] arr = FillArray();

void PrintArray(double[] array) {

    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void MaxMinElement(double[] array) {

    double Max = array[0];
    double Min = array[0];
    double result = 0;

    for (int i = 0; i < array.Length; i++) {
        if (Min > array[i]) {
            Min = array[i];
        }
        if (Max < array[i]) {
            Max = array[i];
        }
    }
    Console.WriteLine($"Max number {Max} ");
    Console.WriteLine($"Min number {Min} ");
    result = Max - Min;
    Console.WriteLine($"Difficult between Max & Min - {result}");
}

PrintArray(arr);
MaxMinElement(arr);
Console.WriteLine();