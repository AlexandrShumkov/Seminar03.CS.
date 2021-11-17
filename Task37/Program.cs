//36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] arr = new int[10];
Random rnd = new Random();
int i; int count1 = 0; int count2 = 0;
for (i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 1000);
    Console.Write(arr[i] + " ");
    if (arr[i] % 2 == 0)
        count1++;
}
Console.WriteLine();
Console.WriteLine("Количество четных чисел:" + count1);

for (i = 0; i < arr.Length; i++)
{
if (arr[i] % 2 != 0)
count2++;
}

Console.WriteLine("Кол-во нечетных чисел:"+count2);