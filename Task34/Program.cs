//33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] arr = new int[12];
Random rnd = new Random();
int sum1 = 0; int sum2 = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 10);
}
for (int i = 0; i < arr.Length; i++)
    Console.Write($"{arr[i]} ");
Console.WriteLine();


for (int i = 0; i < arr.Length; i++)
{
    if(i>0)
    {
        sum1=sum1+i;
    }
    else
    {
    sum2=sum2+i;
    }
    Console.WriteLine("Сумма полож.чисел: "+sum1);
    Console.WriteLine("Сумма отриц.чисел: "+sum2);
}
