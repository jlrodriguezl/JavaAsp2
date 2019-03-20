namespace VideotiendaWFApp.Views
{
    partial class Frmpersonas
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
            this.gbxFiltroP = new System.Windows.Forms.GroupBox();
            this.gbxDatosP = new System.Windows.Forms.GroupBox();
            this.lbltipodoc = new System.Windows.Forms.Label();
            this.lblnumdoc = new System.Windows.Forms.Label();
            this.lblnombres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbxFiltroP.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFiltroP
            // 
            this.gbxFiltroP.Controls.Add(this.comboBox1);
            this.gbxFiltroP.Controls.Add(this.label1);
            this.gbxFiltroP.Controls.Add(this.lblnombres);
            this.gbxFiltroP.Controls.Add(this.lblnumdoc);
            this.gbxFiltroP.Controls.Add(this.lbltipodoc);
            this.gbxFiltroP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxFiltroP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFiltroP.Location = new System.Drawing.Point(12, 12);
            this.gbxFiltroP.Name = "gbxFiltroP";
            this.gbxFiltroP.Size = new System.Drawing.Size(1167, 181);
            this.gbxFiltroP.TabIndex = 0;
            this.gbxFiltroP.TabStop = false;
            this.gbxFiltroP.Text = " Filtro de busqueda";
            // 
            // gbxDatosP
            // 
            this.gbxDatosP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxDatosP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosP.Location = new System.Drawing.Point(12, 213);
            this.gbxDatosP.Name = "gbxDatosP";
            this.gbxDatosP.Size = new System.Drawing.Size(1167, 287);
            this.gbxDatosP.TabIndex = 1;
            this.gbxDatosP.TabStop = false;
            this.gbxDatosP.Text = "Usuarios";
            // 
            // lbltipodoc
            // 
            this.lbltipodoc.AutoSize = true;
            this.lbltipodoc.Location = new System.Drawing.Point(20, 36);
            this.lbltipodoc.Name = "lbltipodoc";
            this.lbltipodoc.Size = new System.Drawing.Size(112, 15);
            this.lbltipodoc.TabIndex = 0;
            this.lbltipodoc.Text = "Tipo Documento";
            this.lbltipodoc.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnumdoc
            // 
            this.lblnumdoc.AutoSize = true;
            this.lblnumdoc.Location = new System.Drawing.Point(20, 69);
            this.lblnumdoc.Name = "lblnumdoc";
            this.lblnumdoc.Size = new System.Drawing.Size(92, 15);
            this.lblnumdoc.TabIndex = 1;
            this.lblnumdoc.Text = "# Documento";
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Location = new System.Drawing.Point(20, 108);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(65, 15);
            this.lblnombres.TabIndex = 2;
            this.lblnombres.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de Celular";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // Frmpersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 500);
            this.ControlBox = false;
            this.Controls.Add(this.gbxDatosP);
            this.Controls.Add(this.gbxFiltroP);
            this.Name = "Frmpersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de usuarios";
            this.Load += new System.EventHandler(this.Frmpersonas_Load);
            this.gbxFiltroP.ResumeLayout(false);
            this.gbxFiltroP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltroP;
        private System.Windows.Forms.Label lbltipodoc;
        private System.Windows.Forms.GroupBox gbxDatosP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Label lblnumdoc;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}