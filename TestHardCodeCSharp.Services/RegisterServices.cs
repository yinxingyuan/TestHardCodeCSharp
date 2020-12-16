using MetaShare.Common.Core.CommonService;
using TestHardCodeCSharp.Services.Interfaces;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestHardCodeCSharp.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}

		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(IOrderService), new OrderService(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
