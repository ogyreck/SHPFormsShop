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
	public partial class BasketForm : Form
	{

		
		public BasketForm()
		{
			InitializeComponent();
			DisplayElements.panel = itemsBasketPanel;
			itemsBasketPanel.AutoScroll = true;
			DisplayElements.ShowBasketItem(basketShop.GetBasketData());
		}

		private void button1_Click(object sender, EventArgs e)
		{

			this.Close();
		}

		private void btnTotalSum_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Общая сумма заказа {basketShop.GetSumBascket()}");
		}
	}
}
