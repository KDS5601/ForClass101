using System;
using System.Collections.Generic;

namespace ForClass101
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Vehicle
    {
        private int numberOfWheels; // bigger than -1
        public List<Wheel> wheels = new List<Wheel>();
        private int fuel; // 0~100

        public Vehicle(int numberOfWheels, ref List<Wheel> wheels, int fuel)
        {
            this.numberOfWheels = numberOfWheels;
            this.wheels = wheels;
            this.fuel = fuel;
        }
        public int getNumberOfWheels()
        {
            return this.numberOfWheels;
        }

        public int getFuel()
        {
            return this.fuel;
        }

        public class Wheel
        {
            public string kind;
            public int rpm = 0;

            Wheel(string kind_p)
            {
                this.kind = kind_p;
            }

            public void setNewRPM(int r)
            {
                this.rpm = r;
            }
        }
    }

    class Car : Vehicle
    {
        public Car(int numberOfWheels, ref List<Wheel> wheels, int fuel) : base(numberOfWheels, ref wheels, fuel) { }

        // 시동을 켠다
        public void run()
        {
            for (int i = 0; i < this.getNumberOfWheels(); i++)
            {
                this.wheels[i].rpm = 5;
            }
        }
        public void isRoadEmpty(ref List<Vehicle> vehicles)
        {
            vehicles.Clear();
        }
    }

    class Bike : Vehicle
    {
        public Bike(int numberOfWheels, ref List<Wheel> wheels, int fuel) : base(numberOfWheels, ref wheels, fuel) { }

        // 페달을 밟는다
        public void start()
        {
            for (int i = 0; i < this.getNumberOfWheels(); i++)
            {
                this.wheels[i].rpm = 8;
            }
        }
        public void isRoadEmpty(ref List<Vehicle> vehicles)
        {
            vehicles.Clear();
        }
    }
}

