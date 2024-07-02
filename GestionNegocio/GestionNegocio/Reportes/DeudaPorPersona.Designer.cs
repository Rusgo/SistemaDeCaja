namespace GestionNegocio.Reportes
{
    partial class DeudaPorPersona
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_buscat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionNegocio.Reportes.DeudaxCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 88);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(764, 437);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_buscat
            // 
            this.btn_buscat.Location = new System.Drawing.Point(427, 37);
            this.btn_buscat.Name = "btn_buscat";
            this.btn_buscat.Size = new System.Drawing.Size(103, 23);
            this.btn_buscat.TabIndex = 2;
            this.btn_buscat.Text = "Buscar";
            this.btn_buscat.UseVisualStyleBackColor = true;
            this.btn_buscat.Click += new System.EventHandler(this.btn_buscat_Click);
            // 
            // DeudaPorPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(759, 524);
            this.Controls.Add(this.btn_buscat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "DeudaPorPersona";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeudaPorPersona";
            this.Load += new System.EventHandler(this.DeudaPorPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_buscat;
    }
}