//15. Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите число от 1 до 1000: ");
int a = Convert.ToInt32(Console.ReadLine());
if((a%7==0)&&(a%23==0))
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Некратно");
}