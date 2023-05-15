namespace Service.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public bool Recommended { get; set; }
        public string Image { get; set; }
    }
}
