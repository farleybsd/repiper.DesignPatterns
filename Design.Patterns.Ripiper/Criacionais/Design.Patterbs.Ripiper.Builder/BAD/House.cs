namespace Design.Patterbs.Ripiper.Builder.BAD;

public class House
{
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public bool HasGarage { get; set; }
    public bool HasSwimmingPool { get; set; }
    public bool HasGarden { get; set; }

    // Problema 1: Construtor com muitos parametros
    // Problema 2: Dificuldade Configuracoes Adicionais
    public House(int bedrooms, int bathrooms, bool hasGarage, bool hasSwimmingPool, bool hasGarden)
    {
        Bedrooms = bedrooms;
        Bathrooms = bathrooms;
        HasGarage = hasGarage;
        HasSwimmingPool = hasSwimmingPool;
        HasGarden = hasGarden;
    }

    public void DisplayHouseInfo()
    {
        Console.WriteLine($"House with {Bedrooms},{Bathrooms} bathrooms , garage: {HasGarage}, Swing: {HasSwimmingPool}, Garden: {HasGarden}");
    }
}