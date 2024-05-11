using FinalProject.BL;
using FinalProject.DAL;
using FinalProject.Model;

namespace FinalProject
{
	public partial class Form1 : Form
	{
		private List<ShopCardModel> _shopData = new List<ShopCardModel>();
		

		public Form1()
		{

			InitializeComponent();
			DisplayElements.panelInMainForms = cardPanel;
			GetShopData();
			
			cardPanel.AutoScroll = true;
			

		}


		private async Task GetShopData()
		{
			JsonData jsonData = new JsonData();
			_shopData = await jsonData.GetData();
			DisplayElements.dataShop = _shopData;
			DisplayElements.ShowMainItemsData();

		}
		private void btnLoad_Click(object sender, EventArgs e)
		{
			
			btnLoad.Enabled = false;

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		

		private void btnOpenBasket_Click(object sender, EventArgs e)
		{
			BasketForm basketForm = new BasketForm();
			basketForm.FormClosed += BasketForm_FormClosed;
			basketForm.Show();
		}

		private void BasketForm_FormClosed(object? sender, FormClosedEventArgs e)
		{
			DisplayElements.ShowMainItemsData();
		}

		public List<ShopCardModel> GetCurrencyData()
		{
			return _shopData;
		}
	}
}
