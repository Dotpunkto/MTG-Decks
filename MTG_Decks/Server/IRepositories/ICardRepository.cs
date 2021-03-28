using MTG_Decks.Entities;
using System.Collections.Generic;

namespace MTG_Decks.Server.IRepositories
{
	public interface ICardRepository
	{
		void AddCardList(List<CardDto> cardList);
	}
}
