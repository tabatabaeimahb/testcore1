using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Mtx.Client.Pages.Learning
{
    public partial class Learn4
    {
		protected override void OnInitialized()
		{
			items =
				new List<Models.Learning.Model.Basket>();

			for (int index = 1; index <= 5; index++)
			{
				var item =
					new Models.Learning.Model.Basket
					{
						count = 1,
						name = $"Product { index }",
						price = index * 100,
					};

				items.Add(item);
			}
		}

		private System.Collections.Generic.List<Models.Learning.Model.Basket> items;


		//زمانی که از روش فرعی استفاده می کنیم توابع در کلاسی خارج از کلاس بسکت به شکل زیر تعریف میشوند

		//public void Plus(Models.Learning.Model.Basket item)
		//{
		//	if (item.count < 10)
		//	{
		//		item.count++;
		//	}
		//}

		//public void Minus(Models.Learning.Model.Basket item)
		//{
		//	if (item.count > 0)
		//	{
		//		item.count--;
		//	}
		//}
	}

	
}
