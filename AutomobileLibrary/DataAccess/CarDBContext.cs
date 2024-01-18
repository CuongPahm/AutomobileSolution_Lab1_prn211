using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BusinessObject;

namespace AutomobileLibrary.DataAccess
{
    internal class CarDBContext
    {
        // khoi tao list
        private static List<Car> Carlist = new List<Car>()
        {
            new Car{ CarID=1, CarName="CRV", Manufacturer="Honda", Price=3000, ReleaseYear=2021},
            new Car{ CarID=2, CarName="Ford Focus", Manufacturer="Ford", Price=15000, ReleaseYear=2020 }
        };

        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }

        public List<Car> GetCarList => Carlist;

        public Car GetCarByID(int CarID)
        {
            Car car = Carlist.SingleOrDefault(pro => pro.CarID == CarID);
            return car;
        }

        //Add
        public void Add(Car car)
        {
            Car pro = GetCarByID(car.CarID);
            if (pro == null)
            {
                Carlist.Add(car);
            }
            else
            {
                throw new Exception("Car is already exists.");
            }
        }
        //Update
        public void Update(Car car)
        {
            Car c = GetCarByID(car.CarID);
            if (c != null)
            {
                var index = Carlist.IndexOf(c);
                Carlist[index] = car;
            }
            else
            {
                throw new Exception("Car is not exists.");
            }
        }
        //Remove
        public void Remove(int carId)
        {
            Car p = GetCarByID(carId);
            if (p != null)
            {
                Carlist.Remove(p);
            }
            else
            {
                throw new Exception("Car is already exists.");
            }
        }
    }
}
