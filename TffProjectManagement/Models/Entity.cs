
using System.Security.Cryptography;

namespace TffProjectManagement.Models;

public abstract class Entity<TId>
{
    public TId Id { get; set; }
}
