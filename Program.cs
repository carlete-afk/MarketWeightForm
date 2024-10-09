using System;
using MySql.Data.MySqlClient;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace MarketWeightForm
{
    public class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
