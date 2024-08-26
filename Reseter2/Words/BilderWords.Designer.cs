namespace Reseter2.Words
{
    partial class BilderWords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilderWords));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_saveClose = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_deleteItem = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bt_newPC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_newCat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(225, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 502);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 480);
            this.panel1.TabIndex = 0;
            // 
            // bt_close
            // 
            this.bt_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_close.Location = new System.Drawing.Point(417, 521);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 4;
            this.bt_close.Text = "Закрыть";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_saveClose
            // 
            this.bt_saveClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_saveClose.Location = new System.Drawing.Point(280, 521);
            this.bt_saveClose.Name = "bt_saveClose";
            this.bt_saveClose.Size = new System.Drawing.Size(131, 23);
            this.bt_saveClose.TabIndex = 5;
            this.bt_saveClose.Text = "Сохранить и закрыть";
            this.bt_saveClose.UseVisualStyleBackColor = true;
            this.bt_saveClose.Click += new System.EventHandler(this.bt_saveClose_Click);
            // 
            // bt_save
            // 
            this.bt_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_save.Location = new System.Drawing.Point(199, 521);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Сохранить";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_deleteItem
            // 
            this.bt_deleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_deleteItem.Location = new System.Drawing.Point(12, 521);
            this.bt_deleteItem.Name = "bt_deleteItem";
            this.bt_deleteItem.Size = new System.Drawing.Size(112, 23);
            this.bt_deleteItem.TabIndex = 9;
            this.bt_deleteItem.Text = "Удалить элемент";
            this.bt_deleteItem.UseVisualStyleBackColor = true;
            this.bt_deleteItem.Click += new System.EventHandler(this.bt_deleteItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.ItemHeight = 16;
            this.treeView1.Location = new System.Drawing.Point(9, 42);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 1;
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(207, 470);
            this.treeView1.TabIndex = 4;
            this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "11favicon.ico");
            this.imageList1.Images.SetKeyName(1, "16favicon.ico");
            this.imageList1.Images.SetKeyName(2, "12favicon.ico");
            this.imageList1.Images.SetKeyName(3, "13favicon.ico");
            this.imageList1.Images.SetKeyName(4, "14favicon.ico");
            this.imageList1.Images.SetKeyName(5, "15favicon.ico");
            this.imageList1.Images.SetKeyName(6, "17favicon.ico");
            this.imageList1.Images.SetKeyName(7, "18favicon.ico");
            this.imageList1.Images.SetKeyName(8, "40favicon.ico");
            // 
            // bt_newPC
            // 
            this.bt_newPC.Location = new System.Drawing.Point(76, 13);
            this.bt_newPC.Name = "bt_newPC";
            this.bt_newPC.Size = new System.Drawing.Size(34, 23);
            this.bt_newPC.TabIndex = 10;
            this.bt_newPC.Tag = "pc";
            this.bt_newPC.Text = "+";
            this.bt_newPC.UseVisualStyleBackColor = true;
            this.bt_newPC.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Компьютер";
            // 
            // bt_newCat
            // 
            this.bt_newCat.Location = new System.Drawing.Point(180, 13);
            this.bt_newCat.Name = "bt_newCat";
            this.bt_newCat.Size = new System.Drawing.Size(34, 23);
            this.bt_newCat.TabIndex = 12;
            this.bt_newCat.Tag = "cat";
            this.bt_newCat.Text = "+";
            this.bt_newCat.UseVisualStyleBackColor = true;
            this.bt_newCat.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Категория";
            // 
            // BilderWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 556);
            this.Controls.Add(this.bt_newCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_newPC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.bt_deleteItem);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_saveClose);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(520, 595);
            this.Name = "BilderWords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор справочника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BilderWords_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_saveClose;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_deleteItem;
        private System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button bt_newPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_newCat;
        private System.Windows.Forms.Label label2;
    }
}