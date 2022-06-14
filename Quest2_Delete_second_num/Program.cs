int Number = new Random().Next(100,1000);
Console.WriteLine(Number);

char[] arr = Number.ToString().ToCharArray();


Console.Write(arr[0]);
Console.Write(arr[2]);