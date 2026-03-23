using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classGame
{
    public class Laptops : Gadgets
    {
        public int Cores = 1;
        public bool Backlight = true; 
        public int VHardDrive = 100;

        public override String GetInfo()
        {
            var str = "Я Ноутбук)";
            str += base.GetInfo();

            str += String.Format("\nКоличество ядер: {0}", this.Cores);
            str += String.Format("\nОбъем памяти: {0}", this.VHardDrive);
            return str;
        }

        public static Laptops Generate()
        {
            return new Laptops
            {
                Cores = rnd.Next() % 20 + 1,
                Backlight = rnd.Next() % 2 == 0,
                VHardDrive = rnd.Next() % 100 + 1,
                Price = rnd.Next() %1000 + 500
            };
        }
    }

    public class Tablets : Gadgets
    {
        public int ScreenDpi = 50;
        public bool Ccamera = true;
        public string Сompany = "MAX";

        public override String GetInfo()
        {
            var str = "Я Планшет?!";
            str += base.GetInfo();

            str += String.Format("\nРазмер экрана: {0}", this.ScreenDpi);
            return str;
        }

        public static Tablets Generate()
        {
            return new Tablets
            {
                ScreenDpi = rnd.Next() % 50 + 1,
                Ccamera = rnd.Next() % 2 == 0,
                Price = rnd.Next() % 1000 + 500
            };
        }
    }

    public class Smartphones : Gadgets
    {
        public int SimCard = 1;
        public int Battery = 1;
        public int MegapixelsCamera = 100;

        public override String GetInfo()
        {
            var str = "Я Смартфон?";
            str += base.GetInfo();

            str += String.Format("\nСимкарт: {0}", this.SimCard);
            str += String.Format("\nБатарея: {0}", this.Battery);
            str += String.Format("\nМегапикселей камеры: {0}", this.MegapixelsCamera);
            return str;
        }

        public static Smartphones Generate()
        {
            return new Smartphones
            {
                SimCard = rnd.Next() % 2 + 1,
                Battery = rnd.Next() % 100 + 1,
                MegapixelsCamera = rnd.Next() % 100 + 1,
                Price = rnd.Next() % 1000 + 500
            };
        }
    }

    public class Gadgets
    {
        public static Random rnd = new Random();
        public int Price = 100;
        public virtual String GetInfo()
        {
            var str = String.Format("\nЦена: {0}", this.Price);
            return str;
        }
    }
}