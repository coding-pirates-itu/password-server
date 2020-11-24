using System.Collections.Generic;

namespace PasswordManager
{
    public interface IPasswordService
    {
        void Add(string userName, string password, string destination);
        
        IReadOnlyCollection<PasswordModel> GetPasswords();
    }
}