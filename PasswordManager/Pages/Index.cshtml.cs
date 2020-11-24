using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace PasswordManager.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IPasswordService mPasswords;
        private readonly ILogger<IndexModel> mLogger;


        public IReadOnlyCollection<PasswordModel> Passwords { get; private set; }


        public IndexModel(
            IPasswordService passwords,
            ILogger<IndexModel> logger)
        {
            mPasswords = passwords;
            mLogger = logger;
        }


        public void OnGet()
        {
            Passwords = mPasswords.GetPasswords();
        }
    }
}
