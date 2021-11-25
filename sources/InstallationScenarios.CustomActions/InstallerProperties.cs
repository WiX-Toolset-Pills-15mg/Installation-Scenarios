// WiX Toolset Pills 15mg
// Copyright (C) 2019-2021 Dust in the Wind
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