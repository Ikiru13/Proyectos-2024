namespace Creditlnquiry
{
    partial class CreditlnquiryForm
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
            txtDisplay = new TextBox();
            btnOpen = new Button();
            btnCredit = new Button();
            btnDebit = new Button();
            btnZero = new Button();
            btnDone = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(776, 301);
            txtDisplay.TabIndex = 0;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(12, 338);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(97, 23);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Abrir archivo";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnCredit
            // 
            btnCredit.Enabled = false;
            btnCredit.Location = new Point(141, 338);
            btnCredit.Name = "btnCredit";
            btnCredit.Size = new Size(122, 23);
            btnCredit.TabIndex = 2;
            btnCredit.Text = "Saldos con credito";
            btnCredit.UseVisualStyleBackColor = true;
            btnCredit.Click += getBalances_Click;
            // 
            // btnDebit
            // 
            btnDebit.Enabled = false;
            btnDebit.Location = new Point(293, 338);
            btnDebit.Name = "btnDebit";
            btnDebit.Size = new Size(113, 23);
            btnDebit.TabIndex = 3;
            btnDebit.Text = "Saldos con debito";
            btnDebit.UseVisualStyleBackColor = true;
            btnDebit.Click += getBalances_Click;
            // 
            // btnZero
            // 
            btnZero.Enabled = false;
            btnZero.Location = new Point(437, 338);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(103, 23);
            btnZero.TabIndex = 4;
            btnZero.Text = "Saldos en cero";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += getBalances_Click;
            // 
            // btnDone
            // 
            btnDone.Location = new Point(687, 338);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(75, 23);
            btnDone.TabIndex = 5;
            btnDone.Text = "Salir";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // CreditlnquiryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDone);
            Controls.Add(btnZero);
            Controls.Add(btnDebit);
            Controls.Add(btnCredit);
            Controls.Add(btnOpen);
            Controls.Add(txtDisplay);
            Name = "CreditlnquiryForm";
            Text = "Consulta de Credito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnOpen;
        private Button btnCredit;
        private Button btnDebit;
        private Button btnZero;
        private Button btnDone;
    }
}