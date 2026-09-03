using System.ComponentModel.DataAnnotations;
using P12_Movie_Reservation_System_Backend.Enums;
using P12_Movie_Reservation_System_Backend.Models.DomainModels;

namespace P12_Movie_Reservation_System_Backend.Models.JunctionModels;

public class MovieCrew
{
    [Required]
    public int MovieId { get; set; }

    public Movie Movie { get; set; } = null!;

    [Required]
    public int CrewId { get; set; }

    public Crew Crew { get; set; } = null!;

    [Required]
    public CrewRole Role { get; set; } 
}