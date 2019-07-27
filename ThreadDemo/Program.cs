using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Program
    {
        public static int count = 0;
        public static object locker = new object();
        static void Main(string[] args)
        {
            int i = 5;
            Thread thread = new Thread(() => {
                Console.WriteLine("i=" + i);
            });
            thread.Start();
            i = 6;
            Console.WriteLine("线程内访问局部变量错误实例1");
            for (int j = 0; j < 10; j++)
            {
                Thread thread1 = new Thread(() =>
                {
                    Console.WriteLine("i=" + j);
                });
                thread1.Start();
            }
            Console.WriteLine("线程内访问局部变量错误实例2");

            int k=5;
            Thread thread3= new Thread((obj) => {
                Console.WriteLine("i=" + obj);
            });
            thread3.Start(k);
            k= 6;
            Console.WriteLine("对1的修改");
            for (int j = 0; j < 10; j++)
            {
                Thread thread4 = new Thread((obj) => {
                    Console.WriteLine("i=" + obj);
                });
                thread4.Start(j);
            }
            Console.WriteLine("对2的修改");
            Thread t1 = new Thread(() => {
                Console.WriteLine("t1 要睡了");
                Thread.Sleep(5000);
                Console.WriteLine("t1 醒了");
            });
            t1.IsBackground = true;//设置完后程序会退出，否则会
            t1.Start();


            //线程同步，解决多个线程访问同一资源问题
            //1、利用join方法
            Thread thread5 = new Thread(() =>
            {
                for (int a = 0; a < 5; a++)
                {
                    //lock (locker)
                    //{
                        count++;
                        Console.WriteLine("thread5  " + count);
                      
                    //}
                    //Thread.Sleep(11);//加上此句后，线程挂起，thread6会访问资源
                }
            }
            );     
        thread5.Start();
                Thread thread6 = new Thread(() =>
                {
                for (int a = 0; a < 5; a++)
                {
                        //lock (locker)
                        //{
                            count++;
                            Console.WriteLine("thread6  " + count);
                           
                        //}
                        //Thread.Sleep(11);
                    }
                });
                thread6.Start();
            thread5.Join();
            thread6.Join();
            Console.WriteLine("countValue  "+count);
            //利用lock锁住资源
            Thread thread7 = new Thread(() =>
            {
                for (int a = 0; a < 5; a++)
                {
                    lock (locker)
                    {
                        count++;
                    Console.WriteLine("thread7  " + count);

                    }
                    //Thread.Sleep(11);//加上此句后，线程挂起，thread6会访问资源
                }
            }
           );
            thread7.Start();
            Thread thread8 = new Thread(() =>
            {
                for (int a = 0; a < 5; a++)
                {
                    lock (locker)
                    {
                        count++;
                    Console.WriteLine("thread8  " + count);

                    }
                    //Thread.Sleep(11);
                }
            });
            thread8.Start();
            //thread7.Join();
            //thread8.Join();
            Console.WriteLine("countValue  " + count);

            ManualResetEvent mre = new ManualResetEvent(false);
            //构造函数 false 表示“初始状态为关门”，设置为 true 则初始化为开门状态
            Thread t2 = new Thread(() => {
                Console.WriteLine("开始等着开门");
                mre.WaitOne();
                Console.WriteLine("终于等到你");
            });
            t2.Start();
            Console.WriteLine("按任意键开门");
            Console.ReadKey();
            mre.Set();//开门
            Console.Read();
        }
    }
}
