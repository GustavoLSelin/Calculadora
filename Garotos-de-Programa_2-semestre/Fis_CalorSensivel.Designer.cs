namespace Garotos_de_Programa_2_semestre
{
    partial class Fis_CalorSensivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fis_CalorSensivel));
            this.L_Fis_CalorSensivel_Calculo_3 = new System.Windows.Forms.Label();
            this.Txt_Fis_CalorSensivel_CalorEspecifico = new System.Windows.Forms.ComboBox();
            this.L_Fis_CalorSensivel_Calculo_8 = new System.Windows.Forms.Label();
            this.Btn_Fis_CalorSensivel_Voltar = new System.Windows.Forms.Button();
            this.Btn_Fis_CalorSensivel_Calculadora = new System.Windows.Forms.Button();
            this.Btn_Fis_CalorSensivel_Limpar = new System.Windows.Forms.Button();
            this.Btn_Fis_CalorSensivel_Calcular = new System.Windows.Forms.Button();
            this.L_Fis_CalorSensivel_Calculo_1 = new System.Windows.Forms.Label();
            this.L_Fis_CalorSensivel_Calculo_2 = new System.Windows.Forms.Label();
            this.Txt_Fis_CalorSensivel_QuantidadeCalor = new System.Windows.Forms.TextBox();
            this.L_Fis_CalorSensivel_Titulo = new System.Windows.Forms.Label();
            this.L_Fis_CalorSensivel_Calculo_4 = new System.Windows.Forms.Label();
            this.L_Fis_CalorSensivel_Calculo_5 = new System.Windows.Forms.Label();
            this.Txt_Fis_CalorSensivel_MassaCorpo = new System.Windows.Forms.TextBox();
            this.L_Fis_CalorSensivel_Calculo_6 = new System.Windows.Forms.Label();
            this.L_Fis_CalorSensivel_Calculo_7 = new System.Windows.Forms.Label();
            this.Txt_Fis_CalorSensivel_Temperatura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // L_Fis_CalorSensivel_Calculo_3
            // 
            this.L_Fis_CalorSensivel_Calculo_3.AutoSize = true;
            this.L_Fis_CalorSensivel_Calculo_3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Fis_CalorSensivel_Calculo_3.Location = new System.Drawing.Point(274, 58);
            this.L_Fis_CalorSensivel_Calculo_3.Name = "L_Fis_CalorSensivel_Calculo_3";
            this.L_Fis_CalorSensivel_Calculo_3.Size = new System.Drawing.Size(110, 32);
            this.L_Fis_CalorSensivel_Calculo_3.TabIndex = 147;
            this.L_Fis_CalorSensivel_Calculo_3.Text = "Calor Especifico\r\n da Substâmcia";
            // 
            // Txt_Fis_CalorSensivel_CalorEspecifico
            // 
            this.Txt_Fis_CalorSensivel_CalorEspecifico.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Fis_CalorSensivel_CalorEspecifico.FormattingEnabled = true;
            this.Txt_Fis_CalorSensivel_CalorEspecifico.Items.AddRange(new object[] {
            "Alumínio  =  0.219 cal/g°C",
            "Água  =  1.000 cal/g°C",
            "Álcool  =   0.590 cal/g°C",
            "Cobre  =  0.093 cal/g°C",
            "Chumbo  =  0.031 cal/g°C",
            "Estanho  =  0.055 cal/g°C",
            "Ferro  =  0.119 cal/g°C",
            "Gelo  =  0.550 cal/g°C",
            "Mercúrio  =  0.033 cal/g°C",
            "Ouro  =  0.031 cal/g°C",
            "Prata  =  0.056 cal/g°C",
            "Vapor de Água  =  0.480 cal/g°C",
            "Zinco  =  0.093 cal/g°C"});
            this.Txt_Fis_CalorSensivel_CalorEspecifico.Location = new System.Drawing.Point(209, 93);
            this.Txt_Fis_CalorSensivel_CalorEspecifico.Name = "Txt_Fis_CalorSensivel_CalorEspecifico";
            this.Txt_Fis_CalorSensivel_CalorEspecifico.Size = new System.Drawing.Size(239, 30);
            this.Txt_Fis_CalorSensivel_CalorEspecifico.TabIndex = 145;
            this.Txt_Fis_CalorSensivel_CalorEspecifico.SelectedIndexChanged += new System.EventHandler(this.Txt_Fis_CalorSensivel_CalorEspecifico_SelectedIndexChanged);
            // 
            // L_Fis_CalorSensivel_Calculo_8
            // 
            this.L_Fis_CalorSensivel_Calculo_8.AutoSize = true;
            this.L_Fis_CalorSensivel_Calculo_8.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Fis_CalorSensivel_Calculo_8.Location = new System.Drawing.Point(50, 154);
            this.L_Fis_CalorSensivel_Calculo_8.Name = "L_Fis_CalorSensivel_Calculo_8";
            this.L_Fis_CalorSensivel_Calculo_8.Size = new System.Drawing.Size(139, 22);
            this.L_Fis_CalorSensivel_Calculo_8.TabIndex = 142;
            this.L_Fis_CalorSensivel_Calculo_8.Text = "Q = c * m * ▲ᴓ";
            // 
            // Btn_Fis_CalorSensivel_Voltar
            // 
            this.Btn_Fis_CalorSensivel_Voltar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fis_CalorSensivel_Voltar.Location = new System.Drawing.Point(835, 220);
            this.Btn_Fis_CalorSensivel_Voltar.Name = "Btn_Fis_CalorSensivel_Voltar";
            this.Btn_Fis_CalorSensivel_Voltar.Size = new System.Drawing.Size(73, 27);
            this.Btn_Fis_CalorSensivel_Voltar.TabIndex = 141;
            this.Btn_Fis_CalorSensivel_Voltar.Text = "Voltar";
            this.Btn_Fis_CalorSensivel_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Fis_CalorSensivel_Voltar.Click += new System.EventHandler(this.Btn_Fis_CalorSensivel_Voltar_Click);
            // 
            // Btn_Fis_CalorSensivel_Calculadora
            // 
            this.Btn_Fis_CalorSensivel_Calculadora.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fis_CalorSensivel_Calculadora.Location = new System.Drawing.Point(784, 12);
            this.Btn_Fis_CalorSensivel_Calculadora.Name = "Btn_Fis_CalorSensivel_Calculadora";
            this.Btn_Fis_CalorSensivel_Calculadora.Size = new System.Drawing.Size(124, 50);
            this.Btn_Fis_CalorSensivel_Calculadora.TabIndex = 140;
            this.Btn_Fis_CalorSensivel_Calculadora.Text = "Calculadora";
            this.Btn_Fis_CalorSensivel_Calculadora.UseVisualStyleBackColor = true;
            this.Btn_Fis_CalorSensivel_Calculadora.Click += new System.EventHandler(this.Btn_Fis_CalorSensivel_Calculadora_Click);
            // 
            // Btn_Fis_CalorSensivel_Limpar
            // 
            this.Btn_Fis_CalorSensivel_Limpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fis_CalorSensivel_Limpar.Location = new System.Drawing.Point(674, 170);
            this.Btn_Fis_CalorSensivel_Limpar.Name = "Btn_Fis_CalorSensivel_Limpar";
            this.Btn_Fis_CalorSensivel_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fis_CalorSensivel_Limpar.TabIndex = 139;
            this.Btn_Fis_CalorSensivel_Limpar.Text = "Limpar";
            this.Btn_Fis_CalorSensivel_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Fis_CalorSensivel_Limpar.Click += new System.EventHandler(this.Btn_Fis_CalorSensivel_Limpar_Click);
            // 
            // Btn_Fis_CalorSensivel_Calcular
            // 
            this.Btn_Fis_CalorSensivel_Calcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fis_CalorSensivel_Calcular.Location = new System.Drawing.Point(665, 135);
            this.Btn_Fis_CalorSensivel_Calcular.Name = "Btn_Fis_CalorSensivel_Calcular";
            this.Btn_Fis_CalorSensivel_Calcular.Size = new System.Drawing.Size(93, 29);
            this.Btn_Fis_CalorSensivel_Calcular.TabIndex = 138;
            this.Btn_Fis_CalorSensivel_Calcular.Text = "Calcular";
            this.Btn_Fis_CalorSensivel_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Fis_CalorSensivel_Calcular.Click += new System.EventHandler(this.Btn_Fis_CalorSensivel_Calcular_Click);
            // 
            // L_Fis_CalorSensivel_Calculo_1
            // 
            this.L_Fis_CalorSensivel_Calculo_1.AutoSize = true;
            this.L_Fis_CalorSensivel_Calculo_1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Fis_CalorSensivel_Calculo_1.Location = new System.Drawing.Point(42, 58);
            this.L_Fis_CalorSensivel_Calculo_1.Name = "L_Fis_CalorSensivel_Calculo_1";
            this.L_Fis_CalorSensivel_Calculo_1.Size = new System.Drawing.Size(102, 32);
            this.L_Fis_CalorSensivel_Calculo_1.TabIndex = 135;
            this.L_Fis_CalorSensivel_Calculo_1.Text = "Quantidade de\r\nCalor Sensível";
            // 
            // L_Fis_CalorSensivel_Calculo_2
            // 
            this.L_Fis_CalorSensivel_Calculo_2.AutoSize = true;
            this.L_Fis_CalorSensivel_Calculo_2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Fis_CalorSensivel_Calculo_2.Location = new System.Drawing.Point(167, 92);
            this.L_Fis_CalorSensivel_Calculo_2.Name = "L_Fis_CalorSensivel_Calculo_2";
            this.L_Fis_CalorSensivel_Calculo_2.Size = new System.Drawing.Size(36, 37);
            this.L_Fis_CalorSensivel_Calculo_2.TabIndex = 131;
            this.L_Fis_CalorSensivel_Calculo_2.Text = "=";
            // 
            // Txt_Fis_CalorSensivel_QuantidadeCalor
            // 
            this.Txt_Fis_CalorSensivel_QuantidadeCalor.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Fis_CalorSensivel_QuantidadeCalor.Location = new System.Drawing.Point(18, 93);
            this.Txt_Fis_CalorSensivel_QuantidadeCalor.Name = "Txt_Fis_CalorSensivel_QuantidadeCalor";
            this.Txt_Fis_CalorSensivel_QuantidadeCalor.Size = new System.Drawing.Size(143, 35);
            this.Txt_Fis_CalorSensivel_QuantidadeCalor.TabIndex = 130;
            this.Txt_Fis_CalorSensivel_QuantidadeCalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // L_Fis_CalorSensivel_Titulo
            // 
            this.L_Fis_CalorSensivel_Titulo.AutoSize = true;
            this.L_Fis_CalorSensivel_Titulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Fis_CalorSensivel_Titulo.Location = new System.Drawing.Point(12, 9);
            this.L_Fis_CalorSensivel_Titulo.Name = "L_Fis_CalorSensivel_Titulo";
            this.L_Fis_CalorSensivel_Titulo.Size = new System.Drawing.Size(205, 32);
            this.L_Fis_CalorSensivel_Titulo.TabIndex = 129;
            this.L_Fis_CalorSensivel_Titulo.Text = "Calor Sensível";
            // 
            // L_Fis_CalorSensivel_Calculo_4
            // 
            this.L_Fis_CalorSensivel_Calculo_4.AutoSize = true;
            this.L_Fis_CalorSensivel_Calculo_4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Fis_CalorSensivel_Calculo_4.Location = new System.Drawing.Point(454, 98);
            this.L_Fis_CalorSensivel_Calculo_4.Name = "L_Fis_CalorSensivel_Calculo_4";
            this.L_Fis_CalorSensivel_Calculo_4.Size = new System.Drawing.Size(29, 37);
            this.L_Fis_CalorSensivel_Calculo_4.TabIndex = 148;
            this.L_Fis_CalorSensivel_Calculo_4.Text = "*";
            // 
            // L_Fis_CalorSensivel_Calculo_5
            // 
            this.L_Fis_CalorSensivel_Calculo_5.AutoSize = true;
            this.L_Fis_CalorSensivel_Calculo_5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Fis_CalorSensivel_Calculo_5.Location = new System.Drawing.Point(494, 74);
            this.L_Fis_CalorSensivel_Calculo_5.Name = "L_Fis_CalorSensivel_Calculo_5";
            this.L_Fis_CalorSensivel_Calculo_5.Size = new System.Drawing.Size(109, 16);
            this.L_Fis_CalorSensivel_Calculo_5.TabIndex = 150;
            this.L_Fis_CalorSensivel_Calculo_5.Text = "Massa do Corpo";
            // 
            // Txt_Fis_CalorSensivel_MassaCorpo
            // 
            this.Txt_Fis_CalorSensivel_MassaCorpo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Fis_CalorSensivel_MassaCorpo.Location = new System.Drawing.Point(489, 93);
            this.Txt_Fis_CalorSensivel_MassaCorpo.Name = "Txt_Fis_CalorSensivel_MassaCorpo";
            this.Txt_Fis_CalorSensivel_MassaCorpo.Size = new System.Drawing.Size(119, 35);
            this.Txt_Fis_CalorSensivel_MassaCorpo.TabIndex = 149;
            this.Txt_Fis_CalorSensivel_MassaCorpo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // L_Fis_CalorSensivel_Calculo_6
            // 
            this.L_Fis_CalorSensivel_Calculo_6.AutoSize = true;
            this.L_Fis_CalorSensivel_Calculo_6.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Fis_CalorSensivel_Calculo_6.Location = new System.Drawing.Point(614, 93);
            this.L_Fis_CalorSensivel_Calculo_6.Name = "L_Fis_CalorSensivel_Calculo_6";
            this.L_Fis_CalorSensivel_Calculo_6.Size = new System.Drawing.Size(29, 37);
            this.L_Fis_CalorSensivel_Calculo_6.TabIndex = 151;
            this.L_Fis_CalorSensivel_Calculo_6.Text = "*";
            // 
            // L_Fis_CalorSensivel_Calculo_7
            // 
            this.L_Fis_CalorSensivel_Calculo_7.AutoSize = true;
            this.L_Fis_CalorSensivel_Calculo_7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Fis_CalorSensivel_Calculo_7.Location = new System.Drawing.Point(665, 58);
            this.L_Fis_CalorSensivel_Calculo_7.Name = "L_Fis_CalorSensivel_Calculo_7";
            this.L_Fis_CalorSensivel_Calculo_7.Size = new System.Drawing.Size(89, 32);
            this.L_Fis_CalorSensivel_Calculo_7.TabIndex = 153;
            this.L_Fis_CalorSensivel_Calculo_7.Text = " Variação de\r\nTemperatura";
            // 
            // Txt_Fis_CalorSensivel_Temperatura
            // 
            this.Txt_Fis_CalorSensivel_Temperatura.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Fis_CalorSensivel_Temperatura.Location = new System.Drawing.Point(649, 94);
            this.Txt_Fis_CalorSensivel_Temperatura.Name = "Txt_Fis_CalorSensivel_Temperatura";
            this.Txt_Fis_CalorSensivel_Temperatura.Size = new System.Drawing.Size(119, 35);
            this.Txt_Fis_CalorSensivel_Temperatura.TabIndex = 152;
            this.Txt_Fis_CalorSensivel_Temperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Fis_CalorSensivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 257);
            this.Controls.Add(this.L_Fis_CalorSensivel_Calculo_7);
            this.Controls.Add(this.Txt_Fis_CalorSensivel_Temperatura);
            this.Controls.Add(this.L_Fis_CalorSensivel_Calculo_6);
            this.Controls.Add(this.L_Fis_CalorSensivel_Calculo_5);
            this.Controls.Add(this.Txt_Fis_CalorSensivel_MassaCorpo);
            this.Controls.Add(this.L_Fis_CalorSensivel_Calculo_4);
            this.Controls.Add(this.L_Fis_CalorSensivel_Calculo_3);
            this.Controls.Add(this.Txt_Fis_CalorSensivel_CalorEspecifico);
            this.Controls.Add(this.L_Fis_CalorSensivel_Calculo_8);
            this.Controls.Add(this.Btn_Fis_CalorSensivel_Voltar);
            this.Controls.Add(this.Btn_Fis_CalorSensivel_Calculadora);
            this.Controls.Add(this.Btn_Fis_CalorSensivel_Limpar);
            this.Controls.Add(this.Btn_Fis_CalorSensivel_Calcular);
            this.Controls.Add(this.L_Fis_CalorSensivel_Calculo_1);
            this.Controls.Add(this.L_Fis_CalorSensivel_Calculo_2);
            this.Controls.Add(this.Txt_Fis_CalorSensivel_QuantidadeCalor);
            this.Controls.Add(this.L_Fis_CalorSensivel_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fis_CalorSensivel";
            this.Text = "Fisíca Calor Sensível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label L_Fis_CalorSensivel_Calculo_3;
        private System.Windows.Forms.ComboBox Txt_Fis_CalorSensivel_CalorEspecifico;
        private System.Windows.Forms.Label L_Fis_CalorSensivel_Calculo_8;
        private System.Windows.Forms.Button Btn_Fis_CalorSensivel_Voltar;
        private System.Windows.Forms.Button Btn_Fis_CalorSensivel_Calculadora;
        private System.Windows.Forms.Button Btn_Fis_CalorSensivel_Limpar;
        private System.Windows.Forms.Button Btn_Fis_CalorSensivel_Calcular;
        private System.Windows.Forms.Label L_Fis_CalorSensivel_Calculo_1;
        private System.Windows.Forms.Label L_Fis_CalorSensivel_Calculo_2;
        private System.Windows.Forms.TextBox Txt_Fis_CalorSensivel_QuantidadeCalor;
        private System.Windows.Forms.Label L_Fis_CalorSensivel_Titulo;
        private System.Windows.Forms.Label L_Fis_CalorSensivel_Calculo_4;
        private System.Windows.Forms.Label L_Fis_CalorSensivel_Calculo_5;
        private System.Windows.Forms.TextBox Txt_Fis_CalorSensivel_MassaCorpo;
        private System.Windows.Forms.Label L_Fis_CalorSensivel_Calculo_6;
        private System.Windows.Forms.Label L_Fis_CalorSensivel_Calculo_7;
        private System.Windows.Forms.TextBox Txt_Fis_CalorSensivel_Temperatura;
    }
}