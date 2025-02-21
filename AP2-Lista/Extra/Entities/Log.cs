using Extra.Observer;

namespace Extra.Entities;
public record Log
{
    public int Id { get; set; }
    public string Message { get; set; }
    public User User { get; set; }
    public DateTime CreateAt { get; set; }

    public override string ToString()
    {
        return $"> [Id: {Id} - User: {User.Name} - CreatedAt: {CreateAt} - Message: {Message}]";
    }
}
