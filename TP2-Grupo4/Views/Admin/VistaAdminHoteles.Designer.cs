﻿
namespace TP2_Grupo4.Views
{
    partial class VistaAdminHoteles
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
            this.dgvHoteles = new System.Windows.Forms.DataGridView();
            this.panelHoteles = new System.Windows.Forms.Panel();
            this.lblAlojamiento = new System.Windows.Forms.Label();
            this.groupBoxHoteles = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnTopModificar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxTv = new System.Windows.Forms.CheckBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.comboBoxCantPersonas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTopAgregar = new System.Windows.Forms.Button();
            this.comboBoxEstrellas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoteles)).BeginInit();
            this.panelHoteles.SuspendLayout();
            this.groupBoxHoteles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoteles
            // 
            this.dgvHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoteles.Location = new System.Drawing.Point(12, 263);
            this.dgvHoteles.Name = "dgvHoteles";
            this.dgvHoteles.RowTemplate.Height = 25;
            this.dgvHoteles.Size = new System.Drawing.Size(976, 287);
            this.dgvHoteles.TabIndex = 1;
            this.dgvHoteles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoteles_CellContentClick);
            // 
            // panelHoteles
            // 
            this.panelHoteles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panelHoteles.Controls.Add(this.lblAlojamiento);
            this.panelHoteles.Controls.Add(this.groupBoxHoteles);
            this.panelHoteles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHoteles.Location = new System.Drawing.Point(0, 0);
            this.panelHoteles.Name = "panelHoteles";
            this.panelHoteles.Size = new System.Drawing.Size(1000, 562);
            this.panelHoteles.TabIndex = 4;
            // 
            // lblAlojamiento
            // 
            this.lblAlojamiento.AutoSize = true;
            this.lblAlojamiento.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlojamiento.ForeColor = System.Drawing.Color.Black;
            this.lblAlojamiento.Location = new System.Drawing.Point(424, 34);
            this.lblAlojamiento.Name = "lblAlojamiento";
            this.lblAlojamiento.Size = new System.Drawing.Size(157, 45);
            this.lblAlojamiento.TabIndex = 13;
            this.lblAlojamiento.Text = "Hoteles";
            // 
            // groupBoxHoteles
            // 
            this.groupBoxHoteles.Controls.Add(this.txtCodigo);
            this.groupBoxHoteles.Controls.Add(this.btnTopModificar);
            this.groupBoxHoteles.Controls.Add(this.label10);
            this.groupBoxHoteles.Controls.Add(this.checkBoxTv);
            this.groupBoxHoteles.Controls.Add(this.txtCiudad);
            this.groupBoxHoteles.Controls.Add(this.label7);
            this.groupBoxHoteles.Controls.Add(this.txtPrecio);
            this.groupBoxHoteles.Controls.Add(this.label3);
            this.groupBoxHoteles.Controls.Add(this.txtBarrio);
            this.groupBoxHoteles.Controls.Add(this.comboBoxCantPersonas);
            this.groupBoxHoteles.Controls.Add(this.label2);
            this.groupBoxHoteles.Controls.Add(this.label5);
            this.groupBoxHoteles.Controls.Add(this.label4);
            this.groupBoxHoteles.Controls.Add(this.btnTopAgregar);
            this.groupBoxHoteles.Controls.Add(this.comboBoxEstrellas);
            this.groupBoxHoteles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxHoteles.ForeColor = System.Drawing.Color.Black;
            this.groupBoxHoteles.Location = new System.Drawing.Point(73, 108);
            this.groupBoxHoteles.Name = "groupBoxHoteles";
            this.groupBoxHoteles.Size = new System.Drawing.Size(842, 117);
            this.groupBoxHoteles.TabIndex = 1;
            this.groupBoxHoteles.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(114, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 23);
            this.txtCodigo.TabIndex = 12;
            // 
            // btnTopModificar
            // 
            this.btnTopModificar.BackColor = System.Drawing.Color.White;
            this.btnTopModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopModificar.ForeColor = System.Drawing.Color.Black;
            this.btnTopModificar.Location = new System.Drawing.Point(700, 32);
            this.btnTopModificar.Name = "btnTopModificar";
            this.btnTopModificar.Size = new System.Drawing.Size(106, 63);
            this.btnTopModificar.TabIndex = 12;
            this.btnTopModificar.Text = "Modificar";
            this.btnTopModificar.UseVisualStyleBackColor = false;
            this.btnTopModificar.Click += new System.EventHandler(this.btnTopModificar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Código:";
            // 
            // checkBoxTv
            // 
            this.checkBoxTv.AutoSize = true;
            this.checkBoxTv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxTv.Location = new System.Drawing.Point(316, 86);
            this.checkBoxTv.Name = "checkBoxTv";
            this.checkBoxTv.Size = new System.Drawing.Size(78, 19);
            this.checkBoxTv.TabIndex = 8;
            this.checkBoxTv.Text = "¿Tiene Tv?";
            this.checkBoxTv.UseVisualStyleBackColor = true;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(114, 53);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(121, 23);
            this.txtCiudad.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ciudad:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(531, 19);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(114, 84);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(121, 23);
            this.txtBarrio.TabIndex = 7;
            // 
            // comboBoxCantPersonas
            // 
            this.comboBoxCantPersonas.BackColor = System.Drawing.Color.White;
            this.comboBoxCantPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCantPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCantPersonas.FormattingEnabled = true;
            this.comboBoxCantPersonas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxCantPersonas.Location = new System.Drawing.Point(380, 19);
            this.comboBoxCantPersonas.Name = "comboBoxCantPersonas";
            this.comboBoxCantPersonas.Size = new System.Drawing.Size(65, 23);
            this.comboBoxCantPersonas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad de Personas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Estrellas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Barrio:";
            // 
            // btnTopAgregar
            // 
            this.btnTopAgregar.BackColor = System.Drawing.Color.White;
            this.btnTopAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnTopAgregar.Location = new System.Drawing.Point(700, 32);
            this.btnTopAgregar.Name = "btnTopAgregar";
            this.btnTopAgregar.Size = new System.Drawing.Size(106, 63);
            this.btnTopAgregar.TabIndex = 10;
            this.btnTopAgregar.Text = "Agregar";
            this.btnTopAgregar.UseVisualStyleBackColor = false;
            this.btnTopAgregar.Click += new System.EventHandler(this.btnTopAgregar_Click);
            // 
            // comboBoxEstrellas
            // 
            this.comboBoxEstrellas.BackColor = System.Drawing.Color.White;
            this.comboBoxEstrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstrellas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEstrellas.FormattingEnabled = true;
            this.comboBoxEstrellas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxEstrellas.Location = new System.Drawing.Point(380, 53);
            this.comboBoxEstrellas.Name = "comboBoxEstrellas";
            this.comboBoxEstrellas.Size = new System.Drawing.Size(53, 23);
            this.comboBoxEstrellas.TabIndex = 5;
            // 
            // VistaAdminHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(4)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.dgvHoteles);
            this.Controls.Add(this.panelHoteles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaAdminHoteles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoteles";
            this.Load += new System.EventHandler(this.FormHoteles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoteles)).EndInit();
            this.panelHoteles.ResumeLayout(false);
            this.panelHoteles.PerformLayout();
            this.groupBoxHoteles.ResumeLayout(false);
            this.groupBoxHoteles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHoteles;
        private System.Windows.Forms.Panel panelHoteles;
        private System.Windows.Forms.Label lblAlojamiento;
        private System.Windows.Forms.GroupBox groupBoxHoteles;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnTopModificar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxTv;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.ComboBox comboBoxCantPersonas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTopAgregar;
        private System.Windows.Forms.ComboBox comboBoxEstrellas;
    }
}