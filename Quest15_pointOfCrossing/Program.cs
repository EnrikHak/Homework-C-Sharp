// y = k1 * x + b1;
// y = k2 * x + b2

void PointOfCrossing (double b1, double k1, double b2, double k2) {
    
    if (k1 * b2 != k2 * b1) {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k2 * x) + b2;
        Console.WriteLine($"Точка пересечения: X = {x}; Y = {y}");
    } else {
        Console.WriteLine("Линии параллельны");
    }
}

Console.WriteLine("Введите координату k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координату k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

PointOfCrossing(k1, b1, k2, b2);