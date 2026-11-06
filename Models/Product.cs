using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleProductCRUD.Models;

[Table("tblProduct", Schema = "dbo")]
public class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public double Price { get; set; }

    public DateTime CreatedDate { get; set; }
}
