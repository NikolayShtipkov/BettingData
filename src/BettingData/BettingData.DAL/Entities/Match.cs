using BettingData.DAL.Enums;

namespace BettingData.DAL.Entities
{
    public class Match : Entity
    {
        public DateTime StartDate { get; set; }
        public MatchTypes MatchType { get; set; }
        public List<Bet> Bets { get; set; }
    }
}
