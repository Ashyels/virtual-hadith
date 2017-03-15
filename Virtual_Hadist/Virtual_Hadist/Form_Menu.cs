using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Virtual_Hadist
{
    public partial class Form_Menu : Form
    {
        private void cmb_bab_SelectedIndexChanged(object sender, EventArgs e){}
        private void richTextBox1_TextChanged(object sender, EventArgs e) {}

        public Form_Menu()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            Form_Start fs = new Form_Start();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open("D:\\Virtual Hadist Project\\DataBase1.xlsx");
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(1);
            Excel.Range xlRange = xlWorksheet.UsedRange;
            object[,] valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

            for (int row = 3; row <= 11; row++)
            {
                cmb_bab.Items.Add(valueArray[row, 1]);
                row++;
            }


            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Form_Start fs = new Form_Start();
            this.Hide();
            fs.Show();
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            switch (cmb_subbab.Text)
            {
                case "Tata Cara Makan di Meja Makan":
                    axWindowsMediaPlayer1.URL = "D:\\Virtual Hadist Project\\Sound Hadist\\01.m4a";break;
                case "Perintah Makan Menggunakan Tangan Kanan":
                    axWindowsMediaPlayer1.URL = "D:\\Virtual Hadist Project\\Sound Hadist\\02.m4a"; break;
                case "Terlalu Banyak Makan Tidak Sehat":
                    axWindowsMediaPlayer1.URL = "D:\\Virtual Hadist Project\\Sound Hadist\\03.m4a"; break;
                case "Dianjurkan Berobat":
                    axWindowsMediaPlayer1.URL = "D:\\Virtual Hadist Project\\Sound Hadist\\04.m4a"; break;
                case "Shalat pada malam Lailatul Qadar":
                    axWindowsMediaPlayer1.URL = "D:\\Virtual Hadist Project\\Sound Hadist\\05.m4a"; break;
                case "Shalat malam (tarawih) Pada Bulan Ramadhan menghilangkan ":
                    axWindowsMediaPlayer1.URL = "D:\\Virtual Hadist Project\\Sound Hadist\\06.m4a"; break;
                case "Belajar Qur'an":
                    axWindowsMediaPlayer1.URL = "D:\\Virtual Hadist Project\\Sound Hadist\\07.m4a"; break;
                case "Kebaikan terhadap Orang yang Allah Berikan Ilmu":
                    axWindowsMediaPlayer1.URL = "D:\\Virtual Hadist Project\\Sound Hadist\\08.m4a"; break;
                case "Mendirikan Shalat":
                    axWindowsMediaPlayer1.URL = "D:\\Virtual Hadist Project\\Sound Hadist\\09.m4a"; break;
                case "Shalat pada Umur Tujuh Tahun":
                    axWindowsMediaPlayer1.URL = "D:\\Virtual Hadist Project\\Sound Hadist\\10.m4a"; break;
            }

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            List<ExcelHadist> Hadist = new List<ExcelHadist>();
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open("D:\\Virtual Hadist Project\\DataBase1.xlsx");
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(1);
            Excel.Range xlRange = xlWorksheet.UsedRange;

            object[,] valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

            for (int row = 3; row <= 11; row++)
            {
                if (valueArray[row, 2].ToString() == cmb_subbab.Text)
                {
                    rtb_terjemahan.Text = valueArray[row, 3].ToString();
                    rtb_arab.Text = valueArray[row, 4].ToString();
                    rtb_shahih.Text = valueArray[row, 5].ToString();
                    row = 20;
                }
            }


            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);


        
        }

        private void cmb_subbab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmb_subbab.Text)
            {
                case "Tata Cara Makan di Meja Makan":
                    pb_gambar.ImageLocation = "D:\\Virtual Hadist Project\\Gambar\\1.jpg"; break;
                case "Perintah Makan Menggunakan Tangan Kanan":
                    pb_gambar.ImageLocation = "D:\\Virtual Hadist Project\\Gambar\\2.jpg"; break;
                case "Terlalu Banyak Makan Tidak Sehat":
                    pb_gambar.ImageLocation = "D:\\Virtual Hadist Project\\Gambar\\3.jpg"; break;
                case "Dianjurkan Berobat":
                    pb_gambar.ImageLocation = "D:\\Virtual Hadist Project\\Gambar\\4.jpg"; break;
                case "Shalat pada malam Lailatul Qadar":
                    pb_gambar.ImageLocation = "D:\\Virtual Hadist Project\\Gambar\\5.jpg"; break;
                case "Shalat malam (tarawih) Pada Bulan Ramadhan menghilangkan ":
                    pb_gambar.ImageLocation = "D:\\Virtual Hadist Project\\Gambar\\6.jpg"; break;
                case "Belajar Qur'an":
                    pb_gambar.ImageLocation = "D:\\Virtual Hadist Project\\Gambar\\7.jpg"; break;
                case "Kebaikan terhadap Orang yang Allah Berikan Ilmu":
                    pb_gambar.ImageLocation = "D:\\Virtual Hadist Project\\Gambar\\8.jpg"; break;
                case "Mendirikan Shalat":
                    pb_gambar.ImageLocation = "D:\\Virtual Hadist Project\\Gambar\\9.jpg"; break;
                case "Shalat pada Umur Tujuh Tahun":
                    pb_gambar.ImageLocation = "D:\\Virtual Hadist Project\\Gambar\\10.jpg"; break;
            }
        }

        private void cmb_bab_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmb_subbab.Items.Clear();
            cmb_subbab.Text = "";

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open("D:\\Virtual Hadist Project\\DataBase1.xlsx");
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(1);
            Excel.Range xlRange = xlWorksheet.UsedRange;
            object[,] valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

            for (int row = 3; row <= 11; row++)
            {
                if (cmb_bab.Text == valueArray[row, 1].ToString())
                {
                    cmb_subbab.Items.Add(valueArray[row, 2].ToString());
                    cmb_subbab.Items.Add(valueArray[row + 1, 2].ToString());
                    row = 20;
                }
                row++;
            }

            
            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);
            

        }
    }
}
