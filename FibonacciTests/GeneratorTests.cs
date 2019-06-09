using Fibonacci.Services;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;
using System.Numerics;

namespace Tests
{
	public class GeneratorTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void GeneratesFibonacciSequence()
		{
			// Act
			var response = FibonacciSequenceGenerator.GenerateFibonacciSequence(10);

			// Assert
			Assert.AreEqual(response, new List<BigInteger> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 });
		}
	}
}