using System;
using System.Threading;

//ref link:https://www.youtube.com/watch?v=cQadZLH8NkI&list=PLRwVmtr-pp06KcX24ycbC-KkmAISAFKV5&index=10
//

class MainClass
{
    static object baton = new object();
    static void Main()
    {

        /*bool lockTaken = false;
        Monitor.Enter(baton, ref lockTaken);
        try
        {
            Console.WriteLine("Got the baton");
        }
        finally 
        { 
            if (lockTaken)
                Monitor.Exit(baton);
        }*/
        lock (baton)
        {
            Console.WriteLine("Got the baton");
        }
    }
}