Console.WriteLine("Input number M to start: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number N to finish: ");
int N = Convert.ToInt32(Console.ReadLine());

// void AllNum(int M, int N) {
//     int first = M;
//     int last = N;
//     if (M > N) {
//         Console.WriteLine("Error! Element M more then element N");
//     } else {
//         for (int i = first; i <= last; i++) {
//             Console.Write($"{i} ");
//         }
//         Console.WriteLine();
//     }
// }
// AllNum(M, N);


int AllNum(int M, int N) {
    
    if(M <= N) {

        Console.Write("{0} ", M);
        return M = AllNum(M + 1, N);
        
    }
    return 0;
}

AllNum(M, N);