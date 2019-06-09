using Fibonacci.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace Tests
{
	public class ApiTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void EnpointReturnsBadRequestIfMoreThan100000()
		{
			// Arrange
			var controller = new FibonacciController();

			// Act
			var response = controller.Get(100001);

			// Assert
			Assert.That(response.Result, Is.InstanceOf<BadRequestObjectResult>());
		}

		[Test]
		public void EnpointReturnsBadRequestIfZeroOrLess()
		{
			// Arrange
			var controller = new FibonacciController();

			// Act
			var response = controller.Get(0);

			// Assert
			Assert.That(response.Result, Is.InstanceOf<BadRequestObjectResult>());

			// Act
			response = controller.Get(-1);

			// Assert
			Assert.That(response.Result, Is.InstanceOf<BadRequestObjectResult>());
		}
	}
}