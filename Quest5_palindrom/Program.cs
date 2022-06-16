Console.WriteLine("Введите 5-значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

char[] arr = number.ToString().ToCharArray();

for (int i = 0; i < arr.Length; i++) {
        if (arr[i] != arr[arr.Length - (i + 1)]) {
            Console.WriteLine($" Это чисто {number} - полиндром");
            break;
        // } else {
            // Console.WriteLine($" Это число {number} - НЕ полиндром!");
            // break;
        }
}


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