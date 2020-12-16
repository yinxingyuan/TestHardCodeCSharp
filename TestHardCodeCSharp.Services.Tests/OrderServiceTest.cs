using System;
using System.Collections.Generic;
using NUnit.Framework;
using TestHardCodeCSharp.Entities;
using TestHardCodeCSharp.TestData;
using TestHardCodeCSharp.Services.Tests.Common;
using TestHardCodeCSharp.Services.Interfaces;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestHardCodeCSharp.Services.Tests
{

	[TestFixture]
	public class OrderServiceTest : CommonServiceTest<Order, IOrderService>
	{
		[TestCase]
		public void SelectAllTest()
		{
			List<Order> items = this.Service.SelectAll();
			Assert.AreEqual(OrderTestData.OrderCount, items.Count);
		}

		[TestCase]
		public void SelectByTest()
		{
			Order itemTest = OrderTestData.CreateOrder1();

			List<Order> find = this.Service.SelectBy(new Order {Name = itemTest.Name}, new List<string> {"Name"});
			Assert.IsNotNull(find);

			foreach (Order item in find)
			{
				Assert.AreEqual(itemTest.Name, item.Name);
			}
		}

		[TestCase]
		public void SelectByIdTest()
		{
			Order itemTest = OrderTestData.CreateOrder1();

			Order find = this.Service.SelectById(new Order {Id = itemTest.Id});
			Assert.IsNotNull(find);

			OrderTestData.AssertAreEqual(itemTest, find);
		}

		[TestCase]
		public void DeleteTest()
		{
			Order itemTest = OrderTestData.CreateOrder2();
			int affectedRows = this.Service.Delete(itemTest, true);

			List<Order> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, OrderTestData.OrderCount - 1);
			Assert.AreEqual(-1, affectedRows);
		}

		[TestCase]
		public void InsertTest()
		{
			Order itemTest = new Order
			{
				Name = string.Empty, 
				Description = string.Empty, 
			};

			int affectedRows = this.Service.Insert(itemTest, true);

			List<Order> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, OrderTestData.OrderCount + 1);
			Assert.AreEqual(1, affectedRows);
		}

		[TestCase]
		public void UpdateTest()
		{
			Order itemTest = OrderTestData.CreateOrder1();

			Order beforeUpdate = this.Service.SelectById(new Order {Id = itemTest.Id});
			beforeUpdate.Name = string.Empty ;
			this.Service.Update(beforeUpdate, true);

			Order afterUpdate = this.Service.SelectById(new Order {Id = itemTest.Id});
			OrderTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}

}
