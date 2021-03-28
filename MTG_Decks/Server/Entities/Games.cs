using System;
using System.Collections.Generic;
using System.Text;

namespace MTG_Decks.Entities

{
	public class Games
	{
		public int ID { get; set; }
		public string Game{ get; set; }
		public CardDto Card { get; set; }
	}
}
