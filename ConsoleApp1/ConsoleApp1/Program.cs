using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SerialPort sp = new SerialPort();
            sp.PortName = "COM4";
            sp.BaudRate = 9600;
            sp.DataBits = 8;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;

            sp.Open();

            while (true)
            {
                var readData = sp.ReadLine();
                Console.WriteLine(readData);
            }
        }
    }
}
