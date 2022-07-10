Console.WriteLine("Input number M to start: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number N to finish: ");
int N = Convert.ToInt32(Console.ReadLine());

// void SummOfNum(int M, int N) {
//     int first = M;
//     int last = N;
//     if(first > last) {
//         Console.WriteLine("Error! Element M more then element N!");
//     } else {
//         int sum = 0;
//         for(int i = first; i <= last; i++) {
//             sum = sum + i;
//         }
//         Console.WriteLine(sum);
//     }
// }
// SummOfNum(M, N);


int SummOfNum(int M, int N) {

    if(M < N) {

        M += SummOfNum(M + 1, N);
    }
    return M;
}
Console.WriteLine(SummOfNum(M, N));
SummOfNum(M, N);