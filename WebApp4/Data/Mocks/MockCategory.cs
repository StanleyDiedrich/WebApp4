using System;
using WebApp4.Data.Interfaces;
using WebApp4.Data.Models;

namespace WebApp4.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { Name = "Электромобили", Description = "Современно" },
                    new Category { Name = "Автомобили с ДВС", Description = "Нестареющая классика" }
                };
            }
        }
    }
}

