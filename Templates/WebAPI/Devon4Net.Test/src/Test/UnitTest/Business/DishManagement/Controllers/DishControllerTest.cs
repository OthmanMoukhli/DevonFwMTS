using Moq;
using System;
using System.Collections.Generic;
using Devon4Net.Test.xUnit.Test.Integration;
using Xunit;
using Devon4Net.Application.WebAPI.Implementation.Business.DishManagement.Service;
using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using Devon4Net.Application.WebAPI.Implementation.Domain.Database;
using Devon4Net.Application.WebAPI.Implementation.Business.DishManagement.Controllers;
using Devon4Net.Application.WebAPI.Implementation.Business.DishManagement.Dto;

namespace Devon4Net.Test.xUnit.Test.UnitTest.Business
{
    public class DishControllerTest: UnitTest
    {
        [Fact]
        public void DishSearchTest()
        {   
            //Arrange
            var dishServiceInterface = new Mock<IDishService>();
            DishController dishController = new DishController(dishServiceInterface.Object);
            FilterDtoSearchObjectDto input = new FilterDtoSearchObjectDto();

            input.SearchBy = "test";
            input.MaxPrice = 10;
            input.MinLikes = 0;
            input.Categories = new CategorySearchDto[1];
            input.Categories[0] = new CategorySearchDto();
            input.Categories[0].Id = 1;
            
            //Act
            var result = dishController.DishSearch(input);
            
            //Assert
            var expectedResult = result; // should be replaced with expected result Json
            Assert.Equal(expectedResult,result);
        }

    }
}
