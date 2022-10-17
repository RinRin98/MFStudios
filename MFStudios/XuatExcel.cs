using System;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace MFStudios
{
    public class XuatExcel
    {
        public static string duongdanex = Application.StartupPath;
        public static void exportecxelhoadon(DataGridView g, string duongdan, string tenfile)
        {
            duongdan = @"C:\XuatExcel\ChiTietHoaDon\chi-tiet-hoa-don-hang-ngay ";
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value;
                    }
                }
            obj.Range["A1", "M100"].Font.Name = "Times New Roman";
            obj.Range["A1", "M100"].HorizontalAlignment = 3;
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tenfile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
            //obj.Quit();
        }
        //obj.Quit();
    }
}

