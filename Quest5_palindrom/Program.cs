Console.WriteLine("Введите 5-значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

char[] arr = number.ToString().ToCharArray();

        if (arr[0] == arr[4] && arr[1] == arr[3]) {
            Console.WriteLine($"Это число {number} - Полиндром!");
        } else {
            Console.WriteLine($"Это число {number} - НЕ полиндром!");
        }

//                 ВАРИАНТ 2

// Console.WriteLine("Введите 5-значное число: ");
// int number = Convert.ToInt32(Console.ReadLine());


// char[] arr = number.ToString().ToCharArray();
// Array.Reverse(arr);
// string s = new String(arr);
// int num = Convert.ToInt32(s);

// if (number == num) {
//     Console.WriteLine("Это число Полиндром!");
// } else {
//     Console.WriteLine("Это число НЕ Полиндром!");
// }