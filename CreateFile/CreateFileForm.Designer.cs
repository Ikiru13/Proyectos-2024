namespace CreateFile
{
    partial class CreateFileForm
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
            btnSave = new Button();
            btnEnter = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(75, 296);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar Como";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEnter
            // 
            btnEnter.Enabled = false;
            btnEnter.Location = new Point(225, 296);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 23);
            btnEnter.TabIndex = 9;
            btnEnter.Text = "Ingresar";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(374, 296);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // CreateFileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 370);
            Controls.Add(btnExit);
            Controls.Add(btnEnter);
            Controls.Add(btnSave);
            Name = "CreateFileForm";
            Text = "Crear archivo";
            Controls.SetChildIndex(btnSave, 0);
            Controls.SetChildIndex(btnEnter, 0);
            Controls.SetChildIndex(btnExit, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnEnter;
        private Button btnExit;
    }
}