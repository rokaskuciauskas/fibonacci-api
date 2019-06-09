using System.Collections.Generic;
using System.Numerics;

namespace Fibonacci.Services
{
	public class FibonacciSequenceGenerator
	{
		public static List<BigInteger> GenerateFibonacciSequence(int length)
		{
			List<BigInteger> sequence = new List<BigInteger>();
			BigInteger n1 = 0, n2 = 1, lastMember;
			int i;
			sequence.Add(n1);
			sequence.Add(n2);
			for (i = 2; i < length; ++i)
			{
				lastMember = n1 + n2;
				n1 = n2;
				n2 = lastMember;
				sequence.Add(lastMember);
			}
			return sequence;
		}
	}
}
