//37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] arr = new int[123];
Random rnd = new Random();

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 124);
    }
}

void PrintArray(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        Console.Write(arr[i]+" ");
    }
    Console.WriteLine();
}

void CountDigit(int[] arr,int count)
{
     count=0;
    for(int i=10;i<=99;i++)
    {
        count++;
    }
        Console.WriteLine($"{count} чисел в отрезке.");
}

int count=0;
FillArray(arr);
PrintArray(arr);
Console.ReadKey();
CountDigit(arr,count);