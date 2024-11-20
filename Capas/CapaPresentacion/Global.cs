using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    internal static class Global
    {
        internal static MonedaCD capaDatosM = new();
        internal static UsuarioCD capaDatosU = new();

        public static void DgvFormato(DataGridView dgvTabla, string? col1 = "", string? col2 = "")
        {
            if (!string.IsNullOrWhiteSpace(col1))
                dgvTabla.Columns[col1].DefaultCellStyle.Format = "F3";

            if (!string.IsNullOrWhiteSpace(col2))
                dgvTabla.Columns[col2].DefaultCellStyle.Format = "F3";
        }
    }
}
