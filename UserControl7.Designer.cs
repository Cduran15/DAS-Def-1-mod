namespace DAS_Def_1
{
    partial class UC_Prestamo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPyD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPyD
            // 
            this.labelPyD.AutoSize = true;
            this.labelPyD.Location = new System.Drawing.Point(16, 23);
            this.labelPyD.Name = "labelPyD";
            this.labelPyD.Size = new System.Drawing.Size(132, 13);
            this.labelPyD.TabIndex = 0;
            this.labelPyD.Text = "Prestamos y Devoluciones";
            // 
            // UC_Prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPyD);
            this.Name = "UC_Prestamo";
            this.Size = new System.Drawing.Size(331, 261);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPyD;
    }
}
