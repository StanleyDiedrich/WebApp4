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
                        Img="https://avatars.mds.yandex.net/get-verba/3587101/2a0000018a747aef42d8a776cc3f953ddc33/cattouchret",
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
                        Img="https://motor.ru/thumb/1816x0/filters:quality(75):no_upscale()/imgs/2023/06/26/14/5962661/324219edac4c85c67033f7c758c2a465c5e77eda.jpg",
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

