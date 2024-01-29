namespace WindowsF
{
    partial class Form1
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
            this.lstAllLines = new System.Windows.Forms.ListBox();
            this.lblNewEntrie = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAllLines
            // 
            this.lstAllLines.FormattingEnabled = true;
            this.lstAllLines.Location = new System.Drawing.Point(47, 103);
            this.lstAllLines.Name = "lstAllLines";
            this.lstAllLines.Size = new System.Drawing.Size(249, 251);
            this.lstAllLines.TabIndex = 0;
            this.lstAllLines.SelectedIndexChanged += new System.EventHandler(this.lstAllLines_SelectedIndexChanged);
            // 
            // lblNewEntrie
            // 
            this.lblNewEntrie.AutoSize = true;
            this.lblNewEntrie.Location = new System.Drawing.Point(345, 103);
            this.lblNewEntrie.Name = "lblNewEntrie";
            this.lblNewEntrie.Size = new System.Drawing.Size(59, 13);
            this.lblNewEntrie.TabIndex = 1;
            this.lblNewEntrie.Text = "New Entrie";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(348, 137);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
            this.txtFirstname.TabIndex = 2;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(348, 177);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 20);
            this.txtLastname.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(348, 223);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(348, 289);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveToFile.TabIndex = 5;
            this.btnSaveToFile.Text = "Save";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(47, 43);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDatos.TabIndex = 6;
            this.btnCargarDatos.Text = "Load";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblNewEntrie);
            this.Controls.Add(this.lstAllLines);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAllLines;
        private System.Windows.Forms.Label lblNewEntrie;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnCargarDatos;
    }
}

