using Moq;
using System;
using System.Collections.Generic;
using Xunit;
using Devon4Net.Application.WebAPI.Implementation.Business.DishManagement.Service;
using Devon4Net.Domain.UnitOfWork.UnitOfWork;

namespace Devon4Net.Test.xUnit.Test.UnitTest.Business
{
    public class DishServiceTest: UnitTest
    {
        [Fact]
        public void getDishesMatchingCriteriasTest()
        {   
            //Arrange
            decimal maxPrice = 10;
            int minLikes = 10;
            string searchBy= "food";
            IList<long> categoryIdList;

            var uowMock = new Mock<IUnitOfWork<ModelContext>>();

            DishService dishService = new DishService(uowMock);
            //Act
            var result = dishService.GetDishesMatchingCriterias(maxPrice,minLikes,searchBy,categoryIdList);
            //Assert
        }

    }
}
