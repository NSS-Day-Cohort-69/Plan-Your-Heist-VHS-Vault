// See https://aka.ms/new-console-template for more information
//Create a main function
//Print message Plan your heist
//Create a team member for which will prompt the user to create a team member and save the created team members info
//Print the team members informatio

List<TeamMember> teamMembers = new List<TeamMember>();

int bankDifficultyLevel = 100;

//find the total skillLevel of all of the team members , use a method on the list teamMembers to find the total


void Main()
{
    Console.WriteLine("Plan your heist!");
    MakeTeam();

    Console.WriteLine("Enter the number of trial runs");
    int trialRuns = int.Parse(Console.ReadLine());

    for (int i = 0; i < trialRuns; i++)
    {
        DoHeist();
    }
}

void DisplayMessageForBankDifficultyAndTotalSkill(int totalSkill, int bankDifficultyLevel)
{
    if (totalSkill >= bankDifficultyLevel)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("you've done it$");
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("FAILURE");
    }
}
;

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

void MakeTeam()
{
    for (int i = 0; i < 100; i++)
    {
        TeamMember teamMember = TeamMemberForm();
        if (teamMember == null)
        {
            break;
        }
        teamMembers.Add(teamMember);
    }
}

void DoHeist()
{
    int totalSkill = teamMembers.Aggregate(
        0,
        (int accumulator, TeamMember teamMember) => accumulator += teamMember.SkillLevel
    );

    Random random = new Random();
    int luckValue = random.Next(-10, 11);
    int bankDifficultyLevel = 100 + luckValue;
    Console.WriteLine(
        @$"Team members skill level: {totalSkill} 
    Bank's difficulty level {bankDifficultyLevel}"
    );

    // compare TotalSkill to bankDifficulty and display message accordingly
    DisplayMessageForBankDifficultyAndTotalSkill(totalSkill, bankDifficultyLevel);
}

Main();
