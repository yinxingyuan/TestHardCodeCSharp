using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using TestHardCodeCSharp.Daos.Interfaces;
using TestHardCodeCSharp.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestHardCodeCSharp.Daos
{
	public class OrderDao : CommonObjectDao<Order>, IOrderDao
	{
		public class OrderSqlBuilder : ObjectSqlBuilder
		{
			public OrderSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"_Order")
			{
				this.SqlInsert = "INSERT INTO _Order (" + this.SqlBaseFieldInsertFront + ") VALUES (" + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE _Order SET " + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class OrderResultHandler : CommonObjectResultHandler<Order>
		{
			public override void GetColumnValues(IDataReader reader, Order item)
			{
				base.GetColumnValues(reader, item);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, Order item)
			{
				base.AddInsertParameters(context, command, item);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public OrderDao(SqlDialect sqlDialect) : base(new OrderSqlBuilder(sqlDialect), new OrderResultHandler())
		{
		}

		public OrderDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new OrderSqlBuilder(sqlDialect), new OrderResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
