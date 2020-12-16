using MetaShare.Common.Core.DataSchema;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestHardCodeCSharp.Daos.DataSchema
{
	public class OrderDdlBuilder : DdlBuilder
	{
		public override string GetSqlCreateTable()
		{
			return @"CREATE TABLE _Order(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,Name nvarchar(255),Description nvarchar(255),Description nvarchar(255),Owner_Id int,Entity_Status int)";
		}

		public override string GetSqlDropTable()
		{
			return @"DROP TABLE _Order";
		}

		public override string GetSqlExistTable()
		{
			return @"SELECT COUNT(*) FROM Information_Schema.COLUMNS WHERE TABLE_NAME = '_Order'";
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
