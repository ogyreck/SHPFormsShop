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
	public partial class ProductForm : Form
	{
		private readonly ShopCardModel _shopCardModel;
		public ProductForm(ShopCardModel shopCardModel)
		{
			_shopCardModel = shopCardModel;
			InitializeComponent();

			nameProduct.Text = _shopCardModel.title;
			productPrice.Text = _shopCardModel.price.ToString();
			productPictureBox.LoadAsync(_shopCardModel.image);
			productCategory.Text = _shopCardModel.category;
			productDescript.Text = _shopCardModel.description;

			Shown += ProductForm_Shown;
			FormClosed += ProductForm_FormClosed;
		}

		private void ProductForm_FormClosed(object? sender, FormClosedEventArgs e)
		{
		    ///Баг, при закрытии формы не обновляются главная страница 
			//DisplayElements.ShowMainItemsData();
		}

		private void ProductForm_Shown(object? sender, EventArgs e)
		{
			if (basketShop.ContainsInBasket(_shopCardModel))
			{
				productBuyBtn.BackColor = Color.Green;
				productBuyBtn.Text = "В корзине";
			}
		}

		private void productBuyBtn_Click(object sender, EventArgs e)
		{
			
			basketShop.AddBasketItem(_shopCardModel);
			if (basketShop.ContainsInBasket(_shopCardModel))
			{
				productBuyBtn.BackColor = Color.Green;
				productBuyBtn.Text = "В корзине";
			}
		}
	}
}
