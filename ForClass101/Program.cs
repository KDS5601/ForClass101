﻿using System;
using System.Collections.Generic;

namespace ForClass101
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> road = new List<Vehicle>();

            Vehicle.Wheel[] wheelsCar = { new Vehicle.Wheel("rubber"), new Vehicle.Wheel("rubber"), new Vehicle.Wheel("rubber"), new Vehicle.Wheel("rubber") };
            Vehicle.Wheel[] wheelsBike = { new Vehicle.Wheel("plastic"), new Vehicle.Wheel("plastic") };

            Car car = new Car(wheelsCar, 100);

            Bike bike = new Bike(wheelsBike, 50);

            road.Add(car);
            road.Add(bike);
            car.Run();
            bike.Start();

            Console.Write("All vehicles on road: ");
            foreach (Vehicle vehicle in road)
            {
                Console.Write(vehicle.ToString() + " ");
            }
            Console.Write("\n");
            Console.WriteLine("isEmpty: " + ChakRoadEmpty(ref road));

            //이하 지역함수

            bool ChakRoadEmpty(ref List<Vehicle> vehicles)
            {
                return (vehicles.Count == 0);
            }
        }
    }
}

