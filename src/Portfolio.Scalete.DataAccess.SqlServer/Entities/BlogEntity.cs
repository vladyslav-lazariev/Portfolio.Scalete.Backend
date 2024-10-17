namespace Portfolio.Scalete.DataAccess.SqlServer.Entities;

public class BlogEntity
{
    public Guid Id { get; set; }
    public DateTime DateTime { get; set; }
    public string Name1 { get; set; } = nameof(Name1);
}
