using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace PasswordManager
{
    public class PasswordViewModel
    {
        [BindProperty]
        public string Destination { get; set; }


        [BindProperty]
        [DisplayName("User name")]
        public string UserName { get; set; }


        [BindProperty]
        public string Password { get; set; }
    }
}
