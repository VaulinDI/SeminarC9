// Показать натуральные числа от N до 1, N задано
void Number(int n) 
{ 
    if (1 <= n) 
    { 
    Console.Write(n + "  "); 
    Number(n-1); 
    } 
}

int n = 5;
Number(n);
Console.WriteLine();