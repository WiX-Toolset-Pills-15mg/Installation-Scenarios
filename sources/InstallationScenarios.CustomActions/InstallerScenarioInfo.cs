// WiX Toolset Pills 15mg
// Copyright (C) 2019-2022 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Text;

namespace DustInTheWind.InstallationScenarios.CustomActions
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