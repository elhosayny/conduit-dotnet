using Conduit.Domain.Models.Shared;

namespace Conduit.Domain.Models
{
    public class Article : BaseEntity
    {
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public int FavoritesCount { get; set; }
        public int AuthorId { get; set; }
    }
}
