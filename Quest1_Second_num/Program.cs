// int Number = new Random().Next(100,1000);
// Console.WriteLine(Number);

// int num = Number / 10 % 10;

// Console.WriteLine(num);


int Number = new Random().Next(100,1000);
Console.WriteLine(Number);

char[] arr = Number.ToString().ToArray();

Console.WriteLine(arr[1]);