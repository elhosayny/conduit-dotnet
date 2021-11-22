using Conduit.Domain.Models.Shared;

namespace Conduit.Domain.Models
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public ICollection<int> FavoriteArticleIds { get; set; }
        public ICollection<int> FollowerIds { get; set; }
    }
}
