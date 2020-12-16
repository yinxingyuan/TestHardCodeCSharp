using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TestHardCodeCSharp.Entities;
/*add customized code between this region*/
using System.Web;
/*add customized code between this region*/

namespace TestHardCodeCSharp.Web.Models
{
	public class OrderModel: CommonModel<Order>
	{

		public override void PopulateFrom(Order entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			/*add customized code between this region*/
			
			entity.Code = this.Code；
			
			/*add customized code between this region*/
		}

		public override void PopulateTo(Order entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			/*add customized code between this region*/
			this.Code = entity.Code;
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	public string Code {get;set;}
	/*add customized code between this region*/
	}
}
