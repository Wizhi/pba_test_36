using AreaCalculation.Domain;

namespace AreaCalculation.Data.Csv
{
    public class CsvPropertyMapper : ICsvPropertyMapper
    {
        public Property Map(string line)
        {
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
            
            return new Property(propertyNumber, propertySquareMeters, propertyRooms);
        }

        private string RemoveQuotes(string item)
        {
            return item.Replace('"', ' ');
        }
    }
}