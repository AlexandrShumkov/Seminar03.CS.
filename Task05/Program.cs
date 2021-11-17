// 4. Найти максимальное из трех чисел

int a=22; int b=33; int c=44;
int max=a;

if(a<b) max=b;
if(max<c) max=c;

Console.WriteLine(max);