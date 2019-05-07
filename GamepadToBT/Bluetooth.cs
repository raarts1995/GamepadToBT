using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Threading;

namespace GamepadToBT
{
    class Bluetooth
    {
        private SerialPort ser;

        public Bluetooth()
        {
            ser = new SerialPort();
        }

        public List<string> GetCOMlist()
        {
            CloseSerial();

            string[] ports = SerialPort.GetPortNames();
            List<string> portList = new List<string>();
            foreach (string port in ports)
            {
                if (!portList.Contains(port))
                {
                    Console.WriteLine(port);
                    portList.Add(port);
                }
            }
            return portList;
        }

        public bool OpenSerial(string com)
        {
            CloseSerial();
            try
            {
                ser.PortName = com;
                ser.WriteTimeout = 500;
                ser.ReadTimeout = 500;
                ser.Open();
                Thread.Sleep(50);
                ser.Write("\n"); //clear arduino buffer
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("OpenSerial: " + e.Message);
                return false;
            }
        }

        public void CloseSerial()
        {
            if (ser.IsOpen)
                ser.Close();
        }

        public bool Opened()
        {
            return ser.IsOpen;
        }

        public bool Write(string data)
        {
            try
            {
                ser.Write(data);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("ser.Write Error: " + e.Message);
                return false;
            }
        }

        public bool WriteLine(string data)
        {
            try
            {
                ser.WriteLine(data);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("ser.WriteLine Error: " + e.Message);
                return false;
            }
        }
    }
}
