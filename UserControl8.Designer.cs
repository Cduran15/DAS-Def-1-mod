namespace DAS_Def_1
{
    partial class UC_History
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
            this.labelHistory1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHistory1
            // 
            this.labelHistory1.AutoSize = true;
            this.labelHistory1.Location = new System.Drawing.Point(22, 26);
            this.labelHistory1.Name = "labelHistory1";
            this.labelHistory1.Size = new System.Drawing.Size(110, 13);
            this.labelHistory1.TabIndex = 0;
            this.labelHistory1.Text = "Historial de prestamos";
            // 
            // UC_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelHistory1);
            this.Name = "UC_History";
            this.Size = new System.Drawing.Size(321, 257);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHistory1;
    }
}
