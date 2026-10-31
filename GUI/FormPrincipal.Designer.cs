namespace ProtoTask
{
    partial class FormPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
			panel1 = new Panel();
			groupBox1 = new GroupBox();
			radNaoConcluidas = new RadioButton();
			radTodas = new RadioButton();
			lblError = new Label();
			statusStrip1 = new StatusStrip();
			tlsUsuario = new ToolStripStatusLabel();
			menuStrip1 = new MenuStrip();
			sairToolStripMenuItem = new ToolStripMenuItem();
			sairDaContaToolStripMenuItem = new ToolStripMenuItem();
			sairParaOWindowsToolStripMenuItem = new ToolStripMenuItem();
			label1 = new Label();
			btnAdicionar = new Button();
			dtpLimite = new DateTimePicker();
			txtPesquisa = new TextBox();
			clbTarefas = new CheckedListBox();
			panel1.SuspendLayout();
			groupBox1.SuspendLayout();
			statusStrip1.SuspendLayout();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel1.Controls.Add(groupBox1);
			panel1.Controls.Add(lblError);
			panel1.Controls.Add(statusStrip1);
			panel1.Controls.Add(menuStrip1);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(btnAdicionar);
			panel1.Controls.Add(dtpLimite);
			panel1.Controls.Add(txtPesquisa);
			panel1.Controls.Add(clbTarefas);
			panel1.Location = new Point(0, -1);
			panel1.Name = "panel1";
			panel1.Size = new Size(558, 494);
			panel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			groupBox1.Controls.Add(radNaoConcluidas);
			groupBox1.Controls.Add(radTodas);
			groupBox1.Location = new Point(332, 449);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(192, 15);
			groupBox1.TabIndex = 10;
			groupBox1.TabStop = false;
			groupBox1.Text = "groupBox1";
			// 
			// radNaoConcluidas
			// 
			radNaoConcluidas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			radNaoConcluidas.AutoSize = true;
			radNaoConcluidas.Location = new Point(6, -2);
			radNaoConcluidas.Name = "radNaoConcluidas";
			radNaoConcluidas.Size = new Size(107, 19);
			radNaoConcluidas.TabIndex = 5;
			radNaoConcluidas.Text = "Não concluídas";
			radNaoConcluidas.UseVisualStyleBackColor = true;
			radNaoConcluidas.CheckedChanged += radNaoConcluidas_CheckedChanged;
			// 
			// radTodas
			// 
			radTodas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			radTodas.AutoSize = true;
			radTodas.Checked = true;
			radTodas.Location = new Point(131, -2);
			radTodas.Name = "radTodas";
			radTodas.Size = new Size(55, 19);
			radTodas.TabIndex = 9;
			radTodas.TabStop = true;
			radTodas.Text = "Todas";
			radTodas.UseVisualStyleBackColor = true;
			radTodas.CheckedChanged += radTodas_CheckedChanged;
			// 
			// lblError
			// 
			lblError.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			lblError.AutoSize = true;
			lblError.ForeColor = Color.Red;
			lblError.Location = new Point(35, 447);
			lblError.Name = "lblError";
			lblError.Size = new Size(213, 15);
			lblError.TabIndex = 1;
			lblError.Text = "Preencha as informações corretamente";
			lblError.Visible = false;
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { tlsUsuario });
			statusStrip1.Location = new Point(0, 472);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(558, 22);
			statusStrip1.TabIndex = 7;
			statusStrip1.Text = "statusStrip1";
			// 
			// tlsUsuario
			// 
			tlsUsuario.Name = "tlsUsuario";
			tlsUsuario.Size = new Size(118, 17);
			tlsUsuario.Text = "toolStripStatusLabel1";
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = SystemColors.ControlLight;
			menuStrip1.Items.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(558, 24);
			menuStrip1.TabIndex = 8;
			menuStrip1.Text = "menuStrip1";
			// 
			// sairToolStripMenuItem
			// 
			sairToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairDaContaToolStripMenuItem, sairParaOWindowsToolStripMenuItem });
			sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			sairToolStripMenuItem.Size = new Size(38, 20);
			sairToolStripMenuItem.Text = "&Sair";
			// 
			// sairDaContaToolStripMenuItem
			// 
			sairDaContaToolStripMenuItem.Name = "sairDaContaToolStripMenuItem";
			sairDaContaToolStripMenuItem.Size = new Size(181, 22);
			sairDaContaToolStripMenuItem.Text = "Sair da &conta";
			sairDaContaToolStripMenuItem.Click += sairDaContaToolStripMenuItem_Click;
			// 
			// sairParaOWindowsToolStripMenuItem
			// 
			sairParaOWindowsToolStripMenuItem.Name = "sairParaOWindowsToolStripMenuItem";
			sairParaOWindowsToolStripMenuItem.Size = new Size(181, 22);
			sairParaOWindowsToolStripMenuItem.Text = "Sair para o &Windows";
			sairParaOWindowsToolStripMenuItem.Click += sairParaOWindowsToolStripMenuItem_Click;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Location = new Point(55, 61);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 6;
			label1.Text = "Pesquisar:";
			// 
			// btnAdicionar
			// 
			btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAdicionar.Location = new Point(491, 57);
			btnAdicionar.Name = "btnAdicionar";
			btnAdicionar.Size = new Size(20, 22);
			btnAdicionar.TabIndex = 3;
			btnAdicionar.Text = "+";
			btnAdicionar.UseVisualStyleBackColor = true;
			btnAdicionar.Click += btnAdicionar_Click;
			// 
			// dtpLimite
			// 
			dtpLimite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			dtpLimite.Format = DateTimePickerFormat.Short;
			dtpLimite.Location = new Point(355, 55);
			dtpLimite.Name = "dtpLimite";
			dtpLimite.Size = new Size(114, 23);
			dtpLimite.TabIndex = 2;
			// 
			// txtPesquisa
			// 
			txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtPesquisa.Location = new Point(121, 55);
			txtPesquisa.Name = "txtPesquisa";
			txtPesquisa.Size = new Size(220, 23);
			txtPesquisa.TabIndex = 1;
			txtPesquisa.KeyUp += txtPesquisa_KeyUp;
			// 
			// clbTarefas
			// 
			clbTarefas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			clbTarefas.FormattingEnabled = true;
			clbTarefas.Location = new Point(35, 154);
			clbTarefas.Name = "clbTarefas";
			clbTarefas.Size = new Size(489, 292);
			clbTarefas.TabIndex = 0;
			clbTarefas.ItemCheck += clbTarefas_ItemCheck;
			// 
			// FormPrincipal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(559, 492);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			MinimumSize = new Size(575, 531);
			Name = "FormPrincipal";
			Text = "Gestão tarefas";
			FormClosing += FormPrincipal_FormClosing;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
        private CheckedListBox clbTarefas;
        private Button btnAdicionar;
        private DateTimePicker dtpLimite;
        private TextBox txtPesquisa;
        private RadioButton radNaoConcluidas;
        private Label label1;
		private StatusStrip statusStrip1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem sairToolStripMenuItem;
		private ToolStripMenuItem sairDaContaToolStripMenuItem;
		private ToolStripMenuItem sairParaOWindowsToolStripMenuItem;
		private Label lblError;
		private ToolStripStatusLabel tlsUsuario;
		private RadioButton radTodas;
		private GroupBox groupBox1;
	}
}
