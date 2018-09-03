namespace AreaCalculation.Domain
{
    public interface IProperty
    {
        int Number { get; }
        double SquareMeters { get; }
        double Rooms { get; }
    }
}