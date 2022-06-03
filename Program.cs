using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;

namespace ConsoleApp1_С_sharp_Events_
{
    public class KeyListener
    {
        public delegate void KeyDelegate();
        public event KeyDelegate KeyPress;
       
        public void Listen()
        {
            Piano piano = new Piano();
            Drums drums = new Drums();
            Skripka skripka = new Skripka();
            while (true)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("Chose your instrument:");
                Console.WriteLine("1 - piano");
                Console.WriteLine("2 - drums");
                Console.WriteLine("3 - skripka");
                Console.WriteLine("Esc - to leave the programm");
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.D1)
                {
                    KeyPress = null;
                    KeyPress += piano.PlayThePiano;
                }
                if (key.Key == ConsoleKey.D2)
                {
                    KeyPress = null;
                    KeyPress += drums.PlayDrums;
                }
                if (key.Key == ConsoleKey.D3)
                {
                    KeyPress = null;
                    KeyPress += skripka.PlaySkripka;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Have a good day!");
                    break;
                }
                KeyPress.Invoke();
            }
        }
    }

    class Piano
    {
        private string path = @"C:\Users\Admin\source\repos\ConsoleApp1(С_sharp_Events)\music_piano\";
        private SoundPlayer sound;
       
        public void PlayThePiano()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Press from A - K (second level of keyboard) to chose melody");
            Console.WriteLine("Esc - to leave the piano");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.A) { sound = new SoundPlayer(path + "do.wav"); Console.Write("до "); }
                if (key.Key == ConsoleKey.S) { sound = new SoundPlayer(path + "re.wav"); Console.Write("ре "); }
                if (key.Key == ConsoleKey.D) { sound = new SoundPlayer(path + "mi.wav"); Console.Write("ми "); }
                if (key.Key == ConsoleKey.F) { sound = new SoundPlayer(path + "fa.wav"); Console.Write("фа "); }
                if (key.Key == ConsoleKey.G) { sound = new SoundPlayer(path + "sol.wav"); Console.Write("соль "); }
                if (key.Key == ConsoleKey.H) { sound = new SoundPlayer(path + "lya.wav"); Console.Write("ля "); }
                if (key.Key == ConsoleKey.J) { sound = new SoundPlayer(path + "si.wav"); Console.Write("си "); }
                if (key.Key == ConsoleKey.K) { sound = new SoundPlayer(path + "do2.wav"); Console.Write("до+ "); }
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Good bye");
                    break;
                }
                sound.Play();
            }
        }
    }

    class Drums
    {
        private string path = @"C:\Users\Admin\source\repos\ConsoleApp1(С_sharp_Events)\drums\";
        private SoundPlayer sound;

        public void PlayDrums()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Press from Q - P (first level of keyboard) to chose metal plates");
            Console.WriteLine("Press from A - L (second level of keyboard) to chose drumMix");
            Console.WriteLine("Press from Z - M (third level of keyboar) to chose solo drum");
            Console.WriteLine("Esc - to leave the drum");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Q) { sound = new SoundPlayer(path + "metal_plate_1.wav"); }
                if (key.Key == ConsoleKey.W) { sound = new SoundPlayer(path + "metal_plate_2.wav"); }
                if (key.Key == ConsoleKey.E) { sound = new SoundPlayer(path + "metal_plate_3.wav"); }
                if (key.Key == ConsoleKey.R) { sound = new SoundPlayer(path + "metal_plate_4.wav"); }
                if (key.Key == ConsoleKey.T) { sound = new SoundPlayer(path + "metal_plate_5.wav"); }
                if (key.Key == ConsoleKey.Y) { sound = new SoundPlayer(path + "metal_plate_6.wav"); }
                if (key.Key == ConsoleKey.U) { sound = new SoundPlayer(path + "metal_plate_7.wav"); }
                if (key.Key == ConsoleKey.I) { sound = new SoundPlayer(path + "metal_plate_8.wav"); }
                if (key.Key == ConsoleKey.O) { sound = new SoundPlayer(path + "metal_plate_9.wav"); }
                if (key.Key == ConsoleKey.P) { sound = new SoundPlayer(path + "metal_plate_10.wav"); }
                if (key.Key == ConsoleKey.A) { sound = new SoundPlayer(path + "drums_1.wav"); }
                if (key.Key == ConsoleKey.S) { sound = new SoundPlayer(path + "drums_2.wav"); }
                if (key.Key == ConsoleKey.D) { sound = new SoundPlayer(path + "drums_3.wav"); }
                if (key.Key == ConsoleKey.F) { sound = new SoundPlayer(path + "drums_4.wav"); }
                if (key.Key == ConsoleKey.G) { sound = new SoundPlayer(path + "drums_5.wav"); }
                if (key.Key == ConsoleKey.H) { sound = new SoundPlayer(path + "drums_6.wav"); }
                if (key.Key == ConsoleKey.J) { sound = new SoundPlayer(path + "drums_7.wav"); }
                if (key.Key == ConsoleKey.K) { sound = new SoundPlayer(path + "drums_8.wav"); }
                if (key.Key == ConsoleKey.L) { sound = new SoundPlayer(path + "drums_9.wav"); }
                if (key.Key == ConsoleKey.Z) { sound = new SoundPlayer(path + "solo_1.wav"); }
                if (key.Key == ConsoleKey.X) { sound = new SoundPlayer(path + "solo_2.wav"); }
                if (key.Key == ConsoleKey.C) { sound = new SoundPlayer(path + "solo_3.wav"); }
                if (key.Key == ConsoleKey.V) { sound = new SoundPlayer(path + "solo_4.wav"); }
                if (key.Key == ConsoleKey.B) { sound = new SoundPlayer(path + "solo_5.wav"); }
                if (key.Key == ConsoleKey.N) { sound = new SoundPlayer(path + "solo_6.wav"); }
                if (key.Key == ConsoleKey.M) { sound = new SoundPlayer(path + "solo_7.wav"); }
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Good bye");
                    break;
                }
                sound.Play();
            }
        }
    }

    class Skripka
    {
        private string path = @"C:\Users\Admin\source\repos\ConsoleApp1(С_sharp_Events)\skripka\";
        private SoundPlayer sound;

        public void PlaySkripka()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Press from Q - U (first level of keyboard) to chose first octave");
            Console.WriteLine("Press from A - J (second level of keyboard) to chose second octave");
            Console.WriteLine("Press from Z - M (third level of keyboar) to chose third octave");
            Console.WriteLine("Esc - to leave the scripka");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Q) { sound = new SoundPlayer(path + "sk_do_1.wav"); }
                if (key.Key == ConsoleKey.A) { sound = new SoundPlayer(path + "sk_do_2.wav"); }
                if (key.Key == ConsoleKey.Z) { sound = new SoundPlayer(path + "sk_do_3.wav"); }
                if (key.Key == ConsoleKey.W) { sound = new SoundPlayer(path + "sk_re_1.wav"); }
                if (key.Key == ConsoleKey.S) { sound = new SoundPlayer(path + "sk_re_2.wav"); }
                if (key.Key == ConsoleKey.X) { sound = new SoundPlayer(path + "sk_re_3.wav"); }
                if (key.Key == ConsoleKey.E) { sound = new SoundPlayer(path + "sk_mi_1.wav"); }
                if (key.Key == ConsoleKey.D) { sound = new SoundPlayer(path + "sk_mi_2.wav"); }
                if (key.Key == ConsoleKey.C) { sound = new SoundPlayer(path + "sk_mi_3.wav"); }
                if (key.Key == ConsoleKey.R) { sound = new SoundPlayer(path + "sk_fa_1.wav"); }
                if (key.Key == ConsoleKey.F) { sound = new SoundPlayer(path + "sk_fa_2.wav"); }
                if (key.Key == ConsoleKey.V) { sound = new SoundPlayer(path + "sk_fa_3.wav"); }
                if (key.Key == ConsoleKey.T) { sound = new SoundPlayer(path + "sk_sol_1.wav"); }
                if (key.Key == ConsoleKey.G) { sound = new SoundPlayer(path + "sk_sol_2.wav"); }
                if (key.Key == ConsoleKey.B) { sound = new SoundPlayer(path + "sk_sol_3.wav"); }
                if (key.Key == ConsoleKey.Y) { sound = new SoundPlayer(path + "sk_lya_1.wav"); }
                if (key.Key == ConsoleKey.H) { sound = new SoundPlayer(path + "sk_lya_2.wav"); }
                if (key.Key == ConsoleKey.N) { sound = new SoundPlayer(path + "sk_lya_3.wav"); }
                if (key.Key == ConsoleKey.U) { sound = new SoundPlayer(path + "sk_si_1.wav"); }
                if (key.Key == ConsoleKey.J) { sound = new SoundPlayer(path + "sk_si_2.wav"); }
                if (key.Key == ConsoleKey.M) { sound = new SoundPlayer(path + "sk_si_3.wav"); }
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Good bye");
                    break;
                }
                sound.Play();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KeyListener listener = new KeyListener();
            listener.Listen();
        }
    }
}
