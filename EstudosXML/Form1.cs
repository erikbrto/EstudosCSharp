using System;
using System.Windows.Forms;
using System.Xml;

namespace EstudosXML
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = CarregarTitulo();
            CarregarContatos();
        }

        private string CarregarTitulo()
        {
            XmlDocument agendaXml = new XmlDocument();
            XmlNode nodeTitulo;

            agendaXml.Load(@"C:\Dev\EstudosCSharp\EstudosXML\Agenda.xml");
            nodeTitulo = agendaXml.SelectSingleNode("/agenda/titulo");

            return nodeTitulo.InnerText;
        }

        private void CarregarContatos()
        {
            XmlDocument agendaXml = new XmlDocument();
            XmlNodeList contatos;

            lbxContatos.Items.Clear();
            agendaXml.Load(@"C:\Dev\EstudosCSharp\EstudosXML\Agenda.xml");
            contatos = agendaXml.SelectNodes("/agenda/contatos/contato");

            foreach (XmlNode contato in contatos)
            {
                string id = contato.Attributes["id"].Value;
                string nome = contato.Attributes["nome"].Value;
                string idade = contato.Attributes["idade"].Value;

                lbxContatos.Items.Add($"{id}; {nome}; {idade}");
            }
        }

        private void CriarContato(string id, string nome, string idade)
        {
            string pathAgendaXml = @"C:\Dev\EstudosCSharp\EstudosXML\Agenda.xml";
            XmlDocument agendaXml = new XmlDocument();
            XmlNode contatos;
            XmlNode novoContato = agendaXml.CreateElement("contato");
            XmlAttribute attrId = agendaXml.CreateAttribute("id");
            XmlAttribute attrNome = agendaXml.CreateAttribute("nome");
            XmlAttribute attrIdade = agendaXml.CreateAttribute("idade");

            agendaXml.Load(pathAgendaXml);
            
            contatos = agendaXml.SelectSingleNode("/agenda/contatos");
            attrId.Value = id;
            attrNome.Value = nome;
            attrIdade.Value = idade;

            novoContato.Attributes.Append(attrId);
            novoContato.Attributes.Append(attrNome);
            novoContato.Attributes.Append(attrIdade);
            contatos.AppendChild(novoContato);

            agendaXml.Save(pathAgendaXml);
            CarregarContatos();
        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbNovoId.Text) ||
                String.IsNullOrEmpty(txbNovoNome.Text) ||
                String.IsNullOrEmpty(txbNovaIdade.Text))
                return;

            CriarContato(txbNovoId.Text, txbNovoNome.Text, txbNovaIdade.Text);
            txbNovoId.Text = String.Empty;
            txbNovoNome.Text = String.Empty;
            txbNovaIdade.Text = String.Empty;
        }
    }
}
