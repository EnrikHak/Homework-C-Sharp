Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int max = A;

if (A < B) {
    Console.WriteLine($"max = {B}");
} else {
    Console.WriteLine($"max = {A}");
}