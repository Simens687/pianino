using System.Xml;

namespace Пианино
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите октаву F5 и F6");
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                if (key.Key == ConsoleKey.F5)
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        Soundf();
                    }
                    Console.WriteLine("");
                }
                else
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        Sounds();
                    }
                    Console.WriteLine("");
                }
                /*izma();*/
                Console.WriteLine("Выберите октаву F5 и F6");
                key = Console.ReadKey();
            }
        }


        static int [] fifth_oktava()
        {
            int[] nota = new int[] { 523 /*C#*/, 554 /*C*/, 587 /*D*/, 622 /*Eb*/, 659 /*E*/, 699 /*F*/, 740 /*F#*/, 784 /*G*/, 830 /*G#*/, 880 /*A*/, 932 /*Bb*/, 989 /*B*/ };
            return nota;
        }


        static int [] sixth_oktava()
        {
            int[] nota = new int[] { 1047 /*C#*/, 1109 /*C*/, 1175 /*D*/, 1245 /*Eb*/, 1319 /*E*/, 1397 /*F*/, 1480 /*F#*/, 1568 /*G*/, 1661 /*G#*/, 1760 /*A*/, 1865 /*Bb*/, 1976 /*B*/ };
            return nota;        
        }


        /*static void izma()
        {
            Console.WriteLine("Выберите октаву F5 и F6");
            key = Console.ReadKey();
        }*/


        /*static void Klava_one()
        {

            var хуй = second_oktava();
            int Cs = хуй[0];
            int C = хуй[1];
            int D = хуй[2];
            int Eb = хуй[3];
            int E = хуй[4];
            int F = хуй[5];
            int Fs = хуй[6];
            int G = хуй[7];
            int Gs = хуй[8];
            int A = хуй[9];
            int Bb = хуй[10];
            int B = хуй[11];
        }


        static void Klava_two()
        {

            var хуй = second_oktava();
            int Cs = хуй[0];
            int C = хуй[1];
            int D = хуй[2];
            int Eb = хуй[3];
            int E = хуй[4];
            int F = хуй[5];
            int Fs = хуй[6];
            int G = хуй[7];
            int Gs = хуй[8];
            int A = хуй[9];
            int Bb = хуй[10];
            int B = хуй[11];
        }*/


        static void Soundf()
        {
            int ch = 200;
            var nota = fifth_oktava();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.E:
                    Console.Beep(nota[0], ch);
                    break;
                case ConsoleKey.D:
                    Console.Beep(nota[1], ch);
                    break;
                case ConsoleKey.F:
                    Console.Beep(nota[2], ch);
                    break;
                case ConsoleKey.T:
                    Console.Beep(nota[3], ch);
                    break;
                case ConsoleKey.G:
                    Console.Beep(nota[4], ch);
                    break;
                case ConsoleKey.Y:
                    Console.Beep(nota[5], ch);
                    break;
                case ConsoleKey.H:
                    Console.Beep(nota[6], ch);
                    break;
                case ConsoleKey.U:
                    Console.Beep(nota[7], ch);
                    break;
                case ConsoleKey.J:
                    Console.Beep(nota[8], ch);
                    break;
                case ConsoleKey.K:
                    Console.Beep(nota[9], ch);
                    break;
                case ConsoleKey.O:
                    Console.Beep(nota[10], ch);
                    break;
                case ConsoleKey.L:
                    Console.Beep(nota[11], ch);
                    break;
            }
        }


        static void Sounds()
        {
            int ch = 200;
            var nota = sixth_oktava();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.E:
                    Console.Beep(nota[0], ch);
                    break;
                case ConsoleKey.D:
                    Console.Beep(nota[1], ch);
                    break;
                case ConsoleKey.F:
                    Console.Beep(nota[2], ch);
                    break;
                case ConsoleKey.T:
                    Console.Beep(nota[3], ch);
                    break;
                case ConsoleKey.G:
                    Console.Beep(nota[4], ch);
                    break;
                case ConsoleKey.Y:
                    Console.Beep(nota[5], ch);
                    break;
                case ConsoleKey.H:
                    Console.Beep(nota[6], ch);
                    break;
                case ConsoleKey.U:
                    Console.Beep(nota[7], ch);
                    break;
                case ConsoleKey.J:
                    Console.Beep(nota[8], ch);
                    break;
                case ConsoleKey.K:
                    Console.Beep(nota[9], ch);
                    break;
                case ConsoleKey.O:
                    Console.Beep(nota[10], ch);
                    break;
                case ConsoleKey.L:
                    Console.Beep(nota[11], ch);
                    break;
            }
        }
    }
}