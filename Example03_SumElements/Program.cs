// Найти сумму элементов от M до N, N и M заданы
int sum = 0;
int Number(int m, int n) 
{
    if (m <= n) 
    { 
        sum = sum + m;
        Number(m + 1, n); 
    } 
return sum;
}

int m = 1;
int n = 5;
Console.WriteLine(Number(m, n));