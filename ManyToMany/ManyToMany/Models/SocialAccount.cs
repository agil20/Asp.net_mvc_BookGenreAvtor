namespace ManyToMany.Models
{
    public class SocialAccount
    {
        public int Id { get; set; }
       
        public string Linkedin { get; set; }
        public string Instagram { get; set; }
        public string Vkontakte { get; set; }
        public int AuthorId { get; set; }
        public Author Authors { get; set; }

    }
}
