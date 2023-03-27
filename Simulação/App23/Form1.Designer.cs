namespace App23
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBitsParada = new System.Windows.Forms.ComboBox();
            this.cbBitsDados = new System.Windows.Forms.ComboBox();
            this.cbParidade = new System.Windows.Forms.ComboBox();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.cbPortas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.btnFinaliza = new System.Windows.Forms.Button();
            this.btnInicia = new System.Windows.Forms.Button();
            this.mnApp = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrApp = new System.Windows.Forms.Timer(this.components);
            this.svArquivo = new System.Windows.Forms.SaveFileDialog();
            this.tmrPlot = new System.Windows.Forms.Timer(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.RedeNeuralPreditiva = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox244 = new System.Windows.Forms.TextBox();
            this.textBox243 = new System.Windows.Forms.TextBox();
            this.textBox242 = new System.Windows.Forms.TextBox();
            this.textBox241 = new System.Windows.Forms.TextBox();
            this.textBox240 = new System.Windows.Forms.TextBox();
            this.textBox239 = new System.Windows.Forms.TextBox();
            this.textBox238 = new System.Windows.Forms.TextBox();
            this.textBox237 = new System.Windows.Forms.TextBox();
            this.textBox236 = new System.Windows.Forms.TextBox();
            this.textBox235 = new System.Windows.Forms.TextBox();
            this.textBox234 = new System.Windows.Forms.TextBox();
            this.textBox233 = new System.Windows.Forms.TextBox();
            this.textBox232 = new System.Windows.Forms.TextBox();
            this.textBox231 = new System.Windows.Forms.TextBox();
            this.textBox230 = new System.Windows.Forms.TextBox();
            this.textBox229 = new System.Windows.Forms.TextBox();
            this.textBox228 = new System.Windows.Forms.TextBox();
            this.textBox227 = new System.Windows.Forms.TextBox();
            this.textBox226 = new System.Windows.Forms.TextBox();
            this.textBox225 = new System.Windows.Forms.TextBox();
            this.textBox224 = new System.Windows.Forms.TextBox();
            this.textBox223 = new System.Windows.Forms.TextBox();
            this.textBox222 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox83 = new System.Windows.Forms.TextBox();
            this.textBox82 = new System.Windows.Forms.TextBox();
            this.textBox81 = new System.Windows.Forms.TextBox();
            this.textBox80 = new System.Windows.Forms.TextBox();
            this.textBox79 = new System.Windows.Forms.TextBox();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.textBox118 = new System.Windows.Forms.TextBox();
            this.textBox117 = new System.Windows.Forms.TextBox();
            this.textBox116 = new System.Windows.Forms.TextBox();
            this.textBox115 = new System.Windows.Forms.TextBox();
            this.textBox114 = new System.Windows.Forms.TextBox();
            this.textBox113 = new System.Windows.Forms.TextBox();
            this.textBox112 = new System.Windows.Forms.TextBox();
            this.textBox111 = new System.Windows.Forms.TextBox();
            this.textBox110 = new System.Windows.Forms.TextBox();
            this.textBox109 = new System.Windows.Forms.TextBox();
            this.textBox108 = new System.Windows.Forms.TextBox();
            this.textBox107 = new System.Windows.Forms.TextBox();
            this.textBox106 = new System.Windows.Forms.TextBox();
            this.textBox153 = new System.Windows.Forms.TextBox();
            this.textBox152 = new System.Windows.Forms.TextBox();
            this.textBox151 = new System.Windows.Forms.TextBox();
            this.textBox150 = new System.Windows.Forms.TextBox();
            this.textBox149 = new System.Windows.Forms.TextBox();
            this.textBox148 = new System.Windows.Forms.TextBox();
            this.textBox147 = new System.Windows.Forms.TextBox();
            this.textBox146 = new System.Windows.Forms.TextBox();
            this.textBox145 = new System.Windows.Forms.TextBox();
            this.textBox144 = new System.Windows.Forms.TextBox();
            this.textBox143 = new System.Windows.Forms.TextBox();
            this.textBox142 = new System.Windows.Forms.TextBox();
            this.textBox141 = new System.Windows.Forms.TextBox();
            this.textBox188 = new System.Windows.Forms.TextBox();
            this.textBox187 = new System.Windows.Forms.TextBox();
            this.textBox186 = new System.Windows.Forms.TextBox();
            this.textBox185 = new System.Windows.Forms.TextBox();
            this.textBox184 = new System.Windows.Forms.TextBox();
            this.textBox183 = new System.Windows.Forms.TextBox();
            this.textBox182 = new System.Windows.Forms.TextBox();
            this.textBox181 = new System.Windows.Forms.TextBox();
            this.textBox180 = new System.Windows.Forms.TextBox();
            this.textBox179 = new System.Windows.Forms.TextBox();
            this.textBox178 = new System.Windows.Forms.TextBox();
            this.textBox177 = new System.Windows.Forms.TextBox();
            this.textBox176 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox105 = new System.Windows.Forms.TextBox();
            this.textBox104 = new System.Windows.Forms.TextBox();
            this.textBox103 = new System.Windows.Forms.TextBox();
            this.textBox102 = new System.Windows.Forms.TextBox();
            this.textBox101 = new System.Windows.Forms.TextBox();
            this.textBox100 = new System.Windows.Forms.TextBox();
            this.textBox99 = new System.Windows.Forms.TextBox();
            this.textBox98 = new System.Windows.Forms.TextBox();
            this.textBox97 = new System.Windows.Forms.TextBox();
            this.textBox96 = new System.Windows.Forms.TextBox();
            this.textBox95 = new System.Windows.Forms.TextBox();
            this.textBox94 = new System.Windows.Forms.TextBox();
            this.textBox93 = new System.Windows.Forms.TextBox();
            this.textBox92 = new System.Windows.Forms.TextBox();
            this.textBox91 = new System.Windows.Forms.TextBox();
            this.textBox90 = new System.Windows.Forms.TextBox();
            this.textBox89 = new System.Windows.Forms.TextBox();
            this.textBox88 = new System.Windows.Forms.TextBox();
            this.textBox87 = new System.Windows.Forms.TextBox();
            this.textBox86 = new System.Windows.Forms.TextBox();
            this.textBox85 = new System.Windows.Forms.TextBox();
            this.textBox84 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox140 = new System.Windows.Forms.TextBox();
            this.textBox139 = new System.Windows.Forms.TextBox();
            this.textBox138 = new System.Windows.Forms.TextBox();
            this.textBox137 = new System.Windows.Forms.TextBox();
            this.textBox136 = new System.Windows.Forms.TextBox();
            this.textBox135 = new System.Windows.Forms.TextBox();
            this.textBox134 = new System.Windows.Forms.TextBox();
            this.textBox133 = new System.Windows.Forms.TextBox();
            this.textBox132 = new System.Windows.Forms.TextBox();
            this.textBox131 = new System.Windows.Forms.TextBox();
            this.textBox130 = new System.Windows.Forms.TextBox();
            this.textBox129 = new System.Windows.Forms.TextBox();
            this.textBox128 = new System.Windows.Forms.TextBox();
            this.textBox127 = new System.Windows.Forms.TextBox();
            this.textBox126 = new System.Windows.Forms.TextBox();
            this.textBox125 = new System.Windows.Forms.TextBox();
            this.textBox124 = new System.Windows.Forms.TextBox();
            this.textBox123 = new System.Windows.Forms.TextBox();
            this.textBox122 = new System.Windows.Forms.TextBox();
            this.textBox121 = new System.Windows.Forms.TextBox();
            this.textBox120 = new System.Windows.Forms.TextBox();
            this.textBox119 = new System.Windows.Forms.TextBox();
            this.textBox175 = new System.Windows.Forms.TextBox();
            this.textBox174 = new System.Windows.Forms.TextBox();
            this.textBox173 = new System.Windows.Forms.TextBox();
            this.textBox172 = new System.Windows.Forms.TextBox();
            this.textBox171 = new System.Windows.Forms.TextBox();
            this.textBox170 = new System.Windows.Forms.TextBox();
            this.textBox169 = new System.Windows.Forms.TextBox();
            this.textBox168 = new System.Windows.Forms.TextBox();
            this.textBox167 = new System.Windows.Forms.TextBox();
            this.textBox166 = new System.Windows.Forms.TextBox();
            this.textBox165 = new System.Windows.Forms.TextBox();
            this.textBox164 = new System.Windows.Forms.TextBox();
            this.textBox163 = new System.Windows.Forms.TextBox();
            this.textBox162 = new System.Windows.Forms.TextBox();
            this.textBox161 = new System.Windows.Forms.TextBox();
            this.textBox160 = new System.Windows.Forms.TextBox();
            this.textBox159 = new System.Windows.Forms.TextBox();
            this.textBox158 = new System.Windows.Forms.TextBox();
            this.textBox157 = new System.Windows.Forms.TextBox();
            this.textBox156 = new System.Windows.Forms.TextBox();
            this.textBox155 = new System.Windows.Forms.TextBox();
            this.textBox154 = new System.Windows.Forms.TextBox();
            this.textBox210 = new System.Windows.Forms.TextBox();
            this.textBox209 = new System.Windows.Forms.TextBox();
            this.textBox208 = new System.Windows.Forms.TextBox();
            this.textBox207 = new System.Windows.Forms.TextBox();
            this.textBox206 = new System.Windows.Forms.TextBox();
            this.textBox205 = new System.Windows.Forms.TextBox();
            this.textBox204 = new System.Windows.Forms.TextBox();
            this.textBox203 = new System.Windows.Forms.TextBox();
            this.textBox202 = new System.Windows.Forms.TextBox();
            this.textBox201 = new System.Windows.Forms.TextBox();
            this.textBox200 = new System.Windows.Forms.TextBox();
            this.textBox199 = new System.Windows.Forms.TextBox();
            this.textBox198 = new System.Windows.Forms.TextBox();
            this.textBox197 = new System.Windows.Forms.TextBox();
            this.textBox196 = new System.Windows.Forms.TextBox();
            this.textBox195 = new System.Windows.Forms.TextBox();
            this.textBox194 = new System.Windows.Forms.TextBox();
            this.textBox193 = new System.Windows.Forms.TextBox();
            this.textBox192 = new System.Windows.Forms.TextBox();
            this.textBox191 = new System.Windows.Forms.TextBox();
            this.textBox190 = new System.Windows.Forms.TextBox();
            this.textBox189 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.mnApp.SuspendLayout();
            this.RedeNeuralPreditiva.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBitsParada);
            this.groupBox1.Controls.Add(this.cbBitsDados);
            this.groupBox1.Controls.Add(this.cbParidade);
            this.groupBox1.Controls.Add(this.cbBaud);
            this.groupBox1.Controls.Add(this.cbPortas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração";
            // 
            // cbBitsParada
            // 
            this.cbBitsParada.FormattingEnabled = true;
            this.cbBitsParada.Location = new System.Drawing.Point(383, 47);
            this.cbBitsParada.Name = "cbBitsParada";
            this.cbBitsParada.Size = new System.Drawing.Size(92, 21);
            this.cbBitsParada.TabIndex = 9;
            // 
            // cbBitsDados
            // 
            this.cbBitsDados.FormattingEnabled = true;
            this.cbBitsDados.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbBitsDados.Location = new System.Drawing.Point(284, 47);
            this.cbBitsDados.Name = "cbBitsDados";
            this.cbBitsDados.Size = new System.Drawing.Size(84, 21);
            this.cbBitsDados.TabIndex = 8;
            // 
            // cbParidade
            // 
            this.cbParidade.FormattingEnabled = true;
            this.cbParidade.Location = new System.Drawing.Point(189, 47);
            this.cbParidade.Name = "cbParidade";
            this.cbParidade.Size = new System.Drawing.Size(80, 21);
            this.cbParidade.TabIndex = 7;
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbBaud.Location = new System.Drawing.Point(87, 47);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(86, 21);
            this.cbBaud.TabIndex = 6;
            // 
            // cbPortas
            // 
            this.cbPortas.FormattingEnabled = true;
            this.cbPortas.Location = new System.Drawing.Point(7, 47);
            this.cbPortas.Name = "cbPortas";
            this.cbPortas.Size = new System.Drawing.Size(69, 21);
            this.cbPortas.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bits de Parada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bits de Dados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paridade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Velocidade (bps):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Portas:";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(522, 31);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(84, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir Porta";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(522, 58);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(84, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar Porta";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(612, 60);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(84, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Serial
            // 
            this.Serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Serial_DataReceived);
            // 
            // btnFinaliza
            // 
            this.btnFinaliza.Location = new System.Drawing.Point(612, 31);
            this.btnFinaliza.Name = "btnFinaliza";
            this.btnFinaliza.Size = new System.Drawing.Size(84, 23);
            this.btnFinaliza.TabIndex = 3;
            this.btnFinaliza.Text = "Finalizar";
            this.btnFinaliza.UseVisualStyleBackColor = true;
            this.btnFinaliza.Click += new System.EventHandler(this.btnFinaliza_Click);
            // 
            // btnInicia
            // 
            this.btnInicia.Location = new System.Drawing.Point(522, 87);
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.Size = new System.Drawing.Size(84, 23);
            this.btnInicia.TabIndex = 1;
            this.btnInicia.Text = "Iniciar";
            this.btnInicia.UseVisualStyleBackColor = true;
            this.btnInicia.Click += new System.EventHandler(this.btnInicia_Click);
            // 
            // mnApp
            // 
            this.mnApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.mnApp.Location = new System.Drawing.Point(0, 0);
            this.mnApp.Name = "mnApp";
            this.mnApp.Size = new System.Drawing.Size(1284, 24);
            this.mnApp.TabIndex = 5;
            this.mnApp.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuItem2.Text = "Abrir";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // tmrApp
            // 
            this.tmrApp.Interval = 1000;
            this.tmrApp.Tick += new System.EventHandler(this.tmrApp_Tick);
            // 
            // svArquivo
            // 
            this.svArquivo.DefaultExt = "txt";
            this.svArquivo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.svArquivo.Title = "Salvar Arquivo";
            // 
            // tmrPlot
            // 
            this.tmrPlot.Interval = 1000;
            this.tmrPlot.Tick += new System.EventHandler(this.tmrPlot_Tick);
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "txt";
            this.openFile.Filter = "Arquivos txt (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
            this.openFile.Title = "Abrir Arquivo";
            // 
            // RedeNeuralPreditiva
            // 
            this.RedeNeuralPreditiva.Controls.Add(this.tabPage1);
            this.RedeNeuralPreditiva.Controls.Add(this.tabPage2);
            this.RedeNeuralPreditiva.Controls.Add(this.tabPage3);
            this.RedeNeuralPreditiva.Controls.Add(this.tabPage4);
            this.RedeNeuralPreditiva.Controls.Add(this.tabPage5);
            this.RedeNeuralPreditiva.Location = new System.Drawing.Point(0, 141);
            this.RedeNeuralPreditiva.Name = "RedeNeuralPreditiva";
            this.RedeNeuralPreditiva.SelectedIndex = 0;
            this.RedeNeuralPreditiva.Size = new System.Drawing.Size(1284, 904);
            this.RedeNeuralPreditiva.TabIndex = 23;
            this.RedeNeuralPreditiva.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1175, 878);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor Serial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "-";
            this.label13.Click += new System.EventHandler(this.label13_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1276, 878);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Giroscópio acelerômetro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App23.Properties.Resources.Movimento1;
            this.pictureBox1.Location = new System.Drawing.Point(95, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 510);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1276, 878);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sensor Ultrassônico";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1276, 878);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Temperatura";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox176);
            this.tabPage5.Controls.Add(this.textBox177);
            this.tabPage5.Controls.Add(this.textBox178);
            this.tabPage5.Controls.Add(this.textBox179);
            this.tabPage5.Controls.Add(this.textBox180);
            this.tabPage5.Controls.Add(this.textBox181);
            this.tabPage5.Controls.Add(this.textBox182);
            this.tabPage5.Controls.Add(this.textBox183);
            this.tabPage5.Controls.Add(this.textBox184);
            this.tabPage5.Controls.Add(this.textBox185);
            this.tabPage5.Controls.Add(this.textBox186);
            this.tabPage5.Controls.Add(this.textBox187);
            this.tabPage5.Controls.Add(this.textBox188);
            this.tabPage5.Controls.Add(this.textBox189);
            this.tabPage5.Controls.Add(this.textBox190);
            this.tabPage5.Controls.Add(this.textBox191);
            this.tabPage5.Controls.Add(this.textBox192);
            this.tabPage5.Controls.Add(this.textBox193);
            this.tabPage5.Controls.Add(this.textBox194);
            this.tabPage5.Controls.Add(this.textBox195);
            this.tabPage5.Controls.Add(this.textBox196);
            this.tabPage5.Controls.Add(this.textBox197);
            this.tabPage5.Controls.Add(this.textBox198);
            this.tabPage5.Controls.Add(this.textBox199);
            this.tabPage5.Controls.Add(this.textBox200);
            this.tabPage5.Controls.Add(this.textBox201);
            this.tabPage5.Controls.Add(this.textBox202);
            this.tabPage5.Controls.Add(this.textBox203);
            this.tabPage5.Controls.Add(this.textBox204);
            this.tabPage5.Controls.Add(this.textBox205);
            this.tabPage5.Controls.Add(this.textBox206);
            this.tabPage5.Controls.Add(this.textBox207);
            this.tabPage5.Controls.Add(this.textBox208);
            this.tabPage5.Controls.Add(this.textBox209);
            this.tabPage5.Controls.Add(this.textBox210);
            this.tabPage5.Controls.Add(this.label45);
            this.tabPage5.Controls.Add(this.textBox222);
            this.tabPage5.Controls.Add(this.textBox223);
            this.tabPage5.Controls.Add(this.textBox224);
            this.tabPage5.Controls.Add(this.textBox225);
            this.tabPage5.Controls.Add(this.textBox226);
            this.tabPage5.Controls.Add(this.textBox227);
            this.tabPage5.Controls.Add(this.textBox228);
            this.tabPage5.Controls.Add(this.textBox229);
            this.tabPage5.Controls.Add(this.textBox230);
            this.tabPage5.Controls.Add(this.textBox231);
            this.tabPage5.Controls.Add(this.textBox232);
            this.tabPage5.Controls.Add(this.textBox233);
            this.tabPage5.Controls.Add(this.textBox234);
            this.tabPage5.Controls.Add(this.textBox235);
            this.tabPage5.Controls.Add(this.textBox236);
            this.tabPage5.Controls.Add(this.textBox237);
            this.tabPage5.Controls.Add(this.textBox238);
            this.tabPage5.Controls.Add(this.textBox239);
            this.tabPage5.Controls.Add(this.textBox240);
            this.tabPage5.Controls.Add(this.textBox241);
            this.tabPage5.Controls.Add(this.textBox242);
            this.tabPage5.Controls.Add(this.textBox243);
            this.tabPage5.Controls.Add(this.textBox244);
            this.tabPage5.Controls.Add(this.textBox141);
            this.tabPage5.Controls.Add(this.textBox142);
            this.tabPage5.Controls.Add(this.textBox143);
            this.tabPage5.Controls.Add(this.textBox144);
            this.tabPage5.Controls.Add(this.textBox145);
            this.tabPage5.Controls.Add(this.textBox146);
            this.tabPage5.Controls.Add(this.textBox147);
            this.tabPage5.Controls.Add(this.textBox148);
            this.tabPage5.Controls.Add(this.textBox149);
            this.tabPage5.Controls.Add(this.textBox150);
            this.tabPage5.Controls.Add(this.textBox151);
            this.tabPage5.Controls.Add(this.textBox152);
            this.tabPage5.Controls.Add(this.textBox153);
            this.tabPage5.Controls.Add(this.textBox154);
            this.tabPage5.Controls.Add(this.textBox155);
            this.tabPage5.Controls.Add(this.textBox156);
            this.tabPage5.Controls.Add(this.textBox157);
            this.tabPage5.Controls.Add(this.textBox158);
            this.tabPage5.Controls.Add(this.textBox159);
            this.tabPage5.Controls.Add(this.textBox160);
            this.tabPage5.Controls.Add(this.textBox161);
            this.tabPage5.Controls.Add(this.textBox162);
            this.tabPage5.Controls.Add(this.textBox163);
            this.tabPage5.Controls.Add(this.textBox164);
            this.tabPage5.Controls.Add(this.textBox165);
            this.tabPage5.Controls.Add(this.textBox166);
            this.tabPage5.Controls.Add(this.textBox167);
            this.tabPage5.Controls.Add(this.textBox168);
            this.tabPage5.Controls.Add(this.textBox169);
            this.tabPage5.Controls.Add(this.textBox170);
            this.tabPage5.Controls.Add(this.textBox171);
            this.tabPage5.Controls.Add(this.textBox172);
            this.tabPage5.Controls.Add(this.textBox173);
            this.tabPage5.Controls.Add(this.textBox174);
            this.tabPage5.Controls.Add(this.textBox175);
            this.tabPage5.Controls.Add(this.textBox106);
            this.tabPage5.Controls.Add(this.textBox107);
            this.tabPage5.Controls.Add(this.textBox108);
            this.tabPage5.Controls.Add(this.textBox109);
            this.tabPage5.Controls.Add(this.textBox110);
            this.tabPage5.Controls.Add(this.textBox111);
            this.tabPage5.Controls.Add(this.textBox112);
            this.tabPage5.Controls.Add(this.textBox113);
            this.tabPage5.Controls.Add(this.textBox114);
            this.tabPage5.Controls.Add(this.textBox115);
            this.tabPage5.Controls.Add(this.textBox116);
            this.tabPage5.Controls.Add(this.textBox117);
            this.tabPage5.Controls.Add(this.textBox118);
            this.tabPage5.Controls.Add(this.textBox119);
            this.tabPage5.Controls.Add(this.textBox120);
            this.tabPage5.Controls.Add(this.textBox121);
            this.tabPage5.Controls.Add(this.textBox122);
            this.tabPage5.Controls.Add(this.textBox123);
            this.tabPage5.Controls.Add(this.textBox124);
            this.tabPage5.Controls.Add(this.textBox125);
            this.tabPage5.Controls.Add(this.textBox126);
            this.tabPage5.Controls.Add(this.textBox127);
            this.tabPage5.Controls.Add(this.textBox128);
            this.tabPage5.Controls.Add(this.textBox129);
            this.tabPage5.Controls.Add(this.textBox130);
            this.tabPage5.Controls.Add(this.textBox131);
            this.tabPage5.Controls.Add(this.textBox132);
            this.tabPage5.Controls.Add(this.textBox133);
            this.tabPage5.Controls.Add(this.textBox134);
            this.tabPage5.Controls.Add(this.textBox135);
            this.tabPage5.Controls.Add(this.textBox136);
            this.tabPage5.Controls.Add(this.textBox137);
            this.tabPage5.Controls.Add(this.textBox138);
            this.tabPage5.Controls.Add(this.textBox139);
            this.tabPage5.Controls.Add(this.textBox140);
            this.tabPage5.Controls.Add(this.label44);
            this.tabPage5.Controls.Add(this.textBox71);
            this.tabPage5.Controls.Add(this.textBox72);
            this.tabPage5.Controls.Add(this.textBox73);
            this.tabPage5.Controls.Add(this.textBox74);
            this.tabPage5.Controls.Add(this.textBox75);
            this.tabPage5.Controls.Add(this.textBox76);
            this.tabPage5.Controls.Add(this.textBox77);
            this.tabPage5.Controls.Add(this.textBox78);
            this.tabPage5.Controls.Add(this.textBox79);
            this.tabPage5.Controls.Add(this.textBox80);
            this.tabPage5.Controls.Add(this.textBox81);
            this.tabPage5.Controls.Add(this.textBox82);
            this.tabPage5.Controls.Add(this.textBox83);
            this.tabPage5.Controls.Add(this.textBox84);
            this.tabPage5.Controls.Add(this.textBox85);
            this.tabPage5.Controls.Add(this.textBox86);
            this.tabPage5.Controls.Add(this.textBox87);
            this.tabPage5.Controls.Add(this.textBox88);
            this.tabPage5.Controls.Add(this.textBox89);
            this.tabPage5.Controls.Add(this.textBox90);
            this.tabPage5.Controls.Add(this.textBox91);
            this.tabPage5.Controls.Add(this.textBox92);
            this.tabPage5.Controls.Add(this.textBox93);
            this.tabPage5.Controls.Add(this.textBox94);
            this.tabPage5.Controls.Add(this.textBox95);
            this.tabPage5.Controls.Add(this.textBox96);
            this.tabPage5.Controls.Add(this.textBox97);
            this.tabPage5.Controls.Add(this.textBox98);
            this.tabPage5.Controls.Add(this.textBox99);
            this.tabPage5.Controls.Add(this.textBox100);
            this.tabPage5.Controls.Add(this.textBox101);
            this.tabPage5.Controls.Add(this.textBox102);
            this.tabPage5.Controls.Add(this.textBox103);
            this.tabPage5.Controls.Add(this.textBox104);
            this.tabPage5.Controls.Add(this.textBox105);
            this.tabPage5.Controls.Add(this.label32);
            this.tabPage5.Controls.Add(this.textBox25);
            this.tabPage5.Controls.Add(this.textBox37);
            this.tabPage5.Controls.Add(this.textBox38);
            this.tabPage5.Controls.Add(this.textBox39);
            this.tabPage5.Controls.Add(this.textBox40);
            this.tabPage5.Controls.Add(this.textBox41);
            this.tabPage5.Controls.Add(this.textBox42);
            this.tabPage5.Controls.Add(this.textBox43);
            this.tabPage5.Controls.Add(this.textBox44);
            this.tabPage5.Controls.Add(this.textBox45);
            this.tabPage5.Controls.Add(this.textBox46);
            this.tabPage5.Controls.Add(this.textBox47);
            this.tabPage5.Controls.Add(this.textBox48);
            this.tabPage5.Controls.Add(this.textBox49);
            this.tabPage5.Controls.Add(this.textBox50);
            this.tabPage5.Controls.Add(this.textBox51);
            this.tabPage5.Controls.Add(this.textBox52);
            this.tabPage5.Controls.Add(this.textBox53);
            this.tabPage5.Controls.Add(this.textBox54);
            this.tabPage5.Controls.Add(this.textBox55);
            this.tabPage5.Controls.Add(this.textBox56);
            this.tabPage5.Controls.Add(this.textBox57);
            this.tabPage5.Controls.Add(this.textBox58);
            this.tabPage5.Controls.Add(this.textBox59);
            this.tabPage5.Controls.Add(this.textBox60);
            this.tabPage5.Controls.Add(this.textBox61);
            this.tabPage5.Controls.Add(this.textBox62);
            this.tabPage5.Controls.Add(this.textBox63);
            this.tabPage5.Controls.Add(this.textBox64);
            this.tabPage5.Controls.Add(this.textBox65);
            this.tabPage5.Controls.Add(this.textBox66);
            this.tabPage5.Controls.Add(this.textBox67);
            this.tabPage5.Controls.Add(this.textBox68);
            this.tabPage5.Controls.Add(this.textBox69);
            this.tabPage5.Controls.Add(this.textBox70);
            this.tabPage5.Controls.Add(this.textBox26);
            this.tabPage5.Controls.Add(this.label33);
            this.tabPage5.Controls.Add(this.textBox27);
            this.tabPage5.Controls.Add(this.label34);
            this.tabPage5.Controls.Add(this.textBox28);
            this.tabPage5.Controls.Add(this.label35);
            this.tabPage5.Controls.Add(this.textBox29);
            this.tabPage5.Controls.Add(this.label36);
            this.tabPage5.Controls.Add(this.textBox30);
            this.tabPage5.Controls.Add(this.label37);
            this.tabPage5.Controls.Add(this.textBox31);
            this.tabPage5.Controls.Add(this.label38);
            this.tabPage5.Controls.Add(this.textBox32);
            this.tabPage5.Controls.Add(this.label39);
            this.tabPage5.Controls.Add(this.textBox33);
            this.tabPage5.Controls.Add(this.label40);
            this.tabPage5.Controls.Add(this.textBox34);
            this.tabPage5.Controls.Add(this.label41);
            this.tabPage5.Controls.Add(this.textBox35);
            this.tabPage5.Controls.Add(this.label42);
            this.tabPage5.Controls.Add(this.textBox36);
            this.tabPage5.Controls.Add(this.label43);
            this.tabPage5.Controls.Add(this.textBox13);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.textBox14);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.textBox15);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.textBox16);
            this.tabPage5.Controls.Add(this.label23);
            this.tabPage5.Controls.Add(this.textBox17);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(this.textBox18);
            this.tabPage5.Controls.Add(this.label25);
            this.tabPage5.Controls.Add(this.textBox19);
            this.tabPage5.Controls.Add(this.label26);
            this.tabPage5.Controls.Add(this.textBox20);
            this.tabPage5.Controls.Add(this.label27);
            this.tabPage5.Controls.Add(this.textBox21);
            this.tabPage5.Controls.Add(this.label28);
            this.tabPage5.Controls.Add(this.textBox22);
            this.tabPage5.Controls.Add(this.label29);
            this.tabPage5.Controls.Add(this.textBox23);
            this.tabPage5.Controls.Add(this.label30);
            this.tabPage5.Controls.Add(this.textBox24);
            this.tabPage5.Controls.Add(this.label31);
            this.tabPage5.Controls.Add(this.textBox9);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.textBox10);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.textBox11);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.textBox12);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.textBox5);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.textBox6);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.textBox7);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.textBox8);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.textBox3);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.textBox4);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.textBox2);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1276, 878);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Rede Neural Preditiva";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // textBox244
            // 
            this.textBox244.Location = new System.Drawing.Point(1137, 187);
            this.textBox244.Name = "textBox244";
            this.textBox244.Size = new System.Drawing.Size(31, 20);
            this.textBox244.TabIndex = 378;
            // 
            // textBox243
            // 
            this.textBox243.Location = new System.Drawing.Point(1137, 207);
            this.textBox243.Name = "textBox243";
            this.textBox243.Size = new System.Drawing.Size(31, 20);
            this.textBox243.TabIndex = 379;
            // 
            // textBox242
            // 
            this.textBox242.Location = new System.Drawing.Point(1137, 226);
            this.textBox242.Name = "textBox242";
            this.textBox242.Size = new System.Drawing.Size(31, 20);
            this.textBox242.TabIndex = 380;
            // 
            // textBox241
            // 
            this.textBox241.Location = new System.Drawing.Point(1137, 246);
            this.textBox241.Name = "textBox241";
            this.textBox241.Size = new System.Drawing.Size(31, 20);
            this.textBox241.TabIndex = 381;
            // 
            // textBox240
            // 
            this.textBox240.Location = new System.Drawing.Point(1137, 265);
            this.textBox240.Name = "textBox240";
            this.textBox240.Size = new System.Drawing.Size(31, 20);
            this.textBox240.TabIndex = 382;
            // 
            // textBox239
            // 
            this.textBox239.Location = new System.Drawing.Point(1137, 285);
            this.textBox239.Name = "textBox239";
            this.textBox239.Size = new System.Drawing.Size(31, 20);
            this.textBox239.TabIndex = 383;
            // 
            // textBox238
            // 
            this.textBox238.Location = new System.Drawing.Point(1137, 304);
            this.textBox238.Name = "textBox238";
            this.textBox238.Size = new System.Drawing.Size(31, 20);
            this.textBox238.TabIndex = 384;
            // 
            // textBox237
            // 
            this.textBox237.Location = new System.Drawing.Point(1137, 324);
            this.textBox237.Name = "textBox237";
            this.textBox237.Size = new System.Drawing.Size(31, 20);
            this.textBox237.TabIndex = 385;
            // 
            // textBox236
            // 
            this.textBox236.Location = new System.Drawing.Point(1137, 344);
            this.textBox236.Name = "textBox236";
            this.textBox236.Size = new System.Drawing.Size(31, 20);
            this.textBox236.TabIndex = 386;
            // 
            // textBox235
            // 
            this.textBox235.Location = new System.Drawing.Point(1137, 364);
            this.textBox235.Name = "textBox235";
            this.textBox235.Size = new System.Drawing.Size(31, 20);
            this.textBox235.TabIndex = 387;
            // 
            // textBox234
            // 
            this.textBox234.Location = new System.Drawing.Point(1137, 383);
            this.textBox234.Name = "textBox234";
            this.textBox234.Size = new System.Drawing.Size(31, 20);
            this.textBox234.TabIndex = 388;
            // 
            // textBox233
            // 
            this.textBox233.Location = new System.Drawing.Point(1137, 403);
            this.textBox233.Name = "textBox233";
            this.textBox233.Size = new System.Drawing.Size(31, 20);
            this.textBox233.TabIndex = 389;
            // 
            // textBox232
            // 
            this.textBox232.Location = new System.Drawing.Point(1137, 431);
            this.textBox232.Name = "textBox232";
            this.textBox232.Size = new System.Drawing.Size(31, 20);
            this.textBox232.TabIndex = 390;
            // 
            // textBox231
            // 
            this.textBox231.Location = new System.Drawing.Point(1137, 451);
            this.textBox231.Name = "textBox231";
            this.textBox231.Size = new System.Drawing.Size(31, 20);
            this.textBox231.TabIndex = 391;
            // 
            // textBox230
            // 
            this.textBox230.Location = new System.Drawing.Point(1137, 470);
            this.textBox230.Name = "textBox230";
            this.textBox230.Size = new System.Drawing.Size(31, 20);
            this.textBox230.TabIndex = 392;
            // 
            // textBox229
            // 
            this.textBox229.Location = new System.Drawing.Point(1137, 490);
            this.textBox229.Name = "textBox229";
            this.textBox229.Size = new System.Drawing.Size(31, 20);
            this.textBox229.TabIndex = 393;
            // 
            // textBox228
            // 
            this.textBox228.Location = new System.Drawing.Point(1137, 509);
            this.textBox228.Name = "textBox228";
            this.textBox228.Size = new System.Drawing.Size(31, 20);
            this.textBox228.TabIndex = 394;
            // 
            // textBox227
            // 
            this.textBox227.Location = new System.Drawing.Point(1137, 529);
            this.textBox227.Name = "textBox227";
            this.textBox227.Size = new System.Drawing.Size(31, 20);
            this.textBox227.TabIndex = 395;
            // 
            // textBox226
            // 
            this.textBox226.Location = new System.Drawing.Point(1137, 548);
            this.textBox226.Name = "textBox226";
            this.textBox226.Size = new System.Drawing.Size(31, 20);
            this.textBox226.TabIndex = 396;
            // 
            // textBox225
            // 
            this.textBox225.Location = new System.Drawing.Point(1137, 568);
            this.textBox225.Name = "textBox225";
            this.textBox225.Size = new System.Drawing.Size(31, 20);
            this.textBox225.TabIndex = 397;
            // 
            // textBox224
            // 
            this.textBox224.Location = new System.Drawing.Point(1137, 588);
            this.textBox224.Name = "textBox224";
            this.textBox224.Size = new System.Drawing.Size(31, 20);
            this.textBox224.TabIndex = 398;
            // 
            // textBox223
            // 
            this.textBox223.Location = new System.Drawing.Point(1137, 608);
            this.textBox223.Name = "textBox223";
            this.textBox223.Size = new System.Drawing.Size(31, 20);
            this.textBox223.TabIndex = 399;
            // 
            // textBox222
            // 
            this.textBox222.Location = new System.Drawing.Point(1137, 627);
            this.textBox222.Name = "textBox222";
            this.textBox222.Size = new System.Drawing.Size(31, 20);
            this.textBox222.TabIndex = 400;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(1120, 152);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(61, 13);
            this.label45.TabIndex = 401;
            this.label45.Text = "PREVISÃO";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(33, 488);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "CM11";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(68, 485);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(31, 20);
            this.textBox14.TabIndex = 49;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(33, 508);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "CM12";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(68, 505);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(31, 20);
            this.textBox13.TabIndex = 51;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(33, 536);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(27, 13);
            this.label43.TabIndex = 52;
            this.label43.Text = "GyX";
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(68, 533);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(31, 20);
            this.textBox36.TabIndex = 53;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(33, 556);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(27, 13);
            this.label42.TabIndex = 54;
            this.label42.Text = "GyY";
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(68, 553);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(31, 20);
            this.textBox35.TabIndex = 55;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(33, 575);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(27, 13);
            this.label41.TabIndex = 56;
            this.label41.Text = "GyZ";
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(68, 572);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(31, 20);
            this.textBox34.TabIndex = 57;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(33, 595);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(27, 13);
            this.label40.TabIndex = 58;
            this.label40.Text = "AcX";
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(68, 592);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(31, 20);
            this.textBox33.TabIndex = 59;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(33, 614);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(27, 13);
            this.label39.TabIndex = 60;
            this.label39.Text = "AcY";
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(68, 611);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(31, 20);
            this.textBox32.TabIndex = 61;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(33, 634);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(27, 13);
            this.label38.TabIndex = 62;
            this.label38.Text = "AcZ";
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(68, 631);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(31, 20);
            this.textBox31.TabIndex = 63;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(33, 653);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(28, 13);
            this.label37.TabIndex = 64;
            this.label37.Text = "Tmp";
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(68, 650);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(31, 20);
            this.textBox30.TabIndex = 65;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(33, 673);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(37, 13);
            this.label36.TabIndex = 66;
            this.label36.Text = "HCSR";
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(68, 670);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(31, 20);
            this.textBox29.TabIndex = 67;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(33, 693);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(14, 13);
            this.label35.TabIndex = 68;
            this.label35.Text = "X";
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(68, 690);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(31, 20);
            this.textBox28.TabIndex = 69;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(33, 713);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(14, 13);
            this.label34.TabIndex = 70;
            this.label34.Text = "Y";
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(68, 710);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(31, 20);
            this.textBox27.TabIndex = 71;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(33, 732);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(14, 13);
            this.label33.TabIndex = 72;
            this.label33.Text = "Z";
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(68, 729);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(31, 20);
            this.textBox26.TabIndex = 73;
            // 
            // textBox48
            // 
            this.textBox48.Location = new System.Drawing.Point(271, 481);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(31, 20);
            this.textBox48.TabIndex = 96;
            // 
            // textBox47
            // 
            this.textBox47.Location = new System.Drawing.Point(271, 501);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(31, 20);
            this.textBox47.TabIndex = 97;
            // 
            // textBox46
            // 
            this.textBox46.Location = new System.Drawing.Point(271, 529);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(31, 20);
            this.textBox46.TabIndex = 98;
            // 
            // textBox45
            // 
            this.textBox45.Location = new System.Drawing.Point(271, 549);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(31, 20);
            this.textBox45.TabIndex = 99;
            // 
            // textBox44
            // 
            this.textBox44.Location = new System.Drawing.Point(271, 568);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(31, 20);
            this.textBox44.TabIndex = 100;
            // 
            // textBox43
            // 
            this.textBox43.Location = new System.Drawing.Point(271, 588);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(31, 20);
            this.textBox43.TabIndex = 101;
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(271, 607);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(31, 20);
            this.textBox42.TabIndex = 102;
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(271, 627);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(31, 20);
            this.textBox41.TabIndex = 103;
            // 
            // textBox40
            // 
            this.textBox40.Location = new System.Drawing.Point(271, 646);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(31, 20);
            this.textBox40.TabIndex = 104;
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(271, 666);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(31, 20);
            this.textBox39.TabIndex = 105;
            // 
            // textBox38
            // 
            this.textBox38.Location = new System.Drawing.Point(271, 686);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(31, 20);
            this.textBox38.TabIndex = 106;
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(271, 706);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(31, 20);
            this.textBox37.TabIndex = 107;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(271, 725);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(31, 20);
            this.textBox25.TabIndex = 108;
            // 
            // textBox83
            // 
            this.textBox83.Location = new System.Drawing.Point(472, 481);
            this.textBox83.Name = "textBox83";
            this.textBox83.Size = new System.Drawing.Size(31, 20);
            this.textBox83.TabIndex = 132;
            // 
            // textBox82
            // 
            this.textBox82.Location = new System.Drawing.Point(472, 501);
            this.textBox82.Name = "textBox82";
            this.textBox82.Size = new System.Drawing.Size(31, 20);
            this.textBox82.TabIndex = 133;
            // 
            // textBox81
            // 
            this.textBox81.Location = new System.Drawing.Point(472, 529);
            this.textBox81.Name = "textBox81";
            this.textBox81.Size = new System.Drawing.Size(31, 20);
            this.textBox81.TabIndex = 134;
            // 
            // textBox80
            // 
            this.textBox80.Location = new System.Drawing.Point(472, 549);
            this.textBox80.Name = "textBox80";
            this.textBox80.Size = new System.Drawing.Size(31, 20);
            this.textBox80.TabIndex = 135;
            // 
            // textBox79
            // 
            this.textBox79.Location = new System.Drawing.Point(472, 568);
            this.textBox79.Name = "textBox79";
            this.textBox79.Size = new System.Drawing.Size(31, 20);
            this.textBox79.TabIndex = 136;
            // 
            // textBox78
            // 
            this.textBox78.Location = new System.Drawing.Point(472, 588);
            this.textBox78.Name = "textBox78";
            this.textBox78.Size = new System.Drawing.Size(31, 20);
            this.textBox78.TabIndex = 137;
            // 
            // textBox77
            // 
            this.textBox77.Location = new System.Drawing.Point(472, 607);
            this.textBox77.Name = "textBox77";
            this.textBox77.Size = new System.Drawing.Size(31, 20);
            this.textBox77.TabIndex = 138;
            // 
            // textBox76
            // 
            this.textBox76.Location = new System.Drawing.Point(472, 627);
            this.textBox76.Name = "textBox76";
            this.textBox76.Size = new System.Drawing.Size(31, 20);
            this.textBox76.TabIndex = 139;
            // 
            // textBox75
            // 
            this.textBox75.Location = new System.Drawing.Point(472, 646);
            this.textBox75.Name = "textBox75";
            this.textBox75.Size = new System.Drawing.Size(31, 20);
            this.textBox75.TabIndex = 140;
            // 
            // textBox74
            // 
            this.textBox74.Location = new System.Drawing.Point(472, 666);
            this.textBox74.Name = "textBox74";
            this.textBox74.Size = new System.Drawing.Size(31, 20);
            this.textBox74.TabIndex = 141;
            // 
            // textBox73
            // 
            this.textBox73.Location = new System.Drawing.Point(472, 686);
            this.textBox73.Name = "textBox73";
            this.textBox73.Size = new System.Drawing.Size(31, 20);
            this.textBox73.TabIndex = 142;
            // 
            // textBox72
            // 
            this.textBox72.Location = new System.Drawing.Point(472, 706);
            this.textBox72.Name = "textBox72";
            this.textBox72.Size = new System.Drawing.Size(31, 20);
            this.textBox72.TabIndex = 143;
            // 
            // textBox71
            // 
            this.textBox71.Location = new System.Drawing.Point(472, 725);
            this.textBox71.Name = "textBox71";
            this.textBox71.Size = new System.Drawing.Size(31, 20);
            this.textBox71.TabIndex = 144;
            // 
            // textBox118
            // 
            this.textBox118.Location = new System.Drawing.Point(597, 481);
            this.textBox118.Name = "textBox118";
            this.textBox118.Size = new System.Drawing.Size(31, 20);
            this.textBox118.TabIndex = 272;
            // 
            // textBox117
            // 
            this.textBox117.Location = new System.Drawing.Point(597, 501);
            this.textBox117.Name = "textBox117";
            this.textBox117.Size = new System.Drawing.Size(31, 20);
            this.textBox117.TabIndex = 273;
            // 
            // textBox116
            // 
            this.textBox116.Location = new System.Drawing.Point(597, 529);
            this.textBox116.Name = "textBox116";
            this.textBox116.Size = new System.Drawing.Size(31, 20);
            this.textBox116.TabIndex = 274;
            // 
            // textBox115
            // 
            this.textBox115.Location = new System.Drawing.Point(597, 549);
            this.textBox115.Name = "textBox115";
            this.textBox115.Size = new System.Drawing.Size(31, 20);
            this.textBox115.TabIndex = 275;
            // 
            // textBox114
            // 
            this.textBox114.Location = new System.Drawing.Point(597, 568);
            this.textBox114.Name = "textBox114";
            this.textBox114.Size = new System.Drawing.Size(31, 20);
            this.textBox114.TabIndex = 276;
            // 
            // textBox113
            // 
            this.textBox113.Location = new System.Drawing.Point(597, 588);
            this.textBox113.Name = "textBox113";
            this.textBox113.Size = new System.Drawing.Size(31, 20);
            this.textBox113.TabIndex = 277;
            // 
            // textBox112
            // 
            this.textBox112.Location = new System.Drawing.Point(597, 607);
            this.textBox112.Name = "textBox112";
            this.textBox112.Size = new System.Drawing.Size(31, 20);
            this.textBox112.TabIndex = 278;
            // 
            // textBox111
            // 
            this.textBox111.Location = new System.Drawing.Point(597, 627);
            this.textBox111.Name = "textBox111";
            this.textBox111.Size = new System.Drawing.Size(31, 20);
            this.textBox111.TabIndex = 279;
            // 
            // textBox110
            // 
            this.textBox110.Location = new System.Drawing.Point(597, 646);
            this.textBox110.Name = "textBox110";
            this.textBox110.Size = new System.Drawing.Size(31, 20);
            this.textBox110.TabIndex = 280;
            // 
            // textBox109
            // 
            this.textBox109.Location = new System.Drawing.Point(597, 666);
            this.textBox109.Name = "textBox109";
            this.textBox109.Size = new System.Drawing.Size(31, 20);
            this.textBox109.TabIndex = 281;
            // 
            // textBox108
            // 
            this.textBox108.Location = new System.Drawing.Point(597, 686);
            this.textBox108.Name = "textBox108";
            this.textBox108.Size = new System.Drawing.Size(31, 20);
            this.textBox108.TabIndex = 282;
            // 
            // textBox107
            // 
            this.textBox107.Location = new System.Drawing.Point(597, 706);
            this.textBox107.Name = "textBox107";
            this.textBox107.Size = new System.Drawing.Size(31, 20);
            this.textBox107.TabIndex = 283;
            // 
            // textBox106
            // 
            this.textBox106.Location = new System.Drawing.Point(597, 725);
            this.textBox106.Name = "textBox106";
            this.textBox106.Size = new System.Drawing.Size(31, 20);
            this.textBox106.TabIndex = 284;
            // 
            // textBox153
            // 
            this.textBox153.Location = new System.Drawing.Point(713, 481);
            this.textBox153.Name = "textBox153";
            this.textBox153.Size = new System.Drawing.Size(31, 20);
            this.textBox153.TabIndex = 307;
            // 
            // textBox152
            // 
            this.textBox152.Location = new System.Drawing.Point(713, 501);
            this.textBox152.Name = "textBox152";
            this.textBox152.Size = new System.Drawing.Size(31, 20);
            this.textBox152.TabIndex = 308;
            // 
            // textBox151
            // 
            this.textBox151.Location = new System.Drawing.Point(713, 529);
            this.textBox151.Name = "textBox151";
            this.textBox151.Size = new System.Drawing.Size(31, 20);
            this.textBox151.TabIndex = 309;
            // 
            // textBox150
            // 
            this.textBox150.Location = new System.Drawing.Point(713, 549);
            this.textBox150.Name = "textBox150";
            this.textBox150.Size = new System.Drawing.Size(31, 20);
            this.textBox150.TabIndex = 310;
            // 
            // textBox149
            // 
            this.textBox149.Location = new System.Drawing.Point(713, 568);
            this.textBox149.Name = "textBox149";
            this.textBox149.Size = new System.Drawing.Size(31, 20);
            this.textBox149.TabIndex = 311;
            // 
            // textBox148
            // 
            this.textBox148.Location = new System.Drawing.Point(713, 588);
            this.textBox148.Name = "textBox148";
            this.textBox148.Size = new System.Drawing.Size(31, 20);
            this.textBox148.TabIndex = 312;
            // 
            // textBox147
            // 
            this.textBox147.Location = new System.Drawing.Point(713, 607);
            this.textBox147.Name = "textBox147";
            this.textBox147.Size = new System.Drawing.Size(31, 20);
            this.textBox147.TabIndex = 313;
            // 
            // textBox146
            // 
            this.textBox146.Location = new System.Drawing.Point(713, 627);
            this.textBox146.Name = "textBox146";
            this.textBox146.Size = new System.Drawing.Size(31, 20);
            this.textBox146.TabIndex = 314;
            // 
            // textBox145
            // 
            this.textBox145.Location = new System.Drawing.Point(713, 646);
            this.textBox145.Name = "textBox145";
            this.textBox145.Size = new System.Drawing.Size(31, 20);
            this.textBox145.TabIndex = 315;
            // 
            // textBox144
            // 
            this.textBox144.Location = new System.Drawing.Point(713, 666);
            this.textBox144.Name = "textBox144";
            this.textBox144.Size = new System.Drawing.Size(31, 20);
            this.textBox144.TabIndex = 316;
            // 
            // textBox143
            // 
            this.textBox143.Location = new System.Drawing.Point(713, 686);
            this.textBox143.Name = "textBox143";
            this.textBox143.Size = new System.Drawing.Size(31, 20);
            this.textBox143.TabIndex = 317;
            // 
            // textBox142
            // 
            this.textBox142.Location = new System.Drawing.Point(713, 706);
            this.textBox142.Name = "textBox142";
            this.textBox142.Size = new System.Drawing.Size(31, 20);
            this.textBox142.TabIndex = 318;
            // 
            // textBox141
            // 
            this.textBox141.Location = new System.Drawing.Point(713, 725);
            this.textBox141.Name = "textBox141";
            this.textBox141.Size = new System.Drawing.Size(31, 20);
            this.textBox141.TabIndex = 319;
            // 
            // textBox188
            // 
            this.textBox188.Location = new System.Drawing.Point(801, 481);
            this.textBox188.Name = "textBox188";
            this.textBox188.Size = new System.Drawing.Size(31, 20);
            this.textBox188.TabIndex = 424;
            // 
            // textBox187
            // 
            this.textBox187.Location = new System.Drawing.Point(801, 501);
            this.textBox187.Name = "textBox187";
            this.textBox187.Size = new System.Drawing.Size(31, 20);
            this.textBox187.TabIndex = 425;
            // 
            // textBox186
            // 
            this.textBox186.Location = new System.Drawing.Point(801, 529);
            this.textBox186.Name = "textBox186";
            this.textBox186.Size = new System.Drawing.Size(31, 20);
            this.textBox186.TabIndex = 426;
            // 
            // textBox185
            // 
            this.textBox185.Location = new System.Drawing.Point(801, 549);
            this.textBox185.Name = "textBox185";
            this.textBox185.Size = new System.Drawing.Size(31, 20);
            this.textBox185.TabIndex = 427;
            // 
            // textBox184
            // 
            this.textBox184.Location = new System.Drawing.Point(801, 568);
            this.textBox184.Name = "textBox184";
            this.textBox184.Size = new System.Drawing.Size(31, 20);
            this.textBox184.TabIndex = 428;
            // 
            // textBox183
            // 
            this.textBox183.Location = new System.Drawing.Point(801, 588);
            this.textBox183.Name = "textBox183";
            this.textBox183.Size = new System.Drawing.Size(31, 20);
            this.textBox183.TabIndex = 429;
            // 
            // textBox182
            // 
            this.textBox182.Location = new System.Drawing.Point(801, 607);
            this.textBox182.Name = "textBox182";
            this.textBox182.Size = new System.Drawing.Size(31, 20);
            this.textBox182.TabIndex = 430;
            // 
            // textBox181
            // 
            this.textBox181.Location = new System.Drawing.Point(801, 627);
            this.textBox181.Name = "textBox181";
            this.textBox181.Size = new System.Drawing.Size(31, 20);
            this.textBox181.TabIndex = 431;
            // 
            // textBox180
            // 
            this.textBox180.Location = new System.Drawing.Point(801, 646);
            this.textBox180.Name = "textBox180";
            this.textBox180.Size = new System.Drawing.Size(31, 20);
            this.textBox180.TabIndex = 432;
            // 
            // textBox179
            // 
            this.textBox179.Location = new System.Drawing.Point(801, 666);
            this.textBox179.Name = "textBox179";
            this.textBox179.Size = new System.Drawing.Size(31, 20);
            this.textBox179.TabIndex = 433;
            // 
            // textBox178
            // 
            this.textBox178.Location = new System.Drawing.Point(801, 686);
            this.textBox178.Name = "textBox178";
            this.textBox178.Size = new System.Drawing.Size(31, 20);
            this.textBox178.TabIndex = 434;
            // 
            // textBox177
            // 
            this.textBox177.Location = new System.Drawing.Point(801, 706);
            this.textBox177.Name = "textBox177";
            this.textBox177.Size = new System.Drawing.Size(31, 20);
            this.textBox177.TabIndex = 435;
            // 
            // textBox176
            // 
            this.textBox176.Location = new System.Drawing.Point(801, 725);
            this.textBox176.Name = "textBox176";
            this.textBox176.Size = new System.Drawing.Size(31, 20);
            this.textBox176.TabIndex = 436;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "DADOS";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "EM1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "EM2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(31, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "EM3";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(68, 86);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(31, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "EM4";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(31, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "EM5";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(68, 125);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(31, 20);
            this.textBox8.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "EM6";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(68, 145);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(31, 20);
            this.textBox7.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "EM7";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(68, 164);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(31, 20);
            this.textBox6.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "EM8";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(68, 184);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(31, 20);
            this.textBox5.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 207);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "EM9";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(68, 204);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(31, 20);
            this.textBox12.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 227);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "EM10";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(68, 224);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(31, 20);
            this.textBox11.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 246);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "EM11";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(68, 243);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(31, 20);
            this.textBox10.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "EM12";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(68, 263);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(31, 20);
            this.textBox9.TabIndex = 27;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(33, 292);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 13);
            this.label31.TabIndex = 28;
            this.label31.Text = "CM1";
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(68, 289);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(31, 20);
            this.textBox24.TabIndex = 29;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(33, 312);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 13);
            this.label30.TabIndex = 30;
            this.label30.Text = "CM2";
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(68, 309);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(31, 20);
            this.textBox23.TabIndex = 31;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(33, 331);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 13);
            this.label29.TabIndex = 32;
            this.label29.Text = "CM3";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(68, 328);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(31, 20);
            this.textBox22.TabIndex = 33;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(33, 351);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 13);
            this.label28.TabIndex = 34;
            this.label28.Text = "CM4";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(68, 348);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(31, 20);
            this.textBox21.TabIndex = 35;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(33, 370);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 13);
            this.label27.TabIndex = 36;
            this.label27.Text = "CM5";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(68, 367);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(31, 20);
            this.textBox20.TabIndex = 37;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(33, 390);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 13);
            this.label26.TabIndex = 38;
            this.label26.Text = "CM6";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(68, 387);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(31, 20);
            this.textBox19.TabIndex = 39;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(33, 409);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 13);
            this.label25.TabIndex = 40;
            this.label25.Text = "CM7";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(68, 406);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(31, 20);
            this.textBox18.TabIndex = 41;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(33, 429);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 13);
            this.label24.TabIndex = 42;
            this.label24.Text = "CM8";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(68, 426);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(31, 20);
            this.textBox17.TabIndex = 43;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(33, 449);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 13);
            this.label23.TabIndex = 44;
            this.label23.Text = "CM9";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(68, 446);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(31, 20);
            this.textBox16.TabIndex = 45;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(33, 469);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 46;
            this.label22.Text = "CM10";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(68, 466);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(31, 20);
            this.textBox15.TabIndex = 47;
            // 
            // textBox70
            // 
            this.textBox70.Location = new System.Drawing.Point(271, 43);
            this.textBox70.Name = "textBox70";
            this.textBox70.Size = new System.Drawing.Size(31, 20);
            this.textBox70.TabIndex = 74;
            // 
            // textBox69
            // 
            this.textBox69.Location = new System.Drawing.Point(271, 63);
            this.textBox69.Name = "textBox69";
            this.textBox69.Size = new System.Drawing.Size(31, 20);
            this.textBox69.TabIndex = 75;
            // 
            // textBox68
            // 
            this.textBox68.Location = new System.Drawing.Point(271, 82);
            this.textBox68.Name = "textBox68";
            this.textBox68.Size = new System.Drawing.Size(31, 20);
            this.textBox68.TabIndex = 76;
            // 
            // textBox67
            // 
            this.textBox67.Location = new System.Drawing.Point(271, 102);
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(31, 20);
            this.textBox67.TabIndex = 77;
            // 
            // textBox66
            // 
            this.textBox66.Location = new System.Drawing.Point(271, 121);
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(31, 20);
            this.textBox66.TabIndex = 78;
            // 
            // textBox65
            // 
            this.textBox65.Location = new System.Drawing.Point(271, 141);
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(31, 20);
            this.textBox65.TabIndex = 79;
            // 
            // textBox64
            // 
            this.textBox64.Location = new System.Drawing.Point(271, 160);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(31, 20);
            this.textBox64.TabIndex = 80;
            // 
            // textBox63
            // 
            this.textBox63.Location = new System.Drawing.Point(271, 180);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(31, 20);
            this.textBox63.TabIndex = 81;
            // 
            // textBox62
            // 
            this.textBox62.Location = new System.Drawing.Point(271, 200);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(31, 20);
            this.textBox62.TabIndex = 82;
            // 
            // textBox61
            // 
            this.textBox61.Location = new System.Drawing.Point(271, 220);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(31, 20);
            this.textBox61.TabIndex = 83;
            // 
            // textBox60
            // 
            this.textBox60.Location = new System.Drawing.Point(271, 239);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(31, 20);
            this.textBox60.TabIndex = 84;
            // 
            // textBox59
            // 
            this.textBox59.Location = new System.Drawing.Point(271, 259);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(31, 20);
            this.textBox59.TabIndex = 85;
            // 
            // textBox58
            // 
            this.textBox58.Location = new System.Drawing.Point(271, 285);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(31, 20);
            this.textBox58.TabIndex = 86;
            // 
            // textBox57
            // 
            this.textBox57.Location = new System.Drawing.Point(271, 305);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(31, 20);
            this.textBox57.TabIndex = 87;
            // 
            // textBox56
            // 
            this.textBox56.Location = new System.Drawing.Point(271, 324);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(31, 20);
            this.textBox56.TabIndex = 88;
            // 
            // textBox55
            // 
            this.textBox55.Location = new System.Drawing.Point(271, 344);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(31, 20);
            this.textBox55.TabIndex = 89;
            // 
            // textBox54
            // 
            this.textBox54.Location = new System.Drawing.Point(271, 363);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(31, 20);
            this.textBox54.TabIndex = 90;
            // 
            // textBox53
            // 
            this.textBox53.Location = new System.Drawing.Point(271, 383);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(31, 20);
            this.textBox53.TabIndex = 91;
            // 
            // textBox52
            // 
            this.textBox52.Location = new System.Drawing.Point(271, 402);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(31, 20);
            this.textBox52.TabIndex = 92;
            // 
            // textBox51
            // 
            this.textBox51.Location = new System.Drawing.Point(271, 422);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(31, 20);
            this.textBox51.TabIndex = 93;
            // 
            // textBox50
            // 
            this.textBox50.Location = new System.Drawing.Point(271, 442);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(31, 20);
            this.textBox50.TabIndex = 94;
            // 
            // textBox49
            // 
            this.textBox49.Location = new System.Drawing.Point(271, 462);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(31, 20);
            this.textBox49.TabIndex = 95;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(226, 17);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(125, 13);
            this.label32.TabIndex = 109;
            this.label32.Text = "CAMADA DE ENTRADA";
            this.label32.Click += new System.EventHandler(this.label32_Click);
            // 
            // textBox105
            // 
            this.textBox105.Location = new System.Drawing.Point(472, 43);
            this.textBox105.Name = "textBox105";
            this.textBox105.Size = new System.Drawing.Size(31, 20);
            this.textBox105.TabIndex = 110;
            // 
            // textBox104
            // 
            this.textBox104.Location = new System.Drawing.Point(472, 63);
            this.textBox104.Name = "textBox104";
            this.textBox104.Size = new System.Drawing.Size(31, 20);
            this.textBox104.TabIndex = 111;
            // 
            // textBox103
            // 
            this.textBox103.Location = new System.Drawing.Point(472, 82);
            this.textBox103.Name = "textBox103";
            this.textBox103.Size = new System.Drawing.Size(31, 20);
            this.textBox103.TabIndex = 112;
            // 
            // textBox102
            // 
            this.textBox102.Location = new System.Drawing.Point(472, 102);
            this.textBox102.Name = "textBox102";
            this.textBox102.Size = new System.Drawing.Size(31, 20);
            this.textBox102.TabIndex = 113;
            // 
            // textBox101
            // 
            this.textBox101.Location = new System.Drawing.Point(472, 121);
            this.textBox101.Name = "textBox101";
            this.textBox101.Size = new System.Drawing.Size(31, 20);
            this.textBox101.TabIndex = 114;
            // 
            // textBox100
            // 
            this.textBox100.Location = new System.Drawing.Point(472, 141);
            this.textBox100.Name = "textBox100";
            this.textBox100.Size = new System.Drawing.Size(31, 20);
            this.textBox100.TabIndex = 115;
            // 
            // textBox99
            // 
            this.textBox99.Location = new System.Drawing.Point(472, 160);
            this.textBox99.Name = "textBox99";
            this.textBox99.Size = new System.Drawing.Size(31, 20);
            this.textBox99.TabIndex = 116;
            // 
            // textBox98
            // 
            this.textBox98.Location = new System.Drawing.Point(472, 180);
            this.textBox98.Name = "textBox98";
            this.textBox98.Size = new System.Drawing.Size(31, 20);
            this.textBox98.TabIndex = 117;
            // 
            // textBox97
            // 
            this.textBox97.Location = new System.Drawing.Point(472, 200);
            this.textBox97.Name = "textBox97";
            this.textBox97.Size = new System.Drawing.Size(31, 20);
            this.textBox97.TabIndex = 118;
            // 
            // textBox96
            // 
            this.textBox96.Location = new System.Drawing.Point(472, 220);
            this.textBox96.Name = "textBox96";
            this.textBox96.Size = new System.Drawing.Size(31, 20);
            this.textBox96.TabIndex = 119;
            // 
            // textBox95
            // 
            this.textBox95.Location = new System.Drawing.Point(472, 239);
            this.textBox95.Name = "textBox95";
            this.textBox95.Size = new System.Drawing.Size(31, 20);
            this.textBox95.TabIndex = 120;
            // 
            // textBox94
            // 
            this.textBox94.Location = new System.Drawing.Point(472, 259);
            this.textBox94.Name = "textBox94";
            this.textBox94.Size = new System.Drawing.Size(31, 20);
            this.textBox94.TabIndex = 121;
            // 
            // textBox93
            // 
            this.textBox93.Location = new System.Drawing.Point(472, 285);
            this.textBox93.Name = "textBox93";
            this.textBox93.Size = new System.Drawing.Size(31, 20);
            this.textBox93.TabIndex = 122;
            // 
            // textBox92
            // 
            this.textBox92.Location = new System.Drawing.Point(472, 305);
            this.textBox92.Name = "textBox92";
            this.textBox92.Size = new System.Drawing.Size(31, 20);
            this.textBox92.TabIndex = 123;
            // 
            // textBox91
            // 
            this.textBox91.Location = new System.Drawing.Point(472, 324);
            this.textBox91.Name = "textBox91";
            this.textBox91.Size = new System.Drawing.Size(31, 20);
            this.textBox91.TabIndex = 124;
            // 
            // textBox90
            // 
            this.textBox90.Location = new System.Drawing.Point(472, 344);
            this.textBox90.Name = "textBox90";
            this.textBox90.Size = new System.Drawing.Size(31, 20);
            this.textBox90.TabIndex = 125;
            // 
            // textBox89
            // 
            this.textBox89.Location = new System.Drawing.Point(472, 363);
            this.textBox89.Name = "textBox89";
            this.textBox89.Size = new System.Drawing.Size(31, 20);
            this.textBox89.TabIndex = 126;
            // 
            // textBox88
            // 
            this.textBox88.Location = new System.Drawing.Point(472, 383);
            this.textBox88.Name = "textBox88";
            this.textBox88.Size = new System.Drawing.Size(31, 20);
            this.textBox88.TabIndex = 127;
            // 
            // textBox87
            // 
            this.textBox87.Location = new System.Drawing.Point(472, 402);
            this.textBox87.Name = "textBox87";
            this.textBox87.Size = new System.Drawing.Size(31, 20);
            this.textBox87.TabIndex = 128;
            // 
            // textBox86
            // 
            this.textBox86.Location = new System.Drawing.Point(472, 422);
            this.textBox86.Name = "textBox86";
            this.textBox86.Size = new System.Drawing.Size(31, 20);
            this.textBox86.TabIndex = 129;
            // 
            // textBox85
            // 
            this.textBox85.Location = new System.Drawing.Point(472, 442);
            this.textBox85.Name = "textBox85";
            this.textBox85.Size = new System.Drawing.Size(31, 20);
            this.textBox85.TabIndex = 130;
            // 
            // textBox84
            // 
            this.textBox84.Location = new System.Drawing.Point(472, 462);
            this.textBox84.Name = "textBox84";
            this.textBox84.Size = new System.Drawing.Size(31, 20);
            this.textBox84.TabIndex = 131;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(594, 3);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(160, 13);
            this.label44.TabIndex = 249;
            this.label44.Text = "CAMADAS INTERMEDIÁRIAS I";
            // 
            // textBox140
            // 
            this.textBox140.Location = new System.Drawing.Point(597, 43);
            this.textBox140.Name = "textBox140";
            this.textBox140.Size = new System.Drawing.Size(31, 20);
            this.textBox140.TabIndex = 250;
            // 
            // textBox139
            // 
            this.textBox139.Location = new System.Drawing.Point(597, 63);
            this.textBox139.Name = "textBox139";
            this.textBox139.Size = new System.Drawing.Size(31, 20);
            this.textBox139.TabIndex = 251;
            // 
            // textBox138
            // 
            this.textBox138.Location = new System.Drawing.Point(597, 82);
            this.textBox138.Name = "textBox138";
            this.textBox138.Size = new System.Drawing.Size(31, 20);
            this.textBox138.TabIndex = 252;
            // 
            // textBox137
            // 
            this.textBox137.Location = new System.Drawing.Point(597, 102);
            this.textBox137.Name = "textBox137";
            this.textBox137.Size = new System.Drawing.Size(31, 20);
            this.textBox137.TabIndex = 253;
            // 
            // textBox136
            // 
            this.textBox136.Location = new System.Drawing.Point(597, 121);
            this.textBox136.Name = "textBox136";
            this.textBox136.Size = new System.Drawing.Size(31, 20);
            this.textBox136.TabIndex = 254;
            // 
            // textBox135
            // 
            this.textBox135.Location = new System.Drawing.Point(597, 141);
            this.textBox135.Name = "textBox135";
            this.textBox135.Size = new System.Drawing.Size(31, 20);
            this.textBox135.TabIndex = 255;
            // 
            // textBox134
            // 
            this.textBox134.Location = new System.Drawing.Point(597, 160);
            this.textBox134.Name = "textBox134";
            this.textBox134.Size = new System.Drawing.Size(31, 20);
            this.textBox134.TabIndex = 256;
            // 
            // textBox133
            // 
            this.textBox133.Location = new System.Drawing.Point(597, 180);
            this.textBox133.Name = "textBox133";
            this.textBox133.Size = new System.Drawing.Size(31, 20);
            this.textBox133.TabIndex = 257;
            // 
            // textBox132
            // 
            this.textBox132.Location = new System.Drawing.Point(597, 200);
            this.textBox132.Name = "textBox132";
            this.textBox132.Size = new System.Drawing.Size(31, 20);
            this.textBox132.TabIndex = 258;
            // 
            // textBox131
            // 
            this.textBox131.Location = new System.Drawing.Point(597, 220);
            this.textBox131.Name = "textBox131";
            this.textBox131.Size = new System.Drawing.Size(31, 20);
            this.textBox131.TabIndex = 259;
            // 
            // textBox130
            // 
            this.textBox130.Location = new System.Drawing.Point(597, 239);
            this.textBox130.Name = "textBox130";
            this.textBox130.Size = new System.Drawing.Size(31, 20);
            this.textBox130.TabIndex = 260;
            // 
            // textBox129
            // 
            this.textBox129.Location = new System.Drawing.Point(597, 259);
            this.textBox129.Name = "textBox129";
            this.textBox129.Size = new System.Drawing.Size(31, 20);
            this.textBox129.TabIndex = 261;
            // 
            // textBox128
            // 
            this.textBox128.Location = new System.Drawing.Point(597, 285);
            this.textBox128.Name = "textBox128";
            this.textBox128.Size = new System.Drawing.Size(31, 20);
            this.textBox128.TabIndex = 262;
            // 
            // textBox127
            // 
            this.textBox127.Location = new System.Drawing.Point(597, 305);
            this.textBox127.Name = "textBox127";
            this.textBox127.Size = new System.Drawing.Size(31, 20);
            this.textBox127.TabIndex = 263;
            // 
            // textBox126
            // 
            this.textBox126.Location = new System.Drawing.Point(597, 324);
            this.textBox126.Name = "textBox126";
            this.textBox126.Size = new System.Drawing.Size(31, 20);
            this.textBox126.TabIndex = 264;
            // 
            // textBox125
            // 
            this.textBox125.Location = new System.Drawing.Point(597, 344);
            this.textBox125.Name = "textBox125";
            this.textBox125.Size = new System.Drawing.Size(31, 20);
            this.textBox125.TabIndex = 265;
            // 
            // textBox124
            // 
            this.textBox124.Location = new System.Drawing.Point(597, 363);
            this.textBox124.Name = "textBox124";
            this.textBox124.Size = new System.Drawing.Size(31, 20);
            this.textBox124.TabIndex = 266;
            // 
            // textBox123
            // 
            this.textBox123.Location = new System.Drawing.Point(597, 383);
            this.textBox123.Name = "textBox123";
            this.textBox123.Size = new System.Drawing.Size(31, 20);
            this.textBox123.TabIndex = 267;
            // 
            // textBox122
            // 
            this.textBox122.Location = new System.Drawing.Point(597, 402);
            this.textBox122.Name = "textBox122";
            this.textBox122.Size = new System.Drawing.Size(31, 20);
            this.textBox122.TabIndex = 268;
            // 
            // textBox121
            // 
            this.textBox121.Location = new System.Drawing.Point(597, 422);
            this.textBox121.Name = "textBox121";
            this.textBox121.Size = new System.Drawing.Size(31, 20);
            this.textBox121.TabIndex = 269;
            // 
            // textBox120
            // 
            this.textBox120.Location = new System.Drawing.Point(597, 442);
            this.textBox120.Name = "textBox120";
            this.textBox120.Size = new System.Drawing.Size(31, 20);
            this.textBox120.TabIndex = 270;
            // 
            // textBox119
            // 
            this.textBox119.Location = new System.Drawing.Point(597, 462);
            this.textBox119.Name = "textBox119";
            this.textBox119.Size = new System.Drawing.Size(31, 20);
            this.textBox119.TabIndex = 271;
            // 
            // textBox175
            // 
            this.textBox175.Location = new System.Drawing.Point(713, 43);
            this.textBox175.Name = "textBox175";
            this.textBox175.Size = new System.Drawing.Size(31, 20);
            this.textBox175.TabIndex = 285;
            // 
            // textBox174
            // 
            this.textBox174.Location = new System.Drawing.Point(713, 63);
            this.textBox174.Name = "textBox174";
            this.textBox174.Size = new System.Drawing.Size(31, 20);
            this.textBox174.TabIndex = 286;
            // 
            // textBox173
            // 
            this.textBox173.Location = new System.Drawing.Point(713, 82);
            this.textBox173.Name = "textBox173";
            this.textBox173.Size = new System.Drawing.Size(31, 20);
            this.textBox173.TabIndex = 287;
            // 
            // textBox172
            // 
            this.textBox172.Location = new System.Drawing.Point(713, 102);
            this.textBox172.Name = "textBox172";
            this.textBox172.Size = new System.Drawing.Size(31, 20);
            this.textBox172.TabIndex = 288;
            // 
            // textBox171
            // 
            this.textBox171.Location = new System.Drawing.Point(713, 121);
            this.textBox171.Name = "textBox171";
            this.textBox171.Size = new System.Drawing.Size(31, 20);
            this.textBox171.TabIndex = 289;
            // 
            // textBox170
            // 
            this.textBox170.Location = new System.Drawing.Point(713, 141);
            this.textBox170.Name = "textBox170";
            this.textBox170.Size = new System.Drawing.Size(31, 20);
            this.textBox170.TabIndex = 290;
            // 
            // textBox169
            // 
            this.textBox169.Location = new System.Drawing.Point(713, 160);
            this.textBox169.Name = "textBox169";
            this.textBox169.Size = new System.Drawing.Size(31, 20);
            this.textBox169.TabIndex = 291;
            // 
            // textBox168
            // 
            this.textBox168.Location = new System.Drawing.Point(713, 180);
            this.textBox168.Name = "textBox168";
            this.textBox168.Size = new System.Drawing.Size(31, 20);
            this.textBox168.TabIndex = 292;
            // 
            // textBox167
            // 
            this.textBox167.Location = new System.Drawing.Point(713, 200);
            this.textBox167.Name = "textBox167";
            this.textBox167.Size = new System.Drawing.Size(31, 20);
            this.textBox167.TabIndex = 293;
            // 
            // textBox166
            // 
            this.textBox166.Location = new System.Drawing.Point(713, 220);
            this.textBox166.Name = "textBox166";
            this.textBox166.Size = new System.Drawing.Size(31, 20);
            this.textBox166.TabIndex = 294;
            // 
            // textBox165
            // 
            this.textBox165.Location = new System.Drawing.Point(713, 239);
            this.textBox165.Name = "textBox165";
            this.textBox165.Size = new System.Drawing.Size(31, 20);
            this.textBox165.TabIndex = 295;
            // 
            // textBox164
            // 
            this.textBox164.Location = new System.Drawing.Point(713, 259);
            this.textBox164.Name = "textBox164";
            this.textBox164.Size = new System.Drawing.Size(31, 20);
            this.textBox164.TabIndex = 296;
            // 
            // textBox163
            // 
            this.textBox163.Location = new System.Drawing.Point(713, 285);
            this.textBox163.Name = "textBox163";
            this.textBox163.Size = new System.Drawing.Size(31, 20);
            this.textBox163.TabIndex = 297;
            // 
            // textBox162
            // 
            this.textBox162.Location = new System.Drawing.Point(713, 305);
            this.textBox162.Name = "textBox162";
            this.textBox162.Size = new System.Drawing.Size(31, 20);
            this.textBox162.TabIndex = 298;
            // 
            // textBox161
            // 
            this.textBox161.Location = new System.Drawing.Point(713, 324);
            this.textBox161.Name = "textBox161";
            this.textBox161.Size = new System.Drawing.Size(31, 20);
            this.textBox161.TabIndex = 299;
            // 
            // textBox160
            // 
            this.textBox160.Location = new System.Drawing.Point(713, 344);
            this.textBox160.Name = "textBox160";
            this.textBox160.Size = new System.Drawing.Size(31, 20);
            this.textBox160.TabIndex = 300;
            // 
            // textBox159
            // 
            this.textBox159.Location = new System.Drawing.Point(713, 363);
            this.textBox159.Name = "textBox159";
            this.textBox159.Size = new System.Drawing.Size(31, 20);
            this.textBox159.TabIndex = 301;
            // 
            // textBox158
            // 
            this.textBox158.Location = new System.Drawing.Point(713, 383);
            this.textBox158.Name = "textBox158";
            this.textBox158.Size = new System.Drawing.Size(31, 20);
            this.textBox158.TabIndex = 302;
            // 
            // textBox157
            // 
            this.textBox157.Location = new System.Drawing.Point(713, 402);
            this.textBox157.Name = "textBox157";
            this.textBox157.Size = new System.Drawing.Size(31, 20);
            this.textBox157.TabIndex = 303;
            // 
            // textBox156
            // 
            this.textBox156.Location = new System.Drawing.Point(713, 422);
            this.textBox156.Name = "textBox156";
            this.textBox156.Size = new System.Drawing.Size(31, 20);
            this.textBox156.TabIndex = 304;
            // 
            // textBox155
            // 
            this.textBox155.Location = new System.Drawing.Point(713, 442);
            this.textBox155.Name = "textBox155";
            this.textBox155.Size = new System.Drawing.Size(31, 20);
            this.textBox155.TabIndex = 305;
            // 
            // textBox154
            // 
            this.textBox154.Location = new System.Drawing.Point(713, 462);
            this.textBox154.Name = "textBox154";
            this.textBox154.Size = new System.Drawing.Size(31, 20);
            this.textBox154.TabIndex = 306;
            // 
            // textBox210
            // 
            this.textBox210.Location = new System.Drawing.Point(801, 43);
            this.textBox210.Name = "textBox210";
            this.textBox210.Size = new System.Drawing.Size(31, 20);
            this.textBox210.TabIndex = 402;
            // 
            // textBox209
            // 
            this.textBox209.Location = new System.Drawing.Point(801, 63);
            this.textBox209.Name = "textBox209";
            this.textBox209.Size = new System.Drawing.Size(31, 20);
            this.textBox209.TabIndex = 403;
            // 
            // textBox208
            // 
            this.textBox208.Location = new System.Drawing.Point(801, 82);
            this.textBox208.Name = "textBox208";
            this.textBox208.Size = new System.Drawing.Size(31, 20);
            this.textBox208.TabIndex = 404;
            // 
            // textBox207
            // 
            this.textBox207.Location = new System.Drawing.Point(801, 102);
            this.textBox207.Name = "textBox207";
            this.textBox207.Size = new System.Drawing.Size(31, 20);
            this.textBox207.TabIndex = 405;
            // 
            // textBox206
            // 
            this.textBox206.Location = new System.Drawing.Point(801, 121);
            this.textBox206.Name = "textBox206";
            this.textBox206.Size = new System.Drawing.Size(31, 20);
            this.textBox206.TabIndex = 406;
            // 
            // textBox205
            // 
            this.textBox205.Location = new System.Drawing.Point(801, 141);
            this.textBox205.Name = "textBox205";
            this.textBox205.Size = new System.Drawing.Size(31, 20);
            this.textBox205.TabIndex = 407;
            // 
            // textBox204
            // 
            this.textBox204.Location = new System.Drawing.Point(801, 160);
            this.textBox204.Name = "textBox204";
            this.textBox204.Size = new System.Drawing.Size(31, 20);
            this.textBox204.TabIndex = 408;
            // 
            // textBox203
            // 
            this.textBox203.Location = new System.Drawing.Point(801, 180);
            this.textBox203.Name = "textBox203";
            this.textBox203.Size = new System.Drawing.Size(31, 20);
            this.textBox203.TabIndex = 409;
            // 
            // textBox202
            // 
            this.textBox202.Location = new System.Drawing.Point(801, 200);
            this.textBox202.Name = "textBox202";
            this.textBox202.Size = new System.Drawing.Size(31, 20);
            this.textBox202.TabIndex = 410;
            // 
            // textBox201
            // 
            this.textBox201.Location = new System.Drawing.Point(801, 220);
            this.textBox201.Name = "textBox201";
            this.textBox201.Size = new System.Drawing.Size(31, 20);
            this.textBox201.TabIndex = 411;
            // 
            // textBox200
            // 
            this.textBox200.Location = new System.Drawing.Point(801, 239);
            this.textBox200.Name = "textBox200";
            this.textBox200.Size = new System.Drawing.Size(31, 20);
            this.textBox200.TabIndex = 412;
            // 
            // textBox199
            // 
            this.textBox199.Location = new System.Drawing.Point(801, 259);
            this.textBox199.Name = "textBox199";
            this.textBox199.Size = new System.Drawing.Size(31, 20);
            this.textBox199.TabIndex = 413;
            // 
            // textBox198
            // 
            this.textBox198.Location = new System.Drawing.Point(801, 285);
            this.textBox198.Name = "textBox198";
            this.textBox198.Size = new System.Drawing.Size(31, 20);
            this.textBox198.TabIndex = 414;
            // 
            // textBox197
            // 
            this.textBox197.Location = new System.Drawing.Point(801, 305);
            this.textBox197.Name = "textBox197";
            this.textBox197.Size = new System.Drawing.Size(31, 20);
            this.textBox197.TabIndex = 415;
            // 
            // textBox196
            // 
            this.textBox196.Location = new System.Drawing.Point(801, 324);
            this.textBox196.Name = "textBox196";
            this.textBox196.Size = new System.Drawing.Size(31, 20);
            this.textBox196.TabIndex = 416;
            // 
            // textBox195
            // 
            this.textBox195.Location = new System.Drawing.Point(801, 344);
            this.textBox195.Name = "textBox195";
            this.textBox195.Size = new System.Drawing.Size(31, 20);
            this.textBox195.TabIndex = 417;
            // 
            // textBox194
            // 
            this.textBox194.Location = new System.Drawing.Point(801, 363);
            this.textBox194.Name = "textBox194";
            this.textBox194.Size = new System.Drawing.Size(31, 20);
            this.textBox194.TabIndex = 418;
            // 
            // textBox193
            // 
            this.textBox193.Location = new System.Drawing.Point(801, 383);
            this.textBox193.Name = "textBox193";
            this.textBox193.Size = new System.Drawing.Size(31, 20);
            this.textBox193.TabIndex = 419;
            // 
            // textBox192
            // 
            this.textBox192.Location = new System.Drawing.Point(801, 402);
            this.textBox192.Name = "textBox192";
            this.textBox192.Size = new System.Drawing.Size(31, 20);
            this.textBox192.TabIndex = 420;
            // 
            // textBox191
            // 
            this.textBox191.Location = new System.Drawing.Point(801, 422);
            this.textBox191.Name = "textBox191";
            this.textBox191.Size = new System.Drawing.Size(31, 20);
            this.textBox191.TabIndex = 421;
            // 
            // textBox190
            // 
            this.textBox190.Location = new System.Drawing.Point(801, 442);
            this.textBox190.Name = "textBox190";
            this.textBox190.Size = new System.Drawing.Size(31, 20);
            this.textBox190.TabIndex = 422;
            // 
            // textBox189
            // 
            this.textBox189.Location = new System.Drawing.Point(801, 462);
            this.textBox189.Name = "textBox189";
            this.textBox189.Size = new System.Drawing.Size(31, 20);
            this.textBox189.TabIndex = 423;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 1005);
            this.Controls.Add(this.RedeNeuralPreditiva);
            this.Controls.Add(this.btnFinaliza);
            this.Controls.Add(this.btnInicia);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mnApp);
            this.MainMenuStrip = this.mnApp;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mnApp.ResumeLayout(false);
            this.mnApp.PerformLayout();
            this.RedeNeuralPreditiva.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbBitsParada;
        private System.Windows.Forms.ComboBox cbBitsDados;
        private System.Windows.Forms.ComboBox cbParidade;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.ComboBox cbPortas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSair;
        private System.IO.Ports.SerialPort Serial;
        private System.Windows.Forms.Button btnInicia;
        private System.Windows.Forms.Button btnFinaliza;
        private System.Windows.Forms.MenuStrip mnApp;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer tmrApp;
        private System.Windows.Forms.SaveFileDialog svArquivo;
        private System.Windows.Forms.Timer tmrPlot;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TabControl RedeNeuralPreditiva;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox176;
        private System.Windows.Forms.TextBox textBox177;
        private System.Windows.Forms.TextBox textBox178;
        private System.Windows.Forms.TextBox textBox179;
        private System.Windows.Forms.TextBox textBox180;
        private System.Windows.Forms.TextBox textBox181;
        private System.Windows.Forms.TextBox textBox182;
        private System.Windows.Forms.TextBox textBox183;
        private System.Windows.Forms.TextBox textBox184;
        private System.Windows.Forms.TextBox textBox185;
        private System.Windows.Forms.TextBox textBox186;
        private System.Windows.Forms.TextBox textBox187;
        private System.Windows.Forms.TextBox textBox188;
        private System.Windows.Forms.TextBox textBox189;
        private System.Windows.Forms.TextBox textBox190;
        private System.Windows.Forms.TextBox textBox191;
        private System.Windows.Forms.TextBox textBox192;
        private System.Windows.Forms.TextBox textBox193;
        private System.Windows.Forms.TextBox textBox194;
        private System.Windows.Forms.TextBox textBox195;
        private System.Windows.Forms.TextBox textBox196;
        private System.Windows.Forms.TextBox textBox197;
        private System.Windows.Forms.TextBox textBox198;
        private System.Windows.Forms.TextBox textBox199;
        private System.Windows.Forms.TextBox textBox200;
        private System.Windows.Forms.TextBox textBox201;
        private System.Windows.Forms.TextBox textBox202;
        private System.Windows.Forms.TextBox textBox203;
        private System.Windows.Forms.TextBox textBox204;
        private System.Windows.Forms.TextBox textBox205;
        private System.Windows.Forms.TextBox textBox206;
        private System.Windows.Forms.TextBox textBox207;
        private System.Windows.Forms.TextBox textBox208;
        private System.Windows.Forms.TextBox textBox209;
        private System.Windows.Forms.TextBox textBox210;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox textBox222;
        private System.Windows.Forms.TextBox textBox223;
        private System.Windows.Forms.TextBox textBox224;
        private System.Windows.Forms.TextBox textBox225;
        private System.Windows.Forms.TextBox textBox226;
        private System.Windows.Forms.TextBox textBox227;
        private System.Windows.Forms.TextBox textBox228;
        private System.Windows.Forms.TextBox textBox229;
        private System.Windows.Forms.TextBox textBox230;
        private System.Windows.Forms.TextBox textBox231;
        private System.Windows.Forms.TextBox textBox232;
        private System.Windows.Forms.TextBox textBox233;
        private System.Windows.Forms.TextBox textBox234;
        private System.Windows.Forms.TextBox textBox235;
        private System.Windows.Forms.TextBox textBox236;
        private System.Windows.Forms.TextBox textBox237;
        private System.Windows.Forms.TextBox textBox238;
        private System.Windows.Forms.TextBox textBox239;
        private System.Windows.Forms.TextBox textBox240;
        private System.Windows.Forms.TextBox textBox241;
        private System.Windows.Forms.TextBox textBox242;
        private System.Windows.Forms.TextBox textBox243;
        private System.Windows.Forms.TextBox textBox244;
        private System.Windows.Forms.TextBox textBox141;
        private System.Windows.Forms.TextBox textBox142;
        private System.Windows.Forms.TextBox textBox143;
        private System.Windows.Forms.TextBox textBox144;
        private System.Windows.Forms.TextBox textBox145;
        private System.Windows.Forms.TextBox textBox146;
        private System.Windows.Forms.TextBox textBox147;
        private System.Windows.Forms.TextBox textBox148;
        private System.Windows.Forms.TextBox textBox149;
        private System.Windows.Forms.TextBox textBox150;
        private System.Windows.Forms.TextBox textBox151;
        private System.Windows.Forms.TextBox textBox152;
        private System.Windows.Forms.TextBox textBox153;
        private System.Windows.Forms.TextBox textBox154;
        private System.Windows.Forms.TextBox textBox155;
        private System.Windows.Forms.TextBox textBox156;
        private System.Windows.Forms.TextBox textBox157;
        private System.Windows.Forms.TextBox textBox158;
        private System.Windows.Forms.TextBox textBox159;
        private System.Windows.Forms.TextBox textBox160;
        private System.Windows.Forms.TextBox textBox161;
        private System.Windows.Forms.TextBox textBox162;
        private System.Windows.Forms.TextBox textBox163;
        private System.Windows.Forms.TextBox textBox164;
        private System.Windows.Forms.TextBox textBox165;
        private System.Windows.Forms.TextBox textBox166;
        private System.Windows.Forms.TextBox textBox167;
        private System.Windows.Forms.TextBox textBox168;
        private System.Windows.Forms.TextBox textBox169;
        private System.Windows.Forms.TextBox textBox170;
        private System.Windows.Forms.TextBox textBox171;
        private System.Windows.Forms.TextBox textBox172;
        private System.Windows.Forms.TextBox textBox173;
        private System.Windows.Forms.TextBox textBox174;
        private System.Windows.Forms.TextBox textBox175;
        private System.Windows.Forms.TextBox textBox106;
        private System.Windows.Forms.TextBox textBox107;
        private System.Windows.Forms.TextBox textBox108;
        private System.Windows.Forms.TextBox textBox109;
        private System.Windows.Forms.TextBox textBox110;
        private System.Windows.Forms.TextBox textBox111;
        private System.Windows.Forms.TextBox textBox112;
        private System.Windows.Forms.TextBox textBox113;
        private System.Windows.Forms.TextBox textBox114;
        private System.Windows.Forms.TextBox textBox115;
        private System.Windows.Forms.TextBox textBox116;
        private System.Windows.Forms.TextBox textBox117;
        private System.Windows.Forms.TextBox textBox118;
        private System.Windows.Forms.TextBox textBox119;
        private System.Windows.Forms.TextBox textBox120;
        private System.Windows.Forms.TextBox textBox121;
        private System.Windows.Forms.TextBox textBox122;
        private System.Windows.Forms.TextBox textBox123;
        private System.Windows.Forms.TextBox textBox124;
        private System.Windows.Forms.TextBox textBox125;
        private System.Windows.Forms.TextBox textBox126;
        private System.Windows.Forms.TextBox textBox127;
        private System.Windows.Forms.TextBox textBox128;
        private System.Windows.Forms.TextBox textBox129;
        private System.Windows.Forms.TextBox textBox130;
        private System.Windows.Forms.TextBox textBox131;
        private System.Windows.Forms.TextBox textBox132;
        private System.Windows.Forms.TextBox textBox133;
        private System.Windows.Forms.TextBox textBox134;
        private System.Windows.Forms.TextBox textBox135;
        private System.Windows.Forms.TextBox textBox136;
        private System.Windows.Forms.TextBox textBox137;
        private System.Windows.Forms.TextBox textBox138;
        private System.Windows.Forms.TextBox textBox139;
        private System.Windows.Forms.TextBox textBox140;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBox71;
        private System.Windows.Forms.TextBox textBox72;
        private System.Windows.Forms.TextBox textBox73;
        private System.Windows.Forms.TextBox textBox74;
        private System.Windows.Forms.TextBox textBox75;
        private System.Windows.Forms.TextBox textBox76;
        private System.Windows.Forms.TextBox textBox77;
        private System.Windows.Forms.TextBox textBox78;
        private System.Windows.Forms.TextBox textBox79;
        private System.Windows.Forms.TextBox textBox80;
        private System.Windows.Forms.TextBox textBox81;
        private System.Windows.Forms.TextBox textBox82;
        private System.Windows.Forms.TextBox textBox83;
        private System.Windows.Forms.TextBox textBox84;
        private System.Windows.Forms.TextBox textBox85;
        private System.Windows.Forms.TextBox textBox86;
        private System.Windows.Forms.TextBox textBox87;
        private System.Windows.Forms.TextBox textBox88;
        private System.Windows.Forms.TextBox textBox89;
        private System.Windows.Forms.TextBox textBox90;
        private System.Windows.Forms.TextBox textBox91;
        private System.Windows.Forms.TextBox textBox92;
        private System.Windows.Forms.TextBox textBox93;
        private System.Windows.Forms.TextBox textBox94;
        private System.Windows.Forms.TextBox textBox95;
        private System.Windows.Forms.TextBox textBox96;
        private System.Windows.Forms.TextBox textBox97;
        private System.Windows.Forms.TextBox textBox98;
        private System.Windows.Forms.TextBox textBox99;
        private System.Windows.Forms.TextBox textBox100;
        private System.Windows.Forms.TextBox textBox101;
        private System.Windows.Forms.TextBox textBox102;
        private System.Windows.Forms.TextBox textBox103;
        private System.Windows.Forms.TextBox textBox104;
        private System.Windows.Forms.TextBox textBox105;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.TextBox textBox57;
        private System.Windows.Forms.TextBox textBox58;
        private System.Windows.Forms.TextBox textBox59;
        private System.Windows.Forms.TextBox textBox60;
        private System.Windows.Forms.TextBox textBox61;
        private System.Windows.Forms.TextBox textBox62;
        private System.Windows.Forms.TextBox textBox63;
        private System.Windows.Forms.TextBox textBox64;
        private System.Windows.Forms.TextBox textBox65;
        private System.Windows.Forms.TextBox textBox66;
        private System.Windows.Forms.TextBox textBox67;
        private System.Windows.Forms.TextBox textBox68;
        private System.Windows.Forms.TextBox textBox69;
        private System.Windows.Forms.TextBox textBox70;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}

