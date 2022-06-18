Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void cub (int N) {
    for (int i = 1; i <= N; i++) {
       int result = i * i * i;
       Console.WriteLine($"{result}");
    }
}

cub(N);