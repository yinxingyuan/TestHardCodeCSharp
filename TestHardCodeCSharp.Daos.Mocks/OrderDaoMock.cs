using MetaShare.Common.Core.Daos;
using TestHardCodeCSharp.Entities;
using TestHardCodeCSharp.Daos.Interfaces;
using TestHardCodeCSharp.TestData;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestHardCodeCSharp.Daos.Mocks
{
	public class OrderDaoMock : MockDao<Order>, IOrderDao
	{
		public OrderDaoMock() : base(OrderTestData.CreateOrder())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
