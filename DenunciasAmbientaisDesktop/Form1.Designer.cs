namespace DenunciasAmbientaisDesktop
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
            btnEnviar = new Button();
            txfDescricao = new TextBox();
            lblDescricao = new Label();
            lblTipo = new Label();
            comboBoxTipo = new ComboBox();
            lblLocal = new Label();
            txfLocal = new TextBox();
            lblFoto = new Label();
            btnFoto = new Button();
            openFileDialog1 = new OpenFileDialog();
            lblFotoEnviada = new Label();
            lblObrigatorio = new Label();
            lblFormulario = new Label();
            lblFormulario2 = new Label();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(338, 399);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(133, 39);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar denúncia!";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txfDescricao
            // 
            txfDescricao.Location = new Point(199, 79);
            txfDescricao.Multiline = true;
            txfDescricao.Name = "txfDescricao";
            txfDescricao.Size = new Size(522, 76);
            txfDescricao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(46, 79);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(134, 15);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição da denúncia*:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(46, 185);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(106, 15);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo da denúncia*:";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(199, 185);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(230, 23);
            comboBoxTipo.TabIndex = 4;
            comboBoxTipo.SelectedIndexChanged += comboBoxTipo_SelectedIndexChanged;
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Location = new Point(46, 248);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(111, 15);
            lblLocal.TabIndex = 5;
            lblLocal.Text = "Local da denúncia*:";
            // 
            // txfLocal
            // 
            txfLocal.Location = new Point(199, 248);
            txfLocal.Name = "txfLocal";
            txfLocal.Size = new Size(522, 23);
            txfLocal.TabIndex = 6;
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Location = new Point(46, 306);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(107, 15);
            lblFoto.TabIndex = 8;
            lblFoto.Text = "Foto da denúncia*:";
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(199, 306);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(176, 37);
            btnFoto.TabIndex = 9;
            btnFoto.Text = "Adicionar foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
            // 
            // lblFotoEnviada
            // 
            lblFotoEnviada.AutoSize = true;
            lblFotoEnviada.Location = new Point(401, 306);
            lblFotoEnviada.Name = "lblFotoEnviada";
            lblFotoEnviada.Size = new Size(0, 15);
            lblFotoEnviada.TabIndex = 10;
            // 
            // lblObrigatorio
            // 
            lblObrigatorio.AutoSize = true;
            lblObrigatorio.Location = new Point(48, 423);
            lblObrigatorio.Name = "lblObrigatorio";
            lblObrigatorio.Size = new Size(124, 15);
            lblObrigatorio.TabIndex = 11;
            lblObrigatorio.Text = "(*) Campo obrigatório";
            // 
            // lblFormulario
            // 
            lblFormulario.AutoSize = true;
            lblFormulario.Location = new Point(243, 9);
            lblFormulario.Name = "lblFormulario";
            lblFormulario.Size = new Size(328, 15);
            lblFormulario.TabIndex = 12;
            lblFormulario.Text = "Bem vindo ao formulário para envio de denúncias anônimas!";
            // 
            // lblFormulario2
            // 
            lblFormulario2.AutoSize = true;
            lblFormulario2.Location = new Point(251, 27);
            lblFormulario2.Name = "lblFormulario2";
            lblFormulario2.Size = new Size(314, 15);
            lblFormulario2.TabIndex = 13;
            lblFormulario2.Text = "Preencha as informações abaixo para enviar sua denúncia!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFormulario2);
            Controls.Add(lblFormulario);
            Controls.Add(lblObrigatorio);
            Controls.Add(lblFotoEnviada);
            Controls.Add(btnFoto);
            Controls.Add(lblFoto);
            Controls.Add(txfLocal);
            Controls.Add(lblLocal);
            Controls.Add(comboBoxTipo);
            Controls.Add(lblTipo);
            Controls.Add(lblDescricao);
            Controls.Add(txfDescricao);
            Controls.Add(btnEnviar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de denúncias ambientais anônimas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private TextBox txfDescricao;
        private Label lblDescricao;
        private Label lblTipo;
        private ComboBox comboBoxTipo;
        private Label lblLocal;
        private TextBox txfLocal;
        private Label lblFoto;
        private Button btnFoto;
        private OpenFileDialog openFileDialog1;
        private Label lblFotoEnviada;
        private Label lblObrigatorio;
        private Label lblFormulario;
        private Label lblFormulario2;
    }
}