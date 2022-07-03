int Fibonaci(int num) {
    if (num == 0) {
        return 0;
    }
    if (num == 1 || num == 2) {
        return 1;
    } else {
        return Fibonaci(num - 1) + Fibonaci (num - 2);
    }
}
Console.WriteLine("Введите число до которого необходимо посчитать: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < number; i++) {
        Console.Write($"{Fibonaci(i)} ");
    }
