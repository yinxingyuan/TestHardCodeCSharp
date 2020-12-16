using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using TestHardCodeCSharp.Entities;
using MetaShare.Common.Core.Services;
using TestHardCodeCSharp.Daos.Interfaces;
using TestHardCodeCSharp.Services.Interfaces;

/*add customized code between this region*/
/*add customized code between this region*/

namespace TestHardCodeCSharp.Services
{
	public class OrderService : Service<Order>, IOrderService
	{
		public OrderService() : base(typeof (IOrderDao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
