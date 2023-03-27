﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace App23
{
    public partial class Form1 : Form
    {

        string RxString;
        string txt_Rec = string.Empty;

        List<string> TempList = new List<string>();

        string txt_List = string.Empty;

        int qtde_data = 0;

        double crtVolt = 0;

        double x_axis = 0;

        int temperaturaEscolhida = 0;

        int temperatura = 0;

        bool fornoLigado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void atualizaCom()
        {
            //Limpa todos os itens em cbPortas caso existam
            cbPortas.Items.Clear();

            /* Para cada nome de porta de comunicação serial identificado
             * será atribuído à variável 's'*/
            foreach (string s in SerialPort.GetPortNames())
            {
                //adiciona a variável 's' a cada item de cbPortas
                cbPortas.Items.Add(s);
            }

            //Seleciona o item de índice 0 em cbPortas
            cbPortas.SelectedIndex = 0;
        }

        private void paridade()
        {
            int i = 0;      //variável de controle de índice do combo

            //Limpa todos os itens em cbParidade caso existam
            cbParidade.Items.Clear();

            // Para cada nome de paridade identificado será atribuído à variável 's'
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                //adiciona a variável 's' a cada item de cbParidade
                cbParidade.Items.Add(s);

                /* verifica se o nome recebido é 'None',
                 * caso seja, seleciona o seu índice para exibição*/
                if (s == "None")
                    cbParidade.SelectedIndex = i;

                i++;    //incrementa a variável i
            }
        }

        private void bitsParada()
        {
            int i = 0;      //variável de controle de índice do combo

            //Limpa todos os itens em cbBitsParada caso existam
            cbBitsParada.Items.Clear();

            // Para cada nome de bits de parada identificado será atribuído à variável 's'
            foreach (string str in Enum.GetNames(typeof(StopBits)))
            {
                //adiciona a variável 's' a cada item de cbBitsParada
                cbBitsParada.Items.Add(str);

                /* verifica se o nome recebido é 'One',
                 * caso seja, seleciona o seu índice para exibição*/
                if (str == "One") cbBitsParada.SelectedIndex = i;

                i++;    //inrementa a variável i
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaCom();

            cbBaud.SelectedText = "9600";

            paridade();

            cbBitsDados.SelectedText = "8";

            bitsParada();

            btnFechar.Enabled = false;
            btnSair.Enabled = true;
            btnAbrir.Enabled = true;

           
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (Serial.IsOpen == true) Serial.Close();

            Serial.PortName = cbPortas.Text;
            Serial.BaudRate = Int32.Parse(cbBaud.Text);
            Serial.Parity = (Parity)cbParidade.SelectedIndex;
            Serial.DataBits = Int32.Parse(cbBitsDados.Text);
            Serial.StopBits = (StopBits)cbBitsParada.SelectedIndex;

            try
            {

                Serial.Open();
                btnAbrir.Enabled = false;
                btnFechar.Enabled = true;
                btnSair.Enabled = false;

            }
            catch
            {

                MessageBox.Show("Não foi possível abrir a porta selecionada",
                                 "ATENÇÃO",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

                btnFechar.Enabled = false;
                btnAbrir.Enabled = true;
                btnSair.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Serial.Close();
            btnFechar.Enabled = false;
            btnSair.Enabled = true;
            btnAbrir.Enabled = true;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Serial.Close();
            Close();
        }

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            RxString = Serial.ReadExisting();
            //chama outra thread para escrever o dado em alguma posição do formulário
            this.Invoke(new EventHandler(trataDadoRecebido));

        }
        List<string> listaDados = new List<string>();
        private void trataDadoRecebido(object sender, EventArgs e)
        {

            txt_Rec += RxString;
           // label13.Text = txt_Rec;
            // txt_Rec = string.Empty;

            if (txt_Rec.IndexOf("}") != -1)
            {
                String novaLinha = txt_Rec;
                label13.Text = "N T EM1 EM2 EM3 EM4 EM5 EM6 EM7 EM8 EM9 EM10 EM11 EM12 CM1 CM2 CM3 CM4 CM5 CM6 CM7 CM8 CM9 CM10 CM11 CM12 GyX GyY GyZ AcX AcY AcZ Tmp HCSR X Y Z \n";
                label13.Text += novaLinha;
                txt_Rec = string.Empty;
                listaDados.Add(novaLinha);
            }
            
        }

        private void btnInicia_Click(object sender, EventArgs e)
        {
            if (Serial.IsOpen)
            {
                Serial.Write("IN000000\r");
                tmrApp.Enabled = true;
                tmrPlot.Enabled = true;
            }
        }

        private void btnFinaliza_Click(object sender, EventArgs e)
        {
            if (Serial.IsOpen)
            {
                Serial.Write("FN000000\r");
                tmrApp.Enabled = false;
                tmrPlot.Enabled = false;
       
                  
            }
        }

        private void tmrApp_Tick(object sender, EventArgs e)
        { 
            TempList.Add(DateTime.Now + " - " + txt_List);
            qtde_data++;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextWriter Arq;

            try
            {
                if (svArquivo.ShowDialog() == DialogResult.OK)
                {
                    Arq = File.AppendText(svArquivo.FileName);

                    for (int i = 0; i < qtde_data; i++)
                        Arq.WriteLine(TempList[i]);

                    Arq.Close();
                }

                MessageBox.Show("Cadastro realizado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        private void tmrPlot_Tick(object sender, EventArgs e)
        {
            x_axis++;

            if (x_axis > 100)
            {

     
            }

        }

        private void scrGraf_Scroll(object sender, ScrollEventArgs e)
        {
      
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StreamReader Arq;
            string recebe = string.Empty;

            x_axis = 0; ;


            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    Arq = new StreamReader(openFile.FileName);

                    while (!(Arq.EndOfStream))
                    {
                        recebe = Arq.ReadLine().Substring(26, 4);

                        crtVolt = (double.Parse(recebe) * 5000) / 1023;

                  

                        x_axis++;
                    }
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
    }
}
