using EstudosAdoNet.DAO;
using EstudosAdoNet.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace EstudosAdoNet
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private void AtualizarDataGridView()
        {
            ContatoDAO contatoDAO = new ContatoDAO();
            DataTable resultado = contatoDAO.GetContatos();

            dgvAgenda.DataSource = resultado;
            dgvAgenda.Refresh();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvAgenda.CurrentRow.Cells[0].Value.ToString());
            ContatoDAO contatoDao = new ContatoDAO();

            contatoDao.ExcluirContato(id);
            AtualizarDataGridView();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarAlterarContato form = new frmAdicionarAlterarContato();
            
            form.ShowDialog();
            AtualizarDataGridView();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato()
            {
                Id = Int32.Parse(dgvAgenda.CurrentRow.Cells[0].Value.ToString()),
                Nome = dgvAgenda.CurrentRow.Cells[1].Value.ToString(),
                Email = dgvAgenda.CurrentRow.Cells[2].Value.ToString(),
                Telefone = dgvAgenda.CurrentRow.Cells[3].Value.ToString(),
            };
            frmAdicionarAlterarContato form = new frmAdicionarAlterarContato(contato);

            form.ShowDialog();
            AtualizarDataGridView();
        }
    }
}
