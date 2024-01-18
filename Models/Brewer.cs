namespace Brewlogger_Blz.Models;

public class Brewer
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string PageUrl { get; set; }
    public string Description { get; set; }
    public int StartingDose { get; set; }
    public int StartingRatio { get; set; }
}