using Microsoft.SqlServer.Management.IntegrationServices;
using System.Data.SqlClient;

namespace AfterDeployingIntoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string targetServerName = @"192.168.2.111\SQL17ENTERPRISE,1435";
            string folderName = "SSISPackageItems";
            string projectName = "SSISPackageRunInSQLJob";
            string packageName = "Package.dtsx";

            // Create a connection to the server
            string sqlConnectionString = "Data Source=" + targetServerName +";Initial Catalog=master;Integrated Security=SSPI;";
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);

            // Create the Integration Services object
            IntegrationServices integrationServices = new IntegrationServices(sqlConnection);

            // Get the Integration Services catalog
            Catalog catalog = integrationServices.Catalogs["SSISDB"];

            // Get the folder
            CatalogFolder folder = catalog.Folders[folderName];

            // Get the project
            ProjectInfo project = folder.Projects[projectName];

            // Get the package
            PackageInfo package = project.Packages[packageName];

            // Run the package
            package.Execute(false, null);
        }
    }
}
