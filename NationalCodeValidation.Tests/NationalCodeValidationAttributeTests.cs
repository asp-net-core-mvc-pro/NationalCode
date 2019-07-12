using NationalCodeValidation.Controllers;
using NationalCodeValidation.Models;
using System;
using Xunit;

namespace NationalCodeValidation.Tests
{
    public class NationalCodeValidationAttributeTests
    {
        public object NationalCodeValidatorAttribute { get; private set; }

        [Fact]
        public void WhenNationalCodeLenth10ModelIsValid()
        {
            var controller = new CustomerController();

            var model = new CustomerModel()
            {
                FirstName = "Morsal",
                LastName = "Mousavi",
                NationalCode = "0014071460"
            };

            var result = controller.Create(model);

            Assert.True(controller.ModelState.IsValid);
        }
    }
}
