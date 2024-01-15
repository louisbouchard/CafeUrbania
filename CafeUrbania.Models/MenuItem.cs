namespace CafeUrbania.Models;

public class MenuItem
{
    public int Id { get; set; }
    public string Slug { get; set; }
    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public string ImageFile { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
}
