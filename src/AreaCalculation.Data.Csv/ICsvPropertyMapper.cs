using AreaCalculation.Domain;

namespace AreaCalculation.Data.Csv
{
    public interface ICsvPropertyMapper
    {
        Property Map(string line);
    }
}