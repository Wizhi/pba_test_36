using AreaCalculation.Domain;
using AreaCalculation.Domain.Factories;

namespace AreaCalculation.Data.Csv.Mappers
{
    public class CsvPropertyMapper : ICsvPropertyMapper
    {
        private readonly IPropertyFactory _propertyFactory;

        public CsvPropertyMapper(IPropertyFactory propertyFactory)
        {
            _propertyFactory = propertyFactory;
        }

        public IProperty Map(string line)
        {
            // Assume line is csv
            var parts = line.Split(',');

            if (!int.TryParse(RemoveQuotes(parts[0]), out var propertyNumber))
            {
                // TODO: handle invalid or missing data
            }
            
            if (!double.TryParse(RemoveQuotes(parts[1]), out var propertySquareMeters))
            {
                // TODO: handle invalid or missing data
            }
            
            if (!double.TryParse(RemoveQuotes(parts[2]), out var propertyRooms))
            {
                // TODO: handle invalid or missing data
            }
            
            return _propertyFactory.Create(propertyNumber, propertySquareMeters, propertyRooms);
        }

        private string RemoveQuotes(string item)
        {
            return item.Replace('"', ' ');
        }
    }
}