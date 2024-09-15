namespace DAS_Def_1
{
    partial class UC_AgregarLibro
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
            this.LabelAL = new System.Windows.Forms.Label();
            this.LabelNL = new System.Windows.Forms.Label();
            this.LabelAutLib = new System.Windows.Forms.Label();
            this.labelEdi = new System.Windows.Forms.Label();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreLibro = new System.Windows.Forms.TextBox();
            this.Autor = new System.Windows.Forms.TextBox();
            this.Edicion = new System.Windows.Forms.DomainUpDown();
            this.Idioma = new System.Windows.Forms.DomainUpDown();
            this.Estado = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // LabelAL
            // 
            this.LabelAL.AutoSize = true;
            this.LabelAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAL.Location = new System.Drawing.Point(11, 11);
            this.LabelAL.Name = "LabelAL";
            this.LabelAL.Size = new System.Drawing.Size(132, 24);
            this.LabelAL.TabIndex = 0;
            this.LabelAL.Text = "Agregar libro";
            // 
            // LabelNL
            // 
            this.LabelNL.AutoSize = true;
            this.LabelNL.Location = new System.Drawing.Point(12, 74);
            this.LabelNL.Name = "LabelNL";
            this.LabelNL.Size = new System.Drawing.Size(86, 13);
            this.LabelNL.TabIndex = 1;
            this.LabelNL.Text = "Nombre del libro:";
            this.LabelNL.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelAutLib
            // 
            this.LabelAutLib.AutoSize = true;
            this.LabelAutLib.Location = new System.Drawing.Point(63, 100);
            this.LabelAutLib.Name = "LabelAutLib";
            this.LabelAutLib.Size = new System.Drawing.Size(35, 13);
            this.LabelAutLib.TabIndex = 2;
            this.LabelAutLib.Text = "Autor:";
            // 
            // labelEdi
            // 
            this.labelEdi.AutoSize = true;
            this.labelEdi.Location = new System.Drawing.Point(25, 125);
            this.labelEdi.Name = "labelEdi";
            this.labelEdi.Size = new System.Drawing.Size(73, 13);
            this.labelEdi.TabIndex = 3;
            this.labelEdi.Text = "Edicion (Año):";
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Location = new System.Drawing.Point(57, 151);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(41, 13);
            this.labelIdioma.TabIndex = 4;
            this.labelIdioma.Text = "Idioma:";
            this.labelIdioma.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estado:";
            // 
            // NombreLibro
            // 
            this.NombreLibro.Location = new System.Drawing.Point(104, 71);
            this.NombreLibro.Name = "NombreLibro";
            this.NombreLibro.Size = new System.Drawing.Size(173, 20);
            this.NombreLibro.TabIndex = 6;
            // 
            // Autor
            // 
            this.Autor.Location = new System.Drawing.Point(104, 97);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(173, 20);
            this.Autor.TabIndex = 7;
            // 
            // Edicion
            // 
            this.Edicion.Items.Add("2024");
            this.Edicion.Items.Add("2023");
            this.Edicion.Items.Add("2022");
            this.Edicion.Items.Add("2021");
            this.Edicion.Items.Add("2020");
            this.Edicion.Items.Add("2019");
            this.Edicion.Items.Add("2018");
            this.Edicion.Items.Add("2017");
            this.Edicion.Items.Add("2016");
            this.Edicion.Items.Add("2015");
            this.Edicion.Items.Add("2014");
            this.Edicion.Items.Add("2013");
            this.Edicion.Items.Add("2012");
            this.Edicion.Items.Add("2011");
            this.Edicion.Items.Add("2010");
            this.Edicion.Items.Add("2009");
            this.Edicion.Items.Add("2008");
            this.Edicion.Items.Add("2007");
            this.Edicion.Items.Add("2006");
            this.Edicion.Items.Add("2005");
            this.Edicion.Items.Add("2004");
            this.Edicion.Items.Add("2003");
            this.Edicion.Items.Add("2002");
            this.Edicion.Items.Add("2001");
            this.Edicion.Items.Add("2000");
            this.Edicion.Location = new System.Drawing.Point(104, 123);
            this.Edicion.Name = "Edicion";
            this.Edicion.Size = new System.Drawing.Size(173, 20);
            this.Edicion.TabIndex = 8;
            this.Edicion.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // Idioma
            // 
            this.Idioma.Items.Add("Español");
            this.Idioma.Items.Add("Ingles");
            this.Idioma.Items.Add("Frances");
            this.Idioma.Items.Add("Italiano");
            this.Idioma.Items.Add("Aleman");
            this.Idioma.Items.Add("Portugues");
            this.Idioma.Items.Add("Japones");
            this.Idioma.Items.Add("Mandarin");
            this.Idioma.Items.Add("Cantones");
            this.Idioma.Location = new System.Drawing.Point(104, 149);
            this.Idioma.Name = "Idioma";
            this.Idioma.Size = new System.Drawing.Size(173, 20);
            this.Idioma.TabIndex = 9;
            // 
            // Estado
            // 
            this.Estado.Items.Add("Disponible");
            this.Estado.Items.Add("Descontinuado");
            this.Estado.Items.Add("Prestado (No disponible)");
            this.Estado.Location = new System.Drawing.Point(104, 175);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(173, 20);
            this.Estado.TabIndex = 10;
            // 
            // UC_AgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Idioma);
            this.Controls.Add(this.Edicion);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.NombreLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIdioma);
            this.Controls.Add(this.labelEdi);
            this.Controls.Add(this.LabelAutLib);
            this.Controls.Add(this.LabelNL);
            this.Controls.Add(this.LabelAL);
            this.Name = "UC_AgregarLibro";
            this.Size = new System.Drawing.Size(313, 217);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAL;
        private System.Windows.Forms.Label LabelNL;
        private System.Windows.Forms.Label LabelAutLib;
        private System.Windows.Forms.Label labelEdi;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreLibro;
        private System.Windows.Forms.TextBox Autor;
        private System.Windows.Forms.DomainUpDown Edicion;
        private System.Windows.Forms.DomainUpDown Idioma;
        private System.Windows.Forms.DomainUpDown Estado;
    }
}
