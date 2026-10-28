namespace ProtoTask
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
            panel1 = new Panel();
            radNaoConcluidas = new RadioButton();
            radTodas = new RadioButton();
            btnAdicionar = new Button();
            dtpLimite = new DateTimePicker();
            txtPesquisa = new TextBox();
            clbTarefas = new CheckedListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(radNaoConcluidas);
            panel1.Controls.Add(radTodas);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(dtpLimite);
            panel1.Controls.Add(txtPesquisa);
            panel1.Controls.Add(clbTarefas);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 468);
            panel1.TabIndex = 0;
            // 
            // radNaoConcluidas
            // 
            radNaoConcluidas.AutoSize = true;
            radNaoConcluidas.Location = new Point(308, 110);
            radNaoConcluidas.Name = "radNaoConcluidas";
            radNaoConcluidas.Size = new Size(107, 19);
            radNaoConcluidas.TabIndex = 5;
            radNaoConcluidas.TabStop = true;
            radNaoConcluidas.Text = "Não concluídas";
            radNaoConcluidas.UseVisualStyleBackColor = true;
            radNaoConcluidas.CheckedChanged += radNaoConcluidas_CheckedChanged;
            // 
            // radTodas
            // 
            radTodas.AutoSize = true;
            radTodas.Location = new Point(121, 110);
            radTodas.Name = "radTodas";
            radTodas.Size = new Size(55, 19);
            radTodas.TabIndex = 4;
            radTodas.TabStop = true;
            radTodas.Text = "Todas";
            radTodas.UseVisualStyleBackColor = true;
            radTodas.CheckedChanged += radTodas_CheckedChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(468, 57);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(20, 22);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "+";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dtpLimite
            // 
            dtpLimite.Format = DateTimePickerFormat.Short;
            dtpLimite.Location = new Point(332, 55);
            dtpLimite.Name = "dtpLimite";
            dtpLimite.Size = new Size(114, 23);
            dtpLimite.TabIndex = 2;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(72, 55);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(230, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.KeyUp += txtPesquisa_KeyUp;
            // 
            // clbTarefas
            // 
            clbTarefas.FormattingEnabled = true;
            clbTarefas.Location = new Point(58, 154);
            clbTarefas.Name = "clbTarefas";
            clbTarefas.Size = new Size(443, 292);
            clbTarefas.TabIndex = 0;
            clbTarefas.ItemCheck += clbTarefas_ItemCheck;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 492);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckedListBox clbTarefas;
        private Button btnAdicionar;
        private DateTimePicker dtpLimite;
        private TextBox txtPesquisa;
        private RadioButton radNaoConcluidas;
        private RadioButton radTodas;
    }
}
