void Distance (int x, int x1, int y, int y1, int z, int z1) {
    double distance = Math.Sqrt((x1 - x)*(x1 - x) + (y1 - y)*(y1 - y) + (z1 - z)*(z1 - z));
    Console.WriteLine($"Расстояние: {distance}");
}

Console.WriteLine("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Distance(x, x1, y, y1, z, z1);