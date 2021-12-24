using Sieve.Attributes;

namespace Demo_SieveLibrary
{
    public class Product
    {
        public string Id { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public string Name { get; set; }
        [Sieve(CanFilter = true, CanSort = false)]
        public string Category { get; set; }
        public string Description { get; set; }
        [Sieve(CanFilter = false, CanSort = true)]
        public float Weight { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public float Price { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public float Cost { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public float Stock { get; set; }
        public string MeasureUnit { get; set; }
    }
}
