Console.WriteLine("Input number M to start: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number N to finish: ");
int N = Convert.ToInt32(Console.ReadLine());

int FunctionAkkerman(int M, int N) {

    if(M == 0) {
        return N + 1;
    }
    if(M > 0 && N == 0) {
        return FunctionAkkerman(M - 1, 1);
    }
    if(M > 0 && N > 0) {
        return FunctionAkkerman(M - 1,FunctionAkkerman(M, N - 1));
    }
    return 0;
}
int result = FunctionAkkerman(M, N);
Console.WriteLine(result);
FunctionAkkerman(M, N);