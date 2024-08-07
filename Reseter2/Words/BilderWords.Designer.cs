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
            this.rb_category = new System.Windows.Forms.RadioButton();
            this.rb_comp = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rb_category
            // 
            this.rb_category.AutoSize = true;
            this.rb_category.Checked = true;
            this.rb_category.Location = new System.Drawing.Point(13, 13);
            this.rb_category.Name = "rb_category";
            this.rb_category.Size = new System.Drawing.Size(78, 17);
            this.rb_category.TabIndex = 0;
            this.rb_category.TabStop = true;
            this.rb_category.Text = "Категория";
            this.rb_category.UseVisualStyleBackColor = true;
            this.rb_category.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_comp
            // 
            this.rb_comp.AutoSize = true;
            this.rb_comp.Location = new System.Drawing.Point(97, 13);
            this.rb_comp.Name = "rb_comp";
            this.rb_comp.Size = new System.Drawing.Size(83, 17);
            this.rb_comp.TabIndex = 1;
            this.rb_comp.Text = "Компьютер";
            this.rb_comp.UseVisualStyleBackColor = true;
            // 
            // BilderWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 264);
            this.Controls.Add(this.rb_comp);
            this.Controls.Add(this.rb_category);
            this.Name = "BilderWords";
            this.Text = "BilderWords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_category;
        private System.Windows.Forms.RadioButton rb_comp;
    }
}