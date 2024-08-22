namespace Reseter2.Setting
{
    partial class SettingSCCMControl
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_checkConnect = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ib_password = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ib_username = new System.Windows.Forms.TextBox();
            this.cb_windowsAuth = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ib_dataBase = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ib_server = new System.Windows.Forms.TextBox();
            this.cb_on = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_checkConnect);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ib_password);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ib_username);
            this.groupBox2.Controls.Add(this.cb_windowsAuth);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ib_dataBase);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ib_server);
            this.groupBox2.Controls.Add(this.cb_on);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 173);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры поиска";
            // 
            // bt_checkConnect
            // 
            this.bt_checkConnect.Location = new System.Drawing.Point(263, 143);
            this.bt_checkConnect.Name = "bt_checkConnect";
            this.bt_checkConnect.Size = new System.Drawing.Size(112, 23);
            this.bt_checkConnect.TabIndex = 11;
            this.bt_checkConnect.Text = "Проверить связь";
            this.bt_checkConnect.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Пароль";
            // 
            // ib_password
            // 
            this.ib_password.Location = new System.Drawing.Point(193, 117);
            this.ib_password.Name = "ib_password";
            this.ib_password.PasswordChar = '•';
            this.ib_password.Size = new System.Drawing.Size(182, 20);
            this.ib_password.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Логин";
            // 
            // ib_username
            // 
            this.ib_username.Location = new System.Drawing.Point(6, 117);
            this.ib_username.Name = "ib_username";
            this.ib_username.Size = new System.Drawing.Size(181, 20);
            this.ib_username.TabIndex = 7;
            // 
            // cb_windowsAuth
            // 
            this.cb_windowsAuth.AutoSize = true;
            this.cb_windowsAuth.Location = new System.Drawing.Point(10, 82);
            this.cb_windowsAuth.Name = "cb_windowsAuth";
            this.cb_windowsAuth.Size = new System.Drawing.Size(157, 17);
            this.cb_windowsAuth.TabIndex = 6;
            this.cb_windowsAuth.Text = "Аутентификация Windows";
            this.cb_windowsAuth.UseVisualStyleBackColor = true;
            this.cb_windowsAuth.CheckedChanged += new System.EventHandler(this.cb_windowsAuth_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "База данных";
            // 
            // ib_dataBase
            // 
            this.ib_dataBase.Location = new System.Drawing.Point(193, 55);
            this.ib_dataBase.Name = "ib_dataBase";
            this.ib_dataBase.Size = new System.Drawing.Size(182, 20);
            this.ib_dataBase.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Сервер базы данных";
            // 
            // ib_server
            // 
            this.ib_server.Location = new System.Drawing.Point(6, 55);
            this.ib_server.Name = "ib_server";
            this.ib_server.Size = new System.Drawing.Size(181, 20);
            this.ib_server.TabIndex = 1;
            // 
            // cb_on
            // 
            this.cb_on.AutoSize = true;
            this.cb_on.Location = new System.Drawing.Point(10, 20);
            this.cb_on.Name = "cb_on";
            this.cb_on.Size = new System.Drawing.Size(215, 17);
            this.cb_on.TabIndex = 0;
            this.cb_on.Text = "Связь с SCCM (помощь в поиске ПК)";
            this.cb_on.UseVisualStyleBackColor = true;
            this.cb_on.CheckedChanged += new System.EventHandler(this.cb_on_CheckedChanged);
            // 
            // SettingSCCMControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "SettingSCCMControl";
            this.Size = new System.Drawing.Size(391, 178);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_checkConnect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ib_password;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ib_username;
        private System.Windows.Forms.CheckBox cb_windowsAuth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ib_dataBase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ib_server;
        private System.Windows.Forms.CheckBox cb_on;
    }
}
