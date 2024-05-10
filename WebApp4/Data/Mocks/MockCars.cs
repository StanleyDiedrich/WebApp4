using System;
using WebApp4.Data.Interfaces;
using WebApp4.Data.Models;

namespace WebApp4.Data.Mocks
{
	public class MockCars:IAllCars
	{
        private readonly ICarsCategory _categoryCars = new MockCategory();
		public IEnumerable<Car>Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        Name="Tesla",
                        LongDesc="Полная хуета",
                        ShortDesc="хуета",
                        Img="/img/Tesla.jpeg",
                        Price=10050,
                        IsFavourite=true,
                        Available=true,
                        Category=_categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        Name ="Ford Fiesta",
                        LongDesc="Норм тачка",
                        ShortDesc ="Ну сойдет",
                        Img="/img/Fiesta.webp",
                        Price=1000,
                        IsFavourite=false,
                        Available=true,
                        Category=_categoryCars.AllCategories.Last()

                    }
                };
            }
        }

        
        public IEnumerable<Car> getFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}

