namespace CalculadoraJuros
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
            vlrOg = new Label();
            valorOgEmes = new Label();
            num7 = new Button();
            num8 = new Button();
            num9 = new Button();
            num6 = new Button();
            num5 = new Button();
            num4 = new Button();
            num3 = new Button();
            num2 = new Button();
            num1 = new Button();
            num0 = new Button();
            ponto = new Button();
            apagar = new Button();
            label2 = new Label();
            jurosSimples = new Label();
            jurosCompostos = new Label();
            ogValor = new Label();
            totalValor = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            jurosValor = new Label();
            enter = new Button();
            refazer = new Button();
            label1 = new Label();
            totalMeses = new Label();
            label3 = new Label();
            porcenJuros = new Label();
            SuspendLayout();
            // 
            // vlrOg
            // 
            vlrOg.BackColor = Color.WhiteSmoke;
            vlrOg.FlatStyle = FlatStyle.Popup;
            vlrOg.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vlrOg.Location = new Point(12, 35);
            vlrOg.Name = "vlrOg";
            vlrOg.Size = new Size(288, 50);
            vlrOg.TabIndex = 0;
            vlrOg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valorOgEmes
            // 
            valorOgEmes.AutoSize = true;
            valorOgEmes.BackColor = Color.WhiteSmoke;
            valorOgEmes.FlatStyle = FlatStyle.Popup;
            valorOgEmes.Location = new Point(91, 95);
            valorOgEmes.Name = "valorOgEmes";
            valorOgEmes.Size = new Size(125, 15);
            valorOgEmes.TabIndex = 1;
            valorOgEmes.Text = "Digite o valor original";
            valorOgEmes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // num7
            // 
            num7.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num7.Location = new Point(52, 122);
            num7.Name = "num7";
            num7.Size = new Size(60, 60);
            num7.TabIndex = 2;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += num7_Click;
            // 
            // num8
            // 
            num8.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num8.Location = new Point(124, 122);
            num8.Name = "num8";
            num8.Size = new Size(60, 60);
            num8.TabIndex = 3;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += num8_Click;
            // 
            // num9
            // 
            num9.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num9.Location = new Point(199, 122);
            num9.Name = "num9";
            num9.Size = new Size(60, 60);
            num9.TabIndex = 4;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += num9_Click;
            // 
            // num6
            // 
            num6.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num6.Location = new Point(199, 188);
            num6.Name = "num6";
            num6.Size = new Size(60, 60);
            num6.TabIndex = 7;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += num6_Click;
            // 
            // num5
            // 
            num5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num5.Location = new Point(124, 188);
            num5.Name = "num5";
            num5.Size = new Size(60, 60);
            num5.TabIndex = 6;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += num5_Click;
            // 
            // num4
            // 
            num4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num4.Location = new Point(52, 188);
            num4.Name = "num4";
            num4.Size = new Size(60, 60);
            num4.TabIndex = 5;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += num4_Click;
            // 
            // num3
            // 
            num3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num3.Location = new Point(199, 254);
            num3.Name = "num3";
            num3.Size = new Size(60, 60);
            num3.TabIndex = 10;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += num3_Click;
            // 
            // num2
            // 
            num2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num2.Location = new Point(124, 254);
            num2.Name = "num2";
            num2.Size = new Size(60, 60);
            num2.TabIndex = 9;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += num2_Click;
            // 
            // num1
            // 
            num1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num1.Location = new Point(52, 254);
            num1.Name = "num1";
            num1.Size = new Size(60, 60);
            num1.TabIndex = 8;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += num1_Click;
            // 
            // num0
            // 
            num0.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num0.Location = new Point(124, 320);
            num0.Name = "num0";
            num0.Size = new Size(60, 60);
            num0.TabIndex = 12;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += num0_Click;
            // 
            // ponto
            // 
            ponto.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ponto.Location = new Point(199, 320);
            ponto.Name = "ponto";
            ponto.Size = new Size(60, 60);
            ponto.TabIndex = 13;
            ponto.Text = ".";
            ponto.UseVisualStyleBackColor = true;
            ponto.Click += ponto_Click;
            // 
            // apagar
            // 
            apagar.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            apagar.Location = new Point(52, 320);
            apagar.Name = "apagar";
            apagar.Size = new Size(60, 60);
            apagar.TabIndex = 14;
            apagar.Text = "C";
            apagar.UseVisualStyleBackColor = true;
            apagar.Click += apagar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Location = new Point(355, 35);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 15;
            label2.Text = "Informe o tipo de juros";
            // 
            // jurosSimples
            // 
            jurosSimples.BackColor = Color.White;
            jurosSimples.BorderStyle = BorderStyle.Fixed3D;
            jurosSimples.FlatStyle = FlatStyle.Popup;
            jurosSimples.Location = new Point(318, 70);
            jurosSimples.Name = "jurosSimples";
            jurosSimples.Size = new Size(125, 39);
            jurosSimples.TabIndex = 16;
            jurosSimples.Text = "Simples";
            jurosSimples.TextAlign = ContentAlignment.MiddleCenter;
            jurosSimples.Click += jurosSimples_Click;
            // 
            // jurosCompostos
            // 
            jurosCompostos.BackColor = Color.White;
            jurosCompostos.BorderStyle = BorderStyle.Fixed3D;
            jurosCompostos.FlatStyle = FlatStyle.Popup;
            jurosCompostos.Location = new Point(318, 122);
            jurosCompostos.Name = "jurosCompostos";
            jurosCompostos.Size = new Size(125, 39);
            jurosCompostos.TabIndex = 17;
            jurosCompostos.Text = "Compostos";
            jurosCompostos.TextAlign = ContentAlignment.MiddleCenter;
            jurosCompostos.Click += jurosCompostos_Click;
            // 
            // ogValor
            // 
            ogValor.BackColor = Color.WhiteSmoke;
            ogValor.BorderStyle = BorderStyle.Fixed3D;
            ogValor.FlatStyle = FlatStyle.Popup;
            ogValor.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ogValor.Location = new Point(500, 71);
            ogValor.Name = "ogValor";
            ogValor.Size = new Size(288, 50);
            ogValor.TabIndex = 18;
            ogValor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // totalValor
            // 
            totalValor.BackColor = Color.WhiteSmoke;
            totalValor.BorderStyle = BorderStyle.Fixed3D;
            totalValor.FlatStyle = FlatStyle.Popup;
            totalValor.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalValor.Location = new Point(500, 161);
            totalValor.Name = "totalValor";
            totalValor.Size = new Size(288, 50);
            totalValor.TabIndex = 19;
            totalValor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Location = new Point(500, 54);
            label5.Name = "label5";
            label5.Size = new Size(83, 17);
            label5.TabIndex = 20;
            label5.Text = "Valor original";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Location = new Point(500, 144);
            label6.Name = "label6";
            label6.Size = new Size(36, 17);
            label6.TabIndex = 21;
            label6.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.WhiteSmoke;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Location = new Point(500, 237);
            label7.Name = "label7";
            label7.Size = new Size(42, 17);
            label7.TabIndex = 23;
            label7.Text = "Juros";
            // 
            // jurosValor
            // 
            jurosValor.BackColor = Color.WhiteSmoke;
            jurosValor.BorderStyle = BorderStyle.Fixed3D;
            jurosValor.FlatStyle = FlatStyle.Popup;
            jurosValor.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jurosValor.Location = new Point(500, 254);
            jurosValor.Name = "jurosValor";
            jurosValor.Size = new Size(288, 50);
            jurosValor.TabIndex = 22;
            jurosValor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // enter
            // 
            enter.Enabled = false;
            enter.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enter.Location = new Point(265, 320);
            enter.Name = "enter";
            enter.Size = new Size(114, 60);
            enter.TabIndex = 24;
            enter.Text = "Enter";
            enter.UseVisualStyleBackColor = true;
            enter.Visible = false;
            enter.Click += enter_Click;
            // 
            // refazer
            // 
            refazer.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            refazer.Location = new Point(265, 254);
            refazer.Name = "refazer";
            refazer.Size = new Size(178, 60);
            refazer.TabIndex = 25;
            refazer.Text = "Refazer";
            refazer.UseMnemonic = false;
            refazer.UseVisualStyleBackColor = true;
            refazer.Click += refazer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Location = new Point(500, 322);
            label1.Name = "label1";
            label1.Size = new Size(122, 17);
            label1.TabIndex = 27;
            label1.Text = "Meses de aplicação";
            // 
            // totalMeses
            // 
            totalMeses.BackColor = Color.WhiteSmoke;
            totalMeses.BorderStyle = BorderStyle.Fixed3D;
            totalMeses.FlatStyle = FlatStyle.Popup;
            totalMeses.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalMeses.Location = new Point(500, 339);
            totalMeses.Name = "totalMeses";
            totalMeses.Size = new Size(288, 50);
            totalMeses.TabIndex = 26;
            totalMeses.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Location = new Point(265, 174);
            label3.Name = "label3";
            label3.Size = new Size(135, 17);
            label3.TabIndex = 29;
            label3.Text = "Porcentagem de juros";
            // 
            // porcenJuros
            // 
            porcenJuros.BackColor = Color.WhiteSmoke;
            porcenJuros.BorderStyle = BorderStyle.Fixed3D;
            porcenJuros.FlatStyle = FlatStyle.Popup;
            porcenJuros.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            porcenJuros.Location = new Point(265, 191);
            porcenJuros.Name = "porcenJuros";
            porcenJuros.Size = new Size(178, 50);
            porcenJuros.TabIndex = 28;
            porcenJuros.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(porcenJuros);
            Controls.Add(label1);
            Controls.Add(totalMeses);
            Controls.Add(refazer);
            Controls.Add(enter);
            Controls.Add(label7);
            Controls.Add(jurosValor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(totalValor);
            Controls.Add(ogValor);
            Controls.Add(jurosCompostos);
            Controls.Add(jurosSimples);
            Controls.Add(label2);
            Controls.Add(apagar);
            Controls.Add(ponto);
            Controls.Add(num0);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(num6);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(num9);
            Controls.Add(num8);
            Controls.Add(num7);
            Controls.Add(valorOgEmes);
            Controls.Add(vlrOg);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Calculadora de juros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label vlrOg;
        private Label valorOgEmes;
        private Button num7;
        private Button num8;
        private Button num9;
        private Button num6;
        private Button num5;
        private Button num4;
        private Button num3;
        private Button num2;
        private Button num1;
        private Button num0;
        private Button ponto;
        private Button apagar;
        private Label label2;
        private Label jurosSimples;
        private Label jurosCompostos;
        private Label ogValor;
        private Label totalValor;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label jurosValor;
        private Button enter;
        private Button refazer;
        private Label label1;
        private Label totalMeses;
        private Label label3;
        private Label porcenJuros;
    }
}
