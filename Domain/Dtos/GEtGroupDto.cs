using System.ComponentModel.DataAnnotations;

public class GEtGroupDto
{
     public int Id { get; set; } 
    public string GroupNick { get; set; }
    public bool NeededMember { get; set; }
    public string TeamSlogan { get; set; }
    public DateTimeOffset CreatedAt { get; set; } 
    public int ChallengeId { get; set; }  
}