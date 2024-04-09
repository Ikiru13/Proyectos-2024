using BankLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateFile
{
    public partial class CreateFileForm : BankUIForm
    {
        private FileRepository? _fileRepository;
        public CreateFileForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Nombre de archivo invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        _fileRepository = new FileRepository(fileName);
                        _fileRepository?.OpenOrCreateFile();

                        btnSave.Enabled = false;
                        btnEnter.Enabled = true;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string[] values = GetTextValues();

            try
            {
                if (!string.IsNullOrEmpty(values[(int)TextBoxIndices.Account]))
                {
                    int accountNumber = int.Parse(values[(int)TextBoxIndices.Account]);

                    if (accountNumber > 0)
                    {
                        var record = new Record(accountNumber, values[(int)TextBoxIndices.First], values[(int)TextBoxIndices.Last], decimal.Parse(values[(int)TextBoxIndices.Balance]));

                        _fileRepository?.WriteRecordToFile(record);
                    }
                    else
                    {
                        MessageBox.Show("Numero de cuentas invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearTextBoxes();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                _fileRepository?.ClseFile();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }
    }
}
