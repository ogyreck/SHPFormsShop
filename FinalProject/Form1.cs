using FinalProject.DAL;
using FinalProject.Model;

namespace FinalProject
{
	public partial class Form1 : Form
	{
		private List<ShopCardModel> _shopData = new List<ShopCardModel>();
		private ShopCardModel test = new ShopCardModel();

		public Form1()
		{

			InitializeComponent();
			GetShopData();
			cardPanel.AutoScroll = true;
		}


		private async Task GetShopData()
		{
			JsonData jsonData = new JsonData();
			_shopData = await jsonData.GetData();
		}
		private void btnLoad_Click(object sender, EventArgs e)
		{
			int marginLeft = 0;
			int marginTop = 0;
			foreach (var card in _shopData)
			{
				ShopCard shopCard = new ShopCard(card);
				if (marginLeft >= cardPanel.Width)
				{
					marginLeft = 0;
					marginTop += shopCard.Height + 20;
				}
				shopCard.Left = marginLeft;
				shopCard.Top = marginTop;

				cardPanel.Controls.Add(shopCard);
				marginLeft += shopCard.Width + 20;
			}


			btnLoad.Enabled = false;

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnOpenBasket_Click(object sender, EventArgs e)
		{
			BasketForm basketForm = new BasketForm();
			basketForm.ShowDialog();
			
		}
	}
}
