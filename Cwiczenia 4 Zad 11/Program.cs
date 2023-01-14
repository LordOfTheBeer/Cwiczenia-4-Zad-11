namespace Cwiczenia_4_Zad_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3;
            double y1, y2, y3;
                x1 = -1;
            do
            {
                x2 = x1 + 0.05;
                x3 = x2 + 0.05;
                
                y1 = x1 * x1 * x1 - 5 * x1 * x1 + 3 * x1 + 3;
                y2 = x2 * x2 * x2 - 5 * x2 * x2 + 3 * x2 + 3;
                y3 = x3 * x3 * x3 - 5 * x3 * x3 + 3 * x3 + 3;

                x1 = x1 + 0.05;

            } while (y1 < y2 & y2 < y3);
            Console.WriteLine("x= " + x2 + " y= " + y2);
        }
    }
}