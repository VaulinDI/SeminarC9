// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем
void Number(int a, int b, int count, int n, int x) 
{ 
    if (count < n) 
    { 
    x = a;
    a = b;
    b = x + b;
    Console.Write(b + "  "); 
    Number(a, b, count + 1, n, x);
    
    } 
}

int a = 1;
int b = 1;
int count = 2;
int n = 10;
int x = a;
Console.Write(a + "  ");
Console.Write(b + "  ");
Number(a, b, count, n, x);
Console.WriteLine();