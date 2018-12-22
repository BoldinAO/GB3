using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Drob dr1 = new Drob();
            Drob dr2 = new Drob();
            Console.Write("Введите числитель 1 дроби: ");
            dr1.Chislitel = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель 1 дроби: ");
            dr1.Znamenatel = int.Parse(Console.ReadLine());
            Console.Write("Введите числитель 2 дроби: ");
            dr2.Chislitel = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель 2 дроби: ");
            dr2.Znamenatel = int.Parse(Console.ReadLine());
            Drob dr = Drob.Plus(dr1, dr2);
            Console.WriteLine(dr.Chislitel.ToString() + "\n--");
            Console.Write(dr.Znamenatel.ToString() + "\n--");
            Console.ReadKey();
        }
    }

    class Drob
    {
        int ch;
        int zn;

        public Drob() { }

        public Drob(int ch, int zn)
        {
            this.ch = ch;
            this.zn = zn;
        }

        public int Chislitel
        {
            get { return ch; }
            set { ch = value; }
        }

        public int Znamenatel
        {
            get { return zn; }
            set
            {
                if(value == 0)
                    throw new ArgumentException(String.Format("Знаменатель не может быть равен {0}", value), "zn");
                zn = value;
            }
        }

        public static Drob Plus(Drob drob1, Drob drob2)
        {
            Drob dr = new Drob();

            if (drob1.Znamenatel != drob2.Znamenatel)
            {
                dr.Chislitel = drob1.Chislitel * drob2.Znamenatel + drob2.Chislitel * drob1.Znamenatel;
                dr.Znamenatel = drob1.Znamenatel * drob2.Znamenatel;
            }
            else
            {
                dr.Chislitel = drob1.Chislitel + drob2.Chislitel;
                dr.Znamenatel = drob1.Znamenatel;
            }
            return dr;
        }
    }
}
