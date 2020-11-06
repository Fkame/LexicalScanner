using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_LexicalScanner
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Производит предподготовку перед использованием формы:
        /// 1. Кастомизирует таблицу лексем.
        /// </summary>
        private void Preparations()
        {
            CustomizeDataGridView();
        }

        private void CustomizeDataGridView()
        {
            // Общий вид таблицы
            LexemGuiTable.EnableHeadersVisualStyles = false;
            LexemGuiTable.AlternatingRowsDefaultCellStyle = null;
            LexemGuiTable.BackgroundColor = Color.Beige;
            LexemGuiTable.RowHeadersVisible = false;

            // Ячейки с данными
            LexemGuiTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            LexemGuiTable.GridColor = Color.FromArgb(191, 182, 48);
            LexemGuiTable.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            LexemGuiTable.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            LexemGuiTable.BackgroundColor = Color.Beige;
            LexemGuiTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            LexemGuiTable.DefaultCellStyle.Font = new Font("Ubuntu", 14);

            // Ячейки заголовка
            /*
            LexemGuiTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            LexemGuiTable.ColumnHeadersDefaultCellStyle.Font = new Font("Ubuntu", 18, FontStyle.Bold);
            LexemGuiTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(48, 48, 59);
            LexemGuiTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.Beige;
            */
            LexemGuiTable.ColumnHeadersVisible = false;
            LexemGuiTable.RowHeadersVisible = false;
        }   

        /// <summary>
        /// После нажатия на кнопку открывается проводник, где пользователь должен выбрать файл с кодом. 
        /// После этого запускается сканнер лексем и заполняется таблица лексем.
        /// После этого таблица лексем выводится в GUI-таблицу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseFileBtn_Click(object sender, EventArgs e)
        {
            string fileText = ChooseAndReadFile();
            List<LexemDataCell> lexemTable = DoAnalysis(fileText);
            if (lexemTable == null) return;
            FillGUITable(lexemTable);
        }

        private string ChooseAndReadFile()
        {
            FileTextField.Clear();
            NameOfFileField.Clear();

            var fileContent = string.Empty;
            var filePath = string.Empty;

            // Чтение из файла
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    fileContent = System.IO.File.ReadAllText(filePath);
                }
                else
                {
                    return string.Empty;
                }
            }

            NameOfFileField.Text = filePath;
            FileTextField.Text = fileContent;

            return fileContent;
        }

        private List<LexemDataCell> DoAnalysis(string fileText)
        {
            return (new LexemScanner(fileText)).DoAnalysis();
        }

        private void FillGUITable(List<LexemDataCell> lexemTable)
        {
            LexemGuiTable.Rows.Clear();

            int rowCount = 1;
            LexemGuiTable.RowCount = lexemTable.Count + 1;
            LexemGuiTable.ColumnCount = 4;
            LexemGuiTable.Rows[rowCount - 1].Cells[0].Value = "Lexem №";
            LexemGuiTable.Rows[rowCount - 1].Cells[1].Value = "String №";
            LexemGuiTable.Rows[rowCount - 1].Cells[2].Value = "Lexem value";
            LexemGuiTable.Rows[rowCount - 1].Cells[3].Value = "Lexem type";

            // Найстройка ширины ячеек
            foreach (DataGridViewColumn c in LexemGuiTable.Columns)
            {
                c.Width = LexemGuiTable.Width / 4 - 4;
            }

            // Найстройка высоты ячеек
            foreach (DataGridViewRow c in LexemGuiTable.Rows)
            {
                c.Height = c.Height + 10;
            }

            foreach (LexemDataCell row in lexemTable)
            {
                LexemGuiTable.Rows[rowCount].Cells[0].Value = rowCount.ToString();
                LexemGuiTable.Rows[rowCount].Cells[1].Value = row.NumOfString.ToString();
                LexemGuiTable.Rows[rowCount].Cells[2].Value = row.Lexem;
                LexemGuiTable.Rows[rowCount].Cells[3].Value = row.LexType.ToString();
                rowCount++;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
