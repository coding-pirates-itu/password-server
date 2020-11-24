using Microsoft.AspNetCore.Mvc;


namespace PasswordManager.Controllers
{
    [ApiController]
    [Route("api/passwords")]
    public class PasswordController : ControllerBase
    {
        private readonly IPasswordService mPasswords;


        public PasswordController(IPasswordService passwords)
        {
            mPasswords = passwords;
        }


        [HttpPost]
        public IActionResult AddPassword(PasswordViewModel password)
        {
            mPasswords.Add(password.UserName, password.Password, password.Destination);
            return NoContent();
        }
    }
}
