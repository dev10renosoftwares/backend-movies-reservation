using System.ComponentModel.DataAnnotations;
using P12_Movie_Reservation_System_Backend.Models.JunctionModels;

namespace P12_Movie_Reservation_System_Backend.Models.DomainModels;

public class Crew
{
    [Key]
    public int CrewId { get; set; }

    [Required]
    [StringLength(200)]
    public string Name { get; set; } = string.Empty;

    public ICollection<MovieCrew> MovieCrews { get; set; }
        = new List<MovieCrew>();
}