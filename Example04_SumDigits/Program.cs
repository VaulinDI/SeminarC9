// Найти сумму цифр числа
int sum = 0;
int Number(int n) 
{
    if (n != 0) 
    { 
        sum = sum + n % 10;
        Number(n / 10); 
    } 
return sum;
}

int n = 10340;
Console.WriteLine(Number(n));