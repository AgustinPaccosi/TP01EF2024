namespace TP01EF2024.Entidades
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; } = null!;
        public ICollection<Shoe> Shoes { get; set; }= new List<Shoe>();
    }
}
