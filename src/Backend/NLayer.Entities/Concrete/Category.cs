using NLayer.Shared.Entities;

namespace NLayer.Entities.Concrete;

public class Category : EntityBaseId, IEntity
{
    public string Name { get; set; } = string.Empty;

    public ICollection<Post>? Posts { get; set; }
}
