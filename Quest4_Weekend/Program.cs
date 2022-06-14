Console.WriteLine("Введите цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 5) {
    Console.WriteLine("NO! It's working day");
} else if (number > 7) {
    Console.WriteLine("Error!!!");
} else {
    Console.WriteLine("Yes!!! Weekend!");
}