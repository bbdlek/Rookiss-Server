using System;

namespace ServerCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5 * 5 배열
            // [][][][][] [][][][][] [][][][][] [][][][][] [][][][][]
            // 첫번째 : 캐시에 미리 어느정도 담아 놓는데 공간적 이점 활용
            // 두번째 : 띄엄띄엄 값이 들어가서 공간적 이점 활용 X
            int[,] arr = new int[10000, 10000];

            {
                long now = DateTime.Now.Ticks;
                for (int y = 0; y < 10000; y++)
                {
                    for(int x = 0; x < 10000;  x++)
                    {
                        arr[y, x] = 1;
                    }
                }
                long end = DateTime.Now.Ticks;
                Console.WriteLine($"(y, x) 순서 걸린 시간 {end - now}");
            }

            {
                long now = DateTime.Now.Ticks;
                for (int y = 0; y < 10000; y++)
                {
                    for (int x = 0; x < 10000; x++)
                    {
                        arr[x, y] = 1;
                    }
                }
                long end = DateTime.Now.Ticks;
                Console.WriteLine($"(x, y) 순서 걸린 시간 {end - now}");
            }
        }
    }
}