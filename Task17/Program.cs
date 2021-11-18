// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём

Console.WriteLine("Введите порядковый номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a>=6) Console.WriteLine("ВЫХОДНОЙ!!!");
else
{
    Console.WriteLine("НА РАБОТУ");
}