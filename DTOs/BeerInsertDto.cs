namespace Backend.DTOs
{
    public class BeerInsertDto
    {
        public string? Name { get; set; }  //El Signo de interrogación (?) hace que el campo permita Null.
        public int BrandID { get; set; }
        public decimal Alcohol { get; set; }
    }
}
