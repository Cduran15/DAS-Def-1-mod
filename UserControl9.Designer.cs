namespace DAS_Def_1
{
    partial class UC_Graph
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
            this.labelGraph = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGraph
            // 
            this.labelGraph.AutoSize = true;
            this.labelGraph.Location = new System.Drawing.Point(19, 18);
            this.labelGraph.Name = "labelGraph";
            this.labelGraph.Size = new System.Drawing.Size(46, 13);
            this.labelGraph.TabIndex = 0;
            this.labelGraph.Text = "Graficas";
            this.labelGraph.Click += new System.EventHandler(this.label1_Click);
            // 
            // UC_Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelGraph);
            this.Name = "UC_Graph";
            this.Size = new System.Drawing.Size(313, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGraph;
    }
}
