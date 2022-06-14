// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// char[] Array = num.ToString().ToCharArray();

// for (int i = 0; i < Array.Length; i++) {

//     if (Array.Length >= i) {
//         Console.WriteLine(Array[2]);
//         break;
//     } else if (Array.Length < i) {
//         Console.WriteLine("Третьей цифры нет");
//     };
// }



Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num <= 999) {
    Console.WriteLine(num % 10);
} else if (num > 999 && num <= 9999) {
    Console.WriteLine(num / 10 % 10);
} else if (num > 9999 && num <= 99999) {  // и так далее...
    Console.WriteLine(num / 100 % 10);    // деление каждый раз увеличивается в 10 раз
} else {
    Console.WriteLine("Нет третьего числа");
}