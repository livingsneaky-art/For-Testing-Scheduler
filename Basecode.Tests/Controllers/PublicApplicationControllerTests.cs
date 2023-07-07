﻿using Basecode.WebApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Tests.Controllers
{
    public class PublicApplicationControllerTests
    {
        private readonly PublicApplicationController _controller;

        public PublicApplicationControllerTests()
        {
            _controller = new PublicApplicationController();
        }

        [Fact]
        public void Index_ReturnsViewResult()
        {
            // Arrange
            var controller = new PublicApplicationController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
