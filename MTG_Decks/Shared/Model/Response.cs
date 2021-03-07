using System;
using System.Collections.Generic;
using System.Text;

namespace MTG_Decks.Shared.Model
{
    public class Response
    {
        public string Object { get; set; }
        public int Total_cards { get; set; }
        public bool Has_more { get; set; }
        public string Next_page { get; set; }
        public List<Card> Data { get; set; }
    }
}
