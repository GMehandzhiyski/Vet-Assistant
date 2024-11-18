namespace VetAssistant.Service.Data.Contracts
{
    internal interface IBaseService
    {
        bool IsGuidValid(string? id, ref Guid parseGuid);
    }
}
