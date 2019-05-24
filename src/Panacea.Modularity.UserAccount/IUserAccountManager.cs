using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.UserAccount
{
    public interface IUserAccountManager
    {
        void NavigateToRegister();

        void NavigateToMyAccount();

        Task<bool> RequestLoginAsync(string text);
    }
}
