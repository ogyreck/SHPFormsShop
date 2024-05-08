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
		}

		private void productBuyBtn_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Вы купили {_shopCardModel.title}");
		}
	}
}
