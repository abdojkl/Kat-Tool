using System;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading.Tasks;
namespace KAT
{
    public partial class KAT : Form
    {
        String[] col_compo;
        String link;
        int rowCount;
        int colCount;
        int serch_column;
        private string orginalDataFileName = AppDomain.CurrentDomain.BaseDirectory + @".xlsx";
        OpenFileDialog ofd;
        String img_link;
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkbook;
        Excel.Worksheet xlWorksheet;
        Excel.Range xlRange;

        public KAT()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void open_bt_Click(object sender, EventArgs e)
        {
           
        }
              
        private void column_compo_SelectedIndexChanged(object sender, EventArgs e)
        {
            serch_column = column_compo.SelectedIndex + 1;

        }

        private void show_img_bt_Click(object sender, EventArgs e)
        {
            xlWorkbook = xlApp.Workbooks.Open(Path.GetFullPath(ofd.FileName));
            xlWorksheet = xlWorkbook.Sheets[1];
            String search_value = search_value2.Text;
            String kobo_account = kobo_account_tx2.Text;
            String account_type = account_type_comp2.Text;
            int valcol = img_compo2.SelectedIndex + 1;
            int valrow = 0;
            if (search_value == "" || kobo_account == "" || account_type == "" || file_path_tx2.Text == "")
            {
                MessageBox.Show("يرجة تعبئة كافة الحقول");
                goto end;
            }
            for (int i = 1; i <= rowCount; i++)
            {
                if (xlRange.Cells[i, serch_column] != null && xlRange.Cells[i, serch_column].Value2 != null)
                {
                    if (search_value == xlRange.Cells[i, serch_column].Value2.ToString())

                        valrow = i;


                }


            }
            img_link = account_type + "attachment/original?media_file=" + kobo_account + "/attachments/" + xlRange.Cells[valrow, valcol].Value2.ToString();
           
            System.Diagnostics.Process.Start(img_link);


            xlWorkbook.Close();
            xlApp.Quit();
            end:;

        }

        private void img_compo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void export_file_bt_Click(object sender, EventArgs e)
        {
          //  SaveFileDialog sfv = saveFileDialog1;
           // sfv.Title = "اختر ملف الحفظ";
           // sfv.Filter = " (*.xlsx)|*.xlsx";
         //   sfv.InitialDirectory = Directory.GetCurrentDirectory();
          //  sfv.ShowDialog();

            xlWorkbook = xlApp.Workbooks.Open(Path.GetFullPath(ofd.FileName));
            xlWorksheet = xlWorkbook.Sheets[1];
            String kobo_account = kobo_account_tx.Text;
            String account_type = account_type_comp.Text;
            int valcol = img_compo.SelectedIndex + 1;


            if (kobo_account == "" || account_type == "" || file_path_tx.Text == "" || valcol==null)
            {
                MessageBox.Show("يرجة تعبئة كافة الحقول");
                goto end2;
            }
            for (int i = 1; i <= rowCount; i++)
            {
                if (xlRange.Cells[i, valcol] != null && xlRange.Cells[i, valcol].Value2 != null)
                {

                    link= account_type + "attachment/original?media_file=" + kobo_account + "/attachments/" + xlRange.Cells[i, valcol].Value2.ToString();
                   // xlRange.Cells[i, colCount + 1].Value2 = link;

                }


            }
             

          MessageBox.Show(link);
            //    System.Diagnostics.Process.Start(img_link);


            xlWorkbook.Close();
            xlApp.Quit();
            end2:;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void account_type_comp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Title = "اختر ملف الداتا اكسل";
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            ofd.Filter = " (*.xlsx)|*.xlsx";
            ofd.ShowDialog();
            file_path_tx2.Text = Path.GetFullPath(ofd.FileName);
            xlWorkbook = xlApp.Workbooks.Open(Path.GetFullPath(ofd.FileName));
            xlWorksheet = xlWorkbook.Sheets[1];
            xlRange = xlWorksheet.UsedRange;
            colCount = xlRange.Columns.Count;
            rowCount = xlRange.Rows.Count;
           

            col_compo = new string[colCount];
            for (int i = 1; i <= colCount; i++)
            {
                if (xlRange.Cells[1, i] != null && xlRange.Cells[1, i].Value2 != null)
                {
                    col_compo[i - 1] = xlRange.Cells[1, i].Value2.ToString();
                    column_compo.Items.Add(col_compo[i - 1]);
                    img_compo2.Items.Add(col_compo[i - 1]);
                }

            }
            xlWorkbook.Close();
            xlApp.Quit();
        }

        private void open_bt_Click_1(object sender, EventArgs e)
        {
             ofd.Title = "اختر ملف الداتا اكسل";
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            ofd.Filter = " (*.xlsx)|*.xlsx";
            ofd.ShowDialog();
            file_path_tx.Text = Path.GetFullPath(ofd.FileName);
            xlWorkbook = xlApp.Workbooks.Open(Path.GetFullPath(ofd.FileName));
            xlWorksheet = xlWorkbook.Sheets[1];
            xlRange = xlWorksheet.UsedRange;
            colCount = xlRange.Columns.Count;
            rowCount = xlRange.Rows.Count;
           

            col_compo = new string[colCount];
            for (int i = 1; i <= colCount; i++)
            {
                if (xlRange.Cells[1, i] != null && xlRange.Cells[1, i].Value2 != null)
                {
                    col_compo[i - 1] = xlRange.Cells[1, i].Value2.ToString();
                   
                    img_compo.Items.Add(col_compo[i - 1]);
                }
            }
            xlWorkbook.Close();
            xlApp.Quit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

