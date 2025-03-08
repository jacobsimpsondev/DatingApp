using System;

namespace API.Entities;

public class Location
{
    public int Id { get; set; }

    public required string LocationName { get; set; }

    public string? Contact { get; set; }
}
