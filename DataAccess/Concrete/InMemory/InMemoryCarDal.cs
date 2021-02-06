using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car(){Id=1,BrandId=1,ColorId=1,DailyPrice=100,Describe="Tesla Model S full otonom",ModelYear=2020},
                new Car(){Id=2,BrandId=2,ColorId=2,DailyPrice=80,Describe="Audi A4",ModelYear=2017},
                new Car(){Id=3,BrandId=3,ColorId=2,DailyPrice=120,Describe="Porsche Cayenne",ModelYear=2019},
                new Car(){Id=4,BrandId=4,ColorId=3,DailyPrice=50,Describe="Ford Mustang",ModelYear=2014},
                new Car(){Id=5,BrandId=5,ColorId=4,DailyPrice=100,Describe="Nissan GTR",ModelYear=2007},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car); 
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => car.Id == c.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => car.Id == c.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Describe = car.Describe;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
        }
    }
}
