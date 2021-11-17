//34. Написать программу замену элементов массива на противоположные

int[] arr=new int[10];
Random rnd=new Random();
int i;
for(i=0;i<arr.Length;i++)
{
arr[i]=rnd.Next(1,100);
}
for(i=0;i<arr.Length;i++)
Console.Write(arr[i]+" ");
Console.WriteLine();
for(i=0;i<arr.Length;i++)
Console.Write(-arr[i]+" ");