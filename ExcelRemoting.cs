using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;

namespace it.schule
{
    public class ExcelRemoting
    {
        static Excel.Application xlApp;
        static Excel.Workbook wb;
        static Excel.Worksheet ws;
        static Excel.Range myRange;
        static object template = Missing.Value;

        static public void LadeExcelTabelle(string target)
        {
            if (xlApp == null)
                xlApp = new Excel.Application();

            object template = Missing.Value;
            object onlyread = false;
            xlApp.Visible = false;

            xlApp.Workbooks.Open(target, template, onlyread, template, template, template, template, template, template, template, template, template, template);
            wb = xlApp.ActiveWorkbook;
            ws = (Excel.Worksheet)wb.Worksheets[1];

          



        }

        public static Excel.Workbook ErzeugeExcelTabelle(bool createWorkbook)
        {
            if (xlApp == null)
                xlApp = new Excel.Application();

            xlApp.Visible = true;
            if (createWorkbook)
                wb = xlApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            return wb;

        }

        static public string ReadValue(int zeile, int spalte)
        {
            myRange = (Excel.Range)ws.Cells[zeile, spalte];
            if (myRange.Value == null)
                return "";
            else
                return myRange.Value.ToString();
        }

        static public void SetValue(int zeile, int spalte, string pValue)
        {
            myRange = (Excel.Range)ws.Cells[zeile, spalte];
            if (myRange != null)
                myRange.Value = pValue;
        }


        public static Excel.Worksheet AddWorksheet(string sheetName)
        {
            object template = Missing.Value;
            ws = (Excel.Worksheet)wb.Sheets.Add(template, template, template, template);
            ws.Name = sheetName;
            return ws;
        }

        public static void SaveWorkbook(string pathname)
        {
            object missing = Missing.Value;
            object targetfile = pathname;
            xlApp.ActiveWorkbook.SaveAs(targetfile, missing, missing, missing, missing, missing, Excel.XlSaveAsAccessMode.xlExclusive, missing, missing, missing, missing);

        }

       

        static public void SetColor(int zeile, int spalte, int colorIndex)
        {
            myRange = (Excel.Range)ws.Cells[zeile, spalte];
            myRange.Interior.ColorIndex = colorIndex;

        }

      
    }

}

