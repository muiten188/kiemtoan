using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System;
using System.Diagnostics;

namespace KiemToan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void readFileCSV() {
            List<Input1> Listinput1 = new List<Input1>();
            List<Input2> Listinput2 = new List<Input2>();
            List<Output> ListOutput = new List<Output>();
            using (TextReader reader = File.OpenText(textBox1.Text))
            {
                CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;
                while (csv.Read())
                {
                    Input1 Record = csv.GetRecord<Input1>();
                    Listinput1.Add(Record);
                }
            }

            using (TextReader reader2 = File.OpenText(textBox2.Text))
            {
                CsvReader csv = new CsvReader(reader2, System.Globalization.CultureInfo.CurrentCulture);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;
                while (csv.Read())
                {
                    Input2 Record = csv.GetRecord<Input2>();
                    Listinput2.Add(Record);
                }
            }
            var joinedData = from l2 in Listinput2
                             join l1 in Listinput1 on l2.MaHang equals l1.MaHang
                             select new {l2.Ngay, l2.SoHD, l2.MaHang, l2.SL, l2.DonGia, l2.ThanhTien, l2.TienThueNop, l1.ThueSuat };
            foreach (var item in joinedData)
            {
                Double ThueKT = Math.Round((item.SL * item.DonGia * item.ThueSuat)/100, 0);
                if(ThueKT != item.TienThueNop)
                {
                    Output output = new Output();
                    output.Ngay = item.Ngay;
                    output.SoHD = item.SoHD;
                    output.MaHang = item.MaHang;
                    output.TienThueNop = item.TienThueNop;
                    output.ThueKiemToan = ThueKT;
                    ListOutput.Add(output);
                }
            }
            saveFileDialog1.FileName = "Output.csv";
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";
            

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(saveFileDialog1.FileName))
                using (var csv = new CsvWriter(writer, System.Globalization.CultureInfo.CurrentCulture))
                {
                    try { 
                        csv.WriteRecords(ListOutput);
                        label1.ForeColor = System.Drawing.Color.Green;
                        label1.Text = "Compare successfully!";
                        Process.Start(Path.GetDirectoryName(saveFileDialog1.FileName));
                    }
                    catch (Exception ex)
                    {
                        label1.ForeColor = System.Drawing.Color.Red;
                        label1.Text = "Compare Error! ( " + ex.Message + " )" ;
                    }
                }
            }
        }

        private void bt_Input1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); 
            if (result == DialogResult.OK)
            {
                    textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void bt_Input2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox2.Text = openFileDialog2.FileName;
            }

        }

        private void bt_Output_Click(object sender, EventArgs e)
        {
            try
            {
                readFileCSV();
            }catch(Exception ex)
            {
                label1.ForeColor = System.Drawing.Color.Red;
                label1.Text = "Compare Error! ( " + ex.Message + " )";
            }
        }
    }
}
