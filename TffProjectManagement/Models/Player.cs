

namespace TffProjectManagement.Models;

public sealed class Player : Entity<Guid>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Number { get; set; }
    public string Branch { get; set; }
    public int Age { get; set; }
    public double MarketValue { get; set; }

    public int TeamId { get; set; }


    public override string ToString()
    {
        return $"{Id},{Name}, {Surname}, {Number}, {Branch},{Age},{MarketValue},{TeamId}";
    }

}
