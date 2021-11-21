using Conduit.Domain.Models.Shared;

namespace Conduit.Domain.Models
{
    public class Tag : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}