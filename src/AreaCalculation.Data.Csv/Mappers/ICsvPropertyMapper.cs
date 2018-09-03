using AreaCalculation.Domain;

namespace AreaCalculation.Data.Csv.Mappers
{
    public interface ICsvPropertyMapper
    {
        IProperty Map(string line);
    }
}