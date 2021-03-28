using System;
using System.Collections.Generic;
using System.Text;

namespace MTG_Decks.Entities
{
	public class ProducedMana
	{
		public int ID { get; set; }
		public string Mana { get; set; }
		public CardDto Card { get; set; }
	}
}
