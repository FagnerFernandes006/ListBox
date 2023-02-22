namespace ExercicioSenac
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
            this.texto = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remover = new System.Windows.Forms.Button();
            this.LimparAll = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.Posicao = new System.Windows.Forms.TextBox();
            this.Quantidade = new System.Windows.Forms.TextBox();
            this.textoItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(61, 28);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(521, 23);
            this.texto.TabIndex = 0;
            this.texto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(61, 83);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(521, 184);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(652, 244);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(109, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remover
            // 
            this.Remover.Location = new System.Drawing.Point(652, 291);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(109, 23);
            this.Remover.TabIndex = 3;
            this.Remover.Text = "Remover";
            this.Remover.UseVisualStyleBackColor = true;
            this.Remover.Click += new System.EventHandler(this.Remover_Click);
            // 
            // LimparAll
            // 
            this.LimparAll.Location = new System.Drawing.Point(652, 339);
            this.LimparAll.Name = "LimparAll";
            this.LimparAll.Size = new System.Drawing.Size(109, 23);
            this.LimparAll.TabIndex = 4;
            this.LimparAll.Text = "Liampar Tudo";
            this.LimparAll.UseVisualStyleBackColor = true;
            this.LimparAll.Click += new System.EventHandler(this.LimparAll_Click);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(652, 384);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(109, 23);
            this.Sair.TabIndex = 5;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Posicao
            // 
            this.Posicao.Location = new System.Drawing.Point(69, 291);
            this.Posicao.Name = "Posicao";
            this.Posicao.Size = new System.Drawing.Size(100, 23);
            this.Posicao.TabIndex = 6;
            // 
            // Quantidade
            // 
            this.Quantidade.Location = new System.Drawing.Point(69, 339);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(100, 23);
            this.Quantidade.TabIndex = 7;
            // 
            // textoItem
            // 
            this.textoItem.Location = new System.Drawing.Point(69, 384);
            this.textoItem.Name = "textoItem";
            this.textoItem.Size = new System.Drawing.Size(100, 23);
            this.textoItem.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textoItem);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.Posicao);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.LimparAll);
            this.Controls.Add(this.Remover);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox texto;
        private ListBox listBox;
        private Button Add;
        private Button Remover;
        private Button LimparAll;
        private Button Sair;
        private TextBox Posicao;
        private TextBox Quantidade;
        private TextBox textoItem;
    }
}