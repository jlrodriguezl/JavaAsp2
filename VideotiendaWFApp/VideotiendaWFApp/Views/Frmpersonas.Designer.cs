using System;

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
            this.components = new System.ComponentModel.Container();
            this.gbxFiltroP = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.lbltipopersona = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnombres = new System.Windows.Forms.Label();
            this.lblnumdoc = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxDatosP = new System.Windows.Forms.GroupBox();
            this.grdDatosP = new System.Windows.Forms.DataGridView();
            this.pERSONASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTipoPersona = new System.Windows.Forms.ComboBox();
            this.gbxFiltroP.SuspendLayout();
            this.gbxDatosP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFiltroP
            // 
            this.gbxFiltroP.Controls.Add(this.cboTipoPersona);
            this.gbxFiltroP.Controls.Add(this.btnLimpiar);
            this.gbxFiltroP.Controls.Add(this.btnBuscar);
            this.gbxFiltroP.Controls.Add(this.txtDireccion);
            this.gbxFiltroP.Controls.Add(this.lblDireccion);
            this.gbxFiltroP.Controls.Add(this.txtCorreo);
            this.gbxFiltroP.Controls.Add(this.lblcorreo);
            this.gbxFiltroP.Controls.Add(this.txtdocumento);
            this.gbxFiltroP.Controls.Add(this.lbltipopersona);
            this.gbxFiltroP.Controls.Add(this.txtCelular);
            this.gbxFiltroP.Controls.Add(this.txtnombre);
            this.gbxFiltroP.Controls.Add(this.label1);
            this.gbxFiltroP.Controls.Add(this.lblnombres);
            this.gbxFiltroP.Controls.Add(this.lblnumdoc);
            this.gbxFiltroP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxFiltroP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFiltroP.Location = new System.Drawing.Point(12, 12);
            this.gbxFiltroP.Name = "gbxFiltroP";
            this.gbxFiltroP.Size = new System.Drawing.Size(742, 181);
            this.gbxFiltroP.TabIndex = 0;
            this.gbxFiltroP.TabStop = false;
            this.gbxFiltroP.Text = " Filtro de busqueda";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(389, 141);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(271, 141);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(525, 96);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 21);
            this.txtDireccion.TabIndex = 13;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.CausesValidation = false;
            this.lblDireccion.Location = new System.Drawing.Point(414, 96);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(68, 15);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(525, 64);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 21);
            this.txtCorreo.TabIndex = 11;
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.CausesValidation = false;
            this.lblcorreo.Location = new System.Drawing.Point(414, 64);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(50, 15);
            this.lblcorreo.TabIndex = 10;
            this.lblcorreo.Text = "Correo";
            // 
            // txtdocumento
            // 
            this.txtdocumento.Location = new System.Drawing.Point(146, 29);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(200, 21);
            this.txtdocumento.TabIndex = 9;
            // 
            // lbltipopersona
            // 
            this.lbltipopersona.AutoSize = true;
            this.lbltipopersona.CausesValidation = false;
            this.lbltipopersona.Location = new System.Drawing.Point(414, 30);
            this.lbltipopersona.Name = "lbltipopersona";
            this.lbltipopersona.Size = new System.Drawing.Size(92, 15);
            this.lbltipopersona.TabIndex = 8;
            this.lbltipopersona.Text = "Tipo Persona";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(146, 92);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(200, 21);
            this.txtCelular.TabIndex = 7;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(146, 61);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(200, 21);
            this.txtnombre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "# Celular";
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Location = new System.Drawing.Point(39, 61);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(65, 15);
            this.lblnombres.TabIndex = 2;
            this.lblnombres.Text = "Nombres";
            // 
            // lblnumdoc
            // 
            this.lblnumdoc.AutoSize = true;
            this.lblnumdoc.Location = new System.Drawing.Point(12, 29);
            this.lblnumdoc.Name = "lblnumdoc";
            this.lblnumdoc.Size = new System.Drawing.Size(92, 15);
            this.lblnumdoc.TabIndex = 1;
            this.lblnumdoc.Text = "# Documento";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(13, 454);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 30);
            this.btnRegresar.TabIndex = 21;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1076, 454);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(964, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(849, 454);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 30);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // gbxDatosP
            // 
            this.gbxDatosP.Controls.Add(this.grdDatosP);
            this.gbxDatosP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxDatosP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosP.Location = new System.Drawing.Point(10, 214);
            this.gbxDatosP.Name = "gbxDatosP";
            this.gbxDatosP.Size = new System.Drawing.Size(1169, 234);
            this.gbxDatosP.TabIndex = 1;
            this.gbxDatosP.TabStop = false;
            this.gbxDatosP.Text = "Usuarios";
            // 
            // grdDatosP
            // 
            this.grdDatosP.AllowUserToOrderColumns = true;
            this.grdDatosP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDatosP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatosP.Location = new System.Drawing.Point(3, 17);
            this.grdDatosP.Name = "grdDatosP";
            this.grdDatosP.Size = new System.Drawing.Size(1163, 214);
            this.grdDatosP.TabIndex = 0;
            // 
            // pERSONASBindingSource
            // 
            this.pERSONASBindingSource.DataMember = "PERSONAS";
            // 
            // cboTipoPersona
            // 
            this.cboTipoPersona.FormattingEnabled = true;
            this.cboTipoPersona.Location = new System.Drawing.Point(525, 28);
            this.cboTipoPersona.Name = "cboTipoPersona";
            this.cboTipoPersona.Size = new System.Drawing.Size(200, 23);
            this.cboTipoPersona.TabIndex = 18;
            // 
            // Frmpersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 500);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gbxDatosP);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbxFiltroP);
            this.Name = "Frmpersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de usuarios";
            this.Load += new System.EventHandler(this.Frmpersonas_Load);
            this.gbxFiltroP.ResumeLayout(false);
            this.gbxFiltroP.PerformLayout();
            this.gbxDatosP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }     
        #endregion

        private System.Windows.Forms.GroupBox gbxFiltroP;
        private System.Windows.Forms.GroupBox gbxDatosP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Label lblnumdoc;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.Label lbltipopersona;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grdDatosP;
        //private videotiendaDataSet videotiendaDataSet;
        private System.Windows.Forms.BindingSource pERSONASBindingSource;
        //private videotiendaDataSetTableAdapters.PERSONASTableAdapter pERSONASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRODOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cELULARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPERSONADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTRASENADataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboTipoPersona;
    }
}