using TestHardCodeCSharp.Entities;
using System.Collections.Generic;
using TestHardCodeCSharp.Services.Interfaces;
using TestHardCodeCSharp.Web.Models;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;

/*add customized code between this region*/
/*add customized code between this region*/

namespace TestHardCodeCSharp.Web.Controllers
{
	public class OrderController:CommonController<Order, IOrderService, OrderModel>
	{


		protected override List<Order> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<Order> lists = this.Service.SelectBy(pagerSearchModel.Pager,new Order { Name = pagerSearchModel.Name }, order => order.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
