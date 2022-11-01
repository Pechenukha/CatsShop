using CatsShop;
using CatsShop.Services;
using CatsShop.Controllers;
using CatsShop.Areas.Identity.Data;
using CatsShop.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace TestProject
{
    public class UnitTest1
    {
        public static List<Cat> GetTestCats()
        {
            return new List<Cat>
            {
                new Cat { Id=1, Breed = "s", Color="s", Gender="m", Age=1},
                new Cat { Id=2, Breed = "v", Color="v", Gender="m", Age=1},
                new Cat { Id=3, Breed = "c", Color="c", Gender="m", Age=2},
                new Cat { Id=4, Breed = "n", Color="n", Gender="f", Age=3}
            };
        }

        [Fact]
        public void Test_Index_Returns_ProductCount()
        {
            Mock<IRepository<Cat>> catService = new Mock<IRepository<Cat>>();
            catService.Setup(repo => repo.GetList()).Returns(GetTestCats());
            var controller = new CatsController(catService.Object);

            var result = controller.Index();

            var actionResult = Assert.IsType<ViewResult>(result);
            Assert.True(actionResult.ViewData.ContainsKey("Cat"));
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            Mock<IRepository<Cat>> catService = new Mock<IRepository<Cat>>();
            catService.Setup(repo => repo.GetList()).Returns(GetTestCats());
            var controller = new CatsController(catService.Object);

            //Act
            var result = controller.Get();

            //Assert
            var actionResult = Assert.IsType<ActionResult<List<ArtistToRead>>>(result);
            var Artists = Assert.IsType<List<ArtistToRead>>(actionResult.Value);
            Assert.Equal(GetTestArtists().Count, Artists.Count);
        }
    }
}