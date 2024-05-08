using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
	public static class basketShop
	{
		private static List<ShopCardModel> _basketShopData = new List<ShopCardModel>();

		public static List<ShopCardModel> GetBasketData()
		{
			return _basketShopData;
		}

		public static bool AddBasketItem(ShopCardModel model)
		{
			if (!_basketShopData.Contains(model))
			{
				_basketShopData.Add(model);
				return true;
			}
			return false;
		}

		public static bool RemoveBasketItem(ShopCardModel model)
		{
			if (_basketShopData.Contains(model))
			{
				_basketShopData.Remove(model);
				return true;
			}
			return false;
		}

		public static int GetCountBasket()
		{
			return (int)_basketShopData.Count;
		}
		public static double GetSumBascket()
		{
			double sumProduct = 0;
			foreach(var item in _basketShopData)
			{
				sumProduct += item.price;
			}

			return sumProduct;
		}
	}
}
