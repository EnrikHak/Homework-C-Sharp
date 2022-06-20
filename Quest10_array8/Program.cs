void Massiv(int[] arr) {
    
    for (int i = 0; i < arr.Length; i++) {
        Console.WriteLine("Введите элемент");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PushArray(int[] arr){
     for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]}");
    }
}

int[] nums = new int[8];

Massiv(nums);
PushArray(nums);