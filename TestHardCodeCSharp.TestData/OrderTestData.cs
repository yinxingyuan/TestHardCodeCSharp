using System;
using System.Collections.Generic;
using NUnit.Framework;
using TestHardCodeCSharp.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestHardCodeCSharp.TestData
{
	public class OrderTestData
	{
		public const int OrderCount = 3;
		/*add customized code between this region*/
		/*add customized code between this region*/

		 public static List<Order> CreateOrder()
		{
			return new List<Order>
			{
				CreateOrder1(),
				CreateOrder2(),
				CreateOrder3(),
			};
		}

		 public static Order CreateOrder1()
		{
			return new Order
			{
					Id = 1, 
					Name = string.Empty, 
					Description = string.Empty, 
			};
		}
		 public static Order CreateOrder2()
		{
			return new Order
			{
					Id = 2, 
					Name = string.Empty, 
					Description = string.Empty, 
			};
		}
		 public static Order CreateOrder3()
		{
			return new Order
			{
					Id = 3, 
					Name = string.Empty, 
					Description = string.Empty, 
			};
		}
		public static void AssertAreEqual(Order expected, Order actual)
		{
			Assert.AreEqual(expected.Name, actual.Name);
			Assert.AreEqual(expected.Description, actual.Description);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
