//12. Удалить вторую цифру трёхзначного числа

int a=567;
int Digit(int a)
{
    int res=((a/100%10)*10+a%10);
    return res;
}

Console.WriteLine(Digit(a));