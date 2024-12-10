namespace Design.Patterbs.Ripiper.Builder.GOOD;

public class House
{
    public int Bedrooms { get; private set; }
    public int Bathrooms { get; private set; }
    public bool HasGarage { get; private set; }
    public bool HasSwimmingPool { get; private set; }
    public bool HasGarden { get; private set; }
    
    public House() { }
    
    public void DisplayHouseInfo()
    {
        Console.WriteLine($"House with {Bedrooms},{Bathrooms} bathrooms , garage: {HasGarage}, Swing: {HasSwimmingPool}, Garden: {HasGarden}");
    }
    
    public class Builder
    {
        private readonly House _house;

        public Builder()
        {
            _house = new House();
        }

        public Builder setBedrooms(int bedrooms)
        {
            _house.Bedrooms = bedrooms;
            return this;
        }

        public Builder setBathrooms(int bathrooms)
        {
            _house.Bathrooms = bathrooms;
            return this;
        }

        public Builder setHasGarage(bool hasGarage)
        {
            _house.HasGarage = hasGarage;
            return this;
        }

        public Builder setHasSwimmingPool(bool hasSwimmingPool)
        {
            _house.HasSwimmingPool = hasSwimmingPool;
            return this;
        }

        public Builder setHasGarden(bool hasGarden)
        {
            _house.HasGarden = hasGarden;
            return this;
        }

        public House Build()
        {
            return _house;
        }
    }
}