﻿using System.Windows;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Excel
{
    class Program
    {
        static void Main(string[] args)
        {
            _Application excel = new _Excel.Application();
            Workbook wb;
            Worksheet ws;

            int i = 1, j = 1;
                wb = excel.Workbooks.Open(@"C:\Users\бьюбт\Desktop\С#.xlsx");
            ws = wb.Worksheets[1];
            ws.Cells[i, j].Value2 = "Red Velvet";
            wb.SaveAs(@"C:\Users\бьюбт\Desktop\С#.xlsx");
            wb.Close();

        }
    }
}


