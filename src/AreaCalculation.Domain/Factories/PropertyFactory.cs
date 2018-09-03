namespace AreaCalculation.Domain.Factories
{
    public class PropertyFactory : IPropertyFactory
    {
        public IProperty Create(int number, double squareMeters, double rooms)
        {
            return new Property(number, squareMeters, rooms);
        }
    }
}