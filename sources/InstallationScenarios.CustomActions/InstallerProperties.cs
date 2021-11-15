using System;
using Microsoft.Deployment.WindowsInstaller;

namespace InstallationScenarios.CustomActions
{
    internal class InstallerProperties
    {
        private readonly Session session;

        public string ProductCode => Get("ProductCode");

        public string Installed => Get("Installed");

        public string REINSTALL => Get("REINSTALL");

        public string UPGRADINGPRODUCTCODE => Get("UPGRADINGPRODUCTCODE");

        public string REMOVE => Get("REMOVE");

        public string WIX_UPGRADE_DETECTED => Get("WIX_UPGRADE_DETECTED");

        public string WIX_DOWNGRADE_DETECTED => Get("WIX_DOWNGRADE_DETECTED");

        public string MIGRATE => Get("MIGRATE");

        public string InstallScenario => Get("InstallScenario");

        public string UninstallScenario => Get("UninstallScenario");

        public string RepairScenario => Get("RepairScenario");

        public string MajorUpgradeUninstallScenario => Get("MajorUpgradeUninstallScenario");

        public string MajorUpgradeInstallScenario => Get("MajorUpgradeInstallScenario");

        public string MajorUpgradeScenario => Get("MajorUpgradeScenario");

        public string DowngradeScenario => Get("DowngradeScenario");

        public InstallerProperties(Session session)
        {
            this.session = session ?? throw new ArgumentNullException(nameof(session));
        }

        private string Get(string propertyName)
        {
            return session[propertyName] ?? "<null>";
        }
    }
}