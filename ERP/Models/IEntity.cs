namespace ERP.Models
{
    public interface IEntity<T>
        // where T : string or int
    {
        T Id { get; set; }
    }
}