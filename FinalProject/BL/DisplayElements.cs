using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{

	public static class DisplayElements
	{
		public static Panel? panelInBasket {  get; set; }
		public static Panel? panelInMainForms { get; set; }

		public static void ShowBasketItem(List<ShopCardModel> basketItems)
		{
			int marginTop = 0;
			panelInBasket.Controls.Clear();
			if (basketItems.Count == 0)
			{
				Label emptyBasket = new Label();
				emptyBasket.Text = "Корзина пуста";
				emptyBasket.Location = new Point(panelInBasket.Width / 2, panelInBasket.Height / 2);
				panelInBasket.Controls.Add(emptyBasket);
			}
			else
			{

				foreach (var item in basketItems)
				{
					BasketItem basketItem = new BasketItem(item);
					basketItem.Top = marginTop;
					panelInBasket.Controls.Add(basketItem);
					marginTop += basketItem.Height+20;
				}
			}

		}

		public static void ShowMainItemsData(List<ShopCardModel> data)
		{
			int marginLeft = 0;
			int marginTop = 0;
			panelInMainForms.Controls.Clear();
			foreach (var card in data)
			{
				ShopCard shopCard = new ShopCard(card);
				if (marginLeft >= panelInMainForms.Width)
				{
					marginLeft = 0;
					marginTop += shopCard.Height + 20;
				}
				shopCard.Left = marginLeft;
				shopCard.Top = marginTop;


				panelInMainForms.Controls.Add(shopCard);
				marginLeft += shopCard.Width + 20;
			}
		}
	}
}
