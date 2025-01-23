namespace Projeto_2
{
    partial class Kcal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAtFisica = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tempoEx = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.resKcal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoEx)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Projeto_2.Properties.Resources.teste1;
            this.pictureBox1.Location = new System.Drawing.Point(419, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 466);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o tipo de atividade fisíca:";
            // 
            // cbxAtFisica
            // 
            this.cbxAtFisica.FormattingEnabled = true;
            this.cbxAtFisica.Items.AddRange(new object[] {
            "Caminhar",
            "Musculação",
            "Futebol",
            "Tênis",
            "Dança",
            "Alongamento"});
            this.cbxAtFisica.Location = new System.Drawing.Point(247, 80);
            this.cbxAtFisica.Name = "cbxAtFisica";
            this.cbxAtFisica.Size = new System.Drawing.Size(166, 21);
            this.cbxAtFisica.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informe seu peso em KG:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(174, 120);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(57, 20);
            this.txtPeso.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quanto tempo você irá fazer o exercício:";
            // 
            // tempoEx
            // 
            this.tempoEx.Location = new System.Drawing.Point(263, 163);
            this.tempoEx.Name = "tempoEx";
            this.tempoEx.Size = new System.Drawing.Size(47, 20);
            this.tempoEx.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "O valor Kcal gasto é de:";
            // 
            // resKcal
            // 
            this.resKcal.Location = new System.Drawing.Point(167, 254);
            this.resKcal.Name = "resKcal";
            this.resKcal.Size = new System.Drawing.Size(123, 20);
            this.resKcal.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(15, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(174, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(338, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Kcal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resKcal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tempoEx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxAtFisica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Kcal";
            this.Text = "Calcule seu gasto de calorias";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoEx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAtFisica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tempoEx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resKcal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

