namespace CardBoard
{
    public class Deck
{
    public string name { get; set; }
    public int id { get; set; }
    Random rand = new Random();
    public Deck(string name)
    {
        this.name = name;
        //random int in range
        this.id = rand.Next(0, 10000);
    }
    public addcard(Card card)
}
}
