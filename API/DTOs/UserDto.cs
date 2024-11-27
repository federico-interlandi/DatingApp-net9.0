using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class UserDto
{

    public required string Username { get; set; }

    public required string token { get; set; }

    public string? PhotoUrl {get; set;}
}