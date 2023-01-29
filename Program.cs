namespace ConsoleGraphic
{
    internal class Program
    {
        static int width = System.Console.WindowWidth;
        static int height = System.Console.WindowHeight;
        static double ratioChar = 11d / 23d;
        static double ratioAspect;

        static char[] screen = new char[width * height];

        static double frame = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.CursorVisible = false;
                width = System.Console.WindowWidth;
                height = System.Console.WindowHeight;
                screen = new char[width * height];
                ratioAspect = (double)width / (double)height;
                Draw();
                frame += 0.05;
            }
            System.Console.ReadKey();
            //while (true)
            //{
            //    Console.Beep();
            //    Console.Beep(800, 200);
            //}

        }
        static void Draw()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    double x = j / (double)width * 2d - 1;
                    double y = i / (double)height * 2d - 1;
                    x *= ratioAspect * ratioChar;


                    screen[i * width + j] = ' ';

                    if (x * x + y * y < 0.5)
                        screen[i * width + j] = '@';
                }
            }
            System.Console.Write(screen);
            System.Console.SetCursorPosition(0, 0);
        }
    }
}