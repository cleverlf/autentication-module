﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutenticationModule.Desktop
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void RegisterScreen_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtLogin.Enabled = false;
        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {
            string[] firstName = txtName.Text.Split(' ');
            string[] lastName = txtSobrenome.Text.Split(' ');
            txtLogin.Text = firstName[0] + lastName[lastName.Length - 1];
        }        

        private void btnAddLevel_Click(object sender, EventArgs e)
        {
            new LevelScreen().Show();
        }

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            var senha = txtSenha.Text;
            var confirmarSenha = txtConfirmarSenha.Text;
            if (confirmarSenha.Equals(senha))
            {
                cbLevel.Focus();
            }
            else
            {
                MessageBox.Show("Senhas incompativeis");
                txtSenha.Clear();
                txtConfirmarSenha.Clear();

            }
        }
    }
}