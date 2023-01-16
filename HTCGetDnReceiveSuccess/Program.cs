using HTCGetDnReceiveSuccess.Services;
using System;

namespace HTCGetDnReceiveSuccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScheduleTimer.SetTime();

            Console.WriteLine("Executing...");
            Console.ReadKey();
        }
    }
}
