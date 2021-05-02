﻿using System;

namespace Make_And_Model_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string brandName = Console.ReadLine();
            string modelName = Console.ReadLine();

            Car car = new Car();
            car.Brand = brandName;
            car.Model = modelName;

            car.ShowBrand();
            car.ShowModel();
        }
        class Vehicle
        {
            public string Brand { get; set; }

            public void ShowBrand()
            {
                Console.WriteLine("Brand: " + Brand);
            }
        }

        //complete the Car class
        class Car : Vehicle
        {
            public string Model { get; set; }
            
            public void ShowModel()
            {
                Console.WriteLine("Model: " + Model);
            }
        }
    }
}
