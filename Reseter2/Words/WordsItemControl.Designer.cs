namespace Reseter2.Words
{
    partial class WordsItemControl
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ip = new System.Windows.Forms.Label();
            this.lb_dsp = new System.Windows.Forms.Label();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя ПК";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(103, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(0, 13);
            this.lb_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP-адрес";
            // 
            // lb_ip
            // 
            this.lb_ip.AutoSize = true;
            this.lb_ip.Location = new System.Drawing.Point(239, 0);
            this.lb_ip.Name = "lb_ip";
            this.lb_ip.Size = new System.Drawing.Size(0, 13);
            this.lb_ip.TabIndex = 4;
            // 
            // lb_dsp
            // 
            this.lb_dsp.AutoSize = true;
            this.lb_dsp.Location = new System.Drawing.Point(50, 13);
            this.lb_dsp.Name = "lb_dsp";
            this.lb_dsp.Size = new System.Drawing.Size(0, 13);
            this.lb_dsp.TabIndex = 6;
            // 
            // pb_icon
            // 
            this.pb_icon.Location = new System.Drawing.Point(27, 3);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(20, 20);
            this.pb_icon.TabIndex = 7;
            this.pb_icon.TabStop = false;
            // 
            // WordsItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_icon);
            this.Controls.Add(this.lb_dsp);
            this.Controls.Add(this.lb_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Name = "WordsItemControl";
            this.Size = new System.Drawing.Size(371, 27);
            this.Load += new System.EventHandler(this.WordsItemControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ip;
        private System.Windows.Forms.Label lb_dsp;
        private System.Windows.Forms.PictureBox pb_icon;
    }
}
