namespace PawPalQoL.Models
{
    public class QualityOfLifeModel
    {
        // User input properties
        public int Pain { get; set; }
        public int Mobility { get; set; }
        public int Appetite { get; set; }
        public int Happiness { get; set; }

        // Calculated result
        public int TotalScore
        {
            get
            {
                return Pain + Mobility + Appetite + Happiness;
            }
        }
    }
}
