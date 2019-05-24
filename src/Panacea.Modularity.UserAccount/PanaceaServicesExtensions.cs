using Panacea.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.UserAccount
{
    public static class PanaceaServicesExtensions
    {
        public static bool TryGetUserAccountManager(this PanaceaServices core, out IUserAccountManager manager)
        {
            manager = core.PluginLoader
                .GetPlugins<IUserAccountPlugin>()
                .FirstOrDefault()
                ?.GetUserAccountManager();
            return manager != null;
        }
    }
}
