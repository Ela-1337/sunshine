using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;

namespace Bietigheim_Sunshine
{
    public class ExcelRemoting
    {
        static public void CreateExcel(List<WeatherDBModel> entries)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object emptyValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(emptyValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "APICallTime";
            xlWorkSheet.Cells[1, 2] = "Country";
            xlWorkSheet.Cells[1, 3] = "City";
            xlWorkSheet.Cells[1, 4] = "Temp";
            xlWorkSheet.Cells[1, 5] = "Wind";
            xlWorkSheet.Cells[1, 6] = "Humdity";
            xlWorkSheet.Cells[1, 7] = "LocalTime";

            const int offset = 2;
            for(int i = 0; i<entries.Count; i++) // i = zeilen
            {
                var elem = entries[i];
                xlWorkSheet.Cells[i+offset, 1] = elem.APICallTime.ToString();
                xlWorkSheet.Cells[i+offset, 2] = elem.Country;
                xlWorkSheet.Cells[i+offset, 3] = elem.City;
                xlWorkSheet.Cells[i+offset, 4] = elem.temp.ToString();
                xlWorkSheet.Cells[i+offset, 5] = elem.wind.ToString();
                xlWorkSheet.Cells[i+offset, 6] = elem.humidity.ToString();
                xlWorkSheet.Cells[i+offset, 7] = elem.localtime;
            }
            xlApp.DisplayAlerts = false;
            xlWorkBook.SaveAs(Environment.CurrentDirectory + @"/weatherData_export.xls", Excel.XlFileFormat.xlWorkbookNormal, emptyValue, emptyValue,
                emptyValue, emptyValue, Excel.XlSaveAsAccessMode.xlNoChange, emptyValue, emptyValue, emptyValue, emptyValue);
            xlWorkBook.Close(true, emptyValue, emptyValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        static private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }


        //static Excel.Application xlApp;
        //static Excel.Workbook wb;
        //static Excel.Worksheet ws;
        //static Excel.Range myRange;
        //static object template = Missing.Value;

        //static public void LadeExcelTabelle(string target)
        //{
        //    if (xlApp == null)
        //        xlApp = new Excel.Application();

        //    object template = Missing.Value;
        //    object onlyread = false;
        //    xlApp.Visible = false;

        //    xlApp.Workbooks.Open(target, template, onlyread, template, template, template, template, template, template, template, template, template, template);
        //    wb = xlApp.ActiveWorkbook;
        //    ws = (Excel.Worksheet)wb.Worksheets[1];





        //}

        //public static Excel.Workbook ErzeugeExcelTabelle(bool createWorkbook)
        //{
        //    if (xlApp == null)
        //        xlApp = new Excel.Application();

        //    xlApp.Visible = true;
        //    if (createWorkbook)
        //        wb = xlApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
        //    return wb;

        //}

        //static public string ReadValue(int zeile, int spalte)
        //{
        //    myRange = (Excel.Range)ws.Cells[zeile, spalte];
        //    if (myRange.Value == null)
        //        return "";
        //    else
        //        return myRange.Value.ToString();
        //}

        //static public void SetValue(int zeile, int spalte, string pValue)
        //{
        //    myRange = (Excel.Range)ws.Cells[zeile, spalte];
        //    if (myRange != null)
        //        myRange.Value = pValue;
        //}


        //public static Excel.Worksheet AddWorksheet(string sheetName)
        //{
        //    object template = Missing.Value;
        //    ws = (Excel.Worksheet)wb.Sheets.Add(template, template, template, template);
        //    ws.Name = sheetName;
        //    return ws;
        //}

        //public static void SaveWorkbook(string pathname)
        //{
        //    object missing = Missing.Value;
        //    object targetfile = pathname;
        //    xlApp.ActiveWorkbook.SaveAs(targetfile, missing, missing, missing, missing, missing, Excel.XlSaveAsAccessMode.xlExclusive, missing, missing, missing, missing);

        //}



        //static public void SetColor(int zeile, int spalte, int colorIndex)
        //{
        //    myRange = (Excel.Range)ws.Cells[zeile, spalte];
        //    myRange.Interior.ColorIndex = colorIndex;

        //}


    }

}

