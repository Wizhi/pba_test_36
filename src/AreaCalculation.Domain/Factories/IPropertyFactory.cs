namespace AreaCalculation.Domain.Factories
{
    public interface IPropertyFactory
    {
        IProperty Create(int number, double squareMeters, double rooms);
    }
}