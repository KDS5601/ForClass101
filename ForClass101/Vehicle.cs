using System;
using System.Collections.Generic;
using System.Text;

namespace ForClass101
{
    public class Vehicle
    {
        protected Wheel[] wheels;
        private int fuel; // 최대 100


        public Vehicle(Wheel[] wheels, int fuel)
        {
            this.wheels = wheels;
            this.fuel = fuel;
        }

        public class Wheel
        {
            private string kind;
            private int rpm = 0;

            public Wheel(string kind_p)
            {
                this.kind = kind_p;
            }

            public string GetKind()
            {
                return kind;
            }
            public void SetNRPM(int RPM_p)
            {
                this.rpm = RPM_p;
            }
            public int GetRPM()
            {
                return rpm;
            }
        }
    }

    class Car : Vehicle
    {
        public Car(Wheel[] wheels, int fuel) : base(wheels, fuel) { }

        /// <summary>시동을 켠다</summary>
        public void Run()
        {
            foreach (Wheel wheel in wheels)
            {
                wheel.SetNRPM(5);
            }
        }

        public override string ToString()
        {
            return "Car";
        }
    }

    class Bike : Vehicle
    {
        public Bike(Wheel[] wheels, int fuel) : base(wheels, fuel) { }

        /// <summary>패달을 밟는다</summary>
        public void Start()
        {
            foreach (Wheel wheel in wheels)
            {
                wheel.SetNRPM(8);
            }
        }

        public override string ToString()
        {
            return "Bike";
        }
    }

}
