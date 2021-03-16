using System;
using System.Collections.Generic;
using System.Text;

namespace MTG_Decks.Shared.Model
{ 
	public class ResponseCardType
	{
		public string Object { get; set; }
		public string URI { get; set; }
		public int Total_values { get; set; }
		public List<string> Data { get; set; }
	}
}
