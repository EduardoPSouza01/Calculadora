namespace Calculadora
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
            Btn_Igual = new Button();
            Btn_Vírgula = new Button();
            Btn_0 = new Button();
            Btn_Adicao = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            Btn_Subtracao = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            Btn_Multiplicacao = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            Btn_Divisao = new Button();
            Btn_Porcentagem = new Button();
            Btn_Sinal = new Button();
            btn_AC = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            txb_display = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Igual
            // 
            Btn_Igual.BackColor = Color.Orange;
            Btn_Igual.Dock = DockStyle.Fill;
            Btn_Igual.FlatAppearance.BorderSize = 0;
            Btn_Igual.FlatStyle = FlatStyle.Flat;
            Btn_Igual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Igual.ForeColor = Color.White;
            Btn_Igual.Location = new Point(233, 252);
            Btn_Igual.Name = "Btn_Igual";
            Btn_Igual.Size = new Size(72, 60);
            Btn_Igual.TabIndex = 19;
            Btn_Igual.Text = "=";
            Btn_Igual.UseVisualStyleBackColor = false;
            Btn_Igual.Click += BtnIgual_Click;
            // 
            // Btn_Vírgula
            // 
            Btn_Vírgula.BackColor = Color.Gray;
            Btn_Vírgula.Dock = DockStyle.Fill;
            Btn_Vírgula.FlatAppearance.BorderSize = 0;
            Btn_Vírgula.FlatStyle = FlatStyle.Flat;
            Btn_Vírgula.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Vírgula.ForeColor = Color.White;
            Btn_Vírgula.Location = new Point(156, 252);
            Btn_Vírgula.Name = "Btn_Vírgula";
            Btn_Vírgula.Size = new Size(71, 60);
            Btn_Vírgula.TabIndex = 18;
            Btn_Vírgula.Text = ",";
            Btn_Vírgula.UseVisualStyleBackColor = false;
            Btn_Vírgula.Click += BtnVirgula_Click;
            // 
            // Btn_0
            // 
            Btn_0.BackColor = Color.Gray;
            Btn_0.Dock = DockStyle.Fill;
            Btn_0.FlatAppearance.BorderSize = 0;
            Btn_0.FlatStyle = FlatStyle.Flat;
            Btn_0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_0.ForeColor = Color.White;
            Btn_0.Location = new Point(3, 252);
            Btn_0.Name = "Btn_0";
            Btn_0.Size = new Size(72, 60);
            Btn_0.TabIndex = 16;
            Btn_0.Text = "0";
            Btn_0.UseVisualStyleBackColor = false;
            Btn_0.Click += NumeroClicado;
            // 
            // Btn_Adicao
            // 
            Btn_Adicao.BackColor = Color.Orange;
            Btn_Adicao.Dock = DockStyle.Fill;
            Btn_Adicao.FlatAppearance.BorderSize = 0;
            Btn_Adicao.FlatStyle = FlatStyle.Flat;
            Btn_Adicao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Adicao.ForeColor = Color.White;
            Btn_Adicao.Location = new Point(233, 190);
            Btn_Adicao.Name = "Btn_Adicao";
            Btn_Adicao.Size = new Size(72, 56);
            Btn_Adicao.TabIndex = 15;
            Btn_Adicao.Text = "+";
            Btn_Adicao.UseVisualStyleBackColor = false;
            Btn_Adicao.Click += OperacaoClicada;
            // 
            // btn_3
            // 
            btn_3.BackColor = Color.Gray;
            btn_3.Dock = DockStyle.Fill;
            btn_3.FlatAppearance.BorderSize = 0;
            btn_3.FlatStyle = FlatStyle.Flat;
            btn_3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_3.ForeColor = Color.White;
            btn_3.Location = new Point(156, 190);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(71, 56);
            btn_3.TabIndex = 14;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += NumeroClicado;
            // 
            // btn_2
            // 
            btn_2.BackColor = Color.Gray;
            btn_2.Dock = DockStyle.Fill;
            btn_2.FlatAppearance.BorderSize = 0;
            btn_2.FlatStyle = FlatStyle.Flat;
            btn_2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_2.ForeColor = Color.White;
            btn_2.Location = new Point(81, 190);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(69, 56);
            btn_2.TabIndex = 13;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += NumeroClicado;
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.Gray;
            btn_1.Dock = DockStyle.Fill;
            btn_1.FlatAppearance.BorderSize = 0;
            btn_1.FlatStyle = FlatStyle.Flat;
            btn_1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_1.ForeColor = Color.White;
            btn_1.Location = new Point(3, 190);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(72, 56);
            btn_1.TabIndex = 12;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += NumeroClicado;
            // 
            // Btn_Subtracao
            // 
            Btn_Subtracao.BackColor = Color.Orange;
            Btn_Subtracao.Dock = DockStyle.Fill;
            Btn_Subtracao.FlatAppearance.BorderSize = 0;
            Btn_Subtracao.FlatStyle = FlatStyle.Flat;
            Btn_Subtracao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Subtracao.ForeColor = Color.White;
            Btn_Subtracao.Location = new Point(233, 128);
            Btn_Subtracao.Name = "Btn_Subtracao";
            Btn_Subtracao.Size = new Size(72, 56);
            Btn_Subtracao.TabIndex = 11;
            Btn_Subtracao.Text = "-";
            Btn_Subtracao.UseVisualStyleBackColor = false;
            Btn_Subtracao.Click += OperacaoClicada;
            // 
            // btn_6
            // 
            btn_6.BackColor = Color.Gray;
            btn_6.Dock = DockStyle.Fill;
            btn_6.FlatAppearance.BorderSize = 0;
            btn_6.FlatStyle = FlatStyle.Flat;
            btn_6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_6.ForeColor = Color.White;
            btn_6.Location = new Point(156, 128);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(71, 56);
            btn_6.TabIndex = 10;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = false;
            btn_6.Click += NumeroClicado;
            // 
            // btn_5
            // 
            btn_5.BackColor = Color.Gray;
            btn_5.Dock = DockStyle.Fill;
            btn_5.FlatAppearance.BorderSize = 0;
            btn_5.FlatStyle = FlatStyle.Flat;
            btn_5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_5.ForeColor = Color.White;
            btn_5.Location = new Point(81, 128);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(69, 56);
            btn_5.TabIndex = 9;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += NumeroClicado;
            // 
            // btn_4
            // 
            btn_4.BackColor = Color.Gray;
            btn_4.Dock = DockStyle.Fill;
            btn_4.FlatAppearance.BorderSize = 0;
            btn_4.FlatStyle = FlatStyle.Flat;
            btn_4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_4.ForeColor = Color.White;
            btn_4.Location = new Point(3, 128);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(72, 56);
            btn_4.TabIndex = 8;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += NumeroClicado;
            // 
            // Btn_Multiplicacao
            // 
            Btn_Multiplicacao.BackColor = Color.Orange;
            Btn_Multiplicacao.Dock = DockStyle.Fill;
            Btn_Multiplicacao.FlatAppearance.BorderSize = 0;
            Btn_Multiplicacao.FlatStyle = FlatStyle.Flat;
            Btn_Multiplicacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Multiplicacao.ForeColor = Color.White;
            Btn_Multiplicacao.Location = new Point(233, 66);
            Btn_Multiplicacao.Name = "Btn_Multiplicacao";
            Btn_Multiplicacao.Size = new Size(72, 56);
            Btn_Multiplicacao.TabIndex = 7;
            Btn_Multiplicacao.Text = "x";
            Btn_Multiplicacao.UseVisualStyleBackColor = false;
            Btn_Multiplicacao.Click += OperacaoClicada;
            // 
            // btn_9
            // 
            btn_9.BackColor = Color.Gray;
            btn_9.Dock = DockStyle.Fill;
            btn_9.FlatAppearance.BorderSize = 0;
            btn_9.FlatStyle = FlatStyle.Flat;
            btn_9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_9.ForeColor = Color.White;
            btn_9.Location = new Point(156, 66);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(71, 56);
            btn_9.TabIndex = 6;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = false;
            btn_9.Click += NumeroClicado;
            // 
            // btn_8
            // 
            btn_8.BackColor = Color.Gray;
            btn_8.Dock = DockStyle.Fill;
            btn_8.FlatAppearance.BorderSize = 0;
            btn_8.FlatStyle = FlatStyle.Flat;
            btn_8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_8.ForeColor = Color.White;
            btn_8.Location = new Point(81, 66);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(69, 56);
            btn_8.TabIndex = 5;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = false;
            btn_8.Click += NumeroClicado;
            // 
            // btn_7
            // 
            btn_7.BackColor = Color.Gray;
            btn_7.Dock = DockStyle.Fill;
            btn_7.FlatAppearance.BorderSize = 0;
            btn_7.FlatStyle = FlatStyle.Flat;
            btn_7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_7.ForeColor = Color.White;
            btn_7.Location = new Point(3, 66);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(72, 56);
            btn_7.TabIndex = 4;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = false;
            btn_7.Click += NumeroClicado;
            // 
            // Btn_Divisao
            // 
            Btn_Divisao.BackColor = Color.Orange;
            Btn_Divisao.Cursor = Cursors.Hand;
            Btn_Divisao.Dock = DockStyle.Fill;
            Btn_Divisao.FlatAppearance.BorderSize = 0;
            Btn_Divisao.FlatStyle = FlatStyle.Flat;
            Btn_Divisao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Divisao.ForeColor = Color.White;
            Btn_Divisao.Location = new Point(233, 3);
            Btn_Divisao.Name = "Btn_Divisao";
            Btn_Divisao.Size = new Size(72, 57);
            Btn_Divisao.TabIndex = 3;
            Btn_Divisao.Text = "÷";
            Btn_Divisao.UseVisualStyleBackColor = false;
            Btn_Divisao.Click += OperacaoClicada;
            // 
            // Btn_Porcentagem
            // 
            Btn_Porcentagem.BackColor = SystemColors.ControlDarkDark;
            Btn_Porcentagem.Cursor = Cursors.Hand;
            Btn_Porcentagem.Dock = DockStyle.Fill;
            Btn_Porcentagem.FlatAppearance.BorderSize = 0;
            Btn_Porcentagem.FlatStyle = FlatStyle.Flat;
            Btn_Porcentagem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Porcentagem.ForeColor = Color.White;
            Btn_Porcentagem.Location = new Point(156, 3);
            Btn_Porcentagem.Name = "Btn_Porcentagem";
            Btn_Porcentagem.Size = new Size(71, 57);
            Btn_Porcentagem.TabIndex = 2;
            Btn_Porcentagem.Text = "%";
            Btn_Porcentagem.UseVisualStyleBackColor = false;
            Btn_Porcentagem.Click += Btn_Porcentagem_Click;
            // 
            // Btn_Sinal
            // 
            Btn_Sinal.BackColor = SystemColors.ControlDarkDark;
            Btn_Sinal.Cursor = Cursors.Hand;
            Btn_Sinal.Dock = DockStyle.Fill;
            Btn_Sinal.FlatAppearance.BorderSize = 0;
            Btn_Sinal.FlatStyle = FlatStyle.Flat;
            Btn_Sinal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Sinal.ForeColor = Color.White;
            Btn_Sinal.Location = new Point(81, 3);
            Btn_Sinal.Name = "Btn_Sinal";
            Btn_Sinal.Size = new Size(69, 57);
            Btn_Sinal.TabIndex = 1;
            Btn_Sinal.Text = "+/-";
            Btn_Sinal.UseVisualStyleBackColor = false;
            Btn_Sinal.Click += Btn_Sinal_Click;
            // 
            // btn_AC
            // 
            btn_AC.BackColor = SystemColors.ControlDarkDark;
            btn_AC.Dock = DockStyle.Fill;
            btn_AC.FlatAppearance.BorderSize = 0;
            btn_AC.FlatStyle = FlatStyle.Flat;
            btn_AC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AC.ForeColor = Color.White;
            btn_AC.Location = new Point(3, 3);
            btn_AC.Name = "btn_AC";
            btn_AC.Size = new Size(72, 57);
            btn_AC.TabIndex = 0;
            btn_AC.Text = "AC";
            btn_AC.UseVisualStyleBackColor = false;
            btn_AC.Click += btn_AC_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(Btn_Divisao, 3, 0);
            tableLayoutPanel1.Controls.Add(Btn_Igual, 3, 4);
            tableLayoutPanel1.Controls.Add(btn_AC, 0, 0);
            tableLayoutPanel1.Controls.Add(Btn_Vírgula, 2, 4);
            tableLayoutPanel1.Controls.Add(Btn_Sinal, 1, 0);
            tableLayoutPanel1.Controls.Add(Btn_0, 0, 4);
            tableLayoutPanel1.Controls.Add(Btn_Porcentagem, 2, 0);
            tableLayoutPanel1.Controls.Add(Btn_Adicao, 3, 3);
            tableLayoutPanel1.Controls.Add(btn_7, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_3, 2, 3);
            tableLayoutPanel1.Controls.Add(btn_8, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_2, 1, 3);
            tableLayoutPanel1.Controls.Add(btn_9, 2, 1);
            tableLayoutPanel1.Controls.Add(btn_1, 0, 3);
            tableLayoutPanel1.Controls.Add(Btn_Multiplicacao, 3, 1);
            tableLayoutPanel1.Controls.Add(Btn_Subtracao, 3, 2);
            tableLayoutPanel1.Controls.Add(btn_4, 0, 2);
            tableLayoutPanel1.Controls.Add(btn_6, 2, 2);
            tableLayoutPanel1.Controls.Add(btn_5, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 106);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000038F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000038F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(308, 315);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(txb_display);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 107);
            panel1.TabIndex = 22;
            // 
            // txb_display
            // 
            txb_display.BackColor = Color.FromArgb(64, 64, 64);
            txb_display.BorderStyle = BorderStyle.None;
            txb_display.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            txb_display.ForeColor = Color.White;
            txb_display.Location = new Point(3, 53);
            txb_display.Name = "txb_display";
            txb_display.ReadOnly = true;
            txb_display.Size = new Size(302, 47);
            txb_display.TabIndex = 1;
            txb_display.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 421);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Cursor = Cursors.Hand;
            Name = "Form1";
            Text = "Calculadora";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Igual;
        private Button Btn_Vírgula;
        private Button Btn_0;
        private Button Btn_Adicao;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button Btn_Subtracao;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button Btn_Multiplicacao;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button Btn_Divisao;
        private Button Btn_Porcentagem;
        private Button Btn_Sinal;
        private Button btn_AC;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox txb_display;
    }
}