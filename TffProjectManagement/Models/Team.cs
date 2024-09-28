

namespace TffProjectManagement.Models;

public sealed class Team : Entity<int>
{
    public string Name { get; set; }
    public DateTime Since { get; set; }

    public override string ToString()
    {
        return $"{Id}, {Name}, {Since}";
    }

}