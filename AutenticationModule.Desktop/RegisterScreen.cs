using AutenticationModule.Classes;
using System;
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
            LoadLevels();
        }
        private void LoadLevels()
        {
            LevelDAO levelSelect = new LevelDAO();
            cbLevel.DataSource = levelSelect.Select();
            cbLevel.DisplayMember = "nome";
        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {
            string[] firstName = txtName.Text.Split(' ');
            string[] lastName = txtSurname.Text.Split(' ');
            txtLogin.Text = firstName[0] + lastName[lastName.Length - 1];
        }        

        private void btnAddLevel_Click(object sender, EventArgs e)
        {
            new LevelScreen().Show();
        }

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            var senha = txtPassword.Text;
            var confirmarSenha = txtConfirmarSenha.Text;
            if (confirmarSenha.Equals(senha))
            {
                cbLevel.Focus();
            }
            else
            {
                MessageBox.Show("Senhas incompativeis");
                txtPassword.Clear();
                txtConfirmarSenha.Clear();

            }
        }      

        private void cbLevel_Enter(object sender, EventArgs e)
        {
            LoadLevels();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegisterDAO register = new RegisterDAO();
            LevelDAO level = new LevelDAO();
            var id_nivel = level.SelectId(cbLevel.Text);
            MessageBox.Show(register.Insert(txtName.Text,txtSurname.Text,txtLogin.Text,txtPassword.Text,id_nivel));
            LoadLevels();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
