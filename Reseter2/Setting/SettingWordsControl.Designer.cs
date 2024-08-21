namespace Reseter2.Setting
{
    partial class SettingWordsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_path_open = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_wordsBilder = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_path_open);
            this.groupBox1.Controls.Add(this.path);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bt_wordsBilder);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры справочника";
            // 
            // bt_path_open
            // 
            this.bt_path_open.Location = new System.Drawing.Point(348, 36);
            this.bt_path_open.Name = "bt_path_open";
            this.bt_path_open.Size = new System.Drawing.Size(27, 23);
            this.bt_path_open.TabIndex = 3;
            this.bt_path_open.Text = "...";
            this.bt_path_open.UseVisualStyleBackColor = true;
            this.bt_path_open.Click += new System.EventHandler(this.bt_path_open_Click);
            // 
            // path
            // 
            this.path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.path.Location = new System.Drawing.Point(10, 37);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(339, 20);
            this.path.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Файл базы данных";
            // 
            // bt_wordsBilder
            // 
            this.bt_wordsBilder.Location = new System.Drawing.Point(220, 65);
            this.bt_wordsBilder.Name = "bt_wordsBilder";
            this.bt_wordsBilder.Size = new System.Drawing.Size(155, 23);
            this.bt_wordsBilder.TabIndex = 0;
            this.bt_wordsBilder.Text = "Редактор справочника";
            this.bt_wordsBilder.UseVisualStyleBackColor = true;
            this.bt_wordsBilder.Click += new System.EventHandler(this.bt_wordsBilder_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.DefaultExt = "*.wb";
            this.openFileDialog1.Filter = "База справочника|*.wb";
            // 
            // SettingWordsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingWordsControl";
            this.Size = new System.Drawing.Size(391, 103);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_path_open;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_wordsBilder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
