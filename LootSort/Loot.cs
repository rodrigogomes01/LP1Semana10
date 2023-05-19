namespace LootSort
{
    /// <summary>
    /// The Loot class should implement IComparable<Loot>
    /// and override GetHashCode() and Equals()
    /// </summary>
    public class Loot
    {
        public override int GetHashCode() =>
            Kind.GetHashCode() ^ Description.GetHashCode() ^ Value.GetHashCode();

        public override bool Equals(object obj) =>
            obj is Loot loot && loot.Kind == Kind && loot.Description == Description && loot.Value == Value;

        // Implement IComparable<Loot>
        public int CompareTo(Loot other)
        {
            // If the other object is null, then this object is greater.
            if (other == null)
            {
                return 1;
            }

            // Compare the loot types.
            int result = Kind.CompareTo(other.Kind);

            // If the loot types are equal, compare the loot descriptions.
            if (result == 0)
            {
                result = Description.CompareTo(other.Description);
            }

            // If the loot descriptions are equal, compare the loot values.
            if (result == 0)
            {
                result = Value.CompareTo(other.Value);
            }

            return result;
        }

        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }

        /// <summary>
        /// Create a new instance of loot.
        /// </summary>
        /// <param name="kind">Type of loot.</param>
        /// <param name="description">Loot description.</param>
        /// <param name="value">Loot value.</param>
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        /// <summary>
        /// Return a nicely formatted string representing the loot instance.
        /// </summary>
        /// <returns>
        /// A nicely formatted string representing the loot instance.
        /// </returns>
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";
    }
}