using BankLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadSequentialAccesFile
{
    public partial class ReadSequentialAccesFileForm : BankUIForm
    {
        private FileRepository? _fileRepository;
        public ReadSequentialAccesFileForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                ClearTextBoxes();
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Nombre de archivo invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        _fileRepository = new FileRepository(fileName);
                        _fileRepository?.OpenFile();

                        btnOpen.Enabled = false;
                        btnNext.Enabled = true;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var inputRecord = _fileRepository?.ReadNextRecord();
            try
            {
                if (inputRecord != null)
                { 
                    string[] inputFields = inputRecord.Split(",");
                    SetTextBoxValues(inputFields);
                }
                else
                {
                    _fileRepository?.ClseFile();
                    btnOpen.Enabled = true;
                    btnNext.Enabled = false;
                    ClearTextBoxes();

                    MessageBox.Show("No hay masregistros en el archivo", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
