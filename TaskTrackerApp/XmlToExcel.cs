//author: shivavandana

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace TaskTrackerApp
{
    class XmlToExcel
    {
        public void LoadToExcel()
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] name;
            name = userName.Split('\\');
            DataSet ds;
            object misValue = System.Reflection.Missing.Value;                      
            string strXMLFilePath = ConfigurationManager.AppSettings["XMLFilePath"];
            string strExcelFilePath = ConfigurationManager.AppSettings["ExcelFilePath"];
            const string Folder = @"C:\vandana";
            Directory.CreateDirectory(Folder);
            if (File.Exists(strExcelFilePath))
            {
                File.Delete(strExcelFilePath);
            }
            try
            {
                ds = new DataSet();
                ds.ReadXml(strXMLFilePath);
            }
            catch (Exception)
            {
                throw;
            }
            Excel.Application excelApp = new Excel.Application();
            //Create an Excel workbook instance and open it from the predefined location
            Excel.Workbook excelWorkBook = excelApp.Workbooks.Add(misValue);
            Excel.Worksheet excelWorkSheet = (Excel.Worksheet)excelWorkBook.Worksheets.get_Item(1);
            excelWorkBook.SaveAs(strExcelFilePath, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            excelWorkSheet = (Excel.Worksheet)excelWorkBook.Sheets.Add();
            DataTable data1 = new DataTable();
            foreach (DataTable table in ds.Tables)
            {
                    excelWorkSheet.Name = table.TableName;
                    for (int i = 1; i < table.Columns.Count + 1; i++)
                    {
                        excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                    }
                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        for (int k = 0; k < table.Columns.Count; k++)
                        {
                            excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                        }
                    }
             }
               
            excelWorkBook.Save();
            excelWorkBook.Close();
            excelApp.Quit();
            releaseObject(excelWorkSheet);
            releaseObject(excelWorkBook);
            releaseObject(excelApp);
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                //MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }

        }
        
    }

}
