namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the number of places
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Specifies the name of the particular place
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the price amount we are going to assign to this place
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of amount we are going to assign to this place
        /// </summary>
        public double PrizePercentage { get; set; }

    }
}