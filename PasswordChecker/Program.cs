Console.WriteLine("Проверка надёжности пароля"); 

Console.Write("Введите пароль: ");
string password = Console.ReadLine();

Console.WriteLine();

bool isValid = IsPasswordValid(password);
if (isValid){
    Console.WriteLine("Пароль подходит");
} else {
    Console.WriteLine("Пароль не подходит");
}

Console.WriteLine();
Console.WriteLine(">>> Результаты проверки <<<");
Console.WriteLine($"Длина не менее 8 символов: {HasMinLength(password, 8)}");
Console.WriteLine($"Содержит хотя бы одну цифру: {HasDigit(password)}");
Console.WriteLine($"Содержит хотя бы одну заглавную букву: {HasUpperCase(password)}");






bool HasMinLength(string password, int minLength){
    if (password.Length >= minLength){
        return true;
    } 
    return false;
}

bool HasDigit(string password){
    foreach (char letter in password){
        if (char.IsDigit(letter)){
            return true;
        }
    } 
    return false;
} 

bool HasUpperCase(string password) {
    foreach (char letter in password){
        if (char.IsUpper(letter)){
            return true;
        }
    } 
    return false;
} 

bool IsPasswordValid(string password){
    bool Length = HasMinLength(password, 8);
    bool num = HasDigit(password);
    bool upper = HasUpperCase(password);
    return  Length && num && upper;
}