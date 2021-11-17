//35. Определить, присутствует ли в заданном массиве, некоторое число

int[] arr = new int[100];
Console.WriteLine("Введите число от 1 до 100: ");
Random rnd = new Random();
int i;
//Console.ReadLine("Введите число от 1 до 100: ");
int a = Convert.ToInt32(Console.ReadLine());

for (i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 101);
    if (arr[i] == a)
    {
        Console.WriteLine("Число присутствует" + " " + a);
        break;
    }
}
if(i==arr.Length)
Console.WriteLine("Число не найдено");







