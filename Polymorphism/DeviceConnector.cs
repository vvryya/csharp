using System;

namespace Polymorphism
{
    public class USBDevice
    {
        public virtual void Connect()
        {
            Console.WriteLine("Connecting unknown device");
        }
    }

    public class Mouse : USBDevice
    {
        public override void Connect()
        {
            Console.WriteLine("Connecting mouse");
        }
    }

    public class DeviceConnector
    {
        public static void Main()
        {
            var mouse = new Mouse();

            ConnectUSBDevice(mouse);
        }

        private static void ConnectUSBDevice(USBDevice device)
        {
            device.Connect();
        }
    }
}