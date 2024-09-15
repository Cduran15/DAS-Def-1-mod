namespace DAS_Def_1
{
    partial class UC_Consulta
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
            this.labelCL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCL
            // 
            this.labelCL.AutoSize = true;
            this.labelCL.Location = new System.Drawing.Point(26, 27);
            this.labelCL.Name = "labelCL";
            this.labelCL.Size = new System.Drawing.Size(73, 13);
            this.labelCL.TabIndex = 0;
            this.labelCL.Text = "Consultar libro";
            // 
            // UC_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCL);
            this.Name = "UC_Consulta";
            this.Size = new System.Drawing.Size(351, 257);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCL;
    }
}
