namespace ByteSoftRelatorio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Visualizar = new System.Windows.Forms.Button();
            this.Novo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SelecionarArquivo = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSELECIONAR = new System.Windows.Forms.Button();
            this.txtCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnloading = new System.Windows.Forms.Button();
            this.Processar = new System.Windows.Forms.TabPage();
            this.VisualizarDados = new System.Windows.Forms.TabPage();
            this.btnExportar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.rbDEC = new System.Windows.Forms.RadioButton();
            this.rbACR = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fClassificar = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.fOperador = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.fUsuario = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.fLoja = new System.Windows.Forms.ComboBox();
            this.pStatus = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.fStatus = new System.Windows.Forms.Button();
            this.fSelecionar = new System.Windows.Forms.ComboBox();
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Gif = new System.Windows.Forms.Timer(this.components);
            this.bgwStyle = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SelecionarArquivo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.VisualizarDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pStatus.SuspendLayout();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.Visualizar);
            this.panel1.Controls.Add(this.Novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 100);
            this.panel1.TabIndex = 0;
            // 
            // Visualizar
            // 
            this.Visualizar.FlatAppearance.BorderSize = 0;
            this.Visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visualizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Visualizar.Image = ((System.Drawing.Image)(resources.GetObject("Visualizar.Image")));
            this.Visualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Visualizar.Location = new System.Drawing.Point(108, 74);
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.Size = new System.Drawing.Size(145, 23);
            this.Visualizar.TabIndex = 0;
            this.Visualizar.Text = "Visualizar último relatório";
            this.Visualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Visualizar.UseVisualStyleBackColor = true;
            this.Visualizar.Click += new System.EventHandler(this.Visualizar_Click);
            // 
            // Novo
            // 
            this.Novo.FlatAppearance.BorderSize = 0;
            this.Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Novo.ForeColor = System.Drawing.Color.Gainsboro;
            this.Novo.Image = ((System.Drawing.Image)(resources.GetObject("Novo.Image")));
            this.Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Novo.Location = new System.Drawing.Point(7, 74);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(95, 23);
            this.Novo.TabIndex = 0;
            this.Novo.Text = "Novo relatório";
            this.Novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(0, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1043, 11);
            this.label1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.SelecionarArquivo);
            this.tabControl1.Controls.Add(this.Processar);
            this.tabControl1.Controls.Add(this.VisualizarDados);
            this.tabControl1.Location = new System.Drawing.Point(-5, -26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 550);
            this.tabControl1.TabIndex = 2;
            // 
            // SelecionarArquivo
            // 
            this.SelecionarArquivo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SelecionarArquivo.Controls.Add(this.groupBox1);
            this.SelecionarArquivo.Location = new System.Drawing.Point(4, 22);
            this.SelecionarArquivo.Name = "SelecionarArquivo";
            this.SelecionarArquivo.Padding = new System.Windows.Forms.Padding(3);
            this.SelecionarArquivo.Size = new System.Drawing.Size(1021, 524);
            this.SelecionarArquivo.TabIndex = 0;
            this.SelecionarArquivo.Text = "SelecionarArquivo";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSELECIONAR);
            this.groupBox1.Controls.Add(this.txtCaminhoArquivo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnloading);
            this.groupBox1.Location = new System.Drawing.Point(278, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 183);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(38, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Passo-a-passo:";
            // 
            // btnSELECIONAR
            // 
            this.btnSELECIONAR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSELECIONAR.BackColor = System.Drawing.Color.White;
            this.btnSELECIONAR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSELECIONAR.BackgroundImage")));
            this.btnSELECIONAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSELECIONAR.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSELECIONAR.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSELECIONAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnSELECIONAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSELECIONAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSELECIONAR.ForeColor = System.Drawing.Color.DimGray;
            this.btnSELECIONAR.Image = global::ByteSoftRelatorio.Properties.Resources.icons8_pasta_de_pesquisa_24;
            this.btnSELECIONAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSELECIONAR.Location = new System.Drawing.Point(122, 109);
            this.btnSELECIONAR.Margin = new System.Windows.Forms.Padding(3, 43, 3, 3);
            this.btnSELECIONAR.Name = "btnSELECIONAR";
            this.btnSELECIONAR.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnSELECIONAR.Size = new System.Drawing.Size(220, 45);
            this.btnSELECIONAR.TabIndex = 4;
            this.btnSELECIONAR.Text = "SELECIONAR ARQUIVO";
            this.btnSELECIONAR.UseVisualStyleBackColor = false;
            this.btnSELECIONAR.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtCaminhoArquivo
            // 
            this.txtCaminhoArquivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCaminhoArquivo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCaminhoArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhoArquivo.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(43, 74);
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.ReadOnly = true;
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(378, 22);
            this.txtCaminhoArquivo.TabIndex = 5;
            this.txtCaminhoArquivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCaminhoArquivo.TextChanged += new System.EventHandler(this.txtCaminhoArquivo_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(37, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Passo-a-passo:      1° Gere o relatório no PROCFIT. 2° Remova a barra de títulos " +
    "e barra de totalizadores. 3° Salve o arquivo com extensões (*.txt ou *.csv ).";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnloading
            // 
            this.btnloading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnloading.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnloading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnloading.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnloading.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnloading.FlatAppearance.BorderSize = 0;
            this.btnloading.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnloading.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnloading.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnloading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloading.ForeColor = System.Drawing.Color.DimGray;
            this.btnloading.Image = global::ByteSoftRelatorio.Properties.Resources.loop;
            this.btnloading.Location = new System.Drawing.Point(348, 109);
            this.btnloading.Margin = new System.Windows.Forms.Padding(3, 43, 3, 3);
            this.btnloading.Name = "btnloading";
            this.btnloading.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnloading.Size = new System.Drawing.Size(34, 45);
            this.btnloading.TabIndex = 4;
            this.btnloading.UseVisualStyleBackColor = false;
            this.btnloading.Visible = false;
            this.btnloading.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Processar
            // 
            this.Processar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Processar.Location = new System.Drawing.Point(4, 22);
            this.Processar.Name = "Processar";
            this.Processar.Padding = new System.Windows.Forms.Padding(3);
            this.Processar.Size = new System.Drawing.Size(1021, 524);
            this.Processar.TabIndex = 1;
            this.Processar.Text = "Processar";
            // 
            // VisualizarDados
            // 
            this.VisualizarDados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.VisualizarDados.Controls.Add(this.btnExportar);
            this.VisualizarDados.Controls.Add(this.pictureBox3);
            this.VisualizarDados.Controls.Add(this.pictureBox2);
            this.VisualizarDados.Controls.Add(this.pictureBox1);
            this.VisualizarDados.Controls.Add(this.btnAtualizar);
            this.VisualizarDados.Controls.Add(this.rbDEC);
            this.VisualizarDados.Controls.Add(this.rbACR);
            this.VisualizarDados.Controls.Add(this.button3);
            this.VisualizarDados.Controls.Add(this.label5);
            this.VisualizarDados.Controls.Add(this.label4);
            this.VisualizarDados.Controls.Add(this.fClassificar);
            this.VisualizarDados.Controls.Add(this.label19);
            this.VisualizarDados.Controls.Add(this.panel8);
            this.VisualizarDados.Controls.Add(this.panel3);
            this.VisualizarDados.Controls.Add(this.panel6);
            this.VisualizarDados.Controls.Add(this.pStatus);
            this.VisualizarDados.Controls.Add(this.DgvDados);
            this.VisualizarDados.Location = new System.Drawing.Point(4, 22);
            this.VisualizarDados.Name = "VisualizarDados";
            this.VisualizarDados.Size = new System.Drawing.Size(1021, 524);
            this.VisualizarDados.TabIndex = 2;
            this.VisualizarDados.Text = "VisualizarDados";
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.AutoSize = true;
            this.btnExportar.BackColor = System.Drawing.Color.White;
            this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnExportar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.ForeColor = System.Drawing.Color.DimGray;
            this.btnExportar.Image = global::ByteSoftRelatorio.Properties.Resources.salvar__2_;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.Location = new System.Drawing.Point(835, 494);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(3, 43, 3, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(88, 25);
            this.btnExportar.TabIndex = 158;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = global::ByteSoftRelatorio.Properties.Resources.status4;
            this.pictureBox3.Location = new System.Drawing.Point(105, 496);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 158;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::ByteSoftRelatorio.Properties.Resources.status3;
            this.pictureBox2.Location = new System.Drawing.Point(228, 496);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 158;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::ByteSoftRelatorio.Properties.Resources.status0;
            this.pictureBox1.Location = new System.Drawing.Point(5, 496);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 158;
            this.pictureBox1.TabStop = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.AutoSize = true;
            this.btnAtualizar.BackColor = System.Drawing.Color.White;
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAtualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.Color.DimGray;
            this.btnAtualizar.Image = global::ByteSoftRelatorio.Properties.Resources.restaurar;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.Location = new System.Drawing.Point(931, 494);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 43, 3, 3);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(86, 25);
            this.btnAtualizar.TabIndex = 157;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // rbDEC
            // 
            this.rbDEC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDEC.AutoSize = true;
            this.rbDEC.ForeColor = System.Drawing.Color.Gray;
            this.rbDEC.Location = new System.Drawing.Point(931, 35);
            this.rbDEC.Name = "rbDEC";
            this.rbDEC.Size = new System.Drawing.Size(86, 17);
            this.rbDEC.TabIndex = 156;
            this.rbDEC.TabStop = true;
            this.rbDEC.Text = "Decrescente";
            this.rbDEC.UseVisualStyleBackColor = true;
            this.rbDEC.CheckedChanged += new System.EventHandler(this.rbACR_CheckedChanged);
            // 
            // rbACR
            // 
            this.rbACR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbACR.AutoSize = true;
            this.rbACR.Checked = true;
            this.rbACR.ForeColor = System.Drawing.Color.Gray;
            this.rbACR.Location = new System.Drawing.Point(846, 35);
            this.rbACR.Name = "rbACR";
            this.rbACR.Size = new System.Drawing.Size(79, 17);
            this.rbACR.TabIndex = 156;
            this.rbACR.TabStop = true;
            this.rbACR.Text = "Acrescente";
            this.rbACR.UseVisualStyleBackColor = true;
            this.rbACR.CheckedChanged += new System.EventHandler(this.rbACR_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.DarkGray;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 8;
            this.button3.Location = new System.Drawing.Point(757, 54);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 21);
            this.button3.TabIndex = 14;
            this.button3.Text = "Classificar por:";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(238, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 152;
            this.label5.Text = "Acima da média";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(116, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 152;
            this.label4.Text = "Nenhuma ocorrência";
            // 
            // fClassificar
            // 
            this.fClassificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fClassificar.BackColor = System.Drawing.SystemColors.Window;
            this.fClassificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fClassificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fClassificar.ForeColor = System.Drawing.Color.DarkGray;
            this.fClassificar.FormattingEnabled = true;
            this.fClassificar.Items.AddRange(new object[] {
            "Usuário",
            "Operador",
            "Loja",
            "Cancelado",
            "Estornado",
            "Devolvido",
            "Finalizado",
            "Cancelamento %"});
            this.fClassificar.Location = new System.Drawing.Point(846, 54);
            this.fClassificar.Margin = new System.Windows.Forms.Padding(5);
            this.fClassificar.Name = "fClassificar";
            this.fClassificar.Size = new System.Drawing.Size(171, 21);
            this.fClassificar.TabIndex = 85;
            this.fClassificar.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(15, 495);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 13);
            this.label19.TabIndex = 152;
            this.label19.Text = "Abaixo da média";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(472, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(150, 65);
            this.panel8.TabIndex = 21;
            this.panel8.Visible = false;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.button1);
            this.panel9.Controls.Add(this.fOperador);
            this.panel9.Location = new System.Drawing.Point(1, 1);
            this.panel9.Margin = new System.Windows.Forms.Padding(1);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(5);
            this.panel9.Size = new System.Drawing.Size(148, 63);
            this.panel9.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 8;
            this.button1.Location = new System.Drawing.Point(5, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 21);
            this.button1.TabIndex = 14;
            this.button1.Text = "Operador";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // fOperador
            // 
            this.fOperador.BackColor = System.Drawing.SystemColors.Window;
            this.fOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fOperador.ForeColor = System.Drawing.Color.DarkGray;
            this.fOperador.Location = new System.Drawing.Point(11, 31);
            this.fOperador.Margin = new System.Windows.Forms.Padding(5);
            this.fOperador.MaxLength = 10;
            this.fOperador.Name = "fOperador";
            this.fOperador.Size = new System.Drawing.Size(127, 20);
            this.fOperador.TabIndex = 86;
            this.fOperador.TextChanged += new System.EventHandler(this.fOperador_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(316, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 65);
            this.panel3.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.fUsuario);
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(1);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(148, 63);
            this.panel5.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DarkGray;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 8;
            this.button2.Location = new System.Drawing.Point(5, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 21);
            this.button2.TabIndex = 14;
            this.button2.Text = "Usuário";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // fUsuario
            // 
            this.fUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.fUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.fUsuario.Location = new System.Drawing.Point(11, 31);
            this.fUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.fUsuario.MaxLength = 10;
            this.fUsuario.Name = "fUsuario";
            this.fUsuario.Size = new System.Drawing.Size(127, 20);
            this.fUsuario.TabIndex = 86;
            this.fUsuario.TextChanged += new System.EventHandler(this.txtFcep_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(160, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 65);
            this.panel6.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.fLoja);
            this.panel7.Location = new System.Drawing.Point(1, 1);
            this.panel7.Margin = new System.Windows.Forms.Padding(1);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(5);
            this.panel7.Size = new System.Drawing.Size(148, 63);
            this.panel7.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.DarkGray;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 8;
            this.button4.Location = new System.Drawing.Point(5, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 21);
            this.button4.TabIndex = 14;
            this.button4.Text = "Loja";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // fLoja
            // 
            this.fLoja.BackColor = System.Drawing.SystemColors.Window;
            this.fLoja.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fLoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fLoja.ForeColor = System.Drawing.Color.DimGray;
            this.fLoja.FormattingEnabled = true;
            this.fLoja.Location = new System.Drawing.Point(11, 31);
            this.fLoja.Margin = new System.Windows.Forms.Padding(5);
            this.fLoja.Name = "fLoja";
            this.fLoja.Size = new System.Drawing.Size(127, 21);
            this.fLoja.TabIndex = 85;
            this.fLoja.SelectionChangeCommitted += new System.EventHandler(this.fLoja_SelectionChangeCommitted);
            this.fLoja.TextChanged += new System.EventHandler(this.fLoja_TextChanged);
            // 
            // pStatus
            // 
            this.pStatus.BackColor = System.Drawing.Color.LightGray;
            this.pStatus.Controls.Add(this.Panel4);
            this.pStatus.Location = new System.Drawing.Point(4, 12);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(150, 65);
            this.pStatus.TabIndex = 21;
            // 
            // Panel4
            // 
            this.Panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel4.BackgroundImage")));
            this.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel4.Controls.Add(this.fStatus);
            this.Panel4.Controls.Add(this.fSelecionar);
            this.Panel4.Location = new System.Drawing.Point(1, 1);
            this.Panel4.Margin = new System.Windows.Forms.Padding(1);
            this.Panel4.Name = "Panel4";
            this.Panel4.Padding = new System.Windows.Forms.Padding(5);
            this.Panel4.Size = new System.Drawing.Size(148, 63);
            this.Panel4.TabIndex = 1;
            // 
            // fStatus
            // 
            this.fStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fStatus.BackColor = System.Drawing.Color.Transparent;
            this.fStatus.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.fStatus.FlatAppearance.BorderSize = 0;
            this.fStatus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.fStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fStatus.ForeColor = System.Drawing.Color.DarkGray;
            this.fStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fStatus.ImageIndex = 8;
            this.fStatus.Location = new System.Drawing.Point(5, 4);
            this.fStatus.Margin = new System.Windows.Forms.Padding(0);
            this.fStatus.Name = "fStatus";
            this.fStatus.Size = new System.Drawing.Size(137, 21);
            this.fStatus.TabIndex = 14;
            this.fStatus.Text = "Selecionar";
            this.fStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fStatus.UseVisualStyleBackColor = false;
            // 
            // fSelecionar
            // 
            this.fSelecionar.BackColor = System.Drawing.SystemColors.Window;
            this.fSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fSelecionar.ForeColor = System.Drawing.Color.DimGray;
            this.fSelecionar.FormattingEnabled = true;
            this.fSelecionar.Items.AddRange(new object[] {
            "Tudo",
            "Top 10  maior %",
            "Top 10 menor %",
            "Acima da média",
            "Abaixo da média"});
            this.fSelecionar.Location = new System.Drawing.Point(11, 31);
            this.fSelecionar.Margin = new System.Windows.Forms.Padding(5);
            this.fSelecionar.Name = "fSelecionar";
            this.fSelecionar.Size = new System.Drawing.Size(127, 21);
            this.fSelecionar.TabIndex = 85;
            this.fSelecionar.SelectionChangeCommitted += new System.EventHandler(this.fSelecionar_SelectionChangeCommitted);
            // 
            // DgvDados
            // 
            this.DgvDados.AllowUserToAddRows = false;
            this.DgvDados.AllowUserToDeleteRows = false;
            this.DgvDados.AllowUserToResizeColumns = false;
            this.DgvDados.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gray;
            this.DgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDados.BackgroundColor = System.Drawing.Color.White;
            this.DgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvDados.ColumnHeadersHeight = 25;
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDados.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvDados.EnableHeadersVisualStyles = false;
            this.DgvDados.GridColor = System.Drawing.Color.White;
            this.DgvDados.Location = new System.Drawing.Point(3, 83);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.ReadOnly = true;
            this.DgvDados.RowHeadersVisible = false;
            this.DgvDados.RowHeadersWidth = 60;
            this.DgvDados.RowTemplate.Height = 25;
            this.DgvDados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDados.Size = new System.Drawing.Size(1014, 407);
            this.DgvDados.TabIndex = 19;
            this.DgvDados.DataSourceChanged += new System.EventHandler(this.DgvDados_DataSourceChanged);
            this.DgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDados_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Image = global::ByteSoftRelatorio.Properties.Resources.transparente;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(12, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 518);
            this.panel2.TabIndex = 3;
            // 
            // bgwStyle
            // 
            this.bgwStyle.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwStyle_DoWork);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ByteSoftRelatorio.Properties.Resources.transparente;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1043, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ByteSoft - Gerador de relatórios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.SelecionarArquivo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.VisualizarDados.ResumeLayout(false);
            this.VisualizarDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pStatus.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SelecionarArquivo;
        private System.Windows.Forms.TabPage Processar;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button btnSELECIONAR;
        private System.Windows.Forms.TextBox txtCaminhoArquivo;
        private System.Windows.Forms.TabPage VisualizarDados;
        public System.Windows.Forms.DataGridView DgvDados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.TextBox fUsuario;
        internal System.Windows.Forms.Panel pStatus;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Button fStatus;
        internal System.Windows.Forms.ComboBox fSelecionar;
        internal System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.ComboBox fClassificar;
        internal System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Panel panel7;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.ComboBox fLoja;
        private System.Windows.Forms.RadioButton rbDEC;
        private System.Windows.Forms.RadioButton rbACR;
        internal System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Gif;
        public System.ComponentModel.BackgroundWorker bgwStyle;
        internal System.Windows.Forms.Button btnloading;
        private System.Windows.Forms.Button Visualizar;
        private System.Windows.Forms.Button Novo;
        internal System.Windows.Forms.Button btnExportar;
        internal System.Windows.Forms.Panel panel8;
        internal System.Windows.Forms.Panel panel9;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.TextBox fOperador;
    }
}

