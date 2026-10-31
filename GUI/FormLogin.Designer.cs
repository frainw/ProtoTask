namespace ProtoTask.GUI
{
    partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			panel1 = new Panel();
			lblError = new Label();
			btnEntrar = new Button();
			txtSenha = new TextBox();
			txtUsuario = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel1.Controls.Add(lblError);
			panel1.Controls.Add(btnEntrar);
			panel1.Controls.Add(txtSenha);
			panel1.Controls.Add(txtUsuario);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(325, 297);
			panel1.TabIndex = 0;
			// 
			// lblError
			// 
			lblError.AutoSize = true;
			lblError.BackColor = SystemColors.Control;
			lblError.ForeColor = Color.Red;
			lblError.Location = new Point(45, 197);
			lblError.Name = "lblError";
			lblError.Size = new Size(154, 15);
			lblError.TabIndex = 1;
			lblError.Text = "Usuario ou senha incorretos";
			lblError.Visible = false;
			// 
			// btnEntrar
			// 
			btnEntrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnEntrar.Location = new Point(196, 232);
			btnEntrar.Name = "btnEntrar";
			btnEntrar.Size = new Size(75, 23);
			btnEntrar.TabIndex = 5;
			btnEntrar.Text = "Entrar";
			btnEntrar.UseVisualStyleBackColor = true;
			btnEntrar.Click += btnEntrar_Click;
			// 
			// txtSenha
			// 
			txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtSenha.Location = new Point(45, 162);
			txtSenha.Name = "txtSenha";
			txtSenha.PasswordChar = '●';
			txtSenha.Size = new Size(226, 23);
			txtSenha.TabIndex = 4;
			txtSenha.KeyDown += txtSenha_KeyDown;
			// 
			// txtUsuario
			// 
			txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtUsuario.Location = new Point(45, 105);
			txtUsuario.Name = "txtUsuario";
			txtUsuario.Size = new Size(226, 23);
			txtUsuario.TabIndex = 3;
			txtUsuario.KeyDown += txtUsuario_KeyDown;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Location = new Point(45, 144);
			label3.Name = "label3";
			label3.Size = new Size(42, 15);
			label3.TabIndex = 2;
			label3.Text = "Senha:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(45, 87);
			label2.Name = "label2";
			label2.Size = new Size(50, 15);
			label2.TabIndex = 1;
			label2.Text = "Usuario:";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(111, 28);
			label1.Name = "label1";
			label1.Size = new Size(101, 45);
			label1.TabIndex = 0;
			label1.Text = "Login";
			// 
			// FormLogin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(349, 321);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(365, 360);
			MinimumSize = new Size(365, 360);
			Name = "FormLogin";
			Text = "Login";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button btnEntrar;
        private TextBox txtSenha;
        private TextBox txtUsuario;
		private Label lblError;
	}
}