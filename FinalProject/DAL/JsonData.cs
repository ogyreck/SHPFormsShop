using FinalProject.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
	public class JsonData
	{
		private HttpClient client = new HttpClient();
       
		public async Task<List<ShopCardModel>> GetData()
		{
			List<ShopCardModel> shopCards = new List<ShopCardModel>();

			HttpResponseMessage responseGet = await client.GetAsync(Helper.apiString);
			if (responseGet.IsSuccessStatusCode)
			{
				string json  = await responseGet.Content.ReadAsStringAsync();
				 shopCards = JsonConvert.DeserializeObject<List<ShopCardModel>>(json);
				return shopCards;
			}
			return shopCards;

		}

		

       
	}
}
