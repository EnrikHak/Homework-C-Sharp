Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void sum (int number) {
    int num = 0;
    while (number > 0) {
        num = num + number % 10;
        number = number / 10;
    }
    Console.WriteLine(num);
}

sum(number);


//             НЕ понимаю...логика не верна

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// char[] arr = number.ToString().ToArray();

// void sumChisel (int number) {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++) {
//         sum = sum + arr[i];
//         Console.WriteLine($"{sum}");
//     }
// }

// sumChisel(number);