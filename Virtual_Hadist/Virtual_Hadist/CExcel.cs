using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace FinalHospitalAppliacation
{
    class CExcel
    {
        public CExcel()
        {

        }

        public string ReadSignIn(string ID, string Password)
        {
            string status = "error";

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\user\Documents\Visual Studio 2013\Projects\FinalHospitalAppliacation\DataBase.xlsx");
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(3);
            Excel.Range xlRange = xlWorksheet.UsedRange;

            object[,] valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

            for (int row = 2; row <= xlWorksheet.UsedRange.Rows.Count; ++row)
            {
                if (valueArray[row, 2].ToString() == ID && valueArray[row, 3].ToString() == Password)
                {
                    status = valueArray[row, 4].ToString();
                }
            }

            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);

            return status;
        }

        public string SearchUser(string ID)
        {
            string nama = "";

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\user\Documents\Visual Studio 2013\Projects\FinalHospitalAppliacation\DataBase.xlsx");
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(3);
            Excel.Range xlRange = xlWorksheet.UsedRange;

            object[,] valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

            for (int row = 2; row <= xlWorksheet.UsedRange.Rows.Count; ++row)
            {
                if (valueArray[row, 2].ToString() == ID )
                {
                    nama = valueArray[row, 1].ToString();
                }
            }

            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);

            return nama;
        }

        public List<CDoctor> readAllDocter()
        {
            List<CDoctor> Doctor = new List<CDoctor>();
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\user\Documents\Visual Studio 2013\Projects\FinalHospitalAppliacation\DataBase.xlsx");
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(3);
            Excel.Range xlRange = xlWorksheet.UsedRange;

            object[,] valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

            for (int row = 2; row <= xlWorksheet.UsedRange.Rows.Count; ++row)
            {
                if (valueArray[row, 4].ToString() == "Dokter")
                {
                    Doctor.Add(new CDoctor(valueArray[row, 1].ToString(),
                                           valueArray[row, 2].ToString(),
                                           valueArray[row, 3].ToString(),
                                           valueArray[row, 5].ToString()));
                }
            }

            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);

            return Doctor;
        }

        public List<CWaitingList> readAllWaitingList()
        {
            List<CWaitingList> WaitingList = new List<CWaitingList>();
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\user\Documents\Visual Studio 2013\Projects\FinalHospitalAppliacation\DataBase.xlsx");
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(5);
            Excel.Range xlRange = xlWorksheet.UsedRange;

            object[,] valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

            for (int row = 2; row <= xlWorksheet.UsedRange.Rows.Count; ++row)
            {               
                    WaitingList.Add(new CWaitingList(Convert.ToBoolean(valueArray[row, 4]),
                                                     Convert.ToDateTime(valueArray[row, 1]),
                                                     valueArray[row, 2].ToString(),
                                                     valueArray[row, 3].ToString()));
                
            }

            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);

            return WaitingList;

        }
        
        public void writePatient(CPatient Patient)
        {
            var excelapp = new Excel.Application();
            var workbooks = excelapp.Workbooks.Open(@"C:\Users\user\Documents\Visual Studio 2013\Projects\FinalHospitalAppliacation\DataBase.xlsx");
            Excel.Workbook workbook = workbooks;
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets.get_Item(1);

            int rows = worksheet.UsedRange.Rows.Count + 1;

            worksheet.Cells[rows, 1] = Patient.tglPendaftaran;
            worksheet.Cells[rows, 2] = Patient.NIP;
            worksheet.Cells[rows, 3] = Patient.nama;
            worksheet.Cells[rows, 4] = Patient.jnsKelamin;
            worksheet.Cells[rows, 5] = Patient.golDarah;
            worksheet.Cells[rows, 6] = Patient.rhesus;
            worksheet.Cells[rows, 7] = Patient.tptLahir;
            worksheet.Cells[rows, 8] = Patient.tglLahir;
            worksheet.Cells[rows, 9] = Patient.alamat;
            worksheet.Cells[rows, 10] = Patient.rt;
            worksheet.Cells[rows, 11] = Patient.rw;
            worksheet.Cells[rows, 12] = Patient.kelurahanDesa;
            worksheet.Cells[rows, 13] = Patient.kecamatan;
            worksheet.Cells[rows, 14] = Patient.kabupatenKota;
            worksheet.Cells[rows, 15] = Patient.kontak;

            workbooks.Save();
            workbook.Close();
            excelapp.Quit();
        }

        public void writeHistory(List<CHistory> History)
        {
            var excelapp = new Excel.Application();
            var workbooks = excelapp.Workbooks.Open(@"C:\Users\user\Documents\Visual Studio 2013\Projects\FinalHospitalAppliacation\DataBase.xlsx");
            Excel.Workbook workbook = workbooks;
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets.get_Item(2);

            foreach (var X in History)
            {
                int rows = worksheet.UsedRange.Rows.Count + 1;

                worksheet.Cells[rows, 1] = X.tanggal;
                worksheet.Cells[rows, 2] = X.NIP;
                worksheet.Cells[rows, 3] = X.riwayatPenyakit;
                worksheet.Cells[rows, 4] = X.riwayatpelayanan;
                worksheet.Cells[rows, 5] = X.riwayatObat;
                worksheet.Cells[rows, 6] = X.dokter;
                worksheet.Cells[rows, 7] = X.keterangan;
                worksheet.Cells[rows, 8] = X.status;
            }
            
            workbooks.Save();
            workbook.Close();
            excelapp.Quit();
        }
        public void writeWaitingList(CWaitingList waiting)
        {
            var excelapp = new Excel.Application();
            var workbooks = excelapp.Workbooks.Open(@"C:\Users\user\Documents\Visual Studio 2013\Projects\FinalHospitalAppliacation\DataBase.xlsx");
            Excel.Workbook workbook = workbooks;
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets.get_Item(5);

           
                int rows = worksheet.UsedRange.Rows.Count + 1;

                worksheet.Cells[rows, 1] = waiting.tanggal;
                worksheet.Cells[rows, 2] = waiting.NIP;
                worksheet.Cells[rows, 3] = waiting.dokter;
                worksheet.Cells[rows, 4] = waiting.status;
            

            workbooks.Save();
            workbook.Close();
            excelapp.Quit();

        }



        public void updateWaitingList(BindingList<CWaitingList> WaitList)
        {
            var excelapp = new Excel.Application();
            var workbooks = excelapp.Workbooks.Open(@"C:\Users\user\Documents\Visual Studio 2013\Projects\FinalHospitalAppliacation\DataBase.xlsx");
            Excel.Workbook workbook = workbooks;
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets.get_Item(5);
            Excel.Range xlRange = worksheet.UsedRange;
            object[,] valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

            int row = 2;
                foreach (var X in WaitList)
                {
                    
                    if (Convert.ToBoolean(valueArray[row, 4]) != X.status)
                    {
                        worksheet.Cells[row, 4] = X.status;
                    }
                    row = row + 1;
                }
               
            
            workbooks.Save();
            workbook.Close();
            excelapp.Quit();

        }




        public CPatient ReadPatient(string NIP)
        {
            CPatient Patient = new CPatient(); ;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\user\Documents\Visual Studio 2013\Projects\FinalHospitalAppliacation\DataBase.xlsx");
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(1);
            Excel.Range xlRange = xlWorksheet.UsedRange;

            object[,] valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

            for (int row = 3; row <= xlWorksheet.UsedRange.Rows.Count; ++row)
            {
                if (valueArray[row, 2].ToString() == NIP )
                {
                    Patient.tglPendaftaran = Convert.ToDateTime(valueArray[row, 1]);
                    Patient.NIP = valueArray[row, 2].ToString();
                    Patient.nama = valueArray[row, 3].ToString();
                    Patient.jnsKelamin = valueArray[row, 4].ToString();
                    Patient.golDarah = valueArray[row, 5].ToString();
                    Patient.rhesus = valueArray[row, 6].ToString();
                    Patient.tptLahir = valueArray[row, 7].ToString();
                    Patient.tglLahir = Convert.ToDateTime(valueArray[row, 8]);
                    Patient.alamat = valueArray[row, 9].ToString();
                    Patient.rt = valueArray[row, 10].ToString();
                    Patient.rw = valueArray[row, 11].ToString();
                    Patient.kelurahanDesa = valueArray[row, 12].ToString();
                    Patient.kecamatan = valueArray[row, 13].ToString();
                    Patient.kabupatenKota = valueArray[row, 14].ToString();
                    Patient.kontak = valueArray[row, 15].ToString();
                }
            }

            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);

            return Patient;
        }
        public List<CHistory> ReadHistory(string NIP)
        {
            List<CHistory> History = new List<CHistory>(); ;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\user\Documents\Visual Studio 2013\Projects\FinalHospitalAppliacation\DataBase.xlsx");
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(2);
            Excel.Range xlRange = xlWorksheet.UsedRange;

            object[,] valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

            for (int row = 2; row <= xlWorksheet.UsedRange.Rows.Count; ++row)
            {
                if (valueArray[row, 2].ToString() == NIP)
                {
                    History.Add(new CHistory(Convert.ToDateTime(valueArray[row, 1]),
                                valueArray[row, 2].ToString(),
                                valueArray[row, 3].ToString(),
                                valueArray[row, 4].ToString(),
                                valueArray[row, 5].ToString(),
                                valueArray[row, 6].ToString(),
                                valueArray[row, 7].ToString(),
                                Convert.ToBoolean(valueArray[row, 8])));
                }
            }

            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);

            return History;
        }

        public List<CPatient> ReadAllPatient()
        {
            List<CPatient> Patient = new List<CPatient>(); ;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\user\Documents\Visual Studio 2013\Projects\FinalHospitalAppliacation\DataBase.xlsx");
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(1);
            Excel.Range xlRange = xlWorksheet.UsedRange;

            object[,] valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

            for (int row = 3; row <= xlWorksheet.UsedRange.Rows.Count; ++row)
            {
                Patient.Add(new CPatient(Convert.ToDateTime(valueArray[row, 1]),
                                         valueArray[row, 2].ToString(),
                                         valueArray[row, 3].ToString(),
                                         valueArray[row, 4].ToString(),
                                         valueArray[row, 5].ToString(),
                                         valueArray[row, 6].ToString(),
                                         valueArray[row, 7].ToString(),
                                         Convert.ToDateTime(valueArray[row, 8]),
                                         valueArray[row, 9].ToString(),
                                         valueArray[row, 10].ToString(),
                                         valueArray[row, 11].ToString(),
                                         valueArray[row, 12].ToString(),
                                         valueArray[row, 13].ToString(),
                                         valueArray[row, 14].ToString(),
                                         valueArray[row, 15].ToString()));
            }

            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);

            return Patient;
        }

        public List<CHistory> ReadAllHistory()
        {
            List<CHistory> History = new List<CHistory>(); ;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\user\Documents\Visual Studio 2013\Projects\FinalHospitalAppliacation\DataBase.xlsx");
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(2);
            Excel.Range xlRange = xlWorksheet.UsedRange;

            object[,] valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

            for (int row = 2; row <= xlWorksheet.UsedRange.Rows.Count; ++row)
            {
                    History.Add(new CHistory(Convert.ToDateTime(valueArray[row, 1]),
                                valueArray[row, 2].ToString(),
                                valueArray[row, 3].ToString(),
                                valueArray[row, 4].ToString(),
                                valueArray[row, 5].ToString(),
                                valueArray[row, 6].ToString(),
                                valueArray[row, 7].ToString(),
                                Convert.ToBoolean(valueArray[row, 8])));
            }

            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);

            return History;
        }

        internal BindingList<CWaitingList> readAllWaitingList(BindingList<CWaitingList> WaitList)
        {
            throw new NotImplementedException();
        }
    }
}
