using System;
using System.Collections.Generic;

namespace MTG_Decks.Shared.Model
{
    public class Card
    {
        public string Object { get; set; }
        public string ID { get; set; }
        public string Oracle_id { get; set; }
        public List<int> Multiverse_ids { get; set; }
        public int Mtgo_id { get; set; }
        public int Mtgo_foil_id { get; set; }
        public int Tcgplayer_id { get; set; }
        public int Cardmarket_id { get; set; }
        public string Name { get; set; }
        public string Lang { get; set; }
        public string Released_at { get; set; }
        public string URI { get; set; }
        public string Scryfall_uri { get; set; }
        public string Layout { get; set; }
        public bool Highres_image { get; set; }
        public ImageUris Image_uris { get; set; } = new ImageUris();
        public string Mana_cost { get; set; }
        public float CMC { get; set; }
        public string Type_line { get; set; }
        public string Oracle_text { get; set; }
        public string Power { get; set; }
        public string Toughness { get; set; }
        public List<string> Colors { get; set; }
        public List<string> Color_identity { get; set; }
        public List<string> Keywords { get; set; }// TODO
        public Legalities Legalities { get; set; }
        public List<string> Games { get; set; }
        public bool Reserved { get; set; }
        public bool Foil { get; set; }
        public bool Nonfoil { get; set; }
        public bool Oversized { get; set; }
        public bool Promo { get; set; }
        public bool Reprint { get; set; }
        public bool Variation { get; set; }
        public string Set { get; set; }
        // public string set_name { get; set; }
        public string Set_type { get; set; }
        // public string set_uri { get; set; }
        public string Set_search_uri { get; set; }
        public string Scryfall_set_uri { get; set; }
        public string Rulings_uri { get; set; }
        public string Prints_search_uri { get; set; }
        public string Collector_number { get; set; }
        public bool Digital { get; set; }
        public string Rarity { get; set; }
        public string Flavor_text { get; set; }
        public string Card_back_id { get; set; }
        public string Artist { get; set; }
        public List<string> Artist_ids { get; set; }
        public string Illustration_id { get; set; }
        public string Border_color { get; set; }
        public string Frame { get; set; }
        public bool Full_art { get; set; }
        public bool Textless { get; set; }
        public bool Booster { get; set; }
        public bool Story_spotlight { get; set; }
        public int Edhrec_rank { get; set; }
        public Prices Prices { get; set; }
        public RelatedUris Related_uris { get; set; }
        public PurchaseUris Purchase_uris { get; set; }
    }
}