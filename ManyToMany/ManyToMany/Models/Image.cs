namespace ManyToMany.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMain { get; set; }
        public int BookId { get; set; }
        public Book book { get; set; }
    }
}
