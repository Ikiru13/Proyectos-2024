namespace BankLibrary
{
    partial class BankUIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtAccount = new TextBox();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastname = new TextBox();
            label3 = new Label();
            txtBalance = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 44);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Cuenta:";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(130, 41);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(378, 23);
            txtAccount.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(130, 87);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(378, 23);
            txtFirstName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 95);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Primer Nombre:";
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(130, 132);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(378, 23);
            txtLastname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 140);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido paterno:";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(130, 177);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(378, 23);
            txtBalance.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 185);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Saldo:";
            // 
            // BankUIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 267);
            Controls.Add(txtBalance);
            Controls.Add(label4);
            Controls.Add(txtLastname);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(txtAccount);
            Controls.Add(label1);
            Name = "BankUIForm";
            Text = "BankUIForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAccount;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastname;
        private Label label3;
        private TextBox txtBalance;
        private Label label4;
    }
}