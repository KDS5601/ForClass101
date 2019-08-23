using System;
using System.Collections.Generic;

namespace ForClass101
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> road = new List<Vehicle>();
            List<Vehicle.Wheel> wheels = new List<Vehicle.Wheel>();

            Car car = new Car(4, , 100);

            Bike bike = new Bike(2, [new Wheel("plastic"), new Wheel("plastic")], 50);

            road.push(car);
            road.push(bike);
            car.run();
            bike.start();

            console.log("All vehicles on road: ", road);
            console.log("isEmpty: ", car.isRoadEmpty(road));

        }
    }

    public class Vehicle
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

            public Wheel(string kind_p)
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

