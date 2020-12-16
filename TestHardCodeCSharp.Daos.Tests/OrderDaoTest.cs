using System.Collections.Generic;
using NUnit.Framework;
using System;
using TestHardCodeCSharp.Daos.Interfaces;
using TestHardCodeCSharp.Daos.DataSchema;
using TestHardCodeCSharp.TestData;
using TestHardCodeCSharp.Daos.Tests.Common;
using TestHardCodeCSharp.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestHardCodeCSharp.Daos.Tests
{
	public class OrderDaoTest : CommonDaoTest<Order, IOrderDao, OrderDdlBuilder>
	{
		public OrderDaoTest() : base(OrderTestData.CreateOrder())
		{
		}

		[TestCase]
		public void SelectAllTest()
		{
			Assert.AreEqual(OrderTestData.OrderCount, this.Dao.SelectAll(this.Context).Count);
		}

		[TestCase]
		public void SelectByIdTest()
		{
			Order item = OrderTestData.CreateOrder1();
			Order find = this.Dao.SelectById(this.Context, item);

			Assert.AreEqual(item.Id, find.Id);
			OrderTestData.AssertAreEqual(item, find);
		}

		[TestCase]
		public void InsertTest()
		{
			Order item = new Order
			{
				Name = string.Empty, 
				Description = string.Empty, 
			};
			int affectedRows = this.Dao.Insert(this.Context, item);
			Assert.AreEqual(1, affectedRows);

			Order find = this.Dao.SelectById(this.Context, item);
			OrderTestData.AssertAreEqual(item, find);

			List<Order> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(OrderTestData.OrderCount + 1, items.Count);
		}

		[TestCase]
		public void UpdateTest()
		{
			Order item = OrderTestData.CreateOrder1();
			Order beforeUpdate = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforeUpdate);
			beforeUpdate.Name = string.Empty;

			this.Dao.Update(this.Context, beforeUpdate);

			Order afterUpdate = this.Dao.SelectById(this.Context, beforeUpdate);
			OrderTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}

		[TestCase]
		public void DeleteTest()
		{
			Order item = OrderTestData.CreateOrder1();
			Order beforedelete = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforedelete);

			int affectedRows = this.Dao.Delete(this.Context, beforedelete);
			Assert.AreEqual(1, affectedRows);

			Order afterDelete = this.Dao.SelectById(this.Context, beforedelete);
			Assert.IsNull(afterDelete);

			List<Order> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(OrderTestData.OrderCount - 1, items.Count);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
