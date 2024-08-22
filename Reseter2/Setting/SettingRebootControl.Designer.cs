namespace Reseter2.Setting
{
    partial class SettingRebootControl
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nb_checkConnect = new System.Windows.Forms.NumericUpDown();
            this.nb_timeOutReboot = new System.Windows.Forms.NumericUpDown();
            this.nb_timeCheckBeforReboot = new System.Windows.Forms.NumericUpDown();
            this.nb_sizeHistoryItem = new System.Windows.Forms.NumericUpDown();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_checkConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_timeOutReboot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_timeCheckBeforReboot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_sizeHistoryItem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nb_sizeHistoryItem);
            this.groupBox3.Controls.Add(this.nb_timeCheckBeforReboot);
            this.groupBox3.Controls.Add(this.nb_timeOutReboot);
            this.groupBox3.Controls.Add(this.nb_checkConnect);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 124);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры перезагрузки";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Кол-во записей истории";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(196, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Время контроля после перезагрузки";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Время ожидание перезагрузки";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Кол-во попыток проверки связи";
            // 
            // nb_checkConnect
            // 
            this.nb_checkConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nb_checkConnect.Location = new System.Drawing.Point(184, 18);
            this.nb_checkConnect.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nb_checkConnect.Name = "nb_checkConnect";
            this.nb_checkConnect.Size = new System.Drawing.Size(182, 20);
            this.nb_checkConnect.TabIndex = 13;
            // 
            // nb_timeOutReboot
            // 
            this.nb_timeOutReboot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nb_timeOutReboot.Location = new System.Drawing.Point(184, 44);
            this.nb_timeOutReboot.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nb_timeOutReboot.Name = "nb_timeOutReboot";
            this.nb_timeOutReboot.Size = new System.Drawing.Size(182, 20);
            this.nb_timeOutReboot.TabIndex = 14;
            // 
            // nb_timeCheckBeforReboot
            // 
            this.nb_timeCheckBeforReboot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nb_timeCheckBeforReboot.Location = new System.Drawing.Point(208, 70);
            this.nb_timeCheckBeforReboot.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nb_timeCheckBeforReboot.Name = "nb_timeCheckBeforReboot";
            this.nb_timeCheckBeforReboot.Size = new System.Drawing.Size(158, 20);
            this.nb_timeCheckBeforReboot.TabIndex = 15;
            // 
            // nb_sizeHistoryItem
            // 
            this.nb_sizeHistoryItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nb_sizeHistoryItem.Location = new System.Drawing.Point(184, 96);
            this.nb_sizeHistoryItem.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nb_sizeHistoryItem.Name = "nb_sizeHistoryItem";
            this.nb_sizeHistoryItem.Size = new System.Drawing.Size(182, 20);
            this.nb_sizeHistoryItem.TabIndex = 16;
            // 
            // SettingRebootControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Name = "SettingRebootControl";
            this.Size = new System.Drawing.Size(391, 130);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_checkConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_timeOutReboot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_timeCheckBeforReboot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_sizeHistoryItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nb_timeOutReboot;
        private System.Windows.Forms.NumericUpDown nb_checkConnect;
        private System.Windows.Forms.NumericUpDown nb_sizeHistoryItem;
        private System.Windows.Forms.NumericUpDown nb_timeCheckBeforReboot;
    }
}
