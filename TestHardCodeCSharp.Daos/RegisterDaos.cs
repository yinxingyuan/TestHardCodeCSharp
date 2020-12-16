using System;
using MetaShare.Common.Core.Daos;
using TestHardCodeCSharp.Daos.Interfaces;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestHardCodeCSharp.Daos
{
	public class RegisterDaos
	{
		public static void RegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, true,sqlDialect,sqlDialectVersion);
		}

		public static void UnRegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, false,sqlDialect,sqlDialectVersion);
		}

		public static void Register(DaoFactory factory, bool isRegister, Type sqlDialect, Type sqlDialectVersion)
		{
			factory.Register(typeof(IOrderDao), new OrderDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
