// See https://aka.ms/new-console-template for more information
//Create a main function
//Print message Plan your heist
//Create a team member for which will prompt the user to create a team member and save the created team members info
//Print the team members information

List<TeamMember> teamMembers = new List<TeamMember>();

void Main()
{
    Console.WriteLine("Plan your heist!");
    for (int i = 0; i < 100; i++)
    {
        TeamMember teamMember = TeamMemberForm();
        if (teamMember == null)
        {
            break;
        }
        teamMembers.Add(teamMember);
    }

    Console.WriteLine(teamMembers.Count);
    foreach (TeamMember teamMember in teamMembers)
    {
        Console.WriteLine($"{teamMember.Name} {teamMember.SkillLevel} {teamMember.CourageFactor}");
    }
    //display message containing the number of members of the team
    //loop through team members
    //make function that displays team member's information
}

TeamMember TeamMemberForm()
{
    string name;
    int skillLevel;
    decimal courageFactor;
    Console.WriteLine("Enter a team member's name.");
    name = Console.ReadLine();
    if (name == "")
    {
        return null;
    }
    Console.WriteLine("Enter a skill level");
    skillLevel = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter a courage factor (between 0 and 2)");
    courageFactor = decimal.Parse(Console.ReadLine());

    TeamMember teamMember = new TeamMember()
    {
        Name = name,
        SkillLevel = skillLevel,
        CourageFactor = courageFactor
    };

    return teamMember;
}

Main();
