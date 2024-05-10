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
	public partial class ShopCard : UserControl
	{
		

		private readonly ShopCardModel _shopCardModel;
		private ProductForm productForm;
		public ShopCard(ShopCardModel shopCardModel)
		{
			InitializeComponent();
			_shopCardModel = shopCardModel;

			NameCard.Text = _shopCardModel.title;
			CostCard.Text = _shopCardModel.price.ToString();
			cardPicture.LoadAsync(_shopCardModel.image);

			productForm = new ProductForm(_shopCardModel);
			ChekBasket();

		}

		
		private void BuyBtn_Click(object sender, EventArgs e)
		{
			basketShop.AddBasketItem(_shopCardModel);
			ChekBasket();

		}

		private void ChekBasket()
		{
			if (basketShop.ContainsInBasket(_shopCardModel))
			{
				BuyBtn.Text = "В корзине";
				BuyBtn.BackColor = Color.Green;
			}
			else
			{
				BuyBtn.Text = "Купить";
				BuyBtn.BackColor = Color.Red;
			}
		}

		private void NameCard_Click(object sender, EventArgs e)
		{
			productForm.ShowDialog();
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void ShopCard_Load(object sender, EventArgs e)
		{

		}

		private void ShopCard_Click(object sender, EventArgs e)
		{
			productForm.ShowDialog();
		}

		private void cardPicture_Click(object sender, EventArgs e)
		{
			productForm.ShowDialog();
		}
	}
}
