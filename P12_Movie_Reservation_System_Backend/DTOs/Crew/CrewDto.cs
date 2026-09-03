using P12_Movie_Reservation_System_Backend.Enums;

namespace P12_Movie_Reservation_System_Backend.DTOs.Movie;

public class CrewDto 
{
    public int CrewId { get; set; } 
    public string Name { get; set; } = string.Empty;
    public CrewRole Role { get; set; } 
}