namespace Portfolio.Scalete.Domain;

public class Blog
{
    public Guid Id { get; set; }
    public DateTime DateTime { get; set; }
    public string Name1 { get; set; } = nameof(Name1);
}
