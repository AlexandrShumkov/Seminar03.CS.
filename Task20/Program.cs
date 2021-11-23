// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

void FindQuater(int x, int y)
{
    if ((x > 0) && (y > 0)) Console.WriteLine("1я четверть");
    if ((x < 0) && (y > 0)) Console.WriteLine("2я четверть");
    if ((x < 0) && (y < 0)) Console.WriteLine("3я четверть");
    if ((x > 0) && (y < 0)) Console.WriteLine("4я четверть");
}
FindQuater(4,3);