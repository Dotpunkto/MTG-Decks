namespace MTG_Decks.Shared.Model
{
    public class ImageUris
    {
        private const string Empty = "";

        public int ID { get; set; }
        public string Small { get; set; } = Empty;
        public string Normal { get; set; } = Empty;
        public string LLarge { get; set; } = Empty;
        public string PNG { get; set; } = Empty;
        public string Art_crop { get; set; } = Empty;
        public string Border_crop { get; set; } = Empty;
    }
}