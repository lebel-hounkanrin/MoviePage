using System.ComponentModel.DataAnnotations;

namespace webapp.Models;

public class Movie
{
    public int Id { get;}
    public string? Title { get; set; }
    public string? Genre { get; set; }
    public Decimal Price { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    
}