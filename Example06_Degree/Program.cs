// Написать программу возведения числа А в целую стень B
int result = 1;
int Number(int n, int m, int x) 
{
    if (x <= m) 
    { 
        result = result * n;
        Number(n, m, x + 1); 
    } 
return result;
}

int n = 10;
int m = 3;
int x = 1;
Console.WriteLine(Number(n, m, x));