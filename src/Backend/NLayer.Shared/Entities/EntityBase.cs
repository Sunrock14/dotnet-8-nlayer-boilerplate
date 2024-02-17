namespace NLayer.Shared.Entities;

public abstract class EntityBase
{
    public virtual Guid Id { get; set; }
    public virtual DateTime CreatedDate { get; set; }
    public virtual DateTime ModifiedDate { get; set; }
    public virtual DateTime IsDeleted { get; set; }
}
