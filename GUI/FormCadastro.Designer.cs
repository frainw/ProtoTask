namespace ProtoTask
{
	partial class FormCadastro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
			txtUsuario = new TextBox();
			txtSenha = new TextBox();
			btnConfirmar = new Button();
			btnLimpar = new Button();
			lblUsuario = new Label();
			lblSenha = new Label();
			lblError = new Label();
			pictureBox1 = new PictureBox();
			btnCancelar = new Button();
			btnRevelar = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// txtUsuario
			// 
			txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtUsuario.Location = new Point(34, 135);
			txtUsuario.Name = "txtUsuario";
			txtUsuario.Size = new Size(329, 23);
			txtUsuario.TabIndex = 0;
			txtUsuario.KeyDown += txtUsuario_KeyDown;
			// 
			// txtSenha
			// 
			txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtSenha.Location = new Point(34, 188);
			txtSenha.Name = "txtSenha";
			txtSenha.PasswordChar = '•';
			txtSenha.Size = new Size(329, 23);
			txtSenha.TabIndex = 1;
			txtSenha.KeyDown += txtSenha_KeyDown;
			// 
			// btnConfirmar
			// 
			btnConfirmar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnConfirmar.Location = new Point(34, 262);
			btnConfirmar.Name = "btnConfirmar";
			btnConfirmar.Size = new Size(75, 23);
			btnConfirmar.TabIndex = 2;
			btnConfirmar.Text = "Confirmar";
			btnConfirmar.UseVisualStyleBackColor = true;
			btnConfirmar.Click += btnConfirmar_Click;
			// 
			// btnLimpar
			// 
			btnLimpar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnLimpar.Location = new Point(132, 262);
			btnLimpar.Name = "btnLimpar";
			btnLimpar.Size = new Size(75, 23);
			btnLimpar.TabIndex = 3;
			btnLimpar.Text = "Limpar";
			btnLimpar.UseVisualStyleBackColor = true;
			btnLimpar.Click += btnLimpar_Click;
			// 
			// lblUsuario
			// 
			lblUsuario.AutoSize = true;
			lblUsuario.Location = new Point(34, 117);
			lblUsuario.Name = "lblUsuario";
			lblUsuario.Size = new Size(47, 15);
			lblUsuario.TabIndex = 4;
			lblUsuario.Text = "Usuario";
			// 
			// lblSenha
			// 
			lblSenha.AutoSize = true;
			lblSenha.Location = new Point(34, 170);
			lblSenha.Name = "lblSenha";
			lblSenha.Size = new Size(39, 15);
			lblSenha.TabIndex = 5;
			lblSenha.Text = "Senha";
			// 
			// lblError
			// 
			lblError.AutoSize = true;
			lblError.ForeColor = Color.Red;
			lblError.Location = new Point(34, 214);
			lblError.Name = "lblError";
			lblError.Size = new Size(250, 15);
			lblError.TabIndex = 6;
			lblError.Text = "Usuario indisponivel tente outra combinação!!";
			lblError.Visible = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(34, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(102, 92);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 7;
			pictureBox1.TabStop = false;
			// 
			// btnCancelar
			// 
			btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnCancelar.Location = new Point(230, 262);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(75, 23);
			btnCancelar.TabIndex = 8;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// btnRevelar
			// 
			btnRevelar.BackColor = Color.Transparent;
			btnRevelar.Location = new Point(340, 187);
			btnRevelar.Name = "btnRevelar";
			btnRevelar.Size = new Size(23, 23);
			btnRevelar.TabIndex = 9;
			btnRevelar.Text = "👁️";
			btnRevelar.UseVisualStyleBackColor = false;
			btnRevelar.Click += btnRevelar_Click;
			// 
			// FormCadastro
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(512, 335);
			Controls.Add(btnRevelar);
			Controls.Add(btnCancelar);
			Controls.Add(pictureBox1);
			Controls.Add(lblError);
			Controls.Add(lblSenha);
			Controls.Add(lblUsuario);
			Controls.Add(btnLimpar);
			Controls.Add(btnConfirmar);
			Controls.Add(txtSenha);
			Controls.Add(txtUsuario);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(528, 374);
			MinimumSize = new Size(528, 374);
			Name = "FormCadastro";
			Text = "Cadastro";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtUsuario;
		private TextBox txtSenha;
		private Button btnConfirmar;
		private Button btnLimpar;
		private Label lblUsuario;
		private Label lblSenha;
		private Label lblError;
		private PictureBox pictureBox1;
		private Button btnCancelar;
		private Button btnRevelar;
	}
}