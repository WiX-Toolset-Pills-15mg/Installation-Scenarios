# Installation Scenarios

# Overview

Windows Installer is providing a set of properties based on which we can deduce what scenario is running (install, uninstall, repair, etc).

But it is not very intuitively what properties should be checked for each scenario. We propose a set of custom properties that helps us in this direction.

## Proposed Custom Properties

The snippet below contains the proposed properties that can be defined and used in an MSI to help identify each execution scenario.

```xml
<SetProperty Id="InstallScenario" After="FindRelatedProducts" Value="true">
    NOT Installed AND NOT WIX_UPGRADE_DETECTED AND NOT WIX_DOWNGRADE_DETECTED
</SetProperty>
 
<SetProperty Id="UninstallScenario" After="SetInstallScenario" Value="true">
    REMOVE="ALL" AND NOT UPGRADINGPRODUCTCODE
</SetProperty>
 
<SetProperty Id="RepairScenario" After="SetUninstallScenario" Value="true">
    REINSTALL="ALL"
</SetProperty>
 
<SetProperty Id="MajorUpgradeUninstallScenario" After="SetRepairScenario" Value="true">
    REMOVE="ALL" AND UPGRADINGPRODUCTCODE
</SetProperty>
 
<SetProperty Id="MajorUpgradeInstallScenario" After="SetMajorUpgradeUninstallScenario" Value="true">
    WIX_UPGRADE_DETECTED
</SetProperty>
 
<SetProperty Id="MajorUpgradeScenario" After="SetMajorUpgradeInstallScenario" Value="true">
    UpgradeUninstallScenario OR UpgradeInstallScenario
</SetProperty>
 
<SetProperty Id="DowngradeScenario" After="SetMajorUpgradeScenario" Value="true">
    WIX_DOWNGRADE_DETECTED
</SetProperty>
```

**Important**:

- The properties must be lower case to be private.

## MSI's properties

The custom properties previously proposed are computed based on the following MSI properties created by Windows Installer (first column).

This table presents their values for different scenarios.

| **Property \ Scenario**    |    **Install**     |   **Uninstall**    |     **Repair**     | **Major Upgrade (Uninstall)** | **Major Upgrade (Install)** |     **Downgrade**      |
| :------------------------- | :----------------: | :----------------: | :----------------: | :---------------------------: | :-------------------------: | :--------------------: |
| **ProductCode**            | {Product/@Id GUID} | {Product/@Id GUID} | {Product/@Id GUID} |    {Old Product/@Id GUID}     |   {New Product/@Id GUID}    | {New Product/@Id GUID} |
| **Installed**              |      <empty>       |      00:00:00      |      00:00:00      |           00:00:00            |           <empty>           |        <empty>         |
| **REINSTALL**              |      <empty>       |      <empty>       |        ALL         |            <empty>            |           <empty>           |        <empty>         |
| **UPGRADINGPRODUCTCODE**   |      <empty>       |      <empty>       |      <empty>       |    {New Product/@Id GUID}     |           <empty>           |        <empty>         |
| **REMOVE**                 |      <empty>       |        ALL         |      <empty>       |              ALL              |           <empty>           |        <empty>         |
| **WIX_UPGRADE_DETECTED**   |      <empty>       |      <empty>       |      <empty>       |            <empty>            |   {Old Product/@Id GUID}    |        <empty>         |
| **WIX_DOWNGRADE_DETECTED** |      <empty>       |      <empty>       |      <empty>       |            <empty>            |           <empty>           | {Old Product/@Id GUID} |
| **MIGRATE**                |      <empty>       |      <empty>       |      <empty>       |            <empty>            |   {Old Product/@Id GUID}    |        <empty>         |
