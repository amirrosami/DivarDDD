using Bazzar.Core.Domain.Advertisements.ValueObjects;
using Framework.Domain.Entities;

namespace Bazzar.Core.Domain.Advertisements.Entities
{
    public class Picture:BaseEntity<Guid>
    {
        public PictureUrl  PictureUrl { get; set; }
    }
}
