using Conduit.Domain.Models.Shared;

namespace Conduit.Domain.Models
{
    public class Comment : BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
    }
}
