using Fibonacci.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Numerics;

namespace Fibonacci.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FibonacciController : ControllerBase
	{
		// GET api/fibonacci/10
		[HttpGet("{length}")]
		public ActionResult<List<BigInteger>> Get(int length)
		{
			if (length > 0 && length <= 100000)
			{
				return FibonacciSequenceGenerator.GenerateFibonacciSequence(length);
			} else
			{
				return BadRequest("Parameter should be positive integer between 1 and 100000");
			}
		}
	}
}
