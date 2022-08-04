using System;
using System.Windows.Forms;
using AutenticationModule.Classes;

namespace AutenticationModule.Desktop
{
    public partial class LevelScreen : Form
    {
        public LevelScreen()
        {
            InitializeComponent();
        }

        private void LevelScreen_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            LoadLevels();
        }
        private void LoadLevels()
        {
            LevelDAO levelSelect = new LevelDAO();
            dgvLevel.DataSource = levelSelect.Select();

        }         

        private void btnInsert_Click(object sender, EventArgs e)
        {
            LevelDAO level = new LevelDAO();
            MessageBox.Show(level.Insert(txtName.Text));
            LoadLevels();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LevelDAO level = new LevelDAO();
            MessageBox.Show(level.Update(txtId.Text, txtName.Text));
            LoadLevels();
        }

        private void dgvLevel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtId.Text = dgvLevel.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvLevel.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LevelDAO level = new LevelDAO();
            MessageBox.Show(level.Delete(txtId.Text));
            LoadLevels();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            LevelDAO levelSelect = new LevelDAO();
            dgvLevel.DataSource = levelSelect.Select(txtName.Text);
            if (txtName.Text.Equals(""))
            {
                LoadLevels();
                txtId.Clear();
            }
            
        }
    }
}
