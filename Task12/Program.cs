//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа


Console.WriteLine("Напишите число от 10 до 99: ");
int a = Convert.ToInt32(Console.ReadLine());
int b=a%10; int c=a/10;
if ( b>c)
{
    Console.WriteLine("Наибольшая цифра: "+b);
}
else
    Console.WriteLine("Наибольшая цифра: "+c);


