using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLibrary
{
    public partial class BankUIForm : Form
    {
        protected int TextBoxCount { get; set; } = 4; //Numero de controles TextBox en el formulario
        
        public enum TextBoxIndices {Account, First, Last, Balance }
        public BankUIForm()
        {
            InitializeComponent();
        }

        public void ClearTextBoxes()
        {
            foreach(Control guiControl in Controls) 
            {
                (guiControl as TextBox)?.Clear();
            }
        }

        public void SetTextBoxValues(string[] values)
        {
            if(values.Length != TextBoxCount)
            {
                throw (new ArgumentException($"There must be {TextBoxCount} string is in the array", nameof(values)));
            }
            else
            {
                txtAccount.Text = values[(int)TextBoxIndices.Account];
                txtFirstName.Text = values[(int)TextBoxIndices.First];
                txtLastname.Text = values[(int)TextBoxIndices.Last];
                txtBalance.Text = values[(int)TextBoxIndices.Balance];
            }
        }

        public string[] GetTextValues()
        {
            return new string[] {txtAccount.Text, txtFirstName.Text,txtLastname.Text, txtBalance.Text};
        }
    }
}
