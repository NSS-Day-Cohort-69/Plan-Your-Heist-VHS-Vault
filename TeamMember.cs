// Create a class for the team member, have a Name, Skill level as an int, and a courage factor as a decimal of 0.0 - 2.0
// For courage factor write a setter function to only allow 0.0 - 2.0

class TeamMember
{
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public decimal CourageFactor
    {
        get { return filteredCourageFactor; }
        set
        {
            value = Math.Max(0, value);
            value = Math.Min(2, value);
            filteredCourageFactor = value;
        }
    }
    private decimal filteredCourageFactor;
}
