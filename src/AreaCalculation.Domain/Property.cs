namespace AreaCalculation.Domain
{
    public class Property
    {
        public Property(int number, double squareMeters, double rooms)
        {
            Number = number;
            SquareMeters = squareMeters;
            Rooms = rooms;
        }

        public int Number { get; }
        public double SquareMeters { get; }
        public double Rooms { get; }
    }
}