namespace erp_api.Models
{
    public interface IEntity<T>
        // where T : string or int
    {
        T Id { get; set; }
    }
}