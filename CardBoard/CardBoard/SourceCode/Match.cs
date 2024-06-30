using System.Text.RegularExpressions;

namespace CardBoard{
    public class Game{
        public Player[] players;
        public int[] playertimer;
        public CardGameRules cardGameRules;
        public MatchRules matchRules;

        public Game(Player[] playersinput, CardGameRules cardGameRulesinput, MatchRules matchRulesinput){
            this.players = playersinput;
            this.cardGameRules = cardGameRulesinput;
            this.matchRules = matchRulesinput;
            playertimer = new int[players.Length];
            for(int i = 0; i < playertimer.Length; i++){
                playertimer[i] = matchRules.timelimit;
            }
        }
    }
}