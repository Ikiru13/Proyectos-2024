using BankLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creditlnquiry
{
    public partial class CreditlnquiryForm : Form
    {
        private FileRepository? _fileRepository;
        public CreditlnquiryForm()
        {
            InitializeComponent();
        }

        private void getBalances_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;

            string accountType = senderButton.Text;

            try
            {
                _fileRepository?.ResetFilePointer();

                txtDisplay.Text = $"Las cuentas con {accountType}{Environment.NewLine}";

                while (true)
                {
                    var inputRecord = _fileRepository?.ReadNextRecord();

                    if (inputRecord == null)
                    {
                        return;
                    }

                    string[] inputFields = inputRecord.Split(",");

                    var record =
                        new Record(int.Parse(inputFields[0]), inputFields[1], inputFields[2], decimal.Parse(inputFields[3]));

                    if (ShouldDisplay(record.Balance, accountType))
                    {
                        txtDisplay.AppendText($"{record.Account}\t{record.FirstName}\t{record.LastName}\t{record.Balance:C}{Environment.NewLine}");
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ShouldDisplay(decimal balance, string accountType)
        {
            if (balance > 0M && accountType == "Saldos con credito")
            {
                return true;
            }
            else if (balance < 0 && accountType == "Saldos con debito")
            {
                return true;
            }
            else if (balance == 0 && accountType == "Saldos en cero")
            {
                return true;
            }
            return false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileCHooser = new OpenFileDialog())
            {
                result = fileCHooser.ShowDialog();
                fileName = fileCHooser.FileName;
            }
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Nombre de archivo invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _fileRepository = new FileRepository(fileName);
                    _fileRepository?.OpenFile();

                    btnOpen.Enabled = false;
                    btnCredit.Enabled = true;
                    btnDebit.Enabled = true;
                    btnZero.Enabled = true;
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                _fileRepository?.ClseFile();
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Exit();
        }
    }
}
