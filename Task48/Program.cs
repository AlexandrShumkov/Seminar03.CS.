// 47. Написать программу копирования массива

int[] arr = new int[10];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 10);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

int[] arr1=new int[10];
for (int i = 0; i < arr.Length; i++)

    {
        arr1[i] = arr[i];
        Console.Write(arr1[i]+" ");
    }



