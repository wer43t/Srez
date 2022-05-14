using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Srez
{
    public static class Core
    {
        public static Model.User CurrentUser { get; private set; }

        public static bool TryLogin(string login, string password)
        {
            var user = App.Database.GetUsers().Where(x => x.Login == login && x.Password == password);
            if(user.Count() == 0)
            {
                return false;
            }
            else
            {
                CurrentUser = user.FirstOrDefault();
                return true;
            }

        }
    }
}
