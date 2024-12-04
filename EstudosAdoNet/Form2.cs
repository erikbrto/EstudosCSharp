using EstudosAdoNet.DAO;
using EstudosAdoNet.Models;
using System;
using System.Windows.Forms;

namespace EstudosAdoNet
{
    public partial class frmAdicionarAlterarContato : Form
    {
        private Contato contato;

        public frmAdicionarAlterarContato(Contato contato = null)
        {
            this.contato = contato;

            InitializeComponent();
        }
        public frmAdicionarAlterarContato()
        {
            InitializeComponent();
        }

        private void frmAdicionarAlterarContato_Load(object sender, EventArgs e)
        {
            if (this.contato == null)
            {
                txbNome.Text = String.Empty;
                txbEmail.Text = String.Empty;
                txbTelefone.Text = String.Empty;
            }
            else
            {
                txbNome.Text = this.contato.Nome;
                txbEmail.Text = this.contato.Email;
                txbTelefone.Text = this.contato.Telefone;
            }

            txbNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ContatoDAO contatoDAO = new ContatoDAO();
            
            if (this.contato == null)
            {
                Contato contato = new Contato()
                {
                    Nome = txbNome.Text, 
                    Email = txbEmail.Text, 
                    Telefone = txbTelefone.Text,
                };

                contatoDAO.AdicionarContato(contato);
            }
            else
            {
                this.contato.Nome = txbNome.Text;
                this.contato.Email = txbEmail.Text;
                this.contato.Telefone = txbTelefone.Text;

                contatoDAO.AlterarContato(this.contato);
            }

            this.Close();
        }
    }
}
