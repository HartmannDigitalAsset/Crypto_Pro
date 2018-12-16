namespace CryptoPro
{
    partial class Form2
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
            System.Windows.Forms.Label cryptoName1Label;
            System.Windows.Forms.Label cryptoTick1Label;
            System.Windows.Forms.Label description1Label;
            System.Windows.Forms.Label watchPrice1Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.cryptoName1TextBox = new System.Windows.Forms.TextBox();
            this.cryptoTick1TextBox = new System.Windows.Forms.TextBox();
            this.description1TextBox = new System.Windows.Forms.TextBox();
            this.watchPrice1TextBox = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.watchingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cryptoName1Label = new System.Windows.Forms.Label();
            cryptoTick1Label = new System.Windows.Forms.Label();
            description1Label = new System.Windows.Forms.Label();
            watchPrice1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cryptoName1Label
            // 
            cryptoName1Label.AutoSize = true;
            cryptoName1Label.Location = new System.Drawing.Point(47, 104);
            cryptoName1Label.Name = "cryptoName1Label";
            cryptoName1Label.Size = new System.Drawing.Size(35, 13);
            cryptoName1Label.TabIndex = 1;
            cryptoName1Label.Text = "Name";
            // 
            // cryptoTick1Label
            // 
            cryptoTick1Label.AutoSize = true;
            cryptoTick1Label.Location = new System.Drawing.Point(45, 127);
            cryptoTick1Label.Name = "cryptoTick1Label";
            cryptoTick1Label.Size = new System.Drawing.Size(37, 13);
            cryptoTick1Label.TabIndex = 3;
            cryptoTick1Label.Text = "Ticker";
            // 
            // description1Label
            // 
            description1Label.AutoSize = true;
            description1Label.Location = new System.Drawing.Point(47, 173);
            description1Label.Name = "description1Label";
            description1Label.Size = new System.Drawing.Size(35, 13);
            description1Label.TabIndex = 5;
            description1Label.Text = "Notes";
            // 
            // watchPrice1Label
            // 
            watchPrice1Label.AutoSize = true;
            watchPrice1Label.Location = new System.Drawing.Point(16, 150);
            watchPrice1Label.Name = "watchPrice1Label";
            watchPrice1Label.Size = new System.Drawing.Size(66, 13);
            watchPrice1Label.TabIndex = 7;
            watchPrice1Label.Text = "Watch Price";
            // 
            // cryptoName1TextBox
            // 
            this.cryptoName1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watchingBindingSource, "CryptoName1", true));
            this.cryptoName1TextBox.Location = new System.Drawing.Point(88, 101);
            this.cryptoName1TextBox.Name = "cryptoName1TextBox";
            this.cryptoName1TextBox.ReadOnly = true;
            this.cryptoName1TextBox.Size = new System.Drawing.Size(297, 20);
            this.cryptoName1TextBox.TabIndex = 2;
            // 
            // cryptoTick1TextBox
            // 
            this.cryptoTick1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watchingBindingSource, "CryptoTick1", true));
            this.cryptoTick1TextBox.Location = new System.Drawing.Point(88, 124);
            this.cryptoTick1TextBox.Name = "cryptoTick1TextBox";
            this.cryptoTick1TextBox.ReadOnly = true;
            this.cryptoTick1TextBox.Size = new System.Drawing.Size(297, 20);
            this.cryptoTick1TextBox.TabIndex = 4;
            // 
            // description1TextBox
            // 
            this.description1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watchingBindingSource, "Description1", true));
            this.description1TextBox.Location = new System.Drawing.Point(88, 170);
            this.description1TextBox.Multiline = true;
            this.description1TextBox.Name = "description1TextBox";
            this.description1TextBox.Size = new System.Drawing.Size(297, 61);
            this.description1TextBox.TabIndex = 6;
            // 
            // watchPrice1TextBox
            // 
            this.watchPrice1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watchingBindingSource, "WatchPrice1", true));
            this.watchPrice1TextBox.Location = new System.Drawing.Point(88, 147);
            this.watchPrice1TextBox.Name = "watchPrice1TextBox";
            this.watchPrice1TextBox.ReadOnly = true;
            this.watchPrice1TextBox.Size = new System.Drawing.Size(297, 20);
            this.watchPrice1TextBox.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(153, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete from Watchlist";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(88, 237);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 30);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit Notes";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(239, 237);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(70, 30);
            this.btnSave2.TabIndex = 11;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(315, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 30);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(88, 273);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(70, 30);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(163, 273);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 30);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(239, 273);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(70, 30);
            this.btnForward.TabIndex = 15;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(315, 273);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(70, 30);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // watchingBindingSource
            // 
            this.watchingBindingSource.DataSource = typeof(CryptoPro.Watching);
            this.watchingBindingSource.CurrentChanged += new System.EventHandler(this.watchingBindingSource_CurrentChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(watchPrice1Label);
            this.Controls.Add(this.watchPrice1TextBox);
            this.Controls.Add(description1Label);
            this.Controls.Add(this.description1TextBox);
            this.Controls.Add(cryptoTick1Label);
            this.Controls.Add(this.cryptoTick1TextBox);
            this.Controls.Add(cryptoName1Label);
            this.Controls.Add(this.cryptoName1TextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "CryptoWatch";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource watchingBindingSource;
        private System.Windows.Forms.TextBox cryptoName1TextBox;
        private System.Windows.Forms.TextBox cryptoTick1TextBox;
        private System.Windows.Forms.TextBox description1TextBox;
        private System.Windows.Forms.TextBox watchPrice1TextBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}