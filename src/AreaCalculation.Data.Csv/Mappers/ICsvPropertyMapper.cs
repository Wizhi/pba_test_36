using AreaCalculation.Domain;

namespace AreaCalculation.Data.Csv.Mappers
{
    public interface ICsvPropertyMapper
    {
        Property Map(string line);
    }
}