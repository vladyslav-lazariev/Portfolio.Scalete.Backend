namespace Portfolio.Scalete.DataAccess.SqlServer.Entities;

public class WorkEntity
{
    public Guid Id { get; set; }
    public DateTime DateTime { get; set; }
    public string Name2 { get; set; } = nameof(Name2);
}
