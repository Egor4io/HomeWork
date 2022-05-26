using System.Threading;

namespace TimeTicker
{
    internal class Program
    {
        public static void Main()
        {
            Thread th = new Thread(Do1);
            Thread th1 = new Thread(Do2);
            th.Start();
            th1.Start();


        }
        public static async void Do1()
        {
            while (true)
            {
                System.DateTime localDate = System.DateTime.Now;
                Thread.Sleep(1000);
                System.Console.SetCursorPosition(0, 0);
                System.Console.WriteLine(localDate.ToString());

            }
        }
        public static void Do2()
        {
            while (true)
            {
                
                System.Console.Write("0");
                Thread.Sleep(10);

               
            }
        }
       
            
        
    }
}
