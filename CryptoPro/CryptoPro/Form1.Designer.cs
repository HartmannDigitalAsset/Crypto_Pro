namespace CryptoPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblUpdated = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colTicker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.btnWatch = new System.Windows.Forms.Button();
            this.btnViewWatch = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaxSupply = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.imgArrow = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl7Days = new System.Windows.Forms.Label();
            this.lbl24Hours = new System.Windows.Forms.Label();
            this.lblOneHour = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSupply = new System.Windows.Forms.Label();
            this.lblMarketCap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgArrow)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.Location = new System.Drawing.Point(142, 612);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(16, 13);
            this.lblUpdated.TabIndex = 5;
            this.lblUpdated.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Market Data Last Updated:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTicker,
            this.colName,
            this.colPrice});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(12, 148);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(444, 453);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // colTicker
            // 
            this.colTicker.Text = "Ticker";
            this.colTicker.Width = 100;
            // 
            // colName
            // 
            this.colName.Text = "Asset Name";
            this.colName.Width = 150;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price (USD)";
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPrice.Width = 100;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(313, 607);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // piclogo
            // 
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(12, 24);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(444, 105);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 7;
            this.piclogo.TabStop = false;
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(525, 481);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(259, 25);
            this.btnWatch.TabIndex = 8;
            this.btnWatch.Text = "Save to Watchlist";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // btnViewWatch
            // 
            this.btnViewWatch.Location = new System.Drawing.Point(525, 510);
            this.btnViewWatch.Name = "btnViewWatch";
            this.btnViewWatch.Size = new System.Drawing.Size(259, 25);
            this.btnViewWatch.TabIndex = 9;
            this.btnViewWatch.Text = "Open Watchlist";
            this.btnViewWatch.UseVisualStyleBackColor = true;
            this.btnViewWatch.Click += new System.EventHandler(this.btnViewWatch_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(600, 173);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 24);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "----";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblMaxSupply);
            this.groupBox1.Controls.Add(this.lbl7);
            this.groupBox1.Controls.Add(this.lblRank);
            this.groupBox1.Controls.Add(this.imgArrow);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblSupply);
            this.groupBox1.Controls.Add(this.lblMarketCap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Location = new System.Drawing.Point(462, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 275);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Maximum Supply";
            // 
            // lblMaxSupply
            // 
            this.lblMaxSupply.AutoSize = true;
            this.lblMaxSupply.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaxSupply.Location = new System.Drawing.Point(207, 223);
            this.lblMaxSupply.MinimumSize = new System.Drawing.Size(150, 18);
            this.lblMaxSupply.Name = "lblMaxSupply";
            this.lblMaxSupply.Size = new System.Drawing.Size(150, 18);
            this.lblMaxSupply.TabIndex = 16;
            this.lblMaxSupply.Text = "--";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(204, 161);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(105, 13);
            this.lbl7.TabIndex = 15;
            this.lbl7.Text = "Rank by Market Cap";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRank.Location = new System.Drawing.Point(207, 178);
            this.lblRank.MinimumSize = new System.Drawing.Size(150, 18);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(150, 18);
            this.lblRank.TabIndex = 14;
            this.lblRank.Text = "--";
            // 
            // imgArrow
            // 
            this.imgArrow.Location = new System.Drawing.Point(327, 9);
            this.imgArrow.Name = "imgArrow";
            this.imgArrow.Size = new System.Drawing.Size(40, 38);
            this.imgArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgArrow.TabIndex = 13;
            this.imgArrow.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl7Days);
            this.groupBox2.Controls.Add(this.lbl24Hours);
            this.groupBox2.Controls.Add(this.lblOneHour);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(18, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 69);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Percent Change";
            // 
            // lbl7Days
            // 
            this.lbl7Days.AutoSize = true;
            this.lbl7Days.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl7Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7Days.Location = new System.Drawing.Point(229, 37);
            this.lbl7Days.Name = "lbl7Days";
            this.lbl7Days.Size = new System.Drawing.Size(30, 18);
            this.lbl7Days.TabIndex = 5;
            this.lbl7Days.Text = "----";
            // 
            // lbl24Hours
            // 
            this.lbl24Hours.AutoSize = true;
            this.lbl24Hours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl24Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl24Hours.Location = new System.Drawing.Point(141, 37);
            this.lbl24Hours.Name = "lbl24Hours";
            this.lbl24Hours.Size = new System.Drawing.Size(30, 18);
            this.lbl24Hours.TabIndex = 4;
            this.lbl24Hours.Text = "----";
            // 
            // lblOneHour
            // 
            this.lblOneHour.AutoSize = true;
            this.lblOneHour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOneHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneHour.Location = new System.Drawing.Point(45, 37);
            this.lblOneHour.Name = "lblOneHour";
            this.lblOneHour.Size = new System.Drawing.Size(30, 18);
            this.lblOneHour.TabIndex = 3;
            this.lblOneHour.Text = "----";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "7 Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "24 hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "1 Hour";
            // 
            // lblSupply
            // 
            this.lblSupply.AutoSize = true;
            this.lblSupply.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSupply.Location = new System.Drawing.Point(18, 223);
            this.lblSupply.MinimumSize = new System.Drawing.Size(150, 18);
            this.lblSupply.Name = "lblSupply";
            this.lblSupply.Size = new System.Drawing.Size(150, 18);
            this.lblSupply.TabIndex = 4;
            this.lblSupply.Text = "--";
            // 
            // lblMarketCap
            // 
            this.lblMarketCap.AutoSize = true;
            this.lblMarketCap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMarketCap.Location = new System.Drawing.Point(18, 178);
            this.lblMarketCap.MinimumSize = new System.Drawing.Size(150, 18);
            this.lblMarketCap.Name = "lblMarketCap";
            this.lblMarketCap.Size = new System.Drawing.Size(150, 18);
            this.lblMarketCap.TabIndex = 3;
            this.lblMarketCap.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Circulating Supply";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Market Capitalization";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(138, 16);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 20);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "----";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Select an Asset to View Trading Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 636);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnViewWatch);
            this.Controls.Add(this.piclogo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.lblUpdated);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CryptoPro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgArrow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colTicker;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Button btnViewWatch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgArrow;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSupply;
        private System.Windows.Forms.Label lblMarketCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl7Days;
        private System.Windows.Forms.Label lbl24Hours;
        private System.Windows.Forms.Label lblOneHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMaxSupply;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label label8;
    }
}

