using System;

namespace Day_15_Assignment_18
{
    internal class Laptop : IConnectable, IRechargeable, IDisplayable
    {
        int batteryLevel;
        bool isConnected;
        string brand;
        public Laptop(string brand)
        {
            batteryLevel = 0;
            isConnected = false;
            this.brand = brand;
        }



        public int Charge(int minutes)
        {
            batteryLevel += minutes / 2;
            if (batteryLevel > 100) 
                batteryLevel = 100;
            return batteryLevel;
        }

        public bool Connect()
        {
            isConnected = true;
            return isConnected;
        }

        public string Display()
        {
            return $"Laptop Brand: {brand}\nBattery Level: {batteryLevel}%\nConnection Status: {(isConnected ? "Connected" : "Not Connected")}";
            
        }
    }
}
