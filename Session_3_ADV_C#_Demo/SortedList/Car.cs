namespace Session_3_ADV_C__Demo.SortedList
{
    internal class Car : IEquatable<Car> , IComparable<Car>
    {
        public Car(int id, string? model, decimal speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
        }

        public int Id { get; set; }

        public string? Model { get; set; }

        public decimal Speed { get; set; }

        public int CompareTo(Car? other)
        {
            if (other is null) return 1;
            return Speed.CompareTo(other.Speed);
        }

        public bool Equals(Car? other)
        {
            return other is not null &&
                   Id == other.Id &&
                   Model == other.Model &&
                   Speed == other.Speed;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Model, Speed);
        }

        public override string ToString()
        {
            return $"{Id} : {Model} : {Speed}";
        }

    }
}
