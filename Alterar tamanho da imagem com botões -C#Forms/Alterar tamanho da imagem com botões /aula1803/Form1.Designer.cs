namespace aula1803
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
            this.btAbrir = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.btMais = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(258, 392);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(75, 29);
            this.btAbrir.TabIndex = 1;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.BtAbrir_Click);
            // 
            // btMenos
            // 
            this.btMenos.BackgroundImage = global::aula1803.Properties.Resources.Lupa_menos;
            this.btMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMenos.Location = new System.Drawing.Point(441, 392);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(75, 29);
            this.btMenos.TabIndex = 3;
            this.btMenos.UseVisualStyleBackColor = true;
            this.btMenos.Click += new System.EventHandler(this.BtMenos_Click);
            // 
            // btMais
            // 
            this.btMais.BackgroundImage = global::aula1803.Properties.Resources.Lupa_Mais;
            this.btMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMais.Location = new System.Drawing.Point(349, 392);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(75, 29);
            this.btMais.TabIndex = 2;
            this.btMais.UseVisualStyleBackColor = true;
            this.btMais.Click += new System.EventHandler(this.BtMais_Click);
            // 
            // pic
            // 
            this.pic.Image = global::aula1803.Properties.Resources.adventure_time2;
            this.pic.Location = new System.Drawing.Point(109, 26);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(562, 344);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // ofdAbrir
            // 
            this.ofdAbrir.FileName = "openFileDialog1";
            this.ofdAbrir.Filter = "Todas as imagens | *.bmp;*png;*.jpeg;*.gif | Imagens PNG | *.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.btMais);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
    }
}

