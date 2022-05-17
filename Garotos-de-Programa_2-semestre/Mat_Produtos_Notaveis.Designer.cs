namespace Garotos_de_Programa_2_semestre
{
    partial class Mat_Produtos_Notaveis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mat_Produtos_Notaveis));
            this.Btn_Mat_Produtos_Notaveis = new System.Windows.Forms.Button();
            this.Btn_Mat_Produtos_Notaveis_Voltar = new System.Windows.Forms.Button();
            this.WeB_Mat_Produtos_Notaveis = new System.Windows.Forms.WebBrowser();
            this.L_Mat_Produtos_Notaveis_Titulo = new System.Windows.Forms.Label();
            this.Btn_Limpar_Produtos_Notaveis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Mat_Produtos_Notaveis
            // 
            this.Btn_Mat_Produtos_Notaveis.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mat_Produtos_Notaveis.Location = new System.Drawing.Point(814, 12);
            this.Btn_Mat_Produtos_Notaveis.Name = "Btn_Mat_Produtos_Notaveis";
            this.Btn_Mat_Produtos_Notaveis.Size = new System.Drawing.Size(124, 50);
            this.Btn_Mat_Produtos_Notaveis.TabIndex = 4;
            this.Btn_Mat_Produtos_Notaveis.Text = "Calculadora";
            this.Btn_Mat_Produtos_Notaveis.UseVisualStyleBackColor = true;
            this.Btn_Mat_Produtos_Notaveis.Click += new System.EventHandler(this.Btn_Mat_Porcentagem_Calculadora_Click);
            // 
            // Btn_Mat_Produtos_Notaveis_Voltar
            // 
            this.Btn_Mat_Produtos_Notaveis_Voltar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mat_Produtos_Notaveis_Voltar.Location = new System.Drawing.Point(865, 604);
            this.Btn_Mat_Produtos_Notaveis_Voltar.Name = "Btn_Mat_Produtos_Notaveis_Voltar";
            this.Btn_Mat_Produtos_Notaveis_Voltar.Size = new System.Drawing.Size(73, 27);
            this.Btn_Mat_Produtos_Notaveis_Voltar.TabIndex = 5;
            this.Btn_Mat_Produtos_Notaveis_Voltar.Text = "Voltar";
            this.Btn_Mat_Produtos_Notaveis_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Mat_Produtos_Notaveis_Voltar.Click += new System.EventHandler(this.Btn_Mat_Porcentagem_Voltar_Click);
            // 
            // WeB_Mat_Produtos_Notaveis
            // 
            this.WeB_Mat_Produtos_Notaveis.Location = new System.Drawing.Point(18, 68);
            this.WeB_Mat_Produtos_Notaveis.MinimumSize = new System.Drawing.Size(20, 20);
            this.WeB_Mat_Produtos_Notaveis.Name = "WeB_Mat_Produtos_Notaveis";
            this.WeB_Mat_Produtos_Notaveis.Size = new System.Drawing.Size(920, 507);
            this.WeB_Mat_Produtos_Notaveis.TabIndex = 6;
            this.WeB_Mat_Produtos_Notaveis.Url = new System.Uri("https://pt.symbolab.com/solver/step-by-step/%5Cleft(%201a%5E%7B1%7D%20%2B%201b%5E" +
        "%7B1%7D%5Cright)", System.UriKind.Absolute);
            // 
            // L_Mat_Produtos_Notaveis_Titulo
            // 
            this.L_Mat_Produtos_Notaveis_Titulo.AutoSize = true;
            this.L_Mat_Produtos_Notaveis_Titulo.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Mat_Produtos_Notaveis_Titulo.Location = new System.Drawing.Point(12, 9);
            this.L_Mat_Produtos_Notaveis_Titulo.Name = "L_Mat_Produtos_Notaveis_Titulo";
            this.L_Mat_Produtos_Notaveis_Titulo.Size = new System.Drawing.Size(258, 32);
            this.L_Mat_Produtos_Notaveis_Titulo.TabIndex = 7;
            this.L_Mat_Produtos_Notaveis_Titulo.Text = "Produtos Notaveis";
            // 
            // Btn_Limpar_Produtos_Notaveis
            // 
            this.Btn_Limpar_Produtos_Notaveis.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpar_Produtos_Notaveis.Location = new System.Drawing.Point(413, 581);
            this.Btn_Limpar_Produtos_Notaveis.Name = "Btn_Limpar_Produtos_Notaveis";
            this.Btn_Limpar_Produtos_Notaveis.Size = new System.Drawing.Size(124, 50);
            this.Btn_Limpar_Produtos_Notaveis.TabIndex = 8;
            this.Btn_Limpar_Produtos_Notaveis.Text = "Limpar";
            this.Btn_Limpar_Produtos_Notaveis.UseVisualStyleBackColor = true;
            this.Btn_Limpar_Produtos_Notaveis.Click += new System.EventHandler(this.Btn_Limpar_Produtos_Notaveis_Click);
            // 
            // Mat_Produtos_Notaveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(950, 643);
            this.Controls.Add(this.Btn_Limpar_Produtos_Notaveis);
            this.Controls.Add(this.L_Mat_Produtos_Notaveis_Titulo);
            this.Controls.Add(this.WeB_Mat_Produtos_Notaveis);
            this.Controls.Add(this.Btn_Mat_Produtos_Notaveis_Voltar);
            this.Controls.Add(this.Btn_Mat_Produtos_Notaveis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mat_Produtos_Notaveis";
            this.Text = "Matemática - Produtos Notaveis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Mat_Produtos_Notaveis;
        private System.Windows.Forms.Button Btn_Mat_Produtos_Notaveis_Voltar;
        private System.Windows.Forms.WebBrowser WeB_Mat_Produtos_Notaveis;
        private System.Windows.Forms.Label L_Mat_Produtos_Notaveis_Titulo;
        private System.Windows.Forms.Button Btn_Limpar_Produtos_Notaveis;
    }
}