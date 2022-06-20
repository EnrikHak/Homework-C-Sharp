Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

void stepen (int A, int B) {
    int result = 1;
    for (int i = 1; i <= B; i++) {
        result = result * A;
    }    
    Console.WriteLine($"{result}");
}

stepen(A, B);


//               ВАРИАНТ 2

// Console.WriteLine("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// void stepen (int A, int B) {
//     double result = Math.Pow(A,B);
//     Console.WriteLine($"{result}");
// }

// stepen(A, B);