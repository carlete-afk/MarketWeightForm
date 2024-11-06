using CapaPresentacion;
using CapaEntidad;

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