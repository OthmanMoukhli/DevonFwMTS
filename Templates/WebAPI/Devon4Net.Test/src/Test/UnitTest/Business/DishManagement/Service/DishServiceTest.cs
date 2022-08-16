using Moq;
using System;
using System.Collections.Generic;
using Xunit;
using Devon4Net.Application.WebAPI.Implementation.Business.DishManagement.Service;
using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using Devon4Net.Application.WebAPI.Implementation.Domain.Database;
using Devon4Net.Application.WebAPI.Implementation.Domain.Entities;
using System.Threading.Tasks;
namespace Devon4Net.Test.xUnit.Test.UnitTest.Business
{
    public class DishServiceTest: UnitTest
    {
        [Fact]
        public void getDishesMatchingCriteriasTest()
        {   
            //Arrange
            /*decimal maxPrice = 10;
            int minLikes = 10;
            string searchBy= "food";
            IList<long> categoryIdList;
            */

            IList<Dish> expectedResult = new List<Dish>();

            Dish dish1 = new Dish();
            dish1.Name = "falafel";
            dish1.Price = 6;

            Dish dish2 = new Dish();
            dish2.Name = "schnitzel";
            dish2.Price = 8;

            Dish dish3 = new Dish();
            dish3.Name = "salad";
            dish3.Price = 5;

            expectedResult.Add(dish1);
            expectedResult.Add(dish2);
            expectedResult.Add(dish3);

            //var uowMock = new Mock<IUnitOfWork<ModelContext>>();

            //var dishService = new Mock<DishServiceTest>();
            //Act
            //var result = dishService.GetDishesMatchingCriterias(maxPrice,minLikes,searchBy,categoryIdList);
            //Assert
        }

    }
}
