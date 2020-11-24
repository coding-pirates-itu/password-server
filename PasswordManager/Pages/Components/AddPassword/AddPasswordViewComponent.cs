using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PasswordManager
{
    public class AddPasswordViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult<IViewComponentResult>(View());
        }
    }
}
