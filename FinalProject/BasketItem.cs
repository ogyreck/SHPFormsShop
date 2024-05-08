using FinalProject.BL;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
	public partial class BasketItem : UserControl
	{
		private readonly ShopCardModel _shopCardModel;
		
		public BasketItem(ShopCardModel shopCardModel)
		{
			InitializeComponent();
			_shopCardModel = shopCardModel;
			itemPictureBox.LoadAsync(_shopCardModel.image);
			itemName.Text = _shopCardModel.title;
			itemCost.Text = _shopCardModel.price.ToString();

		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			basketShop.RemoveBasketItem(_shopCardModel);
			DisplayElements.ShowBasketItem(basketShop.GetBasketData());

		}

		private void openProductFrom(object sender, EventArgs e)
		{
			ProductForm productForm = new ProductForm(_shopCardModel);
			productForm.ShowDialog();
		}
	}
}
