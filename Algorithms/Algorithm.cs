using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public static class Algorithm
	{
		public static int[]GetMultiplesBelow(int number, int below)
		{
			List<int> outp = new List<int>();
			for(int i = number; i < below; i +=number)
			{
				outp.Add(i);
			}
			return outp.ToArray();
		}

		//Fibonacci numbers or sequence is a sequence of numbers where each number is the sum of the two preceding ones starting from 0 & 1
		//Each term in the sequence is equal to the previous multiplied by approximately φ = 1.618(golden number).

		/// <summary>
		/// with a sequence starting at 0, returns the number at the zero based index input of the sequence
		/// </summary>
		/// <param name="seedValueOne"></param>
		/// <param name="seedValTwo"></param>
		/// <param name="index"></param>
		/// <returns></returns>
		public static int FibonacciAtIndexSimple(int desiredIndex)
		{
			if(desiredIndex == 0)
			{
				return 0;
			}
			if(desiredIndex == 1 || desiredIndex == 2)
			{
				return 1;
			}
			int[] fibSequence = new int[desiredIndex + 1];
			fibSequence[0] = 0;
			fibSequence[1] = 1;
			for (int index = 2; index <= desiredIndex; ++index)
			{
				fibSequence[index] = fibSequence[index - 1] + fibSequence[index - 2];
			}
			return fibSequence[desiredIndex];
		}

		/// <summary>
		///  with a sequence starting at 0, returns the number at the zero based index input of the sequence. This 
		///  function is using Binet's Formula and the Golden Ratio.
		/// </summary>
		/// <param name="desiredIndex"></param>
		/// <returns></returns>
		public static int FibonacciAtIndexA(int desiredIndex)
		{
			double goldenRatio = 1.618034;
			
			double a = Math.Pow(goldenRatio, desiredIndex);
			double b = Math.Pow(1 - goldenRatio, desiredIndex);
			double numerator = a - b;
			double denominator = Math.Sqrt(5);
			double result = numerator / denominator;
			return (int)Math.Round(result);
		}

		/// <summary>
		/// with a sequence starting at 0, returns the number at the zero based index input of the sequence. This
		/// function is using a simplified Binet Formula without the Golden Ratio
		/// </summary>
		/// <param name="desiredIndex"></param>
		/// <returns></returns>
		public static int FibonacciAtIndexB(int desiredIndex)
		{
			double sqRtOfFive = Math.Sqrt(5);//the square root of five
			double numeratorStart = (1 + sqRtOfFive)/2;
			double numeratorFull = Math.Pow(numeratorStart, desiredIndex);
			double result_d = numeratorFull / sqRtOfFive;
			//return (int)result_d;
			return (int)Math.Round(result_d);
		}

		/// <summary>
		/// returns the FibonacciSequence, with values less than highLimit, with a sequence starting at 0
		/// </summary>
		/// <param name="higLimnit"></param>
		/// <returns></returns>
		public static int[] FibonacciSequenceLessThan(int higLimnit)
		{
			double goldenRatio = 1.618034;
			List<int> sequence = new List<int>();
			int index = 0;
			do
			{
				double a = Math.Pow(goldenRatio, index);
				double b = Math.Pow(1 - goldenRatio, index);
				double numerator = a - b;
				double denominator = Math.Sqrt(5);
				double result = numerator / denominator;
				if(result >= higLimnit)
				{
					break;
				}
				sequence.Add((int)result);
				++index;
			} while (true);

			return sequence.ToArray();
		}
	}
}
