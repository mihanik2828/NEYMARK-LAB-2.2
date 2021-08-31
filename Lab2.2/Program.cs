using System;
using System.Threading;


namespace Lab2._2
{
    class Program
    {
        static double a, b, c;
        static double _b, b2, ac4, d, dsqrt, a2, x1, x2;

        static void _B() 
        {   _b = -b;  
            Console.WriteLine("_b done"); 
             
        }

        static void B2() { b2 = b * b;  wh1.Set(); wh4_2.Set(); wh5_2.Set(); Console.WriteLine("b2 done"); }
        static void AC4() { ac4 = 4 * a * c; wh2.Set(); Console.WriteLine("ac4 done"); }
        static void D() { wh1.WaitOne(); wh2.WaitOne(); d = b2 - ac4; wh3.Set();  Console.WriteLine("d done"); }
        static void DSQRT() { wh3.WaitOne();  dsqrt = Math.Sqrt(d); wh4_1.Set(); wh5_1.Set(); Console.WriteLine("dsqrt done"); }
        static void A2() {a2 = 2 * a; wh4_3.Set(); wh5_3.Set(); Console.WriteLine("a2 done"); }
        static void X1() { wh4_1.WaitOne(); wh4_2.WaitOne(); wh4_3.WaitOne(); x1 = (_b + dsqrt) / a2; Console.WriteLine("x1 done"); }
        static void X2() { wh5_1.WaitOne(); wh5_2.WaitOne(); wh5_3.WaitOne(); x2 = (_b - dsqrt) / a2; Console.WriteLine("x2 done"); }

        static EventWaitHandle wh1 = new AutoResetEvent(false);
        static EventWaitHandle wh2 = new AutoResetEvent(false);
        static EventWaitHandle wh3 = new AutoResetEvent(false);
        static EventWaitHandle wh4_1 = new AutoResetEvent(false);
        static EventWaitHandle wh4_2 = new AutoResetEvent(false);
        static EventWaitHandle wh4_3 = new AutoResetEvent(false);
        static EventWaitHandle wh5_1 = new AutoResetEvent(false);
        static EventWaitHandle wh5_2 = new AutoResetEvent(false);
        static EventWaitHandle wh5_3 = new AutoResetEvent(false);
        



        static void Main(string[] args)
        {
            
           Console.WriteLine("Введите коэфы уравнения");
            a=Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            
            Thread t1 = new Thread(_B);
            Thread t2 = new Thread(B2);
            Thread t3 = new Thread(AC4);
            Thread t4 = new Thread(D);
            Thread t5 = new Thread(DSQRT);
            Thread t6 = new Thread(A2);
            Thread t7 = new Thread(X1);
            Thread t8 = new Thread(X2);
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            t7.Start();
            t8.Start();

            Thread.Sleep(200);
            Console.WriteLine("x1= " + x1.ToString() + "; x2= "+ x2.ToString()) ;

        }
    }
}
