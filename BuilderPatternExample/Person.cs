namespace BuilderPatternExample;

public class Person
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public int Age { get; set; }
    public Address? Address { get; set; }
    public List<Phone>? Phones { get; set; }
}