using System;

namespace ColorSpheres
{
    class Program
    {
        static void Main()
        {
            Color yellow = new Color(255,255,0);
            Color pink = new Color(255,0,255,100);

            Sphere ball1 = new Sphere(yellow,10);
            Sphere ball2 = new Sphere(pink,15);

            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    ball1.Throw();
                }
                else
                {
                    ball2.Throw();
                }
            }
            Console.WriteLine($"Ball1 throws: {ball1.GetTimesThrown()}");
            Console.WriteLine($"Ball2 throws: {ball2.GetTimesThrown()}");
            ball2.Pop();
            ball1.Throw();
            ball2.Throw();
            Console.WriteLine($"Ball1 throws: {ball1.GetTimesThrown()}");
            Console.WriteLine($"Ball2 throws: {ball2.GetTimesThrown()}");

            Sphere[] balls = new Sphere[2] {ball1,ball2};

            for (int i = 0; i < 2; i ++)
            {
                byte r = balls[i].GetColor().GetRed();
                byte g = balls[i].GetColor().GetGreen();
                byte b = balls[i].GetColor().GetBlue();
                byte a = balls[i].GetColor().GetAlpha();

                Console.WriteLine($"Ball{i + 1} color: ({r}, {g}, {b}, {a})");
            }

        }
    }
}
