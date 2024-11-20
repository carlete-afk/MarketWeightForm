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
            Application.Run(new frmMenuPrincipal());
        }
    }
}