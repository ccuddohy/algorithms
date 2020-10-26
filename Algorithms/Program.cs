using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			//multiples of 3 & 5
			int number = 3;
			int highLimit = 1000;
			int[] multThree = Algorithm.GetMultiplesBelow(number, highLimit);
			int numbTwo = 5;
			int[] multFive = Algorithm.GetMultiplesBelow(numbTwo, highLimit);
			HashSet<int> hashVal = new HashSet<int>(multThree);
			hashVal.UnionWith(multFive);
			int total = hashVal.Sum();


			int highLim = 4000000;
			int[] sequence = Algorithm.FibonacciSequenceLessThan(highLim);
			HashSet<int> terms = new HashSet<int>(sequence);
			HashSet<int> evenTerms = terms.Where(x => x % 2 == 0).ToHashSet();
			int sum = evenTerms.Sum();

		}
	}
}
