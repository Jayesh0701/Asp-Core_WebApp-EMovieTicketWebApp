using System.ComponentModel.DataAnnotations;

namespace ETicketWebApp.Models
{
  public class Producer
  {
    [Key]
    public int ProducerId { get; set; }

    [Display(Name = "Profile Picture")]
    public string ProfilePictureUrl { get; set; }
    [Display(Name = "Full Name")]
    public string FullName { get; set; }
    [Display(Name = "Biograpghy")]
    public string Bio { get; set; }

    //RelationShips
    public List<Movie> Movies { get; set; }
  }
}
