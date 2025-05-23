using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciamentodetarefas
{
    public partial class tarefaspendentes : Form
    {
        private int tarefaAtualIndex = 0;

        public tarefaspendentes()
        {
            InitializeComponent();
        }

        private void AtualizarCampos()
        {
            // Obtém o cliente atual
            var tarefaAtual = DadosCompartilhados.Tarefas[tarefaAtualIndex];

            // Preenche os campos com os dados do cliente atual
            namebox.Text = tarefaAtual.Nome;
            descbox.Text = tarefaAtual.Descricao;


            // Atualiza o estado dos botões
            button5.Enabled = tarefaAtualIndex > 0;
            button1.Enabled = tarefaAtualIndex < DadosCompartilhados.Tarefas.Count - 1;
        }
        private void listarTodos()
        {
            // Exibe os dados que você tenha uma TextBox chamada "textBoxClientes"
            textBoxtarefa.Multiline = true;                   // Certifique-se de que a propriedade Multiline está habilitada
            textBoxtarefa.ScrollBars = ScrollBars.Vertical;   // Adiciona barra de rolagem vertical, se necessário

            // Preenche a TextBox com os nomes e telefones
            textBoxtarefa.Text = string.Join(Environment.NewLine,
            DadosCompartilhados.Tarefas.Select(p => $"{p.Nome} - {p.Descricao}"));
        }

        private void listarStatus(string status)
        {
            List<string> verifica = new List<string>();

            foreach (var atuals in DadosCompartilhados.Tarefas)
            {
                if (atuals.Status == status)
                {
                    verifica.Add($"{atuals.Nome} - {atuals.Descricao} - {atuals.Status}");
                }
            }
            textBoxtarefa.Text = string.Join(Environment.NewLine, "Exibindo as tarefas com Status:", status);
            textBoxtarefa.Multiline = true;
            textBoxtarefa.Text = string.Join(Environment.NewLine, verifica);


        }

        private void FormListarClientes_Load(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Volta para o cliente anterior, se possível
            if (tarefaAtualIndex > 0)
            {
                tarefaAtualIndex--;
                AtualizarCampos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Avança para o próximo cliente, se possível
            if (tarefaAtualIndex < DadosCompartilhados.Tarefas.Count - 1)
            {
                tarefaAtualIndex++;
                AtualizarCampos();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tarefaspendentes_Load(object sender, EventArgs e)
        {
            listarTodos();
            AtualizarCampos();
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listarStatus("Pendente");
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            listarStatus("Atrasado");
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            listarStatus("Concluido");
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = true;
        }

        
    }
}
