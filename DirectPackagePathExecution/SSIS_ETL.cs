using Microsoft.SqlServer.Dts.Runtime;
using System;
using System.Linq;

namespace DirectPackagePathExecution
{
    public abstract class SSIS_ETL
    {
        public static string RunPackage(string filePath)
        {
            var massage = "";
            var result = "";
            var app = new Application();
            Package package = new Package();
            var events = new PackageEvents();

            try
            {
                package = app.LoadPackage(filePath, events);

                //package.Variables["CurrentDate"].Value = DateTime.Now.ToString("yyyy-MM-dd");
                //package.Variables["SourceConnection"].Value = "";
                //package.Variables["DestinationConnection"].Value = "";

                var pkgResults = package.Execute(null, null, events, null, null);
                result = pkgResults.ToString();

                massage = result == "Failure" ? "Failed Components: " + string.Join("|", events.ErrorMessages.Select(e => e.Description)) : result;
            }
            catch (Exception ex)
            {
                massage = result + " " + ex.Message;
            }
            finally
            {
                package?.Dispose();
                package = null;
            }
            return massage;
        }
    }
}
