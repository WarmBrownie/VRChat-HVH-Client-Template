using System;

namespace HVH.API
{
    public static class HVHLogger
    {
        public static void Init()
        {
            Console.Title = "HVH by Shino & Trash";
            //Console.Clear();
        }

        public static void Log(object message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("] [");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("HVH");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("] ");
            Console.WriteLine(message);
        }

        public static void Log(ConsoleColor color, object message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("] [");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("HVH");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("] ");
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
