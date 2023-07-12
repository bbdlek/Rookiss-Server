using System;

namespace ServerCore
{
    class Program
    {
        volatile static bool _stop = false; //쓰레드 동시 접근 가능

        static void ThreadMain()
        {
            Console.WriteLine("쓰레드 시작!");

            while (_stop == false)
            {
                //누군가가 stop 신호를 해주기를 기다린다
            }

            Console.WriteLine("쓰레드 종료!");
        }

        static void Main(string[] args)
        {
            Task t = new Task(ThreadMain);
            t.Start();

            Thread.Sleep(1000); //1s Sleep

            _stop = true;

            Console.WriteLine("Stop 호출");
            Console.WriteLine("종료 대기중");

            t.Wait();

            Console.WriteLine("종료 성공");
        }
    }
}