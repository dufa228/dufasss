using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private string fileName = "Test_RiverWater.xlsx";
        Excel.Application objExcel = null;
        Excel.Workbook WorkBook = null;

        private object oMissing = System.Reflection.Missing.Value;


        [TestMethod]
        public void TestMethod1()
        {
            WaterRiverLib.WaterRiverLib rv = new WaterRiverLib.WaterRiverLib();

            #region 1. Присвоить исходные данные 

            rv.Value_1 = 0.5;
            rv.Value_2 = 1;
            rv.Value_3 = 0.0005;
            rv.Value_4 = 308;
            rv.Value_5 = 2.42;
            rv.Value_6 = 0.18;
            rv.Value_7 = 8.6;
            rv.Value_8 = 1000;
            rv.Value_9 = 70;
            rv.Value_10 = 2;
            rv.Value_12 = 0.0008;
            rv.Value_13 = 0;

            #endregion 1. Присвоить исходные данные 

            #region 2. Передать исходные данные в Excel-файл, записать в соответствующие ячейки (формат адреса ячейки [номер строки, номер столбца])

            objExcel = new Excel.Application();
            WorkBook = objExcel.Workbooks.Open(
                        Directory.GetCurrentDirectory() + "\\" + fileName);
            Excel.Worksheet WorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)WorkBook.Sheets["Исходные данные"];

            ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[2, 3]).Value2 = rv.Value_1;
            ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[3, 3]).Value2 = rv.Value_2;
            ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[4, 3]).Value2 = rv.Value_3;
            ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[5, 3]).Value2 = rv.Value_4;
            ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[6, 3]).Value2 = rv.Value_5;
            ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[7, 3]).Value2 = rv.Value_6;
            ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[8, 3]).Value2 = rv.Value_7;
            ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[9, 3]).Value2 = rv.Value_8;
            ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[10, 3]).Value2 = rv.Value_9;
            ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[11, 3]).Value2 = rv.Value_10;
            ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[13, 3]).Value2 = rv.Value_12;
            ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[14, 3]).Value2 = rv.Value_13;




            #endregion 2. Передать исходные данные в Excel-файл, записать в соответствующие ячейки (формат адреса ячейки [номер строки, номер столбца])

            #region 3. Прочитать из ячейки Excel-файла расчетное значение 

            double _Koef_P = double.Parse(((Excel.Range)WorkBook.Sheets["Результаты расчета"].Cells[2, 3]).Value.ToString());
            double _Koef_a = double.Parse(((Excel.Range)WorkBook.Sheets["Результаты расчета"].Cells[3, 3]).Value.ToString());
            double _Koef_a1 = double.Parse(((Excel.Range)WorkBook.Sheets["Результаты расчета"].Cells[4, 3]).Value.ToString());
            double _Koord_y = double.Parse(((Excel.Range)WorkBook.Sheets["Результаты расчета"].Cells[5, 3]).Value.ToString());
            double _Koord_z = double.Parse(((Excel.Range)WorkBook.Sheets["Результаты расчета"].Cells[6, 3]).Value.ToString());
            double _Integr1 = double.Parse(((Excel.Range)WorkBook.Sheets["Результаты расчета"].Cells[7, 3]).Value.ToString());
            double _Integr2 = double.Parse(((Excel.Range)WorkBook.Sheets["Результаты расчета"].Cells[8, 3]).Value.ToString());
            double _Rez = double.Parse(((Excel.Range)WorkBook.Sheets["Результаты расчета"].Cells[9, 3]).Value.ToString());






            if (WorkBook != null) WorkBook.Close(false, null, null); //закрытие шаблона
            //if (WorkBook != null) WorkBook.Close(Type.Missing, Type.Missing, Type.Missing);//закрытие шаблона
            if (objExcel != null) objExcel.Quit();

            #endregion 3. Прочитать из ячейки Excel-файла расчетное значение 

            #region  4. Сравнить значения из Excel и из библиотеки с нужной точностью, знаков после запятой    

            Console.WriteLine("--- Результаты расчетов");
            Console.WriteLine("");



            Assert.AreEqual(_Koef_P, Math.Round((double)rv.Koef_P(), 3), 0.001);
            Console.WriteLine("Коэффициент P: ожидается _Koef_P={0}; фактически rv.Get_Koef_P()= {1}",
                    _Koef_P, Math.Round((double)rv.Koef_P(), 4));

            Assert.AreEqual(_Koef_a, Math.Round((double)rv.Koef_a(), 2), 0.001);
            Console.WriteLine("Коэффициент A: ожидается _Koef_P={0}; фактически rv.Get_Koef_a()= {1}",
                    _Koef_a, Math.Round((double)rv.Koef_a(), 4));

            Assert.AreEqual(_Koef_a1, Math.Round((double)rv.Koef_a1(), 4), 0.001);
            Console.WriteLine("Коэффициент A: ожидается _Koef_A={0}; фактически rv._Koef_a1()= {1}",
                    _Koef_a1, Math.Round((double)rv.Koef_a1(), 4));




            Assert.AreEqual(_Koord_y, Math.Round((double)rv.Koord_y(), 4), 0.001);
            Console.WriteLine("Координата y: ожидается _Koord_y={0}; фактически rv._Koord_y()= {1}",
                    _Koord_y, Math.Round((double)rv.Koord_y(), 4));

            Assert.AreEqual(_Koord_z, Math.Round((double)rv.Koord_z(), 4), 0.001);
            Console.WriteLine("Координата z: ожидается _Koord_z={0}; фактически rv._Koord_z()= {1}",
                    _Koord_z, Math.Round((double)rv.Koord_z(), 4));




            Assert.AreEqual(_Integr1, Math.Round((double)rv.Integr1(), 4), 0.001);
            Console.WriteLine("Интеграл вероятности Гаусса Фо,в(а): ожидается _Integr1={0}; фактически rv._Integr1()= {1}",
                    _Integr1, Math.Round((double)rv.Integr1(), 4));

            Assert.AreEqual(_Integr2, Math.Round((double)rv.Integr2(), 4), 0.001);
            Console.WriteLine("Интеграл вероятности Гаусса Фо,н(а): ожидается _Integr2={0}; фактически rv._Integr2()= {1}",
                    _Integr2, Math.Round((double)rv.Integr2(), 4));



            Assert.AreEqual(_Rez, Math.Round((double)rv.Rez(), 4), 0.001);
            Console.WriteLine("Концентрация примеси S: ожидается _Rez={0}; фактически rv._Rez()= {1}",
                    _Rez, Math.Round((double)rv.Rez(), 4));







            #endregion  4. Сравнить значения из Excel и из библиотеки с нужной точностью, знаков после запятой    
        }
    }
}
