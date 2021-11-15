using Microsoft.Deployment.WindowsInstaller;

namespace InstallationScenarios.CustomActions
{
    public class LogScenarioPropertiesCustomAction
    {
        [CustomAction("LogScenarioProperties")]
        public static ActionResult Execute(Session session)
        {
            session.Log("Begin LogScenarioProperties");

            try
            {
                InstallerProperties installerProperties = new InstallerProperties(session);
                InstallerScenarioInfo installerScenarioInfo = new InstallerScenarioInfo(installerProperties);

                session.Log(installerScenarioInfo.ToString());

                return ActionResult.Success;
            }
            finally
            {
                session.Log("End LogScenarioProperties");
            }
        }
    }
}