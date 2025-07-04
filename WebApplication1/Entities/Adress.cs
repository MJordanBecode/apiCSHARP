namespace WebApplication1.Entities;

public class Address
{
            public int Id { get; set; }
            public string StreetNumber { get; set; } = string.Empty;
            public int ZipCode { get; set; } 
            public string Town { get; set; }
            public string Country { get; set; }
}