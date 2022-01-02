using CommercialSite.Common.DTOs.User;

namespace CommercialSite.Common.Service.WorkContext
{
    public interface IWorkContext
    {
        UserResponse CurrentUser { get; set; }
    }
}
