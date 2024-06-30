namespace CardBoard
{
    public class Player
    {
        public string name { get; set; }
        public int id { get; set; }
        public int rating { get; set; }
        public Collection collection { get; set; }
        public DeckCollection deckCollection { get; set; }
        public Deck activedeck { get; set; }
        public Player(string name, int id)
        {
            this.name = name;
            this.id = id;
            this.rating = 0;
            this.collection = new Collection();
            this.deckCollection = new DeckCollection();
        }
    }
}