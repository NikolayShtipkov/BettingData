namespace BettingData.DAL.Entities
{
    public class Event : Entity
    {
        public bool IsLive { get; set; }

        public string CategoryId { get; set; }

        public List<Match> Matches { get; set; }
    }
}
