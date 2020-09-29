using System;

namespace TSQLtoCAharp
{
    class Program
    {
        static void Main(string[] args)
        {
            cNotification cNo = new cNotification();
            cInterface cIn = new cInterface();
            cDBConnect cDB = new cDBConnect();
            
            Console.WriteLine("Hello World!");
        }
    }
}
