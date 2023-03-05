using System.ComponentModel.DataAnnotations;

namespace ETicketWebApp.Models
{
  public class Actor
  {
    [Key]
    public int ActorId { get; set; }

    [Display(Name ="Profile Picture")]
    public string ProfilePictureUrl { get; set; }
    [Display(Name = "Full Name")]
    public string FullName { get; set; }
    [Display(Name = "Biograpghy")]
    public string Bio { get; set; }

    //Relationships
    public List<LinkActor_Movie> LinkActor_Movies { get; set; }
  }
}
