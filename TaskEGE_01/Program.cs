//Условие задачи в конспекте.Нашли только числа имеющие 4 делителя,кроме 1 и самого числа
int CountDiv(int n)
{
    int k = 0;
    for (int i = 2; i < n; i++)
        if (n % i == 0) k++;
    return k;
}
for(int i=210235;i<=210300;i++)
if(CountDiv(i)==4)
{
    Console.WriteLine(i);
}