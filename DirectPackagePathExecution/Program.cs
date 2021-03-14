using System;

namespace DirectPackagePathExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = SSIS_ETL.RunPackage(@"D:\SSISPackageRunInSQLJob\SSISPackageRunInSQLJob\SSISPackageRunInSQLJob\Package.dtsx");

            Console.WriteLine(result);
            Console.ReadKey();
        }       
    }
}
