// 26. Возведите число А в натуральную степень B используя цикл

int a=3;int b=3;int res=1;
for(int i=1;i<=b;i++)
{
    res=res*a;
}
Console.WriteLine(res);