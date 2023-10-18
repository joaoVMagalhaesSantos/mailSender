using System.Configuration;

namespace mailSender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            string arquivoConfiguracao = "C:\\tolsistemas\\email\\configuracao.txt";
            EmailSettings settings = EmailConfigurationReader.ReadConfiguration(arquivoConfiguracao);


            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDe = new TextBox();
            txtPara = new TextBox();
            txtCC = new TextBox();
            txtAssunto = new TextBox();
            btnEnviar = new Button();
            btnSair = new Button();
            btnLimpar = new Button();
            lbMensagem = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 48);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Para:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 81);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "CC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 113);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Assunto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 148);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Mensagem:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 14);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 4;
            label5.Text = "De:";
            // 
            // txtDe
            // 
            txtDe.Enabled = false;
            txtDe.Location = new Point(76, 11);
            txtDe.Name = "txtDe";
            txtDe.Size = new Size(532, 23);
            txtDe.TabIndex = 5;
            txtDe.Text = settings.Usuario;
            // 
            // txtPara
            // 
            txtPara.Location = new Point(76, 45);
            txtPara.Name = "txtPara";
            txtPara.Size = new Size(532, 23);
            txtPara.TabIndex = 6;
            txtPara.Text = settings.Destinatario;
            // 
            // txtCC
            // 
            txtCC.Location = new Point(76, 78);
            txtCC.Name = "txtCC";
            txtCC.Size = new Size(532, 23);
            txtCC.TabIndex = 7;
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(76, 110);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(532, 23);
            txtAssunto.TabIndex = 8;
            txtAssunto.Text = settings.Assunto;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(536, 305);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 10;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += BtnEnviar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(536, 334);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 11;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(536, 363);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lbMensagem
            // 
            lbMensagem.Location = new Point(76, 145);
            lbMensagem.Multiline = true;
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(532, 154);
            lbMensagem.TabIndex = 9;
            lbMensagem.Text = settings.Mensagem;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 414);
            Controls.Add(lbMensagem);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(btnEnviar);
            Controls.Add(txtAssunto);
            Controls.Add(txtCC);
            Controls.Add(txtPara);
            Controls.Add(txtDe);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDe;
        private TextBox txtPara;
        private TextBox txtCC;
        private TextBox txtAssunto;
        private Button btnEnviar;
        private Button btnSair;
        private Button btnLimpar;
        private TextBox lbMensagem;
    }
}