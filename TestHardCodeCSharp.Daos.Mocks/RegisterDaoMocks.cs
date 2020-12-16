using MetaShare.Common.Core.Daos;
using TestHardCodeCSharp.Daos.Interfaces;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestHardCodeCSharp.Daos.Mocks
{
	public class RegisterDaoMocks
	{
		public static void RegisterAll()
		{
			Register(DaoFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(DaoFactory.Instance, false);
		}

		public static void Register(DaoFactory factory, bool isRegister)
		{
			factory.Register(typeof(IOrderDao), new OrderDaoMock(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
