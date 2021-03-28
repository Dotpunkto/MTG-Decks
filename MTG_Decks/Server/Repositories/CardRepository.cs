using MTG_Decks.Server.DataAccess;
using MTG_Decks.Server.IRepositories;
using MTG_Decks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTG_Decks.Server.Repositories
{
	public class CardRepository : ICardRepository
	{

		readonly private MTG_Context _Context;

		public CardRepository(MTG_Context context) 
		{
			_Context = context;
		}

		public void AddCardList(List<CardDto> cardList)
		{
			_Context.Card.AddRange(cardList);
			_Context.SaveChanges();
		}

	}
}
