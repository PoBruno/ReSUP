namespace ReSUP_v1._2
{
    partial class Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /*
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
        */


        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idAtividadeLabel;
            System.Windows.Forms.Label idTecnicoLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PagTeamViewer = new System.Windows.Forms.TabPage();
            this.idTecnicoLabel2 = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSet1 = new ReSUP_v1._2.DBSet();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.ComandoTV = new System.Windows.Forms.Label();
            this.fKTeamVieweidClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConecatrTVButton = new System.Windows.Forms.Button();
            this.teamViewerDataGridView = new System.Windows.Forms.DataGridView();
            this.idTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nomeComboBox = new System.Windows.Forms.ComboBox();
            this.teamViewerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PagCadastros = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabCadCliente = new System.Windows.Forms.TabPage();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tecnicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabCadTecnico = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.clienteDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKClienteidTecnicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tecnicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagAtividade = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.idTVTextBox = new System.Windows.Forms.TextBox();
            this.fKAtividadeidClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.idTecnicoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idAtividadeListBox = new System.Windows.Forms.ListBox();
            this.atividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.situacaoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.descricao1TextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.descricao2TextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.created_atListBox = new System.Windows.Forms.ListBox();
            this.atividadeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dBSet = new ReSUP_v1._2.DBSet();
            this.atividadeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tecnicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atividadeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.salvarcomoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteTableAdapter = new ReSUP_v1._2.DBSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new ReSUP_v1._2.DBSetTableAdapters.TableAdapterManager();
            this.teamViewerTableAdapter = new ReSUP_v1._2.DBSetTableAdapters.TeamViewerTableAdapter();
            this.atividadeTableAdapter = new ReSUP_v1._2.DBSetTableAdapters.AtividadeTableAdapter();
            this.tecnicoTableAdapter = new ReSUP_v1._2.DBSetTableAdapters.TecnicoTableAdapter();
            this.fKAtividadeidTecnicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKClienteidTecnicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.atividadeDataGridView = new System.Windows.Forms.DataGridView();
            this.fKAtividadeidClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKAtividadeidClienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idAtividadeLabel = new System.Windows.Forms.Label();
            idTecnicoLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.PagTeamViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTeamVieweidClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamViewerDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamViewerBindingSource)).BeginInit();
            this.PagCadastros.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabCadCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            this.tabCadTecnico.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteidTecnicoBindingSource1)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicoDataGridView)).BeginInit();
            this.PagAtividade.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKAtividadeidClienteBindingSource)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKAtividadeidTecnicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteidTecnicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAtividadeidClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAtividadeidClienteBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // idAtividadeLabel
            // 
            idAtividadeLabel.AutoSize = true;
            idAtividadeLabel.Location = new System.Drawing.Point(304, 26);
            idAtividadeLabel.Name = "idAtividadeLabel";
            idAtividadeLabel.Size = new System.Drawing.Size(0, 13);
            idAtividadeLabel.TabIndex = 1;
            // 
            // idTecnicoLabel1
            // 
            idTecnicoLabel1.AutoSize = true;
            idTecnicoLabel1.Location = new System.Drawing.Point(13, 64);
            idTecnicoLabel1.Name = "idTecnicoLabel1";
            idTecnicoLabel1.Size = new System.Drawing.Size(123, 13);
            idTecnicoLabel1.TabIndex = 6;
            idTecnicoLabel1.Text = "ID Tecnico responsável:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.PagTeamViewer);
            this.tabControl1.Controls.Add(this.PagCadastros);
            this.tabControl1.Controls.Add(this.PagAtividade);
            this.tabControl1.Location = new System.Drawing.Point(9, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // PagTeamViewer
            // 
            this.PagTeamViewer.AutoScroll = true;
            this.PagTeamViewer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PagTeamViewer.Controls.Add(idTecnicoLabel1);
            this.PagTeamViewer.Controls.Add(this.idTecnicoLabel2);
            this.PagTeamViewer.Controls.Add(this.commentTextBox);
            this.PagTeamViewer.Controls.Add(this.ComandoTV);
            this.PagTeamViewer.Controls.Add(this.ConecatrTVButton);
            this.PagTeamViewer.Controls.Add(this.teamViewerDataGridView);
            this.PagTeamViewer.Controls.Add(this.groupBox1);
            this.PagTeamViewer.Location = new System.Drawing.Point(4, 22);
            this.PagTeamViewer.Name = "PagTeamViewer";
            this.PagTeamViewer.Padding = new System.Windows.Forms.Padding(3);
            this.PagTeamViewer.Size = new System.Drawing.Size(793, 522);
            this.PagTeamViewer.TabIndex = 0;
            this.PagTeamViewer.Text = "TeamViewer";
            // 
            // idTecnicoLabel2
            // 
            this.idTecnicoLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "idTecnico", true));
            this.idTecnicoLabel2.Location = new System.Drawing.Point(132, 64);
            this.idTecnicoLabel2.Name = "idTecnicoLabel2";
            this.idTecnicoLabel2.Size = new System.Drawing.Size(41, 19);
            this.idTecnicoLabel2.TabIndex = 7;
            this.idTecnicoLabel2.Text = "label1";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dBSet1;
            // 
            // dBSet1
            // 
            this.dBSet1.DataSetName = "DBSet";
            this.dBSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.commentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(304, 15);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(329, 44);
            this.commentTextBox.TabIndex = 6;
            // 
            // ComandoTV
            // 
            this.ComandoTV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComandoTV.BackColor = System.Drawing.Color.Transparent;
            this.ComandoTV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKTeamVieweidClienteBindingSource, "ComandoTV", true));
            this.ComandoTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComandoTV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ComandoTV.Location = new System.Drawing.Point(578, 505);
            this.ComandoTV.Name = "ComandoTV";
            this.ComandoTV.Size = new System.Drawing.Size(203, 14);
            this.ComandoTV.TabIndex = 4;
            this.ComandoTV.Text = "label1";
            this.ComandoTV.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // fKTeamVieweidClienteBindingSource
            // 
            this.fKTeamVieweidClienteBindingSource.DataMember = "FK_TeamViewe_idCliente";
            this.fKTeamVieweidClienteBindingSource.DataSource = this.clienteBindingSource;
            // 
            // ConecatrTVButton
            // 
            this.ConecatrTVButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConecatrTVButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ConecatrTVButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ConecatrTVButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConecatrTVButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConecatrTVButton.Image = ((System.Drawing.Image)(resources.GetObject("ConecatrTVButton.Image")));
            this.ConecatrTVButton.Location = new System.Drawing.Point(648, 21);
            this.ConecatrTVButton.Name = "ConecatrTVButton";
            this.ConecatrTVButton.Size = new System.Drawing.Size(133, 33);
            this.ConecatrTVButton.TabIndex = 5;
            this.ConecatrTVButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConecatrTVButton.UseVisualStyleBackColor = false;
            this.ConecatrTVButton.Click += new System.EventHandler(this.ConecatrTVButton_Click);
            // 
            // teamViewerDataGridView
            // 
            this.teamViewerDataGridView.AllowUserToOrderColumns = true;
            this.teamViewerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamViewerDataGridView.AutoGenerateColumns = false;
            this.teamViewerDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.teamViewerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.teamViewerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamViewerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTV,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.teamViewerDataGridView.DataSource = this.fKTeamVieweidClienteBindingSource;
            this.teamViewerDataGridView.Location = new System.Drawing.Point(10, 86);
            this.teamViewerDataGridView.Name = "teamViewerDataGridView";
            this.teamViewerDataGridView.Size = new System.Drawing.Size(777, 416);
            this.teamViewerDataGridView.TabIndex = 1;
            this.teamViewerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teamViewerDataGridView_CellContentClick);
            // 
            // idTV
            // 
            this.idTV.DataPropertyName = "idTV";
            this.idTV.HeaderText = "ID PC";
            this.idTV.Name = "idTV";
            this.idTV.ReadOnly = true;
            this.idTV.Width = 45;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomePC";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome do Computador";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumeroTV";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID TeamViewer";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SenhaTV";
            this.dataGridViewTextBoxColumn5.HeaderText = "Senha";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ObsTV";
            this.dataGridViewTextBoxColumn6.HeaderText = "Observações do Computador";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nomeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // nomeComboBox
            // 
            this.nomeComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.nomeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nomeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nomeComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nomeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.clienteBindingSource, "Nome", true));
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teamViewerBindingSource, "idCliente", true));
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.clienteBindingSource, "idCliente", true));
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeComboBox.DataSource = this.clienteBindingSource;
            this.nomeComboBox.DisplayMember = "Nome";
            this.nomeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nomeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeComboBox.FormattingEnabled = true;
            this.nomeComboBox.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.nomeComboBox.Location = new System.Drawing.Point(6, 17);
            this.nomeComboBox.Name = "nomeComboBox";
            this.nomeComboBox.Size = new System.Drawing.Size(250, 21);
            this.nomeComboBox.TabIndex = 1;
            this.nomeComboBox.ValueMember = "idCliente";
            this.nomeComboBox.SelectedIndexChanged += new System.EventHandler(this.nomeComboBox_SelectedIndexChanged);
            // 
            // teamViewerBindingSource
            // 
            this.teamViewerBindingSource.DataMember = "TeamViewer";
            this.teamViewerBindingSource.DataSource = this.dBSet1;
            // 
            // PagCadastros
            // 
            this.PagCadastros.AutoScroll = true;
            this.PagCadastros.Controls.Add(this.tabControl2);
            this.PagCadastros.Location = new System.Drawing.Point(4, 22);
            this.PagCadastros.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.PagCadastros.Name = "PagCadastros";
            this.PagCadastros.Padding = new System.Windows.Forms.Padding(3);
            this.PagCadastros.Size = new System.Drawing.Size(793, 522);
            this.PagCadastros.TabIndex = 2;
            this.PagCadastros.Text = "Cadastros";
            this.PagCadastros.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabCadCliente);
            this.tabControl2.Controls.Add(this.tabCadTecnico);
            this.tabControl2.Location = new System.Drawing.Point(0, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(821, 536);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabCadCliente
            // 
            this.tabCadCliente.AutoScroll = true;
            this.tabCadCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabCadCliente.Controls.Add(this.clienteDataGridView);
            this.tabCadCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCadCliente.Name = "tabCadCliente";
            this.tabCadCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadCliente.Size = new System.Drawing.Size(813, 510);
            this.tabCadCliente.TabIndex = 0;
            this.tabCadCliente.Text = "Cliente";
            this.tabCadCliente.UseVisualStyleBackColor = true;
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToOrderColumns = true;
            this.clienteDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.clienteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clienteDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.clienteDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clienteDataGridView.DataSource = this.clienteBindingSource2;
            this.clienteDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.clienteDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clienteDataGridView.Location = new System.Drawing.Point(0, 8);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.Size = new System.Drawing.Size(801, 496);
            this.clienteDataGridView.TabIndex = 0;
            this.clienteDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clienteDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 55;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 250;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn8.HeaderText = "Observação";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 280;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "idTecnico";
            this.dataGridViewTextBoxColumn9.DataSource = this.tecnicoBindingSource1;
            this.dataGridViewTextBoxColumn9.DisplayMember = "NomeTecnico";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tecnico Responsável";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "idTecnico";
            // 
            // tecnicoBindingSource1
            // 
            this.tecnicoBindingSource1.DataMember = "Tecnico";
            this.tecnicoBindingSource1.DataSource = this.dBSet1;
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "Cliente";
            this.clienteBindingSource2.DataSource = this.dBSet1;
            // 
            // tabCadTecnico
            // 
            this.tabCadTecnico.AutoScroll = true;
            this.tabCadTecnico.Controls.Add(this.groupBox8);
            this.tabCadTecnico.Controls.Add(this.groupBox7);
            this.tabCadTecnico.Location = new System.Drawing.Point(4, 22);
            this.tabCadTecnico.Name = "tabCadTecnico";
            this.tabCadTecnico.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadTecnico.Size = new System.Drawing.Size(778, 473);
            this.tabCadTecnico.TabIndex = 1;
            this.tabCadTecnico.Text = "Tecnico";
            this.tabCadTecnico.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.clienteDataGridView1);
            this.groupBox8.Location = new System.Drawing.Point(346, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(426, 458);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Clientes Relacionados";
            // 
            // clienteDataGridView1
            // 
            this.clienteDataGridView1.AllowUserToAddRows = false;
            this.clienteDataGridView1.AllowUserToDeleteRows = false;
            this.clienteDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clienteDataGridView1.AutoGenerateColumns = false;
            this.clienteDataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.clienteDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.clienteDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.clienteDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView1.ColumnHeadersVisible = false;
            this.clienteDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.clienteDataGridView1.DataSource = this.fKClienteidTecnicoBindingSource1;
            this.clienteDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.clienteDataGridView1.Location = new System.Drawing.Point(6, 19);
            this.clienteDataGridView1.Name = "clienteDataGridView1";
            this.clienteDataGridView1.ReadOnly = true;
            this.clienteDataGridView1.Size = new System.Drawing.Size(420, 436);
            this.clienteDataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn12.HeaderText = "ID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 45;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn13.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fKClienteidTecnicoBindingSource1
            // 
            this.fKClienteidTecnicoBindingSource1.DataMember = "FK_Cliente_idTecnico";
            this.fKClienteidTecnicoBindingSource1.DataSource = this.tecnicoBindingSource1;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox7.Controls.Add(this.tecnicoDataGridView);
            this.groupBox7.Location = new System.Drawing.Point(10, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(320, 455);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Relação de Técnicos";
            // 
            // tecnicoDataGridView
            // 
            this.tecnicoDataGridView.AllowUserToOrderColumns = true;
            this.tecnicoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tecnicoDataGridView.AutoGenerateColumns = false;
            this.tecnicoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tecnicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tecnicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn10});
            this.tecnicoDataGridView.DataSource = this.tecnicoBindingSource1;
            this.tecnicoDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.tecnicoDataGridView.Location = new System.Drawing.Point(10, 19);
            this.tecnicoDataGridView.Name = "tecnicoDataGridView";
            this.tecnicoDataGridView.Size = new System.Drawing.Size(301, 436);
            this.tecnicoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idTecnico";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NomeTecnico";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // PagAtividade
            // 
            this.PagAtividade.AutoScroll = true;
            this.PagAtividade.Controls.Add(this.tabControl3);
            this.PagAtividade.Location = new System.Drawing.Point(4, 22);
            this.PagAtividade.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.PagAtividade.Name = "PagAtividade";
            this.PagAtividade.Padding = new System.Windows.Forms.Padding(3);
            this.PagAtividade.Size = new System.Drawing.Size(762, 503);
            this.PagAtividade.TabIndex = 1;
            this.PagAtividade.Text = "Atividades";
            this.PagAtividade.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl3.Controls.Add(this.tabPage1);
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Location = new System.Drawing.Point(0, 8);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(790, 514);
            this.tabControl3.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(idAtividadeLabel);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Location = new System.Drawing.Point(5, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 50);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teamViewerBindingSource, "idCliente", true));
            this.comboBox2.DataSource = this.clienteBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(250, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "idCliente";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.idTVTextBox);
            this.groupBox10.Location = new System.Drawing.Point(507, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(110, 50);
            this.groupBox10.TabIndex = 14;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "ID do Computador";
            // 
            // idTVTextBox
            // 
            this.idTVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKAtividadeidClienteBindingSource, "idTV", true));
            this.idTVTextBox.Location = new System.Drawing.Point(28, 18);
            this.idTVTextBox.Name = "idTVTextBox";
            this.idTVTextBox.Size = new System.Drawing.Size(55, 20);
            this.idTVTextBox.TabIndex = 13;
            // 
            // fKAtividadeidClienteBindingSource
            // 
            this.fKAtividadeidClienteBindingSource.DataMember = "FK_Atividade_idCliente";
            this.fKAtividadeidClienteBindingSource.DataSource = this.clienteBindingSource;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.idTecnicoTextBox);
            this.groupBox9.Location = new System.Drawing.Point(381, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(102, 50);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "ID do Tecnico";
            // 
            // idTecnicoTextBox
            // 
            this.idTecnicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKAtividadeidClienteBindingSource, "idTecnico", true));
            this.idTecnicoTextBox.Location = new System.Drawing.Point(22, 17);
            this.idTecnicoTextBox.Name = "idTecnicoTextBox";
            this.idTecnicoTextBox.Size = new System.Drawing.Size(55, 20);
            this.idTecnicoTextBox.TabIndex = 9;
            this.idTecnicoTextBox.TextChanged += new System.EventHandler(this.idTecnicoTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.idAtividadeListBox);
            this.groupBox2.Location = new System.Drawing.Point(639, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 335);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atividades";
            // 
            // idAtividadeListBox
            // 
            this.idAtividadeListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.atividadeBindingSource, "idAtividade", true));
            this.idAtividadeListBox.DataSource = this.fKAtividadeidClienteBindingSource;
            this.idAtividadeListBox.DisplayMember = "Created_at";
            this.idAtividadeListBox.FormattingEnabled = true;
            this.idAtividadeListBox.Location = new System.Drawing.Point(8, 18);
            this.idAtividadeListBox.Name = "idAtividadeListBox";
            this.idAtividadeListBox.Size = new System.Drawing.Size(115, 316);
            this.idAtividadeListBox.TabIndex = 3;
            this.idAtividadeListBox.ValueMember = "idAtividade";
            // 
            // atividadeBindingSource
            // 
            this.atividadeBindingSource.DataMember = "Atividade";
            this.atividadeBindingSource.DataSource = this.dBSet1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.situacaoTextBox);
            this.groupBox6.Location = new System.Drawing.Point(490, 274);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(143, 46);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Situação";
            // 
            // situacaoTextBox
            // 
            this.situacaoTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "FINALIZADO",
            "PENDENTE",
            "AGUARDANDO",
            "DBA"});
            this.situacaoTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.situacaoTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.situacaoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.situacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKAtividadeidClienteBindingSource, "Situacao", true));
            this.situacaoTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.situacaoTextBox.Location = new System.Drawing.Point(5, 17);
            this.situacaoTextBox.Name = "situacaoTextBox";
            this.situacaoTextBox.Size = new System.Drawing.Size(132, 20);
            this.situacaoTextBox.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.descricao1TextBox);
            this.groupBox4.Location = new System.Drawing.Point(5, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 170);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Descrição da Atividade";
            // 
            // descricao1TextBox
            // 
            this.descricao1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKAtividadeidClienteBindingSource, "Descricao1", true));
            this.descricao1TextBox.Location = new System.Drawing.Point(6, 19);
            this.descricao1TextBox.Multiline = true;
            this.descricao1TextBox.Name = "descricao1TextBox";
            this.descricao1TextBox.Size = new System.Drawing.Size(343, 145);
            this.descricao1TextBox.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.descricao2TextBox);
            this.groupBox5.Location = new System.Drawing.Point(366, 62);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(267, 170);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Procedimentos";
            // 
            // descricao2TextBox
            // 
            this.descricao2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKAtividadeidClienteBindingSource, "Descricao2", true));
            this.descricao2TextBox.Location = new System.Drawing.Point(6, 19);
            this.descricao2TextBox.Multiline = true;
            this.descricao2TextBox.Name = "descricao2TextBox";
            this.descricao2TextBox.Size = new System.Drawing.Size(255, 145);
            this.descricao2TextBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.atividadeDataGridView);
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.created_atListBox);
            this.groupBox11.Location = new System.Drawing.Point(589, 17);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(183, 421);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "groupBox11";
            // 
            // created_atListBox
            // 
            this.created_atListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.atividadeBindingSource2, "Created_at", true));
            this.created_atListBox.DataSource = this.atividadeBindingSource3;
            this.created_atListBox.DisplayMember = "Created_at";
            this.created_atListBox.FormattingEnabled = true;
            this.created_atListBox.Location = new System.Drawing.Point(20, 19);
            this.created_atListBox.Name = "created_atListBox";
            this.created_atListBox.Size = new System.Drawing.Size(143, 368);
            this.created_atListBox.TabIndex = 1;
            this.created_atListBox.ValueMember = "idAtividade";
            // 
            // atividadeBindingSource2
            // 
            this.atividadeBindingSource2.DataMember = "Atividade";
            this.atividadeBindingSource2.DataSource = this.dBSet;
            // 
            // dBSet
            // 
            this.dBSet.DataSetName = "DBSet";
            this.dBSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atividadeBindingSource3
            // 
            this.atividadeBindingSource3.DataMember = "Atividade";
            this.atividadeBindingSource3.DataSource = this.dBSet1;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "FK_Cliente_idTecnico";
            this.clienteBindingSource1.DataSource = this.tecnicoBindingSource;
            // 
            // tecnicoBindingSource
            // 
            this.tecnicoBindingSource.DataMember = "Tecnico";
            this.tecnicoBindingSource.DataSource = this.dBSet1;
            // 
            // atividadeBindingSource1
            // 
            this.atividadeBindingSource1.DataMember = "Atividade";
            this.atividadeBindingSource1.DataSource = this.dBSet1;
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator,
            this.salvarcomoToolStripMenuItem,
            this.toolStripSeparator1});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.arquivoToolStripMenuItem.Text = "&Menu";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // salvarcomoToolStripMenuItem
            // 
            this.salvarcomoToolStripMenuItem.Name = "salvarcomoToolStripMenuItem";
            this.salvarcomoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarcomoToolStripMenuItem.Text = "Atualizar Dados";
            this.salvarcomoToolStripMenuItem.Click += new System.EventHandler(this.salvarcomoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtividadeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.TeamViewerTableAdapter = this.teamViewerTableAdapter;
            this.tableAdapterManager.TecnicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ReSUP_v1._2.DBSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teamViewerTableAdapter
            // 
            this.teamViewerTableAdapter.ClearBeforeFill = true;
            // 
            // atividadeTableAdapter
            // 
            this.atividadeTableAdapter.ClearBeforeFill = true;
            // 
            // tecnicoTableAdapter
            // 
            this.tecnicoTableAdapter.ClearBeforeFill = true;
            // 
            // fKAtividadeidTecnicoBindingSource
            // 
            this.fKAtividadeidTecnicoBindingSource.DataMember = "FK_Atividade_idTecnico";
            this.fKAtividadeidTecnicoBindingSource.DataSource = this.tecnicoBindingSource;
            // 
            // fKClienteidTecnicoBindingSource
            // 
            this.fKClienteidTecnicoBindingSource.DataMember = "FK_Cliente_idTecnico";
            this.fKClienteidTecnicoBindingSource.DataSource = this.tecnicoBindingSource1;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingNavigatorSaveItem.Image")));
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(58, 22);
            this.clienteBindingNavigatorSaveItem.Text = "Salvar";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click_2);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = null;
            this.clienteBindingNavigator.CountItem = null;
            this.clienteBindingNavigator.DeleteItem = null;
            this.clienteBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.clienteBindingNavigatorSaveItem,
            this.toolStripSeparator6});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(55, 0);
            this.clienteBindingNavigator.MoveFirstItem = null;
            this.clienteBindingNavigator.MoveLastItem = null;
            this.clienteBindingNavigator.MoveNextItem = null;
            this.clienteBindingNavigator.MovePreviousItem = null;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = null;
            this.clienteBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(82, 25);
            this.clienteBindingNavigator.TabIndex = 12;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            this.clienteBindingNavigator.RefreshItems += new System.EventHandler(this.clienteBindingNavigator_RefreshItems);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(740, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 27);
            this.button2.TabIndex = 13;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // atividadeDataGridView
            // 
            this.atividadeDataGridView.AutoGenerateColumns = false;
            this.atividadeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atividadeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.atividadeDataGridView.DataSource = this.atividadeBindingSource2;
            this.atividadeDataGridView.Location = new System.Drawing.Point(3, 36);
            this.atividadeDataGridView.Name = "atividadeDataGridView";
            this.atividadeDataGridView.Size = new System.Drawing.Size(567, 355);
            this.atividadeDataGridView.TabIndex = 1;
            // 
            // fKAtividadeidClienteBindingSource1
            // 
            this.fKAtividadeidClienteBindingSource1.DataMember = "FK_Atividade_idCliente";
            this.fKAtividadeidClienteBindingSource1.DataSource = this.clienteBindingSource1;
            // 
            // fKAtividadeidClienteBindingSource2
            // 
            this.fKAtividadeidClienteBindingSource2.DataMember = "FK_Atividade_idCliente";
            this.fKAtividadeidClienteBindingSource2.DataSource = this.clienteBindingSource;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "idAtividade";
            this.dataGridViewTextBoxColumn11.HeaderText = "idAtividade";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumn14.DataSource = this.clienteBindingSource2;
            this.dataGridViewTextBoxColumn14.DisplayMember = "Nome";
            this.dataGridViewTextBoxColumn14.HeaderText = "idCliente";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn14.ValueMember = "idCliente";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "idTV";
            this.dataGridViewTextBoxColumn15.HeaderText = "idTV";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "idTecnico";
            this.dataGridViewTextBoxColumn16.HeaderText = "idTecnico";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Descricao1";
            this.dataGridViewTextBoxColumn17.HeaderText = "Descricao1";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Descricao2";
            this.dataGridViewTextBoxColumn18.HeaderText = "Descricao2";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Situacao";
            this.dataGridViewTextBoxColumn19.HeaderText = "Situacao";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Created_at";
            this.dataGridViewTextBoxColumn20.HeaderText = "Created_at";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 581);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form";
            this.Text = "ReSUP v1.2";
            this.Load += new System.EventHandler(this.Form_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.PagTeamViewer.ResumeLayout(false);
            this.PagTeamViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTeamVieweidClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamViewerDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamViewerBindingSource)).EndInit();
            this.PagCadastros.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabCadCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            this.tabCadTecnico.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteidTecnicoBindingSource1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tecnicoDataGridView)).EndInit();
            this.PagAtividade.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKAtividadeidClienteBindingSource)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKAtividadeidTecnicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteidTecnicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAtividadeidClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAtividadeidClienteBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PagTeamViewer;
        private System.Windows.Forms.TabPage PagAtividade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem salvarcomoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private DBSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private DBSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox nomeComboBox;
        private DBSet dBSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DBSetTableAdapters.TeamViewerTableAdapter teamViewerTableAdapter;
        private System.Windows.Forms.BindingSource teamViewerBindingSource;
        private System.Windows.Forms.DataGridView teamViewerDataGridView;
        private System.Windows.Forms.BindingSource fKTeamVieweidClienteBindingSource;
        private System.Windows.Forms.Label ComandoTV;
        private System.Windows.Forms.Button ConecatrTVButton;
        private System.Windows.Forms.TabPage PagCadastros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource atividadeBindingSource;
        private DBSetTableAdapters.AtividadeTableAdapter atividadeTableAdapter;
        private System.Windows.Forms.ListBox idAtividadeListBox;
        private System.Windows.Forms.BindingSource fKAtividadeidClienteBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox descricao1TextBox;
        private System.Windows.Forms.TextBox descricao2TextBox;
        private System.Windows.Forms.BindingSource tecnicoBindingSource;
        private DBSetTableAdapters.TecnicoTableAdapter tecnicoTableAdapter;
        private System.Windows.Forms.BindingSource fKAtividadeidTecnicoBindingSource;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox situacaoTextBox;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabCadCliente;
        private System.Windows.Forms.TabPage tabCadTecnico;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.TextBox idTecnicoTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.BindingSource tecnicoBindingSource1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView tecnicoDataGridView;
        private System.Windows.Forms.DataGridView clienteDataGridView1;
        private System.Windows.Forms.BindingSource fKClienteidTecnicoBindingSource1;
        private System.Windows.Forms.BindingSource fKClienteidTecnicoBindingSource;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox idTVTextBox;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource atividadeBindingSource1;
        private System.Windows.Forms.Label idTecnicoLabel2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private DBSet dBSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ListBox created_atListBox;
        private System.Windows.Forms.BindingSource atividadeBindingSource2;
        private System.Windows.Forms.BindingSource atividadeBindingSource3;
        private System.Windows.Forms.DataGridView atividadeDataGridView;
        private System.Windows.Forms.BindingSource fKAtividadeidClienteBindingSource1;
        private System.Windows.Forms.BindingSource fKAtividadeidClienteBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.Button button2;
    }
}

