namespace BettingData.DAL.Entities
{
    public class Odd : Entity
    {
        public double Value { get; set; }

        public double? SpecialBetValue { get; set; }
    }
}
