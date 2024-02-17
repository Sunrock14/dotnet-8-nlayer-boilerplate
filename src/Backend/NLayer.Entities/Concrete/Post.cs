using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Entities.Concrete;

public class Post
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public bool IsFavorite { get; set; } = false;


    public int UserId { get; set; }
    public User User { get; set; } = new();
    public int TypeId { get; set; }
    public Type Type { get; set; } = new();
    public int CategoryId { get; set; }
    public Category Category { get; set; } = new();
}
