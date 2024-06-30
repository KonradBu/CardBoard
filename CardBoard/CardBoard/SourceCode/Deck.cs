namespace CardBoard
{
    public class Deck
    {
        public string name { get; set; }
        public int id { get; set; }
        Random rand = new Random();
        public List<Card>[] deckparts = new List<Card>[CardGame.amountOfDeckParts];
        public Deck(string name)
        {
            this.name = name;
            this.id = rand.Next(0, 10000);
        }
        public bool addcard(Card card, int deckpart){
            if(deckparts[deckpart].Count < CardGame.upperLimitCardsDeckParts[deckpart]){
                deckparts[deckpart].Add(card);
                return true;
            }else{
                return false;
            }
        }
    }
}
