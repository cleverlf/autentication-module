using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            LevelDAO level = new LevelDAO();
            MessageBox.Show(level.Insert(txtName.Text));
            LoadLevels();
        }

        private void LoadLevels()
        {
            LevelDAO levelSelect = new LevelDAO();
            dgvLevel.DataSource = levelSelect.Select();

        }       

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
