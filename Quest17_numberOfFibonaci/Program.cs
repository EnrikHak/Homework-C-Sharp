int Fibonaci() {
    
    Console.WriteLine("Введите число до которого нужно считать: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int a = 0;
    int b = 1;

    for (int i = 0; i < n; i++) {
        int sum = a;
        a = b;
        b = sum + b;
        Console.Write($"{b} ");
    }
    return b;
}



Fibonaci();