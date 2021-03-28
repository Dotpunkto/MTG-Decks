using MTG_Decks.Entities;
using MTG_Decks.Server.DataAccess;
using MTG_Decks.Server.IRepositories;
using MTG_Decks.Server.Repositories;
using MTG_Decks.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTG_Decks.Server.Services
{
	public class CardService
	{
		readonly ICardRepository _CardRepository;

		public CardService(ICardRepository cardRepository) 
		{
			MTG_Context context = new MTG_Context();
			_CardRepository = new CardRepository(context);
		}

		public CardService()
		{
		}

		public void AddCardList(List<CardDto> cardList)
		{
			_CardRepository.AddCardList(cardList);
		}

		public List<CardDto> CreateCardDto(List<Card> cardList)
		{
			return cardList.Select(i => new CardDto()
			{
				Object = i.Object,
				Oracle_id = i.Oracle_id,
				Multiverse_ids = CreateMultiverseIDSList(i.Multiverse_ids),
				Mtgo_id = i.Mtgo_id,
				Mtgo_foil_id = i.Mtgo_foil_id,
				Tcgplayer_id = i.Tcgplayer_id,
				Cardmarket_id = i.Cardmarket_id,
				Name = i.Name,
				Lang = i.Lang,
				Released_at = i.Released_at,
				URI = i.URI,
				Scryfall_uri = i.Scryfall_uri,
				Layout = i.Layout,
				Highres_image = i.Highres_image,
				Image_uris = i.Image_uris,
				Mana_cost = i.Mana_cost,
				CMC = i.CMC,
				Type_line = i.Type_line,
				Oracle_text = i.Oracle_text,
				Power = i.Power,
				Toughness = i.Toughness,
				Colors = CreateColorList(i.Colors),
				Color_identity = CreateColorIdentityList(i.Color_identity),
				Keywords = CreateKeywordsList(i.Keywords),
				Produced_mana = CreateProducedManaList(i.Produced_mana),
				Legalities = i.Legalities,
				Games = CreateGamesList(i.Games),
				Reserved = i.Reserved,
				Foil = i.Foil,
				Nonfoil = i.Nonfoil,
				Oversized = i.Oversized,
				Promo = i.Promo,
				Reprint = i.Reprint,
				Variation = i.Variation,
				Set = i.Set,
				Set_type = i.Set_type,
				Set_search_uri = i.Set_search_uri,
				Scryfall_set_uri = i.Scryfall_set_uri,
				Rulings_uri = i.Rulings_uri,
				Prints_search_uri = i.Prints_search_uri,
				Collector_number = i.Collector_number,
				Digital = i.Digital,
				Rarity = i.Rarity,
				Flavor_text = i.Flavor_text,
				Card_back_id = i.Card_back_id,
				Artist = i.Artist,
				Artist_ids = CreateArtistIDSList(i.Artist_ids),
				Illustration_id = i.Illustration_id,
				Border_color = i.Border_color,
				Frame = i.Frame,
				Full_art = i.Full_art,
				Textless = i.Textless,
				Booster = i.Booster,
				Story_spotlight = i.Story_spotlight,
				Edhrec_rank = i.Edhrec_rank,
				Prices = i.Prices,
				Related_uris = i.Related_uris,
				Purchase_uris = i.Purchase_uris
			}).ToList();
		}

		private List<MultiverseIDS> CreateMultiverseIDSList(List<int> MultiverseIDSList)
		{
			if (MultiverseIDSList == null) { return null; }
			return MultiverseIDSList.Select(e => new MultiverseIDS()
			{
				Multiverse_ids = e
			}).ToList();
		}

		private List<Colors> CreateColorList(List<string> colorList)
		{
			if (colorList == null) { return null; }
			return colorList.Select(e => new Colors()
			{
				Color = e
			}).ToList();
		}

		private List<ColorIdentity> CreateColorIdentityList(List<string> colorIdentityList)
		{
			if (colorIdentityList == null) { return null; }
			return colorIdentityList.Select(e => new ColorIdentity()
			{
				Color = e
			}).ToList();
		}

		private List<Keywords> CreateKeywordsList(List<string> keywordsList)
		{
			if (keywordsList == null) { return null; }
			return keywordsList.Select(e => new Keywords()
			{
				Keyword = e
			}).ToList();
		}

		private List<ProducedMana> CreateProducedManaList(List<string> producedManaList)
		{
			if (producedManaList == null) { return null; }
			return producedManaList.Select(e => new ProducedMana()
			{
				Mana = e
			}).ToList();
		}

		private List<Games> CreateGamesList(List<string> gameList)
		{
			if (gameList == null) { return null; }
			return gameList.Select(e => new Games()
			{
				Game = e
			}).ToList();
		}

		private List<ArtistIDS> CreateArtistIDSList(List<string> artistList)
		{
			if (artistList == null) { return null; }
			return artistList.Select(e => new ArtistIDS()
			{
				Artist_id = e
			}).ToList();
		}
	}
}
