using MTG_Decks.Shared.Model;
using Newtonsoft.Json.Linq;
using Quartz;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using MTG_Decks.Entities;
using System.Linq;
using MTG_Decks.Server.IRepositories;
using MTG_Decks.Server.Services;

namespace MTG_Decks.Server.Job
{
	public class BulkDataJob : IJob
	{

		readonly CardService _CardService;

		public BulkDataJob() 
		{
			_CardService = new CardService();
		}

		public async Task Execute(IJobExecutionContext context) // TODO : Mettre en place la tache mensuelle pour mettre à jour la base de données
		{
			//string downloadURl = GetDownloadURl();
			//List<Card> cardList = DownLoad(downloadURl);
			//List<CardDto> cardDtoList = _CardService.CreateCardDto(cardList);
			//_CardService.AddCardList(cardDtoList.ToList());
			await Console.Out.WriteLineAsync("HelloJob is executing.");
		}

		private string GetDownloadURl()
		{
			string uri = "https://api.scryfall.com/bulk-data/default_cards";
			string result = GetStream(uri);
			JObject resource = JObject.Parse(result);
			return resource.Property("download_uri").Value.ToString();
		}

		private List<Card> DownLoad(string uri)
		{
			string response = GetStream(uri);
			return JsonConvert.DeserializeObject<List<Card>>(response);
		}

		private string GetStream(string uri)
		{
			WebClient webClient = new WebClient();
			Stream stream = webClient.OpenRead(uri);
			StreamReader streamReader = new StreamReader(stream);
			return streamReader.ReadToEnd();
		}
	}
}
