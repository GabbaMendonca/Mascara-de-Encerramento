namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_oi = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_abertura = new System.Windows.Forms.TextBox();
            this.txt_normalizacao = new System.Windows.Forms.TextBox();
            this.txt_validacao = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_outra = new System.Windows.Forms.TextBox();
            this.btn_indevido = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.check_causa = new System.Windows.Forms.CheckBox();
            this.check_desempenho = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_router = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID OI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txt_oi
            // 
            this.txt_oi.Location = new System.Drawing.Point(15, 25);
            this.txt_oi.Name = "txt_oi";
            this.txt_oi.Size = new System.Drawing.Size(100, 20);
            this.txt_oi.TabIndex = 2;
            this.txt_oi.Text = "OI";
            this.txt_oi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_nome
            // 
            this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nome.Location = new System.Drawing.Point(15, 64);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(257, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_abertura
            // 
            this.txt_abertura.Location = new System.Drawing.Point(87, 90);
            this.txt_abertura.Name = "txt_abertura";
            this.txt_abertura.Size = new System.Drawing.Size(185, 20);
            this.txt_abertura.TabIndex = 4;
            // 
            // txt_normalizacao
            // 
            this.txt_normalizacao.Location = new System.Drawing.Point(87, 116);
            this.txt_normalizacao.Name = "txt_normalizacao";
            this.txt_normalizacao.Size = new System.Drawing.Size(185, 20);
            this.txt_normalizacao.TabIndex = 5;
            // 
            // txt_validacao
            // 
            this.txt_validacao.Location = new System.Drawing.Point(87, 176);
            this.txt_validacao.Name = "txt_validacao";
            this.txt_validacao.Size = new System.Drawing.Size(185, 20);
            this.txt_validacao.TabIndex = 6;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(87, 202);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(185, 20);
            this.txt_senha.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Abertura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Normalização";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Validação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Senha de\r\nEncerramento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "LOG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Causa Cliente";
            // 
            // txt_outra
            // 
            this.txt_outra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_outra.Location = new System.Drawing.Point(13, 554);
            this.txt_outra.Name = "txt_outra";
            this.txt_outra.Size = new System.Drawing.Size(257, 20);
            this.txt_outra.TabIndex = 15;
            // 
            // btn_indevido
            // 
            this.btn_indevido.Location = new System.Drawing.Point(13, 280);
            this.btn_indevido.Name = "btn_indevido";
            this.btn_indevido.Size = new System.Drawing.Size(257, 23);
            this.btn_indevido.TabIndex = 16;
            this.btn_indevido.Text = "Abertura Indevida";
            this.btn_indevido.UseVisualStyleBackColor = true;
            this.btn_indevido.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(257, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Local Sem Energia";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Causa Operadora";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 351);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(257, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Causa Não Detctada";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 380);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(257, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Gabinete Queimado";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 409);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(257, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = "Modem Queimado";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(13, 438);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(257, 23);
            this.button8.TabIndex = 22;
            this.button8.Text = "Fibra - Recuperado";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(13, 467);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(257, 23);
            this.button9.TabIndex = 23;
            this.button9.Text = "Fibra - Manobra";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(13, 496);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(257, 23);
            this.button10.TabIndex = 24;
            this.button10.Text = "Redea - Recuperado";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(13, 525);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(257, 23);
            this.button11.TabIndex = 25;
            this.button11.Text = "Redea - Manobra";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(13, 580);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(257, 23);
            this.button12.TabIndex = 26;
            this.button12.Text = "Outra Causa";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // check_causa
            // 
            this.check_causa.AutoSize = true;
            this.check_causa.Location = new System.Drawing.Point(13, 609);
            this.check_causa.Name = "check_causa";
            this.check_causa.Size = new System.Drawing.Size(100, 17);
            this.check_causa.TabIndex = 27;
            this.check_causa.Text = "Causa Cliente ?";
            this.check_causa.UseVisualStyleBackColor = true;
            // 
            // check_desempenho
            // 
            this.check_desempenho.AutoSize = true;
            this.check_desempenho.Location = new System.Drawing.Point(13, 233);
            this.check_desempenho.Name = "check_desempenho";
            this.check_desempenho.Size = new System.Drawing.Size(137, 17);
            this.check_desempenho.TabIndex = 28;
            this.check_desempenho.Text = "É Baixo Desempenho ?";
            this.check_desempenho.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Router";
            // 
            // txt_router
            // 
            this.txt_router.Location = new System.Drawing.Point(87, 142);
            this.txt_router.Name = "txt_router";
            this.txt_router.Size = new System.Drawing.Size(185, 20);
            this.txt_router.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(195, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Router";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 639);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_router);
            this.Controls.Add(this.check_desempenho);
            this.Controls.Add(this.check_causa);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_indevido);
            this.Controls.Add(this.txt_outra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_validacao);
            this.Controls.Add(this.txt_normalizacao);
            this.Controls.Add(this.txt_abertura);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_oi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mascara de Encerramento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_oi;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_abertura;
        private System.Windows.Forms.TextBox txt_normalizacao;
        private System.Windows.Forms.TextBox txt_validacao;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_outra;
        private System.Windows.Forms.Button btn_indevido;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.CheckBox check_causa;
        private System.Windows.Forms.CheckBox check_desempenho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_router;
        private System.Windows.Forms.Button button3;
    }
}

