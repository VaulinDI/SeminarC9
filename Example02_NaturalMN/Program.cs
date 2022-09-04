// Показать натуральные числа от M до N, N и M заданы
void Number(int m, int n) 
{ 
    if (m <= n) 
    { 
    Console.Write(m + "  "); 
    Number(m + 1, n); 
    } 
}

int m = 3;
int n = 9;
Number(m, n);
Console.WriteLine();