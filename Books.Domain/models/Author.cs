using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Domain.models;

public class Author : IBaseEntity
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Required]
    [ForeignKey("country")]
    public int CountryId { get; set; }
    public Country Country { get; set; }
    
    public DateTime BirthDate { get; set; }
    
    public ICollection<Book> Books { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}