namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// the uniq identifier  for the prize
        /// </summary>
        public int id { get; set; }
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

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercantage)
        {
            PlaceName = placeName;
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercantage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;


        }
    }
}