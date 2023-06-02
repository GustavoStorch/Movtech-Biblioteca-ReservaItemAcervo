namespace ReservaItemAcervo
{
    partial class FormReservaItemAcervo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservaItemAcervo));
            this.lblTipoMovimento = new System.Windows.Forms.Label();
            this.lblCodItem = new System.Windows.Forms.Label();
            this.lblNomeItem = new System.Windows.Forms.Label();
            this.lblNumExemplar = new System.Windows.Forms.Label();
            this.lblTipoItem = new System.Windows.Forms.Label();
            this.lblLocalizacaoItem = new System.Windows.Forms.Label();
            this.lblCodLeitor = new System.Windows.Forms.Label();
            this.lblNomeLeitor = new System.Windows.Forms.Label();
            this.lblDataReserva = new System.Windows.Forms.Label();
            this.lblPrazoDevolucao = new System.Windows.Forms.Label();
            this.lblStatusItem = new System.Windows.Forms.Label();
            this.cbxTipoMovimento = new System.Windows.Forms.ComboBox();
            this.txtCodItem = new System.Windows.Forms.TextBox();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.txtNumExemplar = new System.Windows.Forms.TextBox();
            this.txtTipoItem = new System.Windows.Forms.TextBox();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.txtCodLeitor = new System.Windows.Forms.TextBox();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.cbxStatusItem = new System.Windows.Forms.ComboBox();
            this.dtpDataReserva = new System.Windows.Forms.DateTimePicker();
            this.dtpDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.gpbDadosReserva = new System.Windows.Forms.GroupBox();
            this.btnBuscarLeitor = new System.Windows.Forms.Button();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtgDadosReserva = new System.Windows.Forms.DataGridView();
            this.colCoditem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumExemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEncerrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbDadosReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoMovimento
            // 
            this.lblTipoMovimento.AutoSize = true;
            this.lblTipoMovimento.Location = new System.Drawing.Point(6, 35);
            this.lblTipoMovimento.Name = "lblTipoMovimento";
            this.lblTipoMovimento.Size = new System.Drawing.Size(124, 20);
            this.lblTipoMovimento.TabIndex = 0;
            this.lblTipoMovimento.Text = "Tipo Movimento:";
            // 
            // lblCodItem
            // 
            this.lblCodItem.AutoSize = true;
            this.lblCodItem.Location = new System.Drawing.Point(340, 38);
            this.lblCodItem.Name = "lblCodItem";
            this.lblCodItem.Size = new System.Drawing.Size(121, 20);
            this.lblCodItem.TabIndex = 1;
            this.lblCodItem.Text = "Código do Item:";
            // 
            // lblNomeItem
            // 
            this.lblNomeItem.AutoSize = true;
            this.lblNomeItem.Location = new System.Drawing.Point(656, 35);
            this.lblNomeItem.Name = "lblNomeItem";
            this.lblNomeItem.Size = new System.Drawing.Size(113, 20);
            this.lblNomeItem.TabIndex = 2;
            this.lblNomeItem.Text = "Nome do Item:";
            // 
            // lblNumExemplar
            // 
            this.lblNumExemplar.AutoSize = true;
            this.lblNumExemplar.Location = new System.Drawing.Point(6, 78);
            this.lblNumExemplar.Name = "lblNumExemplar";
            this.lblNumExemplar.Size = new System.Drawing.Size(139, 20);
            this.lblNumExemplar.TabIndex = 3;
            this.lblNumExemplar.Text = "Número Exemplar:";
            // 
            // lblTipoItem
            // 
            this.lblTipoItem.AutoSize = true;
            this.lblTipoItem.Location = new System.Drawing.Point(340, 78);
            this.lblTipoItem.Name = "lblTipoItem";
            this.lblTipoItem.Size = new System.Drawing.Size(101, 20);
            this.lblTipoItem.TabIndex = 4;
            this.lblTipoItem.Text = "Tipo do Item:";
            // 
            // lblLocalizacaoItem
            // 
            this.lblLocalizacaoItem.AutoSize = true;
            this.lblLocalizacaoItem.Location = new System.Drawing.Point(656, 78);
            this.lblLocalizacaoItem.Name = "lblLocalizacaoItem";
            this.lblLocalizacaoItem.Size = new System.Drawing.Size(97, 20);
            this.lblLocalizacaoItem.TabIndex = 5;
            this.lblLocalizacaoItem.Text = "Localização:";
            // 
            // lblCodLeitor
            // 
            this.lblCodLeitor.AutoSize = true;
            this.lblCodLeitor.Location = new System.Drawing.Point(6, 120);
            this.lblCodLeitor.Name = "lblCodLeitor";
            this.lblCodLeitor.Size = new System.Drawing.Size(129, 20);
            this.lblCodLeitor.TabIndex = 6;
            this.lblCodLeitor.Text = "Código do Leitor:";
            // 
            // lblNomeLeitor
            // 
            this.lblNomeLeitor.AutoSize = true;
            this.lblNomeLeitor.Location = new System.Drawing.Point(340, 120);
            this.lblNomeLeitor.Name = "lblNomeLeitor";
            this.lblNomeLeitor.Size = new System.Drawing.Size(121, 20);
            this.lblNomeLeitor.TabIndex = 7;
            this.lblNomeLeitor.Text = "Nome do Leitor:";
            // 
            // lblDataReserva
            // 
            this.lblDataReserva.AutoSize = true;
            this.lblDataReserva.Location = new System.Drawing.Point(6, 165);
            this.lblDataReserva.Name = "lblDataReserva";
            this.lblDataReserva.Size = new System.Drawing.Size(133, 20);
            this.lblDataReserva.TabIndex = 8;
            this.lblDataReserva.Text = "Data da Reserva:";
            // 
            // lblPrazoDevolucao
            // 
            this.lblPrazoDevolucao.AutoSize = true;
            this.lblPrazoDevolucao.Location = new System.Drawing.Point(340, 165);
            this.lblPrazoDevolucao.Name = "lblPrazoDevolucao";
            this.lblPrazoDevolucao.Size = new System.Drawing.Size(155, 20);
            this.lblPrazoDevolucao.TabIndex = 9;
            this.lblPrazoDevolucao.Text = "Prazo de Devolução:";
            // 
            // lblStatusItem
            // 
            this.lblStatusItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusItem.AutoSize = true;
            this.lblStatusItem.Location = new System.Drawing.Point(968, 121);
            this.lblStatusItem.Name = "lblStatusItem";
            this.lblStatusItem.Size = new System.Drawing.Size(60, 20);
            this.lblStatusItem.TabIndex = 10;
            this.lblStatusItem.Text = "Status:";
            // 
            // cbxTipoMovimento
            // 
            this.cbxTipoMovimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoMovimento.FormattingEnabled = true;
            this.cbxTipoMovimento.Items.AddRange(new object[] {
            "Devolver",
            "Empréstimo",
            "Reservar"});
            this.cbxTipoMovimento.Location = new System.Drawing.Point(152, 32);
            this.cbxTipoMovimento.Name = "cbxTipoMovimento";
            this.cbxTipoMovimento.Size = new System.Drawing.Size(182, 28);
            this.cbxTipoMovimento.TabIndex = 1;
            this.cbxTipoMovimento.TextChanged += new System.EventHandler(this.cbxTipoMovimento_TextChanged);
            // 
            // txtCodItem
            // 
            this.txtCodItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodItem.Location = new System.Drawing.Point(466, 35);
            this.txtCodItem.MaxLength = 5;
            this.txtCodItem.Name = "txtCodItem";
            this.txtCodItem.Size = new System.Drawing.Size(123, 26);
            this.txtCodItem.TabIndex = 2;
            this.txtCodItem.TextChanged += new System.EventHandler(this.txtCodItem_TextChanged);
            this.txtCodItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodItem_KeyPress);
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeItem.Location = new System.Drawing.Point(776, 32);
            this.txtNomeItem.MaxLength = 50;
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.ReadOnly = true;
            this.txtNomeItem.Size = new System.Drawing.Size(516, 26);
            this.txtNomeItem.TabIndex = 4;
            // 
            // txtNumExemplar
            // 
            this.txtNumExemplar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumExemplar.Location = new System.Drawing.Point(152, 77);
            this.txtNumExemplar.MaxLength = 50;
            this.txtNumExemplar.Name = "txtNumExemplar";
            this.txtNumExemplar.ReadOnly = true;
            this.txtNumExemplar.Size = new System.Drawing.Size(184, 26);
            this.txtNumExemplar.TabIndex = 5;
            // 
            // txtTipoItem
            // 
            this.txtTipoItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoItem.Location = new System.Drawing.Point(466, 77);
            this.txtTipoItem.MaxLength = 50;
            this.txtTipoItem.Name = "txtTipoItem";
            this.txtTipoItem.ReadOnly = true;
            this.txtTipoItem.Size = new System.Drawing.Size(184, 26);
            this.txtTipoItem.TabIndex = 6;
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalizacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalizacao.Location = new System.Drawing.Point(776, 77);
            this.txtLocalizacao.MaxLength = 50;
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.ReadOnly = true;
            this.txtLocalizacao.Size = new System.Drawing.Size(516, 26);
            this.txtLocalizacao.TabIndex = 7;
            // 
            // txtCodLeitor
            // 
            this.txtCodLeitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodLeitor.Location = new System.Drawing.Point(152, 118);
            this.txtCodLeitor.MaxLength = 3;
            this.txtCodLeitor.Name = "txtCodLeitor";
            this.txtCodLeitor.Size = new System.Drawing.Size(123, 26);
            this.txtCodLeitor.TabIndex = 8;
            this.txtCodLeitor.TextChanged += new System.EventHandler(this.txtCodLeitor_TextChanged);
            this.txtCodLeitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodLeitor_KeyPress);
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeLeitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeLeitor.Location = new System.Drawing.Point(466, 118);
            this.txtNomeLeitor.MaxLength = 50;
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.ReadOnly = true;
            this.txtNomeLeitor.Size = new System.Drawing.Size(496, 26);
            this.txtNomeLeitor.TabIndex = 10;
            // 
            // cbxStatusItem
            // 
            this.cbxStatusItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxStatusItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatusItem.Enabled = false;
            this.cbxStatusItem.FormattingEnabled = true;
            this.cbxStatusItem.Items.AddRange(new object[] {
            "Disponível",
            "Reservado",
            "Emprestado"});
            this.cbxStatusItem.Location = new System.Drawing.Point(1032, 118);
            this.cbxStatusItem.Name = "cbxStatusItem";
            this.cbxStatusItem.Size = new System.Drawing.Size(260, 28);
            this.cbxStatusItem.TabIndex = 13;
            // 
            // dtpDataReserva
            // 
            this.dtpDataReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataReserva.Location = new System.Drawing.Point(152, 160);
            this.dtpDataReserva.MinDate = new System.DateTime(2023, 5, 25, 0, 0, 0, 0);
            this.dtpDataReserva.Name = "dtpDataReserva";
            this.dtpDataReserva.Size = new System.Drawing.Size(141, 26);
            this.dtpDataReserva.TabIndex = 11;
            // 
            // dtpDataDevolucao
            // 
            this.dtpDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDevolucao.Location = new System.Drawing.Point(507, 160);
            this.dtpDataDevolucao.MinDate = new System.DateTime(2023, 5, 25, 0, 0, 0, 0);
            this.dtpDataDevolucao.Name = "dtpDataDevolucao";
            this.dtpDataDevolucao.Size = new System.Drawing.Size(141, 26);
            this.dtpDataDevolucao.TabIndex = 12;
            // 
            // gpbDadosReserva
            // 
            this.gpbDadosReserva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbDadosReserva.Controls.Add(this.btnBuscarLeitor);
            this.gpbDadosReserva.Controls.Add(this.btnBuscarItem);
            this.gpbDadosReserva.Controls.Add(this.lblTipoMovimento);
            this.gpbDadosReserva.Controls.Add(this.cbxStatusItem);
            this.gpbDadosReserva.Controls.Add(this.dtpDataReserva);
            this.gpbDadosReserva.Controls.Add(this.dtpDataDevolucao);
            this.gpbDadosReserva.Controls.Add(this.lblStatusItem);
            this.gpbDadosReserva.Controls.Add(this.cbxTipoMovimento);
            this.gpbDadosReserva.Controls.Add(this.lblCodItem);
            this.gpbDadosReserva.Controls.Add(this.lblPrazoDevolucao);
            this.gpbDadosReserva.Controls.Add(this.txtCodItem);
            this.gpbDadosReserva.Controls.Add(this.txtNomeLeitor);
            this.gpbDadosReserva.Controls.Add(this.lblNomeItem);
            this.gpbDadosReserva.Controls.Add(this.lblDataReserva);
            this.gpbDadosReserva.Controls.Add(this.txtCodLeitor);
            this.gpbDadosReserva.Controls.Add(this.txtNomeItem);
            this.gpbDadosReserva.Controls.Add(this.txtLocalizacao);
            this.gpbDadosReserva.Controls.Add(this.lblNomeLeitor);
            this.gpbDadosReserva.Controls.Add(this.lblNumExemplar);
            this.gpbDadosReserva.Controls.Add(this.txtTipoItem);
            this.gpbDadosReserva.Controls.Add(this.txtNumExemplar);
            this.gpbDadosReserva.Controls.Add(this.lblCodLeitor);
            this.gpbDadosReserva.Controls.Add(this.lblTipoItem);
            this.gpbDadosReserva.Controls.Add(this.lblLocalizacaoItem);
            this.gpbDadosReserva.Location = new System.Drawing.Point(12, 12);
            this.gpbDadosReserva.Name = "gpbDadosReserva";
            this.gpbDadosReserva.Size = new System.Drawing.Size(1302, 205);
            this.gpbDadosReserva.TabIndex = 22;
            this.gpbDadosReserva.TabStop = false;
            this.gpbDadosReserva.Text = "Dados da Reserva";
            // 
            // btnBuscarLeitor
            // 
            this.btnBuscarLeitor.FlatAppearance.BorderSize = 0;
            this.btnBuscarLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLeitor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarLeitor.Image = global::ReservaItemAcervo.Properties.Resources.lupa__1_;
            this.btnBuscarLeitor.Location = new System.Drawing.Point(276, 118);
            this.btnBuscarLeitor.Name = "btnBuscarLeitor";
            this.btnBuscarLeitor.Size = new System.Drawing.Size(58, 26);
            this.btnBuscarLeitor.TabIndex = 9;
            this.btnBuscarLeitor.UseVisualStyleBackColor = true;
            this.btnBuscarLeitor.Click += new System.EventHandler(this.btnBuscarLeitor_Click);
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.FlatAppearance.BorderSize = 0;
            this.btnBuscarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBuscarItem.Image = global::ReservaItemAcervo.Properties.Resources.lupa__1_;
            this.btnBuscarItem.Location = new System.Drawing.Point(592, 32);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(58, 28);
            this.btnBuscarItem.TabIndex = 3;
            this.btnBuscarItem.UseVisualStyleBackColor = true;
            this.btnBuscarItem.Click += new System.EventHandler(this.btnBuscarItem_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(1198, 225);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 34);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtgDadosReserva
            // 
            this.dtgDadosReserva.AllowUserToAddRows = false;
            this.dtgDadosReserva.AllowUserToDeleteRows = false;
            this.dtgDadosReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCoditem,
            this.colNomeItem,
            this.colStatusItem,
            this.colNomeLeitor,
            this.colDataReserva,
            this.colDataRetorno,
            this.colNumExemplar,
            this.colTipoItem,
            this.colLocalizacao,
            this.colCodLeitor,
            this.colEncerrar,
            this.colTipoMovimento});
            this.dtgDadosReserva.Location = new System.Drawing.Point(12, 268);
            this.dtgDadosReserva.MultiSelect = false;
            this.dtgDadosReserva.Name = "dtgDadosReserva";
            this.dtgDadosReserva.ReadOnly = true;
            this.dtgDadosReserva.RowHeadersWidth = 62;
            this.dtgDadosReserva.RowTemplate.Height = 28;
            this.dtgDadosReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosReserva.Size = new System.Drawing.Size(1302, 445);
            this.dtgDadosReserva.TabIndex = 16;
            this.dtgDadosReserva.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosReserva_CellDoubleClick);
            // 
            // colCoditem
            // 
            this.colCoditem.FillWeight = 36F;
            this.colCoditem.HeaderText = "Cod. Item";
            this.colCoditem.MinimumWidth = 8;
            this.colCoditem.Name = "colCoditem";
            this.colCoditem.ReadOnly = true;
            // 
            // colNomeItem
            // 
            this.colNomeItem.FillWeight = 90F;
            this.colNomeItem.HeaderText = "Item";
            this.colNomeItem.MinimumWidth = 8;
            this.colNomeItem.Name = "colNomeItem";
            this.colNomeItem.ReadOnly = true;
            // 
            // colStatusItem
            // 
            this.colStatusItem.FillWeight = 50F;
            this.colStatusItem.HeaderText = "Status";
            this.colStatusItem.MinimumWidth = 8;
            this.colStatusItem.Name = "colStatusItem";
            this.colStatusItem.ReadOnly = true;
            // 
            // colNomeLeitor
            // 
            this.colNomeLeitor.HeaderText = "Leitor";
            this.colNomeLeitor.MinimumWidth = 8;
            this.colNomeLeitor.Name = "colNomeLeitor";
            this.colNomeLeitor.ReadOnly = true;
            // 
            // colDataReserva
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.colDataReserva.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDataReserva.FillWeight = 44F;
            this.colDataReserva.HeaderText = "Data Reserva";
            this.colDataReserva.MinimumWidth = 8;
            this.colDataReserva.Name = "colDataReserva";
            this.colDataReserva.ReadOnly = true;
            // 
            // colDataRetorno
            // 
            this.colDataRetorno.FillWeight = 44F;
            this.colDataRetorno.HeaderText = "Data Retorno";
            this.colDataRetorno.MinimumWidth = 8;
            this.colDataRetorno.Name = "colDataRetorno";
            this.colDataRetorno.ReadOnly = true;
            // 
            // colNumExemplar
            // 
            this.colNumExemplar.HeaderText = "Num. Exemplar";
            this.colNumExemplar.MinimumWidth = 8;
            this.colNumExemplar.Name = "colNumExemplar";
            this.colNumExemplar.ReadOnly = true;
            this.colNumExemplar.Visible = false;
            // 
            // colTipoItem
            // 
            this.colTipoItem.HeaderText = "Tipo Item";
            this.colTipoItem.MinimumWidth = 8;
            this.colTipoItem.Name = "colTipoItem";
            this.colTipoItem.ReadOnly = true;
            this.colTipoItem.Visible = false;
            // 
            // colLocalizacao
            // 
            this.colLocalizacao.HeaderText = "Localização";
            this.colLocalizacao.MinimumWidth = 8;
            this.colLocalizacao.Name = "colLocalizacao";
            this.colLocalizacao.ReadOnly = true;
            this.colLocalizacao.Visible = false;
            // 
            // colCodLeitor
            // 
            this.colCodLeitor.HeaderText = "Cod. Leitor";
            this.colCodLeitor.MinimumWidth = 8;
            this.colCodLeitor.Name = "colCodLeitor";
            this.colCodLeitor.ReadOnly = true;
            this.colCodLeitor.Visible = false;
            // 
            // colEncerrar
            // 
            this.colEncerrar.HeaderText = "Encerrar";
            this.colEncerrar.MinimumWidth = 8;
            this.colEncerrar.Name = "colEncerrar";
            this.colEncerrar.ReadOnly = true;
            this.colEncerrar.Visible = false;
            // 
            // colTipoMovimento
            // 
            this.colTipoMovimento.HeaderText = "Movimento";
            this.colTipoMovimento.MinimumWidth = 8;
            this.colTipoMovimento.Name = "colTipoMovimento";
            this.colTipoMovimento.ReadOnly = true;
            this.colTipoMovimento.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(1074, 226);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 34);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormReservaItemAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 722);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dtgDadosReserva);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gpbDadosReserva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReservaItemAcervo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva Item Acervo";
            this.Load += new System.EventHandler(this.FormReservaItemAcervo_Load);
            this.gpbDadosReserva.ResumeLayout(false);
            this.gpbDadosReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTipoMovimento;
        private System.Windows.Forms.Label lblCodItem;
        private System.Windows.Forms.Label lblNomeItem;
        private System.Windows.Forms.Label lblNumExemplar;
        private System.Windows.Forms.Label lblTipoItem;
        private System.Windows.Forms.Label lblLocalizacaoItem;
        private System.Windows.Forms.Label lblCodLeitor;
        private System.Windows.Forms.Label lblNomeLeitor;
        private System.Windows.Forms.Label lblDataReserva;
        private System.Windows.Forms.Label lblPrazoDevolucao;
        private System.Windows.Forms.Label lblStatusItem;
        private System.Windows.Forms.ComboBox cbxTipoMovimento;
        private System.Windows.Forms.TextBox txtCodItem;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.TextBox txtNumExemplar;
        private System.Windows.Forms.TextBox txtTipoItem;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.TextBox txtCodLeitor;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.ComboBox cbxStatusItem;
        private System.Windows.Forms.DateTimePicker dtpDataReserva;
        private System.Windows.Forms.DateTimePicker dtpDataDevolucao;
        private System.Windows.Forms.GroupBox gpbDadosReserva;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dtgDadosReserva;
        private System.Windows.Forms.Button btnBuscarLeitor;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoditem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataRetorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumExemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEncerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoMovimento;
    }
}

