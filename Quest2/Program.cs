Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число C: ");
int C = Convert.ToInt32(Console.ReadLine());

int max = A;

if (A < B) {
    Console.WriteLine($"max = {B}");
} else if (A < C) {
    Console.WriteLine($"max = {C}");
} else if (B < A) {
    Console.WriteLine($"max = {A}");
} else if (B < C) {
    Console.WriteLine($"max = {C}");
} else if (C < A) {
    Console.WriteLine($"max = {A}");
} else if (C < B) {
    Console.WriteLine($"max = {B}");
}