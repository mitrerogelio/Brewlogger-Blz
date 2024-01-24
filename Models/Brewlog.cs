using System.ComponentModel.DataAnnotations;

namespace Brewlogger_Blz.Models;

public class Brewlog
{
    public int? Id { get; }
    [Required]
    public string CoffeeName { get; set; }
    public int Dose { get; set; }
    [Required]
    public string Grind { get; set; }
    public int BrewRatio { get; set; }
    public string Roast { get; set; } = "";
    public string BrewerUsed { get; set; } = "";
    [Required]
    public int Rating { get; set; }
    public string? Notes { get; set; }
}