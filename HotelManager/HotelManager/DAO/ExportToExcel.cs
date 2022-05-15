using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System;

namespace HotelManager.DAO
{
    public enum ModeExportToExcel
    {
        XLS = 0,
        XLSX = 1,
        PDF = 2
    }
    public class ExportToExcel
    {
        private static ExportToExcel instance;
        public static ExportToExcel Instance
        {
            get
            {
                if (instance == null)
                    instance = new ExportToExcel();
                return instance;
            }
        }
        private ExportToExcel() { }
        public bool Export(DataGridView dataGridView, string path, ModeExportToExcel mode = ModeExportToExcel.XLS)
        {
            return false;
        }

        private void ToExcel()
        {
        }
    }
}
