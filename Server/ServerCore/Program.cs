static void MainThread()
{
    Console.WriteLine("Hello Thread!");
}

Thread t = new Thread(MainThread);
t.Start();