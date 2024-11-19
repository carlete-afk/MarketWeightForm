using CapaPresentacion;
using CapaEntidad;
using System.Security.Policy;
using System.Diagnostics;

namespace MarketWeightForm
{
    internal static class Program
    {

        [STAThread] 
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Terminar la creacion de la base de datos automática
            // Process.Start("bash.exe", "./mysqlConnector");
            Application.Run(new frmMenuPrincipal());
        }
    }
}