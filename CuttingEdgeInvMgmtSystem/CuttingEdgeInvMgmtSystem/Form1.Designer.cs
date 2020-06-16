namespace CuttingEdgeInvMgmtSystem
{
    partial class Form1
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
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.InfoList = new System.Windows.Forms.ListBox();
            this.TxtBxLength = new System.Windows.Forms.TextBox();
            this.EnterDataBox = new System.Windows.Forms.GroupBox();
            this.ComboBoxColorList = new System.Windows.Forms.ComboBox();
            this.CheckBxBar36 = new System.Windows.Forms.CheckBox();
            this.CheckBxBar27 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioBtnBar = new System.Windows.Forms.RadioButton();
            this.RadioBtnVanity = new System.Windows.Forms.RadioButton();
            this.RadioBtnKitchen = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripFileBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuCurrentInvetory = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuPrintReport = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuAddColor = new System.Windows.Forms.ToolStripMenuItem();
            this.removeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.GroupBxAddColor = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddColor = new System.Windows.Forms.Button();
            this.TxtBxAddColor = new System.Windows.Forms.TextBox();
            this.EnterDataBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.GroupBxAddColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(97, 429);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(212, 62);
            this.BtnSubmit.TabIndex = 0;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // InfoList
            // 
            this.InfoList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.InfoList.FormattingEnabled = true;
            this.InfoList.ItemHeight = 16;
            this.InfoList.Location = new System.Drawing.Point(474, 73);
            this.InfoList.Margin = new System.Windows.Forms.Padding(4);
            this.InfoList.Name = "InfoList";
            this.InfoList.Size = new System.Drawing.Size(345, 676);
            this.InfoList.TabIndex = 2;
            this.InfoList.SelectedIndexChanged += new System.EventHandler(this.InfoList_SelectedIndexChanged);
            this.InfoList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InfoList_KeyPress);
            // 
            // TxtBxLength
            // 
            this.TxtBxLength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtBxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxLength.Location = new System.Drawing.Point(173, 209);
            this.TxtBxLength.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBxLength.Name = "TxtBxLength";
            this.TxtBxLength.Size = new System.Drawing.Size(224, 34);
            this.TxtBxLength.TabIndex = 5;
            this.TxtBxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxLength_KeyPress);
            // 
            // EnterDataBox
            // 
            this.EnterDataBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnterDataBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.EnterDataBox.Controls.Add(this.ComboBoxColorList);
            this.EnterDataBox.Controls.Add(this.CheckBxBar36);
            this.EnterDataBox.Controls.Add(this.CheckBxBar27);
            this.EnterDataBox.Controls.Add(this.label2);
            this.EnterDataBox.Controls.Add(this.label1);
            this.EnterDataBox.Controls.Add(this.RadioBtnBar);
            this.EnterDataBox.Controls.Add(this.RadioBtnVanity);
            this.EnterDataBox.Controls.Add(this.RadioBtnKitchen);
            this.EnterDataBox.Controls.Add(this.TxtBxLength);
            this.EnterDataBox.Controls.Add(this.BtnSubmit);
            this.EnterDataBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterDataBox.Location = new System.Drawing.Point(13, 73);
            this.EnterDataBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnterDataBox.Name = "EnterDataBox";
            this.EnterDataBox.Padding = new System.Windows.Forms.Padding(4);
            this.EnterDataBox.Size = new System.Drawing.Size(409, 676);
            this.EnterDataBox.TabIndex = 6;
            this.EnterDataBox.TabStop = false;
            this.EnterDataBox.Text = "Add Inventory";
            // 
            // ComboBoxColorList
            // 
            this.ComboBoxColorList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ComboBoxColorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxColorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxColorList.FormattingEnabled = true;
            this.ComboBoxColorList.Location = new System.Drawing.Point(173, 270);
            this.ComboBoxColorList.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxColorList.Name = "ComboBoxColorList";
            this.ComboBoxColorList.Size = new System.Drawing.Size(224, 37);
            this.ComboBoxColorList.TabIndex = 15;
            this.ComboBoxColorList.SelectedIndexChanged += new System.EventHandler(this.ComboBoxColorList_SelectedIndexChanged);
            // 
            // CheckBxBar36
            // 
            this.CheckBxBar36.AutoSize = true;
            this.CheckBxBar36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBxBar36.Location = new System.Drawing.Point(206, 121);
            this.CheckBxBar36.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBxBar36.Name = "CheckBxBar36";
            this.CheckBxBar36.Size = new System.Drawing.Size(112, 33);
            this.CheckBxBar36.TabIndex = 14;
            this.CheckBxBar36.Text = "36\" Bar";
            this.CheckBxBar36.UseVisualStyleBackColor = true;
            this.CheckBxBar36.Visible = false;
            this.CheckBxBar36.CheckedChanged += new System.EventHandler(this.Bar36CheckBx_CheckedChanged);
            // 
            // CheckBxBar27
            // 
            this.CheckBxBar27.AutoSize = true;
            this.CheckBxBar27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBxBar27.Location = new System.Drawing.Point(206, 80);
            this.CheckBxBar27.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBxBar27.Name = "CheckBxBar27";
            this.CheckBxBar27.Size = new System.Drawing.Size(112, 33);
            this.CheckBxBar27.TabIndex = 13;
            this.CheckBxBar27.Text = "27\" Bar";
            this.CheckBxBar27.UseVisualStyleBackColor = true;
            this.CheckBxBar27.Visible = false;
            this.CheckBxBar27.CheckedChanged += new System.EventHandler(this.Bar27CheckBx_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Length (ft)";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Color #";
            // 
            // RadioBtnBar
            // 
            this.RadioBtnBar.AutoSize = true;
            this.RadioBtnBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtnBar.Location = new System.Drawing.Point(25, 121);
            this.RadioBtnBar.Margin = new System.Windows.Forms.Padding(4);
            this.RadioBtnBar.Name = "RadioBtnBar";
            this.RadioBtnBar.Size = new System.Drawing.Size(71, 33);
            this.RadioBtnBar.TabIndex = 8;
            this.RadioBtnBar.TabStop = true;
            this.RadioBtnBar.Text = "Bar";
            this.RadioBtnBar.UseVisualStyleBackColor = true;
            this.RadioBtnBar.CheckedChanged += new System.EventHandler(this.BarRadioBtn_CheckedChanged);
            // 
            // RadioBtnVanity
            // 
            this.RadioBtnVanity.AutoSize = true;
            this.RadioBtnVanity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtnVanity.Location = new System.Drawing.Point(25, 79);
            this.RadioBtnVanity.Margin = new System.Windows.Forms.Padding(4);
            this.RadioBtnVanity.Name = "RadioBtnVanity";
            this.RadioBtnVanity.Size = new System.Drawing.Size(98, 33);
            this.RadioBtnVanity.TabIndex = 7;
            this.RadioBtnVanity.TabStop = true;
            this.RadioBtnVanity.Text = "Vanity";
            this.RadioBtnVanity.UseVisualStyleBackColor = true;
            this.RadioBtnVanity.CheckedChanged += new System.EventHandler(this.VanityRadioBtn_CheckedChanged);
            // 
            // RadioBtnKitchen
            // 
            this.RadioBtnKitchen.AutoSize = true;
            this.RadioBtnKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtnKitchen.Location = new System.Drawing.Point(25, 37);
            this.RadioBtnKitchen.Margin = new System.Windows.Forms.Padding(4);
            this.RadioBtnKitchen.Name = "RadioBtnKitchen";
            this.RadioBtnKitchen.Size = new System.Drawing.Size(114, 33);
            this.RadioBtnKitchen.TabIndex = 6;
            this.RadioBtnKitchen.TabStop = true;
            this.RadioBtnKitchen.Text = "Kitchen";
            this.RadioBtnKitchen.UseVisualStyleBackColor = true;
            this.RadioBtnKitchen.CheckedChanged += new System.EventHandler(this.KitchenRadioBtn_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripFileBtn,
            this.toolStripButton1,
            this.toolStripSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(1);
            this.toolStrip1.Size = new System.Drawing.Size(1260, 34);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripFileBtn
            // 
            this.ToolStripFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripFileBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuCurrentInvetory,
            this.ToolStripMenuPrintReport,
            this.ToolStripMenuAddColor,
            this.removeColorToolStripMenuItem});
            this.ToolStripFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripFileBtn.Name = "ToolStripFileBtn";
            this.ToolStripFileBtn.Size = new System.Drawing.Size(55, 29);
            this.ToolStripFileBtn.Text = "File";
            // 
            // ToolStripMenuCurrentInvetory
            // 
            this.ToolStripMenuCurrentInvetory.Name = "ToolStripMenuCurrentInvetory";
            this.ToolStripMenuCurrentInvetory.Size = new System.Drawing.Size(274, 30);
            this.ToolStripMenuCurrentInvetory.Text = "Current Inventory";
            this.ToolStripMenuCurrentInvetory.Click += new System.EventHandler(this.ToolStripMenuCurrentInvetory_Click);
            // 
            // ToolStripMenuPrintReport
            // 
            this.ToolStripMenuPrintReport.Name = "ToolStripMenuPrintReport";
            this.ToolStripMenuPrintReport.Size = new System.Drawing.Size(274, 30);
            this.ToolStripMenuPrintReport.Text = "Print Inventory Report";
            this.ToolStripMenuPrintReport.Click += new System.EventHandler(this.ToolStripMenuPrintReport_Click);
            // 
            // ToolStripMenuAddColor
            // 
            this.ToolStripMenuAddColor.Name = "ToolStripMenuAddColor";
            this.ToolStripMenuAddColor.Size = new System.Drawing.Size(274, 30);
            this.ToolStripMenuAddColor.Text = "Add Color";
            this.ToolStripMenuAddColor.Click += new System.EventHandler(this.ToolStripMenuAddColor_Click);
            // 
            // removeColorToolStripMenuItem
            // 
            this.removeColorToolStripMenuItem.Name = "removeColorToolStripMenuItem";
            this.removeColorToolStripMenuItem.Size = new System.Drawing.Size(274, 30);
            this.removeColorToolStripMenuItem.Text = "Remove Color";
            this.removeColorToolStripMenuItem.Click += new System.EventHandler(this.removeColorToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Image = global::CuttingEdgeInvMgmtSystem.Properties.Resources.Save_16x;
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(24, 29);
            this.toolStripSave.Text = "toolStripSaveChanges";
            this.toolStripSave.ToolTipText = "Saves all changes to database\r\n";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // GroupBxAddColor
            // 
            this.GroupBxAddColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBxAddColor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GroupBxAddColor.Controls.Add(this.label3);
            this.GroupBxAddColor.Controls.Add(this.BtnAddColor);
            this.GroupBxAddColor.Controls.Add(this.TxtBxAddColor);
            this.GroupBxAddColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBxAddColor.Location = new System.Drawing.Point(870, 73);
            this.GroupBxAddColor.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBxAddColor.Name = "GroupBxAddColor";
            this.GroupBxAddColor.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBxAddColor.Size = new System.Drawing.Size(374, 254);
            this.GroupBxAddColor.TabIndex = 17;
            this.GroupBxAddColor.TabStop = false;
            this.GroupBxAddColor.Text = "Add Color";
            this.GroupBxAddColor.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Color #";
            // 
            // BtnAddColor
            // 
            this.BtnAddColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddColor.Location = new System.Drawing.Point(89, 148);
            this.BtnAddColor.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddColor.Name = "BtnAddColor";
            this.BtnAddColor.Size = new System.Drawing.Size(212, 62);
            this.BtnAddColor.TabIndex = 17;
            this.BtnAddColor.Text = "Add";
            this.BtnAddColor.UseVisualStyleBackColor = true;
            this.BtnAddColor.Click += new System.EventHandler(this.BtnAddColor_Click_1);
            // 
            // TxtBxAddColor
            // 
            this.TxtBxAddColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxAddColor.Location = new System.Drawing.Point(137, 63);
            this.TxtBxAddColor.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBxAddColor.Name = "TxtBxAddColor";
            this.TxtBxAddColor.Size = new System.Drawing.Size(204, 34);
            this.TxtBxAddColor.TabIndex = 17;
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1260, 761);
            this.Controls.Add(this.GroupBxAddColor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.EnterDataBox);
            this.Controls.Add(this.InfoList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1278, 808);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuttingEdge Inventory Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnterDataBox.ResumeLayout(false);
            this.EnterDataBox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GroupBxAddColor.ResumeLayout(false);
            this.GroupBxAddColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.ListBox InfoList;
        private System.Windows.Forms.TextBox TxtBxLength;
        private System.Windows.Forms.GroupBox EnterDataBox;
        private System.Windows.Forms.RadioButton RadioBtnBar;
        private System.Windows.Forms.RadioButton RadioBtnVanity;
        private System.Windows.Forms.RadioButton RadioBtnKitchen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBxBar36;
        private System.Windows.Forms.CheckBox CheckBxBar27;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox ComboBoxColorList;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripFileBtn;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuAddColor;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.GroupBox GroupBxAddColor;
        private System.Windows.Forms.Button BtnAddColor;
        private System.Windows.Forms.TextBox TxtBxAddColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuCurrentInvetory;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuPrintReport;
        private System.Windows.Forms.ToolStripMenuItem removeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripSave;
    }
}

