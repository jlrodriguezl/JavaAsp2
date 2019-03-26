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
            this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnombres = new System.Windows.Forms.Label();
            this.lblnumdoc = new System.Windows.Forms.Label();
            this.lbltipodoc = new System.Windows.Forms.Label();
            this.gbxDatosP = new System.Windows.Forms.GroupBox();
            this.cbxTipoPersona = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lbltipopersona = new System.Windows.Forms.Label();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.grdDatosP = new System.Windows.Forms.DataGridView();
            this.videotiendaDataSet = new VideotiendaWFApp.videotiendaDataSet();
            this.pERSONASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONASTableAdapter = new VideotiendaWFApp.videotiendaDataSetTableAdapters.PERSONASTableAdapter();
            this.nRODOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cELULARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOPERSONADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTRASENADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxFiltroP.SuspendLayout();
            this.gbxDatosP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videotiendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFiltroP
            // 
            this.gbxFiltroP.Controls.Add(this.btnRegresar);
            this.gbxFiltroP.Controls.Add(this.btnEliminar);
            this.gbxFiltroP.Controls.Add(this.button1);
            this.gbxFiltroP.Controls.Add(this.btnNuevo);
            this.gbxFiltroP.Controls.Add(this.btnLimpiar);
            this.gbxFiltroP.Controls.Add(this.btnBuscar);
            this.gbxFiltroP.Controls.Add(this.txtContrasena);
            this.gbxFiltroP.Controls.Add(this.lblcontrasena);
            this.gbxFiltroP.Controls.Add(this.txtDireccion);
            this.gbxFiltroP.Controls.Add(this.lblDireccion);
            this.gbxFiltroP.Controls.Add(this.txtCorreo);
            this.gbxFiltroP.Controls.Add(this.lblcorreo);
            this.gbxFiltroP.Controls.Add(this.txtdocumento);
            this.gbxFiltroP.Controls.Add(this.lbltipopersona);
            this.gbxFiltroP.Controls.Add(this.txtCelular);
            this.gbxFiltroP.Controls.Add(this.txtnombre);
            this.gbxFiltroP.Controls.Add(this.cbxTipoPersona);
            this.gbxFiltroP.Controls.Add(this.cbxTipoDocumento);
            this.gbxFiltroP.Controls.Add(this.label1);
            this.gbxFiltroP.Controls.Add(this.lblnombres);
            this.gbxFiltroP.Controls.Add(this.lblnumdoc);
            this.gbxFiltroP.Controls.Add(this.lbltipodoc);
            this.gbxFiltroP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxFiltroP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFiltroP.Location = new System.Drawing.Point(12, 12);
            this.gbxFiltroP.Name = "gbxFiltroP";
            this.gbxFiltroP.Size = new System.Drawing.Size(1167, 195);
            this.gbxFiltroP.TabIndex = 0;
            this.gbxFiltroP.TabStop = false;
            this.gbxFiltroP.Text = " Filtro de busqueda";
            this.gbxFiltroP.Enter += new System.EventHandler(this.gbxFiltroP_Enter);
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.FormattingEnabled = true;
            this.cbxTipoDocumento.Location = new System.Drawing.Point(154, 27);
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Size = new System.Drawing.Size(200, 23);
            this.cbxTipoDocumento.TabIndex = 4;
            this.cbxTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "# Celular";
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Location = new System.Drawing.Point(47, 93);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(65, 15);
            this.lblnombres.TabIndex = 2;
            this.lblnombres.Text = "Nombres";
            // 
            // lblnumdoc
            // 
            this.lblnumdoc.AutoSize = true;
            this.lblnumdoc.Location = new System.Drawing.Point(20, 61);
            this.lblnumdoc.Name = "lblnumdoc";
            this.lblnumdoc.Size = new System.Drawing.Size(92, 15);
            this.lblnumdoc.TabIndex = 1;
            this.lblnumdoc.Text = "# Documento";
            // 
            // lbltipodoc
            // 
            this.lbltipodoc.AutoSize = true;
            this.lbltipodoc.Location = new System.Drawing.Point(0, 27);
            this.lbltipodoc.Name = "lbltipodoc";
            this.lbltipodoc.Size = new System.Drawing.Size(112, 15);
            this.lbltipodoc.TabIndex = 0;
            this.lbltipodoc.Text = "Tipo Documento";
            this.lbltipodoc.Click += new System.EventHandler(this.label1_Click);
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
            // cbxTipoPersona
            // 
            this.cbxTipoPersona.FormattingEnabled = true;
            this.cbxTipoPersona.Location = new System.Drawing.Point(689, 27);
            this.cbxTipoPersona.Name = "cbxTipoPersona";
            this.cbxTipoPersona.Size = new System.Drawing.Size(200, 23);
            this.cbxTipoPersona.TabIndex = 5;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(154, 93);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(200, 21);
            this.txtnombre.TabIndex = 6;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(154, 124);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(200, 21);
            this.txtCelular.TabIndex = 7;
            // 
            // lbltipopersona
            // 
            this.lbltipopersona.AutoSize = true;
            this.lbltipopersona.CausesValidation = false;
            this.lbltipopersona.Location = new System.Drawing.Point(578, 27);
            this.lbltipopersona.Name = "lbltipopersona";
            this.lbltipopersona.Size = new System.Drawing.Size(92, 15);
            this.lbltipopersona.TabIndex = 8;
            this.lbltipopersona.Text = "Tipo Persona";
            // 
            // txtdocumento
            // 
            this.txtdocumento.Location = new System.Drawing.Point(154, 61);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(200, 21);
            this.txtdocumento.TabIndex = 9;
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.CausesValidation = false;
            this.lblcorreo.Location = new System.Drawing.Point(578, 61);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(50, 15);
            this.lblcorreo.TabIndex = 10;
            this.lblcorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(689, 61);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 21);
            this.txtCorreo.TabIndex = 11;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.CausesValidation = false;
            this.lblDireccion.Location = new System.Drawing.Point(578, 93);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(68, 15);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(689, 93);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 21);
            this.txtDireccion.TabIndex = 13;
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.CausesValidation = false;
            this.lblcontrasena.Location = new System.Drawing.Point(578, 124);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(80, 15);
            this.lblcontrasena.TabIndex = 14;
            this.lblcontrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(689, 124);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(200, 21);
            this.txtContrasena.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(154, 166);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(279, 166);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(431, 166);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(689, 166);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(431, 116);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 21;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // grdDatosP
            // 
            this.grdDatosP.AllowUserToOrderColumns = true;
            this.grdDatosP.AutoGenerateColumns = false;
            this.grdDatosP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDatosP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nRODOCDataGridViewTextBoxColumn,
            this.tIPODOCDataGridViewTextBoxColumn,
            this.nOMBRESDataGridViewTextBoxColumn,
            this.cELULARDataGridViewTextBoxColumn,
            this.cORREODataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn,
            this.tIPOPERSONADataGridViewTextBoxColumn,
            this.cONTRASENADataGridViewTextBoxColumn});
            this.grdDatosP.DataSource = this.pERSONASBindingSource;
            this.grdDatosP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatosP.Location = new System.Drawing.Point(3, 17);
            this.grdDatosP.Name = "grdDatosP";
            this.grdDatosP.Size = new System.Drawing.Size(1163, 214);
            this.grdDatosP.TabIndex = 0;
            // 
            // videotiendaDataSet
            // 
            this.videotiendaDataSet.DataSetName = "videotiendaDataSet";
            this.videotiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERSONASBindingSource
            // 
            this.pERSONASBindingSource.DataMember = "PERSONAS";
            this.pERSONASBindingSource.DataSource = this.videotiendaDataSet;
            // 
            // pERSONASTableAdapter
            // 
            this.pERSONASTableAdapter.ClearBeforeFill = true;
            // 
            // nRODOCDataGridViewTextBoxColumn
            // 
            this.nRODOCDataGridViewTextBoxColumn.DataPropertyName = "NRO_DOC";
            this.nRODOCDataGridViewTextBoxColumn.HeaderText = "NRO_DOC";
            this.nRODOCDataGridViewTextBoxColumn.Name = "nRODOCDataGridViewTextBoxColumn";
            // 
            // tIPODOCDataGridViewTextBoxColumn
            // 
            this.tIPODOCDataGridViewTextBoxColumn.DataPropertyName = "TIPO_DOC";
            this.tIPODOCDataGridViewTextBoxColumn.HeaderText = "TIPO_DOC";
            this.tIPODOCDataGridViewTextBoxColumn.Name = "tIPODOCDataGridViewTextBoxColumn";
            // 
            // nOMBRESDataGridViewTextBoxColumn
            // 
            this.nOMBRESDataGridViewTextBoxColumn.DataPropertyName = "NOMBRES";
            this.nOMBRESDataGridViewTextBoxColumn.HeaderText = "NOMBRES";
            this.nOMBRESDataGridViewTextBoxColumn.Name = "nOMBRESDataGridViewTextBoxColumn";
            // 
            // cELULARDataGridViewTextBoxColumn
            // 
            this.cELULARDataGridViewTextBoxColumn.DataPropertyName = "CELULAR";
            this.cELULARDataGridViewTextBoxColumn.HeaderText = "CELULAR";
            this.cELULARDataGridViewTextBoxColumn.Name = "cELULARDataGridViewTextBoxColumn";
            // 
            // cORREODataGridViewTextBoxColumn
            // 
            this.cORREODataGridViewTextBoxColumn.DataPropertyName = "CORREO";
            this.cORREODataGridViewTextBoxColumn.HeaderText = "CORREO";
            this.cORREODataGridViewTextBoxColumn.Name = "cORREODataGridViewTextBoxColumn";
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            // 
            // tIPOPERSONADataGridViewTextBoxColumn
            // 
            this.tIPOPERSONADataGridViewTextBoxColumn.DataPropertyName = "TIPO_PERSONA";
            this.tIPOPERSONADataGridViewTextBoxColumn.HeaderText = "TIPO_PERSONA";
            this.tIPOPERSONADataGridViewTextBoxColumn.Name = "tIPOPERSONADataGridViewTextBoxColumn";
            // 
            // cONTRASENADataGridViewTextBoxColumn
            // 
            this.cONTRASENADataGridViewTextBoxColumn.DataPropertyName = "CONTRASENA";
            this.cONTRASENADataGridViewTextBoxColumn.HeaderText = "CONTRASENA";
            this.cONTRASENADataGridViewTextBoxColumn.Name = "cONTRASENADataGridViewTextBoxColumn";
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
            this.gbxDatosP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videotiendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void gbxFiltroP_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltroP;
        private System.Windows.Forms.Label lbltipodoc;
        private System.Windows.Forms.GroupBox gbxDatosP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Label lblnumdoc;
        private System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.ComboBox cbxTipoPersona;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.Label lbltipopersona;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grdDatosP;
        private videotiendaDataSet videotiendaDataSet;
        private System.Windows.Forms.BindingSource pERSONASBindingSource;
        private videotiendaDataSetTableAdapters.PERSONASTableAdapter pERSONASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRODOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cELULARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOPERSONADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTRASENADataGridViewTextBoxColumn;
    }
}