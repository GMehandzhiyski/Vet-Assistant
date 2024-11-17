namespace VetAssistant.Data.Repository.Contracts
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; set; }
    }
}
