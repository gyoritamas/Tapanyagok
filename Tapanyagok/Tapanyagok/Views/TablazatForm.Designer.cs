
namespace Tapanyagok.Views
{
    partial class TablazatForm
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
            this.components = new System.ComponentModel.Container();
            this.pagesLabel = new System.Windows.Forms.Label();
            this.lastButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mentesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torlesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresesTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.keresesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.szerkesztesContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torlesContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feherjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zsirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szenhidratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tapanyagBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tapanyagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tapanyagBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapanyagBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pagesLabel
            // 
            this.pagesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pagesLabel.Location = new System.Drawing.Point(225, 5);
            this.pagesLabel.Name = "pagesLabel";
            this.pagesLabel.Size = new System.Drawing.Size(49, 29);
            this.pagesLabel.TabIndex = 4;
            this.pagesLabel.Text = "0/0";
            this.pagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastButton
            // 
            this.lastButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastButton.Location = new System.Drawing.Point(343, 5);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(54, 29);
            this.lastButton.TabIndex = 3;
            this.lastButton.Text = ">>";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextButton.Location = new System.Drawing.Point(283, 5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(54, 29);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.previousButton.Location = new System.Drawing.Point(163, 5);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(54, 29);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "<";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstButton.Location = new System.Drawing.Point(103, 5);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(54, 29);
            this.firstButton.TabIndex = 0;
            this.firstButton.Text = "<<";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn,
            this.energiaDataGridViewTextBoxColumn,
            this.feherjeDataGridViewTextBoxColumn,
            this.zsirDataGridViewTextBoxColumn,
            this.szenhidratDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tapanyagBindingSource1;
            this.dataGridView.Location = new System.Drawing.Point(13, 30);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(476, 576);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ColumnHeaderMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mentesMenuItem,
            this.ujMenuItem,
            this.torlesMenuItem,
            this.keresesTextBox,
            this.keresesMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mentesMenuItem
            // 
            this.mentesMenuItem.Name = "mentesMenuItem";
            this.mentesMenuItem.Size = new System.Drawing.Size(58, 23);
            this.mentesMenuItem.Text = "Mentés";
            this.mentesMenuItem.Click += new System.EventHandler(this.mentesMenuItem_Click);
            // 
            // ujMenuItem
            // 
            this.ujMenuItem.Name = "ujMenuItem";
            this.ujMenuItem.Size = new System.Drawing.Size(30, 23);
            this.ujMenuItem.Text = "Új";
            this.ujMenuItem.Click += new System.EventHandler(this.ujMenuItem_Click);
            // 
            // torlesMenuItem
            // 
            this.torlesMenuItem.Name = "torlesMenuItem";
            this.torlesMenuItem.Size = new System.Drawing.Size(49, 23);
            this.torlesMenuItem.Text = "Törlés";
            // 
            // keresesTextBox
            // 
            this.keresesTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keresesTextBox.Name = "keresesTextBox";
            this.keresesTextBox.Size = new System.Drawing.Size(200, 23);
            // 
            // keresesMenuItem
            // 
            this.keresesMenuItem.Name = "keresesMenuItem";
            this.keresesMenuItem.Size = new System.Drawing.Size(58, 23);
            this.keresesMenuItem.Text = "Keresés";
            this.keresesMenuItem.Click += new System.EventHandler(this.keresesMenuItem_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztesContextMenuItem,
            this.torlesContextMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(133, 48);
            // 
            // szerkesztesContextMenuItem
            // 
            this.szerkesztesContextMenuItem.Name = "szerkesztesContextMenuItem";
            this.szerkesztesContextMenuItem.Size = new System.Drawing.Size(132, 22);
            this.szerkesztesContextMenuItem.Text = "Szerkesztes";
            // 
            // torlesContextMenuItem
            // 
            this.torlesContextMenuItem.Name = "torlesContextMenuItem";
            this.torlesContextMenuItem.Size = new System.Drawing.Size(132, 22);
            this.torlesContextMenuItem.Text = "Torles";
            this.torlesContextMenuItem.Click += new System.EventHandler(this.torlesContextMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.firstButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.previousButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pagesLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lastButton, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.nextButton, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 612);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 39);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 121.8274F;
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "nev";
            this.nevDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.nevDataGridViewTextBoxColumn.HeaderText = "név";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // energiaDataGridViewTextBoxColumn
            // 
            this.energiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.energiaDataGridViewTextBoxColumn.DataPropertyName = "energia";
            this.energiaDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.energiaDataGridViewTextBoxColumn.HeaderText = "energia";
            this.energiaDataGridViewTextBoxColumn.Name = "energiaDataGridViewTextBoxColumn";
            this.energiaDataGridViewTextBoxColumn.Width = 60;
            // 
            // feherjeDataGridViewTextBoxColumn
            // 
            this.feherjeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.feherjeDataGridViewTextBoxColumn.DataPropertyName = "feherje";
            this.feherjeDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.feherjeDataGridViewTextBoxColumn.HeaderText = "fehérje";
            this.feherjeDataGridViewTextBoxColumn.Name = "feherjeDataGridViewTextBoxColumn";
            this.feherjeDataGridViewTextBoxColumn.Width = 60;
            // 
            // zsirDataGridViewTextBoxColumn
            // 
            this.zsirDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.zsirDataGridViewTextBoxColumn.DataPropertyName = "zsir";
            this.zsirDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.zsirDataGridViewTextBoxColumn.HeaderText = "zsír";
            this.zsirDataGridViewTextBoxColumn.Name = "zsirDataGridViewTextBoxColumn";
            this.zsirDataGridViewTextBoxColumn.Width = 60;
            // 
            // szenhidratDataGridViewTextBoxColumn
            // 
            this.szenhidratDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.szenhidratDataGridViewTextBoxColumn.DataPropertyName = "szenhidrat";
            this.szenhidratDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.szenhidratDataGridViewTextBoxColumn.HeaderText = "szénhidrát";
            this.szenhidratDataGridViewTextBoxColumn.Name = "szenhidratDataGridViewTextBoxColumn";
            this.szenhidratDataGridViewTextBoxColumn.Width = 60;
            // 
            // tapanyagBindingSource1
            // 
            this.tapanyagBindingSource1.DataSource = typeof(Tapanyagok.Models.tapanyag);
            // 
            // tapanyagBindingSource
            // 
            this.tapanyagBindingSource.DataSource = typeof(Tapanyagok.Models.tapanyag);
            // 
            // TablazatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 655);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TablazatForm";
            this.Text = "Tápanyagok";
            this.Load += new System.EventHandler(this.TablazatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tapanyagBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapanyagBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mentesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torlesMenuItem;
        private System.Windows.Forms.ToolStripTextBox keresesTextBox;
        private System.Windows.Forms.ToolStripMenuItem keresesMenuItem;
        private System.Windows.Forms.Label pagesLabel;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem szerkesztesContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torlesContextMenuItem;
        private System.Windows.Forms.BindingSource tapanyagBindingSource;
        private System.Windows.Forms.BindingSource tapanyagBindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feherjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zsirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szenhidratDataGridViewTextBoxColumn;
    }
}