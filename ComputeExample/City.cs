using System.ComponentModel.DataAnnotations;

namespace ComputeExample
{
  public class City
  {
    [Key]
    public Guid Id { get; set; }

    public String Name { get; set; }
  }
}
