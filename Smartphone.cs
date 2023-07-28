using System;

namespace Day_15_Assignment_18
{
    internal class Smartphone : IConnectable, IRechargeable, IDisplayable
    {
        bool isConnected;
        int BatteryLevel;
        string model;
        public Smartphone(string model)
        {
            isConnected = false;
            BatteryLevel = 100;
            this.model = model;
        }
        public int Charge(int minutes)
        {
            BatteryLevel += minutes / 5;
            if (BatteryLevel > 100)
                BatteryLevel = 100;
            return BatteryLevel;
        }

        public bool Connect()
        {
            isConnected = false;
            return isConnected;
        }

        public string Display()
        {
            return $"Smartphone Model: {model}\nBattery Level: {BatteryLevel}%\nConnection Status: {(isConnected ? "Connected" : "Not Connected")}";
            
        }
    }
}
