﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //CarManager carManager = new CarManager(new InMemoryCarDal());

            //// Ekleme
            //carManager.Add(new Car { Id = 11, BrandId = 5, ColorId = 1, DailyPrice = 300, ModelYear = 2017, Description = "Az yakar çok kaçar" });

            //// Silme
            //carManager.Delete(new Car { Id = 11, BrandId = 5, ColorId = 1, DailyPrice = 300, ModelYear = 2017, Description = "Az yakar çok kaçar" });

            //// Güncelleme
            //carManager.Update(
            //new Car { Id = 1, BrandId = 4, ColorId = 3, ModelYear = 2015, DailyPrice = 290, Description = "Az yakar çok kaçar" },
            //new Car { Id = 1, BrandId = 5, ColorId = 1, DailyPrice = 300, ModelYear = 2017, Description = "Az yakar çok kaçar" }
            //);

            //// Bütün araçları getir
            //carManager.GetAll();

            //// Id ile filtreleyerek araba getir
            //carManager.GetById(1);


            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 11, ColorId = 2, ModelYear = 2013, DailyPrice = 190, Description = "Az yakar çok kaçar"});

            var getCarsByBrandId = carManager.GetCarsByBrandId(1);
            Console.WriteLine(getCarsByBrandId.ModelYear);
            var getCarsByColordId = carManager.GetCarsByColorId(1);
            Console.WriteLine(getCarsByColordId.ModelYear);
        }
    }
}
