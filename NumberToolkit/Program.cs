using System.Globalization;

Console.Write("Введите первое число: ");
int a = GetNumber();
Console.Write("Введите второе число: ");
int b = GetNumber();
Console.Write("Введите третье число: ");
int c = GetNumber();

PrintSeparator();

Console.WriteLine($"{a} простое: {IsPrime(a)}");
Console.WriteLine($"{b} простое: {IsPrime(b)}");
Console.WriteLine($"{c} простое: {IsPrime(c)}");

PrintSeparator();

int Max3 = FindMax(a, b, c);
int Max2 = FindMax2(a, b);

Console.WriteLine($"Максимум из трёх: {Max3}");
Console.WriteLine($"Максимум из двух: {Max2}");

PrintSeparator();

Console.WriteLine($"Среднее арифметическое: {CalculateAverage(a, b, c):F2}");

int GetNumber() {
    int number;
    while(! int.TryParse(Console.ReadLine(), out number)){
        Console.Write("Ошибка. Введите целое число: ");
    } 
    return number;
}

void PrintSeparator(){
    Console.WriteLine();
}    

bool IsPrime(int number){
    if (number < 2){
        return false;
    } 
    for (int i = 2; i < number; i++){
        if (number % i == 0){
            return false;
        }
    } 
    return true;
} 

int FindMax(int a, int b, int c){
    int max = a;
    if (b > max){
        max = b;
    } 
    if (c > max){
        max = c;
    } 
    return max; 
} 

int FindMax2(int a, int b){
    if (a > b){
        return a;
    } 
    return b;
}

double CalculateAverage(int a, int b, int c){
    return (a + b + c) / 3.0;
}