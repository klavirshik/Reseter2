namespace Reseter2.Words
{
    partial class WordsCategoryControl
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
            this.Select = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flow_wordsItem = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Select
            // 
            this.Select.AutoSize = true;
            this.Select.Location = new System.Drawing.Point(6, 2);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(15, 14);
            this.Select.TabIndex = 1;
            this.Select.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "____________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вебинарные ПК";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(366, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "⟱";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flow_wordsItem
            // 
            this.flow_wordsItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flow_wordsItem.AutoSize = true;
            this.flow_wordsItem.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_wordsItem.Location = new System.Drawing.Point(0, 20);
            this.flow_wordsItem.Name = "flow_wordsItem";
            this.flow_wordsItem.Size = new System.Drawing.Size(403, 5);
            this.flow_wordsItem.TabIndex = 4;
            this.flow_wordsItem.WrapContents = false;
            // 
            // WordsCategoryControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flow_wordsItem);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "WordsCategoryControl";
            this.Size = new System.Drawing.Size(403, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox Select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flow_wordsItem;
    }
}
