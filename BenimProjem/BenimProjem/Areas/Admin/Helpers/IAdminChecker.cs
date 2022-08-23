using Microsoft.AspNetCore.Http;

namespace BenimProjem.Areas.Admin.Helpers
{
    public interface IAdminChecker
    {
        bool Check(HttpRequest request);
    }
}
