namespace CardBoard{
    public class DeckCollection{
        private List<Deck> decks;

        public DeckCollection(){
            decks = new List<Deck>();
        }
        public bool AddDeck(Deck deck){
            if(decks.Count() < CardGame.amountOfDeckSlots){
                decks.Add(deck);
                return true;
            }else{
                return false;
            }
        }
    }
}