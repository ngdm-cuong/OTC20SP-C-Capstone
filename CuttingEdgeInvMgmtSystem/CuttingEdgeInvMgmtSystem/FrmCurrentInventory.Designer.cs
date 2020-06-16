namespace CuttingEdgeInvMgmtSystem
{
    partial class FrmCurrentInventory
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
            this.dataGridColors = new System.Windows.Forms.DataGridView();
            this.dataGridBarTops = new System.Windows.Forms.DataGridView();
            this.ColorBarTop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridKitchenTops = new System.Windows.Forms.DataGridView();
            this.ColorKitchen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridVanityTops = new System.Windows.Forms.DataGridView();
            this.ColorVanity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BarTop = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBarTops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitchenTops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVanityTops)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridColors
            // 
            this.dataGridColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridColors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridColors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridColors.Location = new System.Drawing.Point(40, 47);
            this.dataGridColors.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridColors.Name = "dataGridColors";
            this.dataGridColors.Size = new System.Drawing.Size(321, 157);
            this.dataGridColors.TabIndex = 0;
            // 
            // dataGridBarTops
            // 
            this.dataGridBarTops.AccessibleDescription = "";
            this.dataGridBarTops.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBarTops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBarTops.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridBarTops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBarTops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColorBarTop});
            this.dataGridBarTops.Location = new System.Drawing.Point(377, 263);
            this.dataGridBarTops.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridBarTops.Name = "dataGridBarTops";
            this.dataGridBarTops.Size = new System.Drawing.Size(321, 157);
            this.dataGridBarTops.TabIndex = 0;
            // 
            // ColorBarTop
            // 
            this.ColorBarTop.HeaderText = "Color";
            this.ColorBarTop.Name = "ColorBarTop";
            // 
            // dataGridKitchenTops
            // 
            this.dataGridKitchenTops.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridKitchenTops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridKitchenTops.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridKitchenTops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKitchenTops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColorKitchen});
            this.dataGridKitchenTops.Location = new System.Drawing.Point(40, 263);
            this.dataGridKitchenTops.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridKitchenTops.Name = "dataGridKitchenTops";
            this.dataGridKitchenTops.Size = new System.Drawing.Size(321, 157);
            this.dataGridKitchenTops.TabIndex = 0;
            // 
            // ColorKitchen
            // 
            this.ColorKitchen.HeaderText = "Color";
            this.ColorKitchen.Name = "ColorKitchen";
            // 
            // dataGridVanityTops
            // 
            this.dataGridVanityTops.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVanityTops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVanityTops.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridVanityTops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVanityTops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColorVanity});
            this.dataGridVanityTops.Location = new System.Drawing.Point(377, 47);
            this.dataGridVanityTops.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridVanityTops.Name = "dataGridVanityTops";
            this.dataGridVanityTops.Size = new System.Drawing.Size(321, 157);
            this.dataGridVanityTops.TabIndex = 0;
            this.dataGridVanityTops.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVanityTops_CellContentClick);
            // 
            // ColorVanity
            // 
            this.ColorVanity.HeaderText = "Color";
            this.ColorVanity.Name = "ColorVanity";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(262, 487);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiscard.Location = new System.Drawing.Point(415, 487);
            this.btnDiscard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(128, 30);
            this.btnDiscard.TabIndex = 1;
            this.btnDiscard.Text = "Discard Changes";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(570, 487);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color";
            // 
            // BarTop
            // 
            this.BarTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BarTop.AutoSize = true;
            this.BarTop.Location = new System.Drawing.Point(523, 242);
            this.BarTop.Name = "BarTop";
            this.BarTop.Size = new System.Drawing.Size(55, 17);
            this.BarTop.TabIndex = 2;
            this.BarTop.Text = "BarTop";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitchen";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vanity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FrmCurrentInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BarTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridKitchenTops);
            this.Controls.Add(this.dataGridVanityTops);
            this.Controls.Add(this.dataGridBarTops);
            this.Controls.Add(this.dataGridColors);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(729, 577);
            this.Name = "FrmCurrentInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCurrentInventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCurrentInventory_FormClosing);
            this.Load += new System.EventHandler(this.FrmCurrentInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBarTops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitchenTops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVanityTops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridColors;
        private System.Windows.Forms.DataGridView dataGridBarTops;
        private System.Windows.Forms.DataGridView dataGridKitchenTops;
        private System.Windows.Forms.DataGridView dataGridVanityTops;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorKitchen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorBarTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorVanity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BarTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}