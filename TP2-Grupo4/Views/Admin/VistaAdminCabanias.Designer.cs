﻿
namespace TP2_Grupo4.Views
{
    partial class VistaAdminCabanias
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
            this.dgvCabanias = new System.Windows.Forms.DataGridView();
            this.groupBoxCabanias = new System.Windows.Forms.GroupBox();
            this.comboBoxHabitaciones = new System.Windows.Forms.ComboBox();
            this.comboBoxBanios = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnTopModificar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxTV = new System.Windows.Forms.CheckBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioDia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.comboBoxCantPersonas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTopAgregar = new System.Windows.Forms.Button();
            this.comboBoxEstrellas = new System.Windows.Forms.ComboBox();
            this.lblAlojamiento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabanias)).BeginInit();
            this.groupBoxCabanias.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCabanias
            // 
            this.dgvCabanias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCabanias.Location = new System.Drawing.Point(12, 198);
            this.dgvCabanias.Name = "dgvCabanias";
            this.dgvCabanias.RowTemplate.Height = 25;
            this.dgvCabanias.Size = new System.Drawing.Size(976, 352);
            this.dgvCabanias.TabIndex = 1;
            this.dgvCabanias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCabanias_CellContentClick);
            // 
            // groupBoxCabanias
            // 
            this.groupBoxCabanias.Controls.Add(this.comboBoxHabitaciones);
            this.groupBoxCabanias.Controls.Add(this.comboBoxBanios);
            this.groupBoxCabanias.Controls.Add(this.label6);
            this.groupBoxCabanias.Controls.Add(this.label1);
            this.groupBoxCabanias.Controls.Add(this.txtCodigo);
            this.groupBoxCabanias.Controls.Add(this.btnTopModificar);
            this.groupBoxCabanias.Controls.Add(this.label10);
            this.groupBoxCabanias.Controls.Add(this.checkBoxTV);
            this.groupBoxCabanias.Controls.Add(this.txtCiudad);
            this.groupBoxCabanias.Controls.Add(this.label7);
            this.groupBoxCabanias.Controls.Add(this.txtPrecioDia);
            this.groupBoxCabanias.Controls.Add(this.label3);
            this.groupBoxCabanias.Controls.Add(this.txtBarrio);
            this.groupBoxCabanias.Controls.Add(this.comboBoxCantPersonas);
            this.groupBoxCabanias.Controls.Add(this.label2);
            this.groupBoxCabanias.Controls.Add(this.label5);
            this.groupBoxCabanias.Controls.Add(this.label4);
            this.groupBoxCabanias.Controls.Add(this.btnTopAgregar);
            this.groupBoxCabanias.Controls.Add(this.comboBoxEstrellas);
            this.groupBoxCabanias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxCabanias.ForeColor = System.Drawing.Color.Black;
            this.groupBoxCabanias.Location = new System.Drawing.Point(83, 66);
            this.groupBoxCabanias.Name = "groupBoxCabanias";
            this.groupBoxCabanias.Size = new System.Drawing.Size(842, 117);
            this.groupBoxCabanias.TabIndex = 2;
            this.groupBoxCabanias.TabStop = false;
            // 
            // comboBoxHabitaciones
            // 
            this.comboBoxHabitaciones.BackColor = System.Drawing.Color.White;
            this.comboBoxHabitaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxHabitaciones.FormattingEnabled = true;
            this.comboBoxHabitaciones.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxHabitaciones.Location = new System.Drawing.Point(557, 50);
            this.comboBoxHabitaciones.Name = "comboBoxHabitaciones";
            this.comboBoxHabitaciones.Size = new System.Drawing.Size(86, 23);
            this.comboBoxHabitaciones.TabIndex = 18;
            // 
            // comboBoxBanios
            // 
            this.comboBoxBanios.BackColor = System.Drawing.Color.White;
            this.comboBoxBanios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBanios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBanios.FormattingEnabled = true;
            this.comboBoxBanios.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxBanios.Location = new System.Drawing.Point(557, 79);
            this.comboBoxBanios.Name = "comboBoxBanios";
            this.comboBoxBanios.Size = new System.Drawing.Size(86, 23);
            this.comboBoxBanios.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Baños";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Habitaciones";
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
            // checkBoxTV
            // 
            this.checkBoxTV.AutoSize = true;
            this.checkBoxTV.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxTV.Location = new System.Drawing.Point(316, 86);
            this.checkBoxTV.Name = "checkBoxTV";
            this.checkBoxTV.Size = new System.Drawing.Size(78, 19);
            this.checkBoxTV.TabIndex = 8;
            this.checkBoxTV.Text = "¿Tiene Tv?";
            this.checkBoxTV.UseVisualStyleBackColor = true;
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
            // txtPrecioDia
            // 
            this.txtPrecioDia.Location = new System.Drawing.Point(557, 19);
            this.txtPrecioDia.Name = "txtPrecioDia";
            this.txtPrecioDia.Size = new System.Drawing.Size(86, 23);
            this.txtPrecioDia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio x Dia";
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
            this.comboBoxCantPersonas.Cursor = System.Windows.Forms.Cursors.Default;
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
            // lblAlojamiento
            // 
            this.lblAlojamiento.AutoSize = true;
            this.lblAlojamiento.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlojamiento.ForeColor = System.Drawing.Color.Black;
            this.lblAlojamiento.Location = new System.Drawing.Point(435, 9);
            this.lblAlojamiento.Name = "lblAlojamiento";
            this.lblAlojamiento.Size = new System.Drawing.Size(177, 45);
            this.lblAlojamiento.TabIndex = 14;
            this.lblAlojamiento.Text = "Cabañas";
            // 
            // VistaAdminCabanias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.lblAlojamiento);
            this.Controls.Add(this.groupBoxCabanias);
            this.Controls.Add(this.dgvCabanias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaAdminCabanias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCabanias";
            this.Load += new System.EventHandler(this.FormCabanias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabanias)).EndInit();
            this.groupBoxCabanias.ResumeLayout(false);
            this.groupBoxCabanias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCabanias;
        private System.Windows.Forms.GroupBox groupBoxCabanias;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnTopModificar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxTV;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.ComboBox comboBoxCantPersonas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTopAgregar;
        private System.Windows.Forms.ComboBox comboBoxEstrellas;
        private System.Windows.Forms.Label lblAlojamiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxHabitaciones;
        private System.Windows.Forms.ComboBox comboBoxBanios;
    }
}