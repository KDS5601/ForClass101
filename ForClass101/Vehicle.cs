using System;
using System.Collections.Generic;
using System.Text;

namespace ForClass101
{
    public class Vehicle
    {
        protected Wheel[] wheels;
        private int fuel;

        public Vehicle(Wheel[] wheels, int fuel)
        {
            this.wheels = wheels;
            this.fuel = fuel;
        }

        public bool isRoadEmpty(ref List<Vehicle> vehicles)
        {
            return (vehicles.Count == 0);
        }

        public class Wheel
        {
            private string kind;
            private int rpm = 0;

            public Wheel(string kind_p)
            {
                this.kind = kind_p;
            }

            public void SetNRPM(int r)
            {
                this.rpm = r;
            }
        }
    }

    class Car : Vehicle
    {
        public Car(Wheel[] wheels, int fuel) : base(wheels, fuel) { }

        // 시동을 켠다
        public void Run()
        {
            foreach (Wheel wheel in wheels)
            {
                wheel.SetNRPM(5);
            }
        }
    }

    class Bike : Vehicle
    {
        public Bike(Wheel[] wheels, int fuel) : base(wheels, fuel) { }

        // 페달을 밟는다
        public void Start()
        {
            foreach (Wheel wheel in wheels)
            {
                wheel.SetNRPM(8);
            }
        }
    }

}
