namespace Quiz_noite
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
            this.grupo = new System.Windows.Forms.GroupBox();
            this.btProximo = new System.Windows.Forms.Button();
            this.btiniciar = new System.Windows.Forms.Button();
            this.resp1 = new System.Windows.Forms.RadioButton();
            this.resp2 = new System.Windows.Forms.RadioButton();
            this.resp3 = new System.Windows.Forms.RadioButton();
            this.resp4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grupo
            // 
            this.grupo.Controls.Add(this.label3);
            this.grupo.Controls.Add(this.lblPergunta);
            this.grupo.Controls.Add(this.lblPontos);
            this.grupo.Controls.Add(this.resp1);
            this.grupo.Controls.Add(this.label1);
            this.grupo.Controls.Add(this.resp2);
            this.grupo.Controls.Add(this.resp3);
            this.grupo.Controls.Add(this.resp4);
            this.grupo.Controls.Add(this.btProximo);
            this.grupo.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo.Location = new System.Drawing.Point(566, 225);
            this.grupo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grupo.Name = "grupo";
            this.grupo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grupo.Size = new System.Drawing.Size(532, 331);
            this.grupo.TabIndex = 0;
            this.grupo.TabStop = false;
            this.grupo.Visible = false;
            // 
            // btProximo
            // 
            this.btProximo.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProximo.Location = new System.Drawing.Point(174, 286);
            this.btProximo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(112, 35);
            this.btProximo.TabIndex = 0;
            this.btProximo.Text = "Próximo";
            this.btProximo.UseVisualStyleBackColor = true;
            this.btProximo.Click += new System.EventHandler(this.BtProximo_Click);
            // 
            // btiniciar
            // 
            this.btiniciar.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btiniciar.Location = new System.Drawing.Point(740, 566);
            this.btiniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btiniciar.Name = "btiniciar";
            this.btiniciar.Size = new System.Drawing.Size(112, 35);
            this.btiniciar.TabIndex = 1;
            this.btiniciar.Text = "Iniciar";
            this.btiniciar.UseVisualStyleBackColor = true;
            this.btiniciar.Click += new System.EventHandler(this.Btiniciar_Click);
            // 
            // resp1
            // 
            this.resp1.AutoSize = true;
            this.resp1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resp1.Location = new System.Drawing.Point(158, 110);
            this.resp1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resp1.Name = "resp1";
            this.resp1.Size = new System.Drawing.Size(142, 32);
            this.resp1.TabIndex = 2;
            this.resp1.TabStop = true;
            this.resp1.Text = "radioButton1";
            this.resp1.UseVisualStyleBackColor = true;
            this.resp1.CheckedChanged += new System.EventHandler(this.Resp1_CheckedChanged);
            // 
            // resp2
            // 
            this.resp2.AutoSize = true;
            this.resp2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resp2.Location = new System.Drawing.Point(158, 152);
            this.resp2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resp2.Name = "resp2";
            this.resp2.Size = new System.Drawing.Size(142, 32);
            this.resp2.TabIndex = 3;
            this.resp2.TabStop = true;
            this.resp2.Text = "radioButton2";
            this.resp2.UseVisualStyleBackColor = true;
            this.resp2.CheckedChanged += new System.EventHandler(this.Resp2_CheckedChanged);
            // 
            // resp3
            // 
            this.resp3.AutoSize = true;
            this.resp3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resp3.Location = new System.Drawing.Point(158, 194);
            this.resp3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resp3.Name = "resp3";
            this.resp3.Size = new System.Drawing.Size(142, 32);
            this.resp3.TabIndex = 4;
            this.resp3.TabStop = true;
            this.resp3.Text = "radioButton3";
            this.resp3.UseVisualStyleBackColor = true;
            this.resp3.CheckedChanged += new System.EventHandler(this.Resp3_CheckedChanged);
            // 
            // resp4
            // 
            this.resp4.AutoSize = true;
            this.resp4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resp4.Location = new System.Drawing.Point(158, 236);
            this.resp4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resp4.Name = "resp4";
            this.resp4.Size = new System.Drawing.Size(142, 32);
            this.resp4.TabIndex = 5;
            this.resp4.TabStop = true;
            this.resp4.Text = "radioButton4";
            this.resp4.UseVisualStyleBackColor = true;
            this.resp4.CheckedChanged += new System.EventHandler(this.Resp4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pontos:";
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.Location = new System.Drawing.Point(288, 22);
            this.lblPontos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(21, 21);
            this.lblPontos.TabIndex = 7;
            this.lblPontos.Text = "0";
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(8, 65);
            this.lblPergunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(66, 18);
            this.lblPergunta.TabIndex = 7;
            this.lblPergunta.Text = "label3";
            this.lblPergunta.Click += new System.EventHandler(this.LblPergunta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz_noite.Properties.Resources.fundo;
            this.pictureBox1.InitialImage = global::Quiz_noite.Properties.Resources.fundo;
            this.pictureBox1.Location = new System.Drawing.Point(-225, -25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1661, 845);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quiz Hora de Aventura";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "/ 6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 799);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btiniciar);
            this.Controls.Add(this.grupo);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupo.ResumeLayout(false);
            this.grupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.RadioButton resp1;
        private System.Windows.Forms.RadioButton resp2;
        private System.Windows.Forms.RadioButton resp3;
        private System.Windows.Forms.RadioButton resp4;
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.Button btiniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

