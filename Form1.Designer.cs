namespace DAS_Def_1
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
            RegistroLibro = new System.Windows.Forms.Button();
            Bienvenida = new System.Windows.Forms.Label();
            ConsultaLibro = new System.Windows.Forms.Button();
            ActualizaLibro = new System.Windows.Forms.Button();
            EliminaLibro = new System.Windows.Forms.Button();
            GestionLibro = new System.Windows.Forms.GroupBox();
            GestionUsuario = new System.Windows.Forms.GroupBox();
            RemoverUsuario = new System.Windows.Forms.Button();
            RegistroUsuario = new System.Windows.Forms.Button();
            OtraGes = new System.Windows.Forms.GroupBox();
            btnSalir = new System.Windows.Forms.Button();
            Grafic = new System.Windows.Forms.Button();
            HistPrest = new System.Windows.Forms.Button();
            PrestDevol = new System.Windows.Forms.Button();
            uC_AgregarLibro1 = new UC_AgregarLibro();
            GestionLibro.SuspendLayout();
            GestionUsuario.SuspendLayout();
            OtraGes.SuspendLayout();
            SuspendLayout();
            // 
            // RegistroLibro
            // 
            RegistroLibro.Location = new System.Drawing.Point(56, 36);
            RegistroLibro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            RegistroLibro.Name = "RegistroLibro";
            RegistroLibro.Size = new System.Drawing.Size(133, 65);
            RegistroLibro.TabIndex = 0;
            RegistroLibro.Text = "Registrar nuevo libro";
            RegistroLibro.UseVisualStyleBackColor = true;
            RegistroLibro.Click += button1_Click;
            // 
            // Bienvenida
            // 
            Bienvenida.AutoSize = true;
            Bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Bienvenida.Location = new System.Drawing.Point(53, 34);
            Bienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Bienvenida.Name = "Bienvenida";
            Bienvenida.Size = new System.Drawing.Size(516, 37);
            Bienvenida.TabIndex = 1;
            Bienvenida.Text = "Bienvenido, seleccione una opcion:";
            Bienvenida.Click += label1_Click;
            // 
            // ConsultaLibro
            // 
            ConsultaLibro.Location = new System.Drawing.Point(214, 36);
            ConsultaLibro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            ConsultaLibro.Name = "ConsultaLibro";
            ConsultaLibro.Size = new System.Drawing.Size(133, 65);
            ConsultaLibro.TabIndex = 4;
            ConsultaLibro.Text = "Consultar libros";
            ConsultaLibro.UseVisualStyleBackColor = true;
            // 
            // ActualizaLibro
            // 
            ActualizaLibro.Location = new System.Drawing.Point(57, 113);
            ActualizaLibro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            ActualizaLibro.Name = "ActualizaLibro";
            ActualizaLibro.Size = new System.Drawing.Size(132, 65);
            ActualizaLibro.TabIndex = 5;
            ActualizaLibro.Text = "Actualizacion de libros";
            ActualizaLibro.UseVisualStyleBackColor = true;
            // 
            // EliminaLibro
            // 
            EliminaLibro.Location = new System.Drawing.Point(214, 113);
            EliminaLibro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            EliminaLibro.Name = "EliminaLibro";
            EliminaLibro.Size = new System.Drawing.Size(133, 65);
            EliminaLibro.TabIndex = 6;
            EliminaLibro.Text = "Eliminar libro";
            EliminaLibro.UseVisualStyleBackColor = true;
            // 
            // GestionLibro
            // 
            GestionLibro.Controls.Add(EliminaLibro);
            GestionLibro.Controls.Add(ActualizaLibro);
            GestionLibro.Controls.Add(ConsultaLibro);
            GestionLibro.Controls.Add(RegistroLibro);
            GestionLibro.Location = new System.Drawing.Point(53, 87);
            GestionLibro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            GestionLibro.Name = "GestionLibro";
            GestionLibro.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            GestionLibro.Size = new System.Drawing.Size(413, 200);
            GestionLibro.TabIndex = 7;
            GestionLibro.TabStop = false;
            GestionLibro.Text = "Gestion de Libros";
            GestionLibro.Enter += groupBox1_Enter;
            // 
            // GestionUsuario
            // 
            GestionUsuario.Controls.Add(RemoverUsuario);
            GestionUsuario.Controls.Add(RegistroUsuario);
            GestionUsuario.Location = new System.Drawing.Point(53, 299);
            GestionUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            GestionUsuario.Name = "GestionUsuario";
            GestionUsuario.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            GestionUsuario.Size = new System.Drawing.Size(413, 122);
            GestionUsuario.TabIndex = 8;
            GestionUsuario.TabStop = false;
            GestionUsuario.Text = "Gestion de Usuario";
            // 
            // RemoverUsuario
            // 
            RemoverUsuario.Location = new System.Drawing.Point(232, 36);
            RemoverUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            RemoverUsuario.Name = "RemoverUsuario";
            RemoverUsuario.Size = new System.Drawing.Size(132, 67);
            RemoverUsuario.TabIndex = 4;
            RemoverUsuario.Text = "Eliminar usuario";
            RemoverUsuario.UseVisualStyleBackColor = true;
            // 
            // RegistroUsuario
            // 
            RegistroUsuario.Location = new System.Drawing.Point(57, 36);
            RegistroUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            RegistroUsuario.Name = "RegistroUsuario";
            RegistroUsuario.Size = new System.Drawing.Size(132, 67);
            RegistroUsuario.TabIndex = 0;
            RegistroUsuario.Text = "Registrar nuevo usuario";
            RegistroUsuario.UseVisualStyleBackColor = true;
            // 
            // OtraGes
            // 
            OtraGes.Controls.Add(btnSalir);
            OtraGes.Controls.Add(Grafic);
            OtraGes.Controls.Add(HistPrest);
            OtraGes.Controls.Add(PrestDevol);
            OtraGes.Location = new System.Drawing.Point(53, 445);
            OtraGes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            OtraGes.Name = "OtraGes";
            OtraGes.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            OtraGes.Size = new System.Drawing.Size(413, 201);
            OtraGes.TabIndex = 9;
            OtraGes.TabStop = false;
            OtraGes.Text = "Otras Gestiones";
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(213, 113);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(134, 64);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Grafic
            // 
            Grafic.Location = new System.Drawing.Point(55, 112);
            Grafic.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Grafic.Name = "Grafic";
            Grafic.Size = new System.Drawing.Size(133, 65);
            Grafic.TabIndex = 5;
            Grafic.Text = "Generacion de Graficos";
            Grafic.UseVisualStyleBackColor = true;
            // 
            // HistPrest
            // 
            HistPrest.Location = new System.Drawing.Point(213, 36);
            HistPrest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            HistPrest.Name = "HistPrest";
            HistPrest.Size = new System.Drawing.Size(134, 65);
            HistPrest.TabIndex = 4;
            HistPrest.Text = "Historial de Prestamos";
            HistPrest.UseVisualStyleBackColor = true;
            // 
            // PrestDevol
            // 
            PrestDevol.Location = new System.Drawing.Point(55, 36);
            PrestDevol.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            PrestDevol.Name = "PrestDevol";
            PrestDevol.Size = new System.Drawing.Size(134, 65);
            PrestDevol.TabIndex = 0;
            PrestDevol.Text = "Prestamos y Devoluciones";
            PrestDevol.UseVisualStyleBackColor = true;
            PrestDevol.Click += PrestDevol_Click;
            // 
            // uC_AgregarLibro1
            // 
            uC_AgregarLibro1.Location = new System.Drawing.Point(517, 98);
            uC_AgregarLibro1.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            uC_AgregarLibro1.Name = "uC_AgregarLibro1";
            uC_AgregarLibro1.Size = new System.Drawing.Size(607, 472);
            uC_AgregarLibro1.TabIndex = 10;
            // 
            // MenuBiblioteca
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1024, 901);
            Controls.Add(uC_AgregarLibro1);
            Controls.Add(OtraGes);
            Controls.Add(GestionUsuario);
            Controls.Add(GestionLibro);
            Controls.Add(Bienvenida);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Name = "MenuBiblioteca";
            Text = "Biblioteca UDB";
            Load += Form1_Load;
            GestionLibro.ResumeLayout(false);
            GestionUsuario.ResumeLayout(false);
            OtraGes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button RegistroLibro;
        private System.Windows.Forms.Label Bienvenida;
        private System.Windows.Forms.Button ConsultaLibro;
        private System.Windows.Forms.Button ActualizaLibro;
        private System.Windows.Forms.Button EliminaLibro;
        private System.Windows.Forms.GroupBox GestionLibro;
        private System.Windows.Forms.GroupBox GestionUsuario;
        private System.Windows.Forms.Button RegistroUsuario;
        private System.Windows.Forms.Button RemoverUsuario;
        private System.Windows.Forms.GroupBox OtraGes;
        private System.Windows.Forms.Button Grafic;
        private System.Windows.Forms.Button HistPrest;
        private System.Windows.Forms.Button PrestDevol;
        private UC_AgregarLibro uC_AgregarLibro1;
        private System.Windows.Forms.Button btnSalir;
    }
}

