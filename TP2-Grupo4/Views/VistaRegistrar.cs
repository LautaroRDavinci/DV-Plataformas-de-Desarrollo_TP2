﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TP2_Grupo4.Views
{
    public partial class VistaRegistrar : Form
    {
        private AgenciaManager agencia;
        public VistaRegistrar()
        {
            InitializeComponent();
            this.agencia = new AgenciaManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VistaLogin cambiarFormulario = new VistaLogin();
            cambiarFormulario.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "DNI")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "DNI";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.LightGray;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.DimGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "EMAIL")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.LightGray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "EMAIL";
                txtMail.ForeColor = Color.DimGray;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                agencia.AgregarUsuario(int.Parse(txtUsuario.Text), txtNombre.Text, txtMail.Text, txtContrasena.Text, checkAdmin.Checked, false);
                agencia.GuardarCambiosDeLosUsuarios();
                txtUsuario.Text = "";
                txtNombre.Text = "";
                txtMail.Text = "";
                txtContrasena.Text = "";
                checkAdmin.Checked = false;
                MessageBox.Show("Se ha registrado de manera exitosa.");
            }
            catch
            {
                MessageBox.Show("Error en el registro, por favor intentelo nuevamente.");
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
