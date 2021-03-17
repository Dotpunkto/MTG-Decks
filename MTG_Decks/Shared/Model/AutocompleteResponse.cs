using System.Collections.Generic;

namespace MTG_Decks.Shared.Model
{
    public class AutocompleteResponse
    {
        public string Object { get; set; }
        public int Total_values { get; set; }
        public List<string> Data { get; set; }
    }
}