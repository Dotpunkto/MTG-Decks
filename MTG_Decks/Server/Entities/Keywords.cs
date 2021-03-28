using System;
using System.Collections.Generic;
using System.Text;

namespace MTG_Decks.Entities
{
	public class Keywords
	{
		public int ID { get; set; }
		public string Keyword { get; set; }
		public CardDto Card { get; set; }
	}
}
