using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda_simples
{
    public partial class Form1 : Form
    {
        private Contato[] listaDeContatos = new Contato[1];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            AtualizarDisplay();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btmAddBotao_Click(object sender, EventArgs e)
        {

            //Criar contato :)
            Contato objetoContato = new Contato(txtNome.Text, txtSobrenome.Text, txtTelefone.Text, txtEmail.Text);
            Escrever(objetoContato);
            Ler();
            AtualizarDisplay();
            LimparFormulario();

        }
        //Escrever contatos no arquivo TXT
        private void Escrever(Contato contato) 
        {
            StreamWriter sw = new StreamWriter("Contatos.txt");
            sw.WriteLine(listaDeContatos.Length + 1);
            sw.WriteLine(contato.PrimeiroNome);
            sw.Write(contato.sobrenome);
            sw.WriteLine(contato.Telefone);
            sw.WriteLine(contato.Email);

            // Recuperador de contatos anteriores :)
            for(int i = 0; i < listaDeContatos.Length; i++) 
            {
                sw.WriteLine(listaDeContatos.Length + 1);
                sw.WriteLine(contato.PrimeiroNome);
                sw.Write(contato.sobrenome);
                sw.WriteLine(contato.Telefone);
                sw.WriteLine(contato.Email);
            }
            sw.Close();
        }
        private void Ler()
        {
            StreamReader leitorDeArquivos = new StreamReader("Contatos.txt");
            listaDeContatos = new Contato[Convert.ToInt32(leitorDeArquivos.ReadLine())];
            // Copia os dados do arquivo de texto para o vetor listaDeContatos
            for (int i = 0; i < listaDeContatos.Length; i++)
            {
                listaDeContatos[i] = new Contato();
                listaDeContatos[i].PrimeiroNome = leitorDeArquivos.ReadLine();
                listaDeContatos[i].sobrenome = leitorDeArquivos.ReadLine();
                listaDeContatos[i].Telefone = leitorDeArquivos.ReadLine();
                listaDeContatos[i].Email = leitorDeArquivos.ReadLine();
            }
            leitorDeArquivos.Close();
        }
        //atualiza o "display" com os dados do arquivo de txt
        private void AtualizarDisplay()
        {
            lstContatos.Items.Clear();
            for(int i = 0; i < listaDeContatos.Length; i++)
            {
                //insere no display, os membros de listaContatos
                //um a um
                lstContatos.Items.Add(listaDeContatos[i].ToString());
            }
        }
        private void LimparFormulario() 
        { 
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
    private void lstContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
