namespace BettingData.DAL.Entities
{
    public class Sport : Entity
    {
        public List<Event> Events { get; set; }
    }
}
