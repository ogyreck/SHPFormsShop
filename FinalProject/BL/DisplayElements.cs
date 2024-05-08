using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
	/// <summary>
	/// Возможно надо передлать на статик?
	/// </summary>
	public static class DisplayElements
	{
		public static Panel? panel {  get; set; } 

		public static void ShowBasketItem(List<ShopCardModel> basketItems)
		{
			int marginTop = 0;
			panel.Controls.Clear();
			if (basketItems.Count == 0)
			{
				Label emptyBasket = new Label();
				emptyBasket.Text = "Корзина пуста";
				emptyBasket.Location = new Point(panel.Width / 2, panel.Height / 2);
				panel.Controls.Add(emptyBasket);
			}
			else
			{

				foreach (var item in basketItems)
				{
					BasketItem basketItem = new BasketItem(item);
					basketItem.Top = marginTop;
					panel.Controls.Add(basketItem);
					marginTop += basketItem.Height+20;
				}
			}

		}
	}
}
