namespace DAS_Def_1
{
    partial class UC_RemoveUser
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
            this.labelRemUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRemUser
            // 
            this.labelRemUser.AutoSize = true;
            this.labelRemUser.Location = new System.Drawing.Point(60, 25);
            this.labelRemUser.Name = "labelRemUser";
            this.labelRemUser.Size = new System.Drawing.Size(89, 13);
            this.labelRemUser.TabIndex = 0;
            this.labelRemUser.Text = "Remover Usuario";
            this.labelRemUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // UC_RemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelRemUser);
            this.Name = "UC_RemoveUser";
            this.Size = new System.Drawing.Size(289, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRemUser;
    }
}
