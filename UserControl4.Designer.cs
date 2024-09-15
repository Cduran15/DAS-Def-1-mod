namespace DAS_Def_1
{
    partial class UC_Remove
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
            this.labelRemove1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRemove1
            // 
            this.labelRemove1.AutoSize = true;
            this.labelRemove1.Location = new System.Drawing.Point(14, 22);
            this.labelRemove1.Name = "labelRemove1";
            this.labelRemove1.Size = new System.Drawing.Size(72, 13);
            this.labelRemove1.TabIndex = 0;
            this.labelRemove1.Text = "Remover libro";
            // 
            // UC_Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelRemove1);
            this.Name = "UC_Remove";
            this.Size = new System.Drawing.Size(302, 227);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRemove1;
    }
}
