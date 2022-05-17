namespace Garotos_de_Programa_2_semestre
{
    partial class Ele_Hexadecimal_Decimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ele_Hexadecimal_Decimal));
            this.L_Ele_Binario_Decimal_Titulo = new System.Windows.Forms.Label();
            this.Btn_Ele_Binario_Decimal_Calculadora = new System.Windows.Forms.Button();
            this.Btn_Binario_Decimal_Voltar = new System.Windows.Forms.Button();
            this.Web_Ele_Hexadecimal_Decimal = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // L_Ele_Binario_Decimal_Titulo
            // 
            this.L_Ele_Binario_Decimal_Titulo.AutoSize = true;
            this.L_Ele_Binario_Decimal_Titulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Ele_Binario_Decimal_Titulo.Location = new System.Drawing.Point(12, 9);
            this.L_Ele_Binario_Decimal_Titulo.Name = "L_Ele_Binario_Decimal_Titulo";
            this.L_Ele_Binario_Decimal_Titulo.Size = new System.Drawing.Size(365, 32);
            this.L_Ele_Binario_Decimal_Titulo.TabIndex = 8;
            this.L_Ele_Binario_Decimal_Titulo.Text = "Hexadecimal para Decimal";
            // 
            // Btn_Ele_Binario_Decimal_Calculadora
            // 
            this.Btn_Ele_Binario_Decimal_Calculadora.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ele_Binario_Decimal_Calculadora.Location = new System.Drawing.Point(673, 12);
            this.Btn_Ele_Binario_Decimal_Calculadora.Name = "Btn_Ele_Binario_Decimal_Calculadora";
            this.Btn_Ele_Binario_Decimal_Calculadora.Size = new System.Drawing.Size(124, 50);
            this.Btn_Ele_Binario_Decimal_Calculadora.TabIndex = 9;
            this.Btn_Ele_Binario_Decimal_Calculadora.Text = "Calculadora";
            this.Btn_Ele_Binario_Decimal_Calculadora.UseVisualStyleBackColor = true;
            this.Btn_Ele_Binario_Decimal_Calculadora.Click += new System.EventHandler(this.Btn_Ele_Binario_Decimal_Calculadora_Click);
            // 
            // Btn_Binario_Decimal_Voltar
            // 
            this.Btn_Binario_Decimal_Voltar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Binario_Decimal_Voltar.Location = new System.Drawing.Point(716, 535);
            this.Btn_Binario_Decimal_Voltar.Name = "Btn_Binario_Decimal_Voltar";
            this.Btn_Binario_Decimal_Voltar.Size = new System.Drawing.Size(73, 27);
            this.Btn_Binario_Decimal_Voltar.TabIndex = 10;
            this.Btn_Binario_Decimal_Voltar.Text = "Voltar";
            this.Btn_Binario_Decimal_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Binario_Decimal_Voltar.Click += new System.EventHandler(this.Btn_Binario_Decimal_Voltar_Click);
            // 
            // Web_Ele_Hexadecimal_Decimal
            // 
            this.Web_Ele_Hexadecimal_Decimal.Location = new System.Drawing.Point(12, 60);
            this.Web_Ele_Hexadecimal_Decimal.MinimumSize = new System.Drawing.Size(20, 20);
            this.Web_Ele_Hexadecimal_Decimal.Name = "Web_Ele_Hexadecimal_Decimal";
            this.Web_Ele_Hexadecimal_Decimal.Size = new System.Drawing.Size(648, 487);
            this.Web_Ele_Hexadecimal_Decimal.TabIndex = 11;
            this.Web_Ele_Hexadecimal_Decimal.Url = new System.Uri("https://pt.calcuworld.com/calculadoras-informaticas/calculadora-hexadecimal/?ifra" +
        "me=1", System.UriKind.Absolute);
            // 
            // Ele_Hexadecimal_Decimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(801, 574);
            this.Controls.Add(this.Web_Ele_Hexadecimal_Decimal);
            this.Controls.Add(this.Btn_Binario_Decimal_Voltar);
            this.Controls.Add(this.Btn_Ele_Binario_Decimal_Calculadora);
            this.Controls.Add(this.L_Ele_Binario_Decimal_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ele_Hexadecimal_Decimal";
            this.Text = "Eletrônica - Converter Hexadecimal para Decimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Ele_Binario_Decimal_Titulo;
        private System.Windows.Forms.Button Btn_Ele_Binario_Decimal_Calculadora;
        private System.Windows.Forms.Button Btn_Binario_Decimal_Voltar;
        private System.Windows.Forms.WebBrowser Web_Ele_Hexadecimal_Decimal;
    }
}