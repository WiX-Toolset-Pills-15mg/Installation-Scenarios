using System;
using System.Text;

namespace InstallationScenarios.CustomActions
{
    internal class InstallerScenarioInfo
    {
        private readonly InstallerProperties installerProperties;

        public InstallerScenarioInfo(InstallerProperties installerProperties)
        {
            this.installerProperties = installerProperties ?? throw new ArgumentNullException(nameof(installerProperties));
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("====================================================================================================");
            stringBuilder.AppendLine("Installation Scenario Info");
            stringBuilder.AppendLine("====================================================================================================");
            stringBuilder.AppendLine($"ProductCode = {installerProperties.ProductCode}");
            stringBuilder.AppendLine($"Installed = {installerProperties.Installed}");
            stringBuilder.AppendLine($"REINSTALL = {installerProperties.REINSTALL}");
            stringBuilder.AppendLine($"UPGRADINGPRODUCTCODE = {installerProperties.UPGRADINGPRODUCTCODE}");
            stringBuilder.AppendLine($"REMOVE = {installerProperties.REMOVE}");
            stringBuilder.AppendLine($"WIX_UPGRADE_DETECTED = {installerProperties.WIX_UPGRADE_DETECTED}");
            stringBuilder.AppendLine($"WIX_DOWNGRADE_DETECTED = {installerProperties.WIX_DOWNGRADE_DETECTED}");
            stringBuilder.AppendLine($"MIGRATE = {installerProperties.MIGRATE}");
            stringBuilder.AppendLine("----------------------------------------------------------------------------------------------------");
            stringBuilder.AppendLine($"InstallScenario = {installerProperties.InstallScenario}");
            stringBuilder.AppendLine($"UninstallScenario = {installerProperties.UninstallScenario}");
            stringBuilder.AppendLine($"RepairScenario = {installerProperties.RepairScenario}");
            stringBuilder.AppendLine($"MajorUpgradeUninstallScenario = {installerProperties.MajorUpgradeUninstallScenario}");
            stringBuilder.AppendLine($"MajorUpgradeInstallScenario = {installerProperties.MajorUpgradeInstallScenario}");
            stringBuilder.AppendLine($"MajorUpgradeScenario = {installerProperties.MajorUpgradeScenario}");
            stringBuilder.AppendLine($"DowngradeScenario = {installerProperties.DowngradeScenario}");
            stringBuilder.Append("====================================================================================================");

            return stringBuilder.ToString();
        }
    }
}