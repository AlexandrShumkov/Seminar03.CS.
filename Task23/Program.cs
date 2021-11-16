//22. Найти расстояние между точками в пространстве 2D/3D

double Distance2D(double x1,double y1,double x2,double y2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
}

Console.WriteLine(Distance2D(1,1,3,4));