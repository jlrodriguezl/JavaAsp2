namespace VideotiendaAPP.Views
{
    partial class FrmGestionarCategorias
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
            this.lblNCategoria = new System.Windows.Forms.Label();
            this.txtNcategoria = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNCategoria
            // 
            this.lblNCategoria.AutoSize = true;
            this.lblNCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCategoria.Location = new System.Drawing.Point(78, 86);
            this.lblNCategoria.Name = "lblNCategoria";
            this.lblNCategoria.Size = new System.Drawing.Size(108, 15);
            this.lblNCategoria.TabIndex = 1;
            this.lblNCategoria.Text = "Nombre Categoria";
            this.lblNCategoria.Click += new System.EventHandler(this.lblNCategoria_Click);
            // 
            // txtNcategoria
            // 
            this.txtNcategoria.Location = new System.Drawing.Point(238, 81);
            this.txtNcategoria.Name = "txtNcategoria";
            this.txtNcategoria.Size = new System.Drawing.Size(200, 20);
            this.txtNcategoria.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(106, 147);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(305, 147);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(444, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(450, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "*";
            // 
            // FrmGestionarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNcategoria);
            this.Controls.Add(this.lblNCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmGestionarCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar/Modificar Categorias";
            this.Load += new System.EventHandler(this.FrmGestionarCategorias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNCategoria;
        private System.Windows.Forms.TextBox txtNcategoria;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}