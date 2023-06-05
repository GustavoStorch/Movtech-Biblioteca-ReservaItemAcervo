namespace ReservaItemAcervo
{
    partial class FormBuscaItemAcervo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscaItemAcervo));
            this.dtgDadosItemAcervo = new System.Windows.Forms.DataGridView();
            this.colCodItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumExemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeItemAcervo = new System.Windows.Forms.TextBox();
            this.lblNomeItemAcervo = new System.Windows.Forms.Label();
            this.txtCodItem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosItemAcervo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDadosItemAcervo
            // 
            this.dtgDadosItemAcervo.AllowUserToAddRows = false;
            this.dtgDadosItemAcervo.AllowUserToDeleteRows = false;
            this.dtgDadosItemAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosItemAcervo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosItemAcervo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodItemAcervo,
            this.colNomeItemAcervo,
            this.colNumExemplar,
            this.colTipoItem,
            this.colLocalizacao,
            this.colStatusItem});
            this.dtgDadosItemAcervo.Location = new System.Drawing.Point(16, 42);
            this.dtgDadosItemAcervo.MultiSelect = false;
            this.dtgDadosItemAcervo.Name = "dtgDadosItemAcervo";
            this.dtgDadosItemAcervo.ReadOnly = true;
            this.dtgDadosItemAcervo.RowHeadersWidth = 62;
            this.dtgDadosItemAcervo.RowTemplate.Height = 28;
            this.dtgDadosItemAcervo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosItemAcervo.Size = new System.Drawing.Size(771, 318);
            this.dtgDadosItemAcervo.TabIndex = 2;
            this.dtgDadosItemAcervo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosItemAcervo_CellDoubleClick);
            // 
            // colCodItemAcervo
            // 
            this.colCodItemAcervo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCodItemAcervo.FillWeight = 30F;
            this.colCodItemAcervo.HeaderText = "Código";
            this.colCodItemAcervo.MinimumWidth = 8;
            this.colCodItemAcervo.Name = "colCodItemAcervo";
            this.colCodItemAcervo.ReadOnly = true;
            // 
            // colNomeItemAcervo
            // 
            this.colNomeItemAcervo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeItemAcervo.HeaderText = "ItemAcervo";
            this.colNomeItemAcervo.MinimumWidth = 8;
            this.colNomeItemAcervo.Name = "colNomeItemAcervo";
            this.colNomeItemAcervo.ReadOnly = true;
            // 
            // colNumExemplar
            // 
            this.colNumExemplar.FillWeight = 80F;
            this.colNumExemplar.HeaderText = "Exemplar";
            this.colNumExemplar.MinimumWidth = 8;
            this.colNumExemplar.Name = "colNumExemplar";
            this.colNumExemplar.ReadOnly = true;
            this.colNumExemplar.Width = 150;
            // 
            // colTipoItem
            // 
            this.colTipoItem.HeaderText = "TipoItem";
            this.colTipoItem.MinimumWidth = 8;
            this.colTipoItem.Name = "colTipoItem";
            this.colTipoItem.ReadOnly = true;
            this.colTipoItem.Visible = false;
            this.colTipoItem.Width = 150;
            // 
            // colLocalizacao
            // 
            this.colLocalizacao.HeaderText = "Localizacao";
            this.colLocalizacao.MinimumWidth = 8;
            this.colLocalizacao.Name = "colLocalizacao";
            this.colLocalizacao.ReadOnly = true;
            this.colLocalizacao.Visible = false;
            this.colLocalizacao.Width = 150;
            // 
            // colStatusItem
            // 
            this.colStatusItem.HeaderText = "StatusItem";
            this.colStatusItem.MinimumWidth = 8;
            this.colStatusItem.Name = "colStatusItem";
            this.colStatusItem.ReadOnly = true;
            this.colStatusItem.Visible = false;
            this.colStatusItem.Width = 150;
            // 
            // txtNomeItemAcervo
            // 
            this.txtNomeItemAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeItemAcervo.Location = new System.Drawing.Point(73, 10);
            this.txtNomeItemAcervo.Name = "txtNomeItemAcervo";
            this.txtNomeItemAcervo.Size = new System.Drawing.Size(714, 26);
            this.txtNomeItemAcervo.TabIndex = 1;
            this.txtNomeItemAcervo.TextChanged += new System.EventHandler(this.txtNomeItemAcervo_TextChanged);
            // 
            // lblNomeItemAcervo
            // 
            this.lblNomeItemAcervo.AutoSize = true;
            this.lblNomeItemAcervo.Location = new System.Drawing.Point(12, 13);
            this.lblNomeItemAcervo.Name = "lblNomeItemAcervo";
            this.lblNomeItemAcervo.Size = new System.Drawing.Size(55, 20);
            this.lblNomeItemAcervo.TabIndex = 5;
            this.lblNomeItemAcervo.Text = "Nome:";
            // 
            // txtCodItem
            // 
            this.txtCodItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodItem.Enabled = false;
            this.txtCodItem.Location = new System.Drawing.Point(0, 341);
            this.txtCodItem.Name = "txtCodItem";
            this.txtCodItem.ReadOnly = true;
            this.txtCodItem.Size = new System.Drawing.Size(10, 19);
            this.txtCodItem.TabIndex = 8;
            this.txtCodItem.Visible = false;
            // 
            // FormBuscaItemAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 370);
            this.Controls.Add(this.txtCodItem);
            this.Controls.Add(this.dtgDadosItemAcervo);
            this.Controls.Add(this.txtNomeItemAcervo);
            this.Controls.Add(this.lblNomeItemAcervo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuscaItemAcervo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscaItemAcervo";
            this.Load += new System.EventHandler(this.FormBuscaItemAcervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosItemAcervo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDadosItemAcervo;
        private System.Windows.Forms.TextBox txtNomeItemAcervo;
        private System.Windows.Forms.Label lblNomeItemAcervo;
        private System.Windows.Forms.TextBox txtCodItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumExemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusItem;
    }
}