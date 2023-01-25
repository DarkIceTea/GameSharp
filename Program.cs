namespace ConsoleGraphic
{
    internal class Program
    {
        static int width = System.Console.WindowWidth;
        static int height = System.Console.WindowHeight;
        static float ratioChar = 11.0f / 27.0f;

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
                    int x = (int)((j - width / 2) * ratioChar);
                    int y = height / 2 - i;
                    screen[i * width + j] = ' ';
                    if ((Math.Pow(x - (Math.Cos(frame) * 50.0), 2) + (Math.Pow(y - (Math.Sin(frame) * 50.0), 2))) <= 100) screen[i * width + j] = '@';
                }
            }
            System.Console.Write(screen);
            System.Console.SetCursorPosition(0, 0);
        }
    }
}