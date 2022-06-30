Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NumberFrom10To2(int number) {

    int arrayLastN = 0;
    int num = number;

    while (num != 0) {

        num = num / 2;
        arrayLastN++;       
    }

    int[] array = new int [arrayLastN];

    for (int i = array.Length - 1; i >= 0; i--) {
        
        array[i] = number % 2;
        number = number / 2;
        
    }   
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]}");
    }    
    Console.WriteLine();
}

NumberFrom10To2(number);