using API.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Application.Homes;
using API.Contracts;
using System.Threading.Tasks;
using Domain;

namespace API_tests
{
    public class HomeControllerTest
    {
        HomeController _controller;
        IHomeService _service;

        public HomeControllerTest()
        {
            _service = new APITestServiceFake();
            _controller = new HomeController(_service);
        }

        [Fact]
        // Testing Get All Properties Method
        public void Get_WhenCalled_ReturnsAllProperties()
        {
            // Act
            var okResult = _controller.List();
            // Assert
            Assert.IsType<ActionResult<SearchResult>>(okResult.Result);
        }

        [Fact]
        // Testing Method for Adding new Properties
        public void Add_ValidObjectPassed_ReturnsCreatedResponse()
        {
            // Arrange
            Home testItem = new Home()
            {
                PropertyId = 4292232,
                GroupLogoUrl = "https://photosa.propertyimages.ie/groups/9/0/4/6409/logo.jpg",
                BedsString = "2 beds",
                Price = "395000",
                SizeStringMeters = 52.95,
                DisplayAddress = "Apt. 16 The Northumberlands, Off Lower Mount Street, Dublin 2",
                PropertyType = "Apartment",
                BerRating = "D2",
                MainPhoto = "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg",
                Photos = "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg,https://photosa.propertyimages.ie/media/2/3/2/4292232/e0c4c2c8-6a61-4fda-b5a8-59edc32060b6_l.jpg,https://photosa.propertyimages.ie/media/2/3/2/4292232/b5ce3372-d71c-4897-91dc7c5b4ce21c17_l.jpg"
            };

            // Act
            var createdResponse = _controller.Create(testItem);

            // Assert
            Assert.IsType<Task<ActionResult <Home>>>(createdResponse);
        }

        [Fact]
        // Testing Deletion Method
        public void Remove_ExistingGuidPassed_ReturnsOkResult()
        {
            // Arrange
            var existingId = 4292232;

            // Act
            var okResponse = _controller.Delete(existingId);

            // Assert
            Assert.IsType<Task<ActionResult<dynamic>>>(okResponse);
        }

        [Fact]
        // Testing View Property/Advertisement By Id Method
        public void GetById_ExistingIdPassed_ReturnsObject()
        {
            // Arrange
            var existingId = 4284885;

            // Act
            var okResult = _controller.Details(existingId);

            // Assert
            Assert.IsType<Task<ActionResult<HomeDTO>>>(okResult);
        }

        [Fact]
        // Testing Modify Property/Advertisement Method
        public void Modify_ExistingIdPassed_ReturnsObject()
        {
            var exisingId = 4292232;
            // Arrange
            Home testItem = new Home()
            {
                GroupLogoUrl = "https://photosa.propertyimages.ie/groups/9/0/4/6409/logo.jpg",
                BedsString = "2 beds",
                Price = "395000",
                SizeStringMeters = 52.95,
                DisplayAddress = "Apt. 16 The Northumberlands, Off Lower Mount Street, Dublin 2",
                PropertyType = "Apartment",
                BerRating = "D2",
                MainPhoto = "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg",
                Photos = "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg,https://photosa.propertyimages.ie/media/2/3/2/4292232/e0c4c2c8-6a61-4fda-b5a8-59edc32060b6_l.jpg,https://photosa.propertyimages.ie/media/2/3/2/4292232/b5ce3372-d71c-4897-91dc7c5b4ce21c17_l.jpg"
            };

            // Act
            var modifiedResponse = _controller.Edit(exisingId, testItem);

            // Assert
            Assert.IsType<Task<ActionResult<Home>>>(modifiedResponse);
        }
    }
}