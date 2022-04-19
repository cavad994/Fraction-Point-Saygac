using System;
using System.Numerics;
using System.Threading;

namespace Csharp
{
    #region Point

    //class point
    //{
    //    private int x;
    //    private int y;
    //    public int x { get => x; set => x = value; }
    //    public int y { get => y; set => y = value; }

    //    public point() {}
    //    public point(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }

    //    public void showdata()
    //    {
    //        console.writeline("x : " + x + "\ny : " + y);
    //    }
    //}
    #endregion


    #region Counter

    internal class Counter
    {
        private int min, max, currentData;

        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }
        public int CurrentData { get => currentData; set => currentData = value; }

        public Counter(int min, int max, int currentData)
        {
            Min = min;
            Max = max;
            CurrentData = currentData;
        }
        public Counter() { }

        public void Increment()
        {
            if (this.currentData + 1 == max)
                currentData = Min;
            else
                currentData++;
        }
        public void GetCurrent() { Console.WriteLine(currentData); }


    }

    #endregion



    #region Fraction Calculator

    class Fraction
    {
        private int x, x1;

        public int X { get => x; set => x = value; }
        public int Y { get => x1; set => x1 = value; }
        public Fraction(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Plus(Fraction fraction)
        {
            int mexrec = Y * fraction.Y;
            if (Y % fraction.Y == 0)
                mexrec = Y;
            else if (fraction.Y % Y == 0)
                mexrec = fraction.Y;
            int suret = ((mexrec / Y) * X) + ((mexrec / fraction.Y) * fraction.X);
            Console.WriteLine($"{suret} / {mexrec}");
            if (suret > mexrec)
                Console.WriteLine("Tam hisse : " + suret / mexrec);
        }
        public void Minus(Fraction fraction)
        {
            int mexrec = Y * fraction.Y;
            if (Y % fraction.Y == 0)
            {
                if (Y > fraction.Y)
                {
                    mexrec = Y;
                }
                else if (Y < fraction.Y)
                    mexrec = fraction.Y;
            }
            int suret = ((mexrec / Y) * X) - ((mexrec / fraction.Y) * fraction.X);
            Console.WriteLine($"{suret} / {mexrec}");
            if (suret > mexrec)
                Console.WriteLine("Tam hisse : " + suret / mexrec);
        }
        public void Multiple(Fraction fraction)
        {
            int mexrec = Y * fraction.Y;
            int suret = (X * fraction.X);
            Console.WriteLine($"{suret} / {mexrec}");
            if (suret > mexrec)
                Console.WriteLine("Tam hisse : " + suret / mexrec);
        }
        public void Devide(Fraction fraction)
        {
            int mexrec = Y * fraction.X;
            if (Y % fraction.X == 0)
                mexrec = Y;
            else if(fraction.X % Y == 0)
                mexrec = fraction.X;
            int suret = fraction.Y * X;
            Console.WriteLine($"{suret} / {mexrec}");
            if(suret > mexrec)
                Console.WriteLine("Tam hisse : " + suret / mexrec);
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            //Counter c = new Counter(0, 100, 0);

            //for (int i = 0; i < 1000; i++)
            //{
            //    c.Increment();
            //    c.GetCurrent();
            //}

            Fraction f = new(5, 7);
            Fraction f1 = new(3, 8);
            f.Plus(f1);
            f.Devide(f1);
        }
    }
}
