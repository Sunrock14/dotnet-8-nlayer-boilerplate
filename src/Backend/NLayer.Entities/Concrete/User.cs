using NLayer.Shared.Entities;

namespace NLayer.Entities.Concrete;

public class User : EntityBaseId, IEntity
{
    public string Name { get; set; } = string.Empty;
    public string SurName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public ICollection<Post>? Posts { get; set; }
}
