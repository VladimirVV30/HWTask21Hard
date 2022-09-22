// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

double Distance(int[] Dot1, int[] Dot2, int n)
{
    int sumDots = 0;
    for (int i = 0; i < n; i++)
    {
        sumDots = sumDots + (Dot2[i] - Dot1[i]) * (Dot2[i] - Dot1[i]);
    }
    double res = Math.Sqrt(sumDots);
    return res;
}
try
{
    Console.WriteLine("Введите размерность пространства N ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n <= 0) Console.WriteLine("Нужно целое число больше 0");
    else
    {
        int[] Dot1 = new int[n];
        int[] Dot2 = new int[n];
        int i = 0;

        Console.WriteLine("Введите координаты первой точки");
        while (i < n)
        {
            Dot1[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }
        i = 0;
        Console.WriteLine("Введите координаты второй точки");
        while (i < n)
        {
            Dot2[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }

        Console.WriteLine($"Расстояние между точками = {Distance(Dot1, Dot2, n)}");
    }    
}
catch
{
    Console.WriteLine("Надо было вводить именно целые числа"); 
}