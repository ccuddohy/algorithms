using Algorithms;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTestAlgorithm
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void TestGetMultiplesBelow()
		{
			int numb = 3;
			int highLim = 10;
			int[] expected = new int[] { 3, 6, 9 };
			int[] calc = Algorithm.GetMultiplesBelow(numb, highLim);
			Assert.AreEqual(expected, calc);

			numb = 10;
			highLim = 100;
			expected = new int[] { 10,20,30,40,50,60,70,80,90 };
			calc = Algorithm.GetMultiplesBelow(numb, highLim);
			Assert.AreEqual(expected, calc);
		}

		[Test]
		public void TestFibonacciAtIndexSimple()
		{
			int desIndex = 5;
			int expect = 5;
			int calc = Algorithm.FibonacciAtIndexSimple(desIndex);
			Assert.AreEqual(expect, calc);

			desIndex = 7;
			expect = 13;
			calc = Algorithm.FibonacciAtIndexSimple(desIndex);
			Assert.AreEqual(expect, calc);

			desIndex = 10;
			expect = 55;
			calc = Algorithm.FibonacciAtIndexSimple(desIndex);
			Assert.AreEqual(expect, calc);

			desIndex = 0;
			expect = 0;
			calc = Algorithm.FibonacciAtIndexSimple(desIndex);
			Assert.AreEqual(expect, calc);

			desIndex = 1;
			expect = 1;
			calc = Algorithm.FibonacciAtIndexSimple(desIndex);
			Assert.AreEqual(expect, calc);

			desIndex = 2;
			expect = 1;
			calc = Algorithm.FibonacciAtIndexSimple(desIndex);
			Assert.AreEqual(expect, calc);
		}

		[Test]
		public void TestFibonacciAtIndexA()
		{
			int desIndex = 5;
			int expect = 5;
			int calc = Algorithm.FibonacciAtIndexA(desIndex);
			Assert.AreEqual(expect, calc);

			desIndex = 7;
			expect = 13;
			calc = Algorithm.FibonacciAtIndexA(desIndex);
			Assert.AreEqual(expect, calc);

			desIndex = 10;
			expect = 55;
			calc = Algorithm.FibonacciAtIndexA(desIndex);
			Assert.AreEqual(expect, calc);

			desIndex = 0;
			expect = 0;
			calc = Algorithm.FibonacciAtIndexA(desIndex);
			Assert.AreEqual(expect, calc);

			desIndex = 1;
			expect = 1;
			calc = Algorithm.FibonacciAtIndexA(desIndex);
			Assert.AreEqual(expect, calc);

			desIndex = 2;
			expect = 1;
			calc = Algorithm.FibonacciAtIndexA(desIndex);
			Assert.AreEqual(expect, calc);

		}

		[Test]
		public void TestFibonacciSequenceLessThan()
		{
			int highLim = 90;
			int[] sequence = Algorithm.FibonacciSequenceLessThan(highLim);
			HashSet<int> terms = new HashSet<int>(sequence);
			int[] expected = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
			Assert.AreEqual(expected, terms);


			highLim = 4000000;
			sequence = Algorithm.FibonacciSequenceLessThan(highLim);
			terms = new HashSet<int>(sequence);
			HashSet<int> evenTerms = terms.Where(x => x % 2 == 0).ToHashSet();
			int sum = evenTerms.Sum();
			Assert.AreEqual(4613732, sum);

		}
	}
}