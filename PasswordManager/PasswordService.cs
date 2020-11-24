using System;
using System.Collections.Generic;


namespace PasswordManager
{
    public class PasswordService : IPasswordService
    {
        private static List<PasswordModel> mPasswords;


        static PasswordService()
        {
            mPasswords = new List<PasswordModel>
            {
                new PasswordModel
                {
                    Destination = "Default",
                    UserName = "default",
                    Password = "DEFAULT"
                },
                new PasswordModel
                {
                    Destination = "Another",
                    UserName = "me",
                    Password = "haha"
                }
            };
        }


        void IPasswordService.Add(string userName, string password, string destination)
        {
            mPasswords.Add(new PasswordModel
            {
                UserName = userName,
                Password = password,
                Destination = destination
            });
        }


        IReadOnlyCollection<PasswordModel> IPasswordService.GetPasswords()
        {
            return mPasswords;
        }
    }
}
