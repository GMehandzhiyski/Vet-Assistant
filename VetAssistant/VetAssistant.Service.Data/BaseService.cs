using VetAssistant.Service.Data.Contracts;

namespace VetAssistant.Service.Data
{
    public class BaseService : IBaseService
    {
        public bool IsGuidValid(string? id, ref Guid parseGuid)
        {
            if (String.IsNullOrWhiteSpace(id))
            {
                return false;
            }

            bool isGuidValid = Guid.TryParse(id, out parseGuid);
            if (!isGuidValid)
            {
                return false;
            }

            return true;
        }
    }
}
