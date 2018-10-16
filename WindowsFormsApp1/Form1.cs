using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

        }

        //declara uma classe publica para acessar a variavel de forma global
        public class log_da_Form2_teste
        {

            public static string log_teste;

        }


        //variaveis
        string varMotivo;


        // texto padrão da mascara
        public void Texto()
        {
            //verificar de a check_desempenho esta setada
            if ( check_desempenho.Checked == true )
            {

                Clipboard.SetText(text:
                "ENCERRAMENTO" + System.Environment.NewLine +
                "COLABORADOR: CGS SP - TEC. " + txt_nome.Text + " - " + txt_oi.Text + System.Environment.NewLine +
                "FALHA: BAIXO DESEMPENHO" + System.Environment.NewLine + //chek inoperante ou desempenho
                "HORARIO DA FALHA: " + txt_abertura.Text + System.Environment.NewLine +
                "HORARIO DE NORMALIZACAO: " + txt_normalizacao.Text + System.Environment.NewLine +
                "CAUSA / SOLUCAO: " + varMotivo + System.Environment.NewLine + //var motivo
                "CONTATO DE AUTORIZACAO: " + txt_validacao.Text + " CGR" + System.Environment.NewLine +
                txt_senha.Text + System.Environment.NewLine +
                log_da_Form2_teste.log_teste);

            }
            else
            {

                Clipboard.SetText(text:
                "ENCERRAMENTO" + System.Environment.NewLine +
                "COLABORADOR: CGS SP - TEC. " + txt_nome.Text + " - " + txt_oi.Text + System.Environment.NewLine +
                "FALHA: INOPERANTE" + System.Environment.NewLine + //chek inoperante ou desempenho
                "HORARIO DA FALHA: " + txt_abertura.Text + System.Environment.NewLine +
                "HORARIO DE NORMALIZACAO: " + txt_normalizacao.Text + System.Environment.NewLine +
                "CAUSA / SOLUCAO: " + varMotivo + System.Environment.NewLine + //var motivo
                "CONTATO DE AUTORIZACAO: " + txt_validacao.Text + " CGR" + System.Environment.NewLine +
                txt_senha.Text + System.Environment.NewLine +
                log_da_Form2_teste.log_teste);

            }

        }


        // causa cliente
        // botao abertura indeveida
        private void Button3_Click(object sender, EventArgs e)
        {
            varMotivo = "CAUSA CLIENTE - RECLAMACAO INDEVIDA - CLIENTE SOLICITA ABERTURA PARA CIRCUITO SEM FALHAS.";
            //Texto();
            Texto();
        }
        // botao energia
        private void button4_Click(object sender, EventArgs e)
        {
            varMotivo = "CAUSA CLIENTE - LOCAL SEM ENERGIA.";
            Texto();
        }
        //causa operadora
        // botao causa nao detectada
        private void button5_Click(object sender, EventArgs e)
        {
            varMotivo = "CAUSA OPERADORA - CAUSA NAO DETECTADA - CIRCUITO NORMALIZA APOS OSCILACAO NO BACKBONE.";
            Texto();
        }
        // botao gabinete queimado
        private void button6_Click(object sender, EventArgs e)
        {
            varMotivo = "CAUSA OPERADORA - GABINETE QUEIMADO NO CLIENTE, SUBSTITUIDO.";
            Texto();
        }
        // botao do modem
        private void button7_Click(object sender, EventArgs e)
        {
            varMotivo = "CAUSA OPERADORA - MODEM QUEIMADO NO CLIENTE, SUBSTITUIDO.";
            Texto();
        }
        // botao da fibra recuperado
        private void button8_Click(object sender, EventArgs e)
        {
            varMotivo = "CAUSA OPERADORA - ROMPIMENTO DE FO, RECUPERADA.";
            Texto();
        }
        // botao da fibra manobra
        private void button9_Click(object sender, EventArgs e)
        {
            varMotivo = "CAUSA OPERADORA - ROMPIMENTO DE FO, MANOBRADO.";
            Texto();
        }
        // botao do redea recuperado
        private void button10_Click(object sender, EventArgs e)
        {
            varMotivo = "CAUSA OPERADORA - REDE METALICA DANIFICADA, RECUPERADA.";
            Texto();
        }
        // botao do redea manobra
        private void button11_Click(object sender, EventArgs e)
        {
            varMotivo = "CAUSA OPERADORA - REDE METALICA DANIFICADA, MANOBRA DE PAR.";
            Texto();
        }




        //outra causa
        private void button12_Click(object sender, EventArgs e)
        {

            if ( check_causa.Checked == true )
            { varMotivo = "CAUSA CLIENTE - " + txt_outra.Text; }
            else
            { varMotivo = "CAUSA OPERADORA - " + txt_outra.Text; }
            Texto();

        }



        // botao limpar
        private void button2_Click(object sender, EventArgs e)
        {

            txt_abertura.Clear();
            txt_normalizacao.Clear();
            txt_validacao.Clear();
            txt_senha.Clear();
            txt_outra.Clear();
            log_da_Form2_teste.log_teste = "";

        }



        // botao log
        private void button1_Click(object sender, EventArgs e)
        {

            Form2 testelog = new Form2();
            testelog.ShowDialog();

        }

        // botao router
        private void button3_Click_1(object sender, EventArgs e)

            /* Ao pressinar o botão instancia e chama o
            metodo para verificar se tem letras na hora
            e efetua o calculo de tempo de normalização*/

        {
            HoraClass botaoRouter;
            botaoRouter = new HoraClass();

            botaoRouter.Entrada(txt_router.Text);
            // Faz a entrada de dados no metodo.

            txt_normalizacao.Text = botaoRouter.Saida();
            // Faz a saida de dados do metodo.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}