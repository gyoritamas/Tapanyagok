
namespace Tapanyagok.Views
{
    partial class TapanyagForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.energiaNUD = new System.Windows.Forms.NumericUpDown();
            this.feherjeNUD = new System.Windows.Forms.NumericUpDown();
            this.zsirNUD = new System.Windows.Forms.NumericUpDown();
            this.szenhidratNUD = new System.Windows.Forms.NumericUpDown();
            this.nevLabel = new System.Windows.Forms.Label();
            this.energiaLabel = new System.Windows.Forms.Label();
            this.feherjeLabel = new System.Windows.Forms.Label();
            this.zsirLabel = new System.Windows.Forms.Label();
            this.szenhidratLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.energiaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feherjeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zsirNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szenhidratNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cancelButton);
            this.splitContainer1.Panel2.Controls.Add(this.okButton);
            this.splitContainer1.Size = new System.Drawing.Size(436, 286);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.szenhidratLabel);
            this.splitContainer2.Panel1.Controls.Add(this.zsirLabel);
            this.splitContainer2.Panel1.Controls.Add(this.feherjeLabel);
            this.splitContainer2.Panel1.Controls.Add(this.energiaLabel);
            this.splitContainer2.Panel1.Controls.Add(this.nevLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.szenhidratNUD);
            this.splitContainer2.Panel2.Controls.Add(this.zsirNUD);
            this.splitContainer2.Panel2.Controls.Add(this.feherjeNUD);
            this.splitContainer2.Panel2.Controls.Add(this.energiaNUD);
            this.splitContainer2.Panel2.Controls.Add(this.nevTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(436, 232);
            this.splitContainer2.SplitterDistance = 125;
            this.splitContainer2.TabIndex = 0;
            // 
            // nevTextBox
            // 
            this.nevTextBox.Location = new System.Drawing.Point(25, 25);
            this.nevTextBox.Multiline = true;
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(247, 81);
            this.nevTextBox.TabIndex = 0;
            // 
            // energiaNUD
            // 
            this.energiaNUD.DecimalPlaces = 1;
            this.energiaNUD.Location = new System.Drawing.Point(25, 112);
            this.energiaNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.energiaNUD.Name = "energiaNUD";
            this.energiaNUD.Size = new System.Drawing.Size(247, 20);
            this.energiaNUD.TabIndex = 1;
            this.energiaNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // feherjeNUD
            // 
            this.feherjeNUD.DecimalPlaces = 1;
            this.feherjeNUD.Location = new System.Drawing.Point(25, 138);
            this.feherjeNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.feherjeNUD.Name = "feherjeNUD";
            this.feherjeNUD.Size = new System.Drawing.Size(247, 20);
            this.feherjeNUD.TabIndex = 2;
            this.feherjeNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zsirNUD
            // 
            this.zsirNUD.DecimalPlaces = 1;
            this.zsirNUD.Location = new System.Drawing.Point(25, 164);
            this.zsirNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.zsirNUD.Name = "zsirNUD";
            this.zsirNUD.Size = new System.Drawing.Size(247, 20);
            this.zsirNUD.TabIndex = 3;
            this.zsirNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // szenhidratNUD
            // 
            this.szenhidratNUD.DecimalPlaces = 1;
            this.szenhidratNUD.Location = new System.Drawing.Point(25, 190);
            this.szenhidratNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.szenhidratNUD.Name = "szenhidratNUD";
            this.szenhidratNUD.Size = new System.Drawing.Size(247, 20);
            this.szenhidratNUD.TabIndex = 4;
            this.szenhidratNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nevLabel
            // 
            this.nevLabel.AutoSize = true;
            this.nevLabel.Location = new System.Drawing.Point(16, 28);
            this.nevLabel.Name = "nevLabel";
            this.nevLabel.Size = new System.Drawing.Size(25, 13);
            this.nevLabel.TabIndex = 0;
            this.nevLabel.Text = "név";
            // 
            // energiaLabel
            // 
            this.energiaLabel.AutoSize = true;
            this.energiaLabel.Location = new System.Drawing.Point(16, 114);
            this.energiaLabel.Name = "energiaLabel";
            this.energiaLabel.Size = new System.Drawing.Size(42, 13);
            this.energiaLabel.TabIndex = 1;
            this.energiaLabel.Text = "energia";
            // 
            // feherjeLabel
            // 
            this.feherjeLabel.AutoSize = true;
            this.feherjeLabel.Location = new System.Drawing.Point(16, 140);
            this.feherjeLabel.Name = "feherjeLabel";
            this.feherjeLabel.Size = new System.Drawing.Size(39, 13);
            this.feherjeLabel.TabIndex = 2;
            this.feherjeLabel.Text = "fehérje";
            // 
            // zsirLabel
            // 
            this.zsirLabel.AutoSize = true;
            this.zsirLabel.Location = new System.Drawing.Point(16, 166);
            this.zsirLabel.Name = "zsirLabel";
            this.zsirLabel.Size = new System.Drawing.Size(24, 13);
            this.zsirLabel.TabIndex = 3;
            this.zsirLabel.Text = "zsír";
            // 
            // szenhidratLabel
            // 
            this.szenhidratLabel.AutoSize = true;
            this.szenhidratLabel.Location = new System.Drawing.Point(16, 192);
            this.szenhidratLabel.Name = "szenhidratLabel";
            this.szenhidratLabel.Size = new System.Drawing.Size(55, 13);
            this.szenhidratLabel.TabIndex = 4;
            this.szenhidratLabel.Text = "szénhidrát";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(36, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 32);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(326, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 32);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Mégse";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // TapanyagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 286);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TapanyagForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TapanyagForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.energiaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feherjeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zsirNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szenhidratNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label szenhidratLabel;
        private System.Windows.Forms.Label zsirLabel;
        private System.Windows.Forms.Label feherjeLabel;
        private System.Windows.Forms.Label energiaLabel;
        private System.Windows.Forms.Label nevLabel;
        private System.Windows.Forms.NumericUpDown szenhidratNUD;
        private System.Windows.Forms.NumericUpDown zsirNUD;
        private System.Windows.Forms.NumericUpDown feherjeNUD;
        private System.Windows.Forms.NumericUpDown energiaNUD;
        private System.Windows.Forms.TextBox nevTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}