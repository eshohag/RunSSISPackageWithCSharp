Add references
In Solution Explorer, right-click the References folder and select Add Reference. The Reference Manager dialog box opens.
In the Reference Manager dialog box, expand Assemblies and select Extensions.
Select the following two references to add:
Microsoft.SqlServer.Management.Sdk.Sfc
Microsoft.SqlServer.Smo

Click the Browse button to add a reference to Microsoft.SqlServer.Management.IntegrationServices. 
(This assembly is installed only in the global assembly cache (GAC).) The Select the files to reference dialog box opens.
In the Select the files to reference dialog box, navigate to the GAC folder that contains the assembly.
Typically this folder is C:\Windows\assembly\GAC_MSIL\Microsoft.SqlServer.Management.IntegrationServices\14.0.0.0__89845dcd8080cc91.
Select the assembly (that is, the .dll file) in the folder and click Add.
Click OK to close the Reference Manager dialog box and add the three references. 
To make sure the references are there, check the References list in Solution Explorer.