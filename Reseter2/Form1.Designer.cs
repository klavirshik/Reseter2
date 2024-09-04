namespace Reseter2
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_reset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ss_activ = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_close = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_resetAll = new System.Windows.Forms.Button();
            this.checkControl1 = new Reseter2.CheckControl();
            this.treeView1 = new Reseter2.NewTreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_history = new System.Windows.Forms.ListBox();
            this.cm_history = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sm_RebootItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sm_SaveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.settingRebootControl1 = new Reseter2.Setting.SettingRebootControl();
            this.settingSCCMControl1 = new Reseter2.Setting.SettingSCCMControl();
            this.settingWordsControl1 = new Reseter2.Setting.SettingWordsControl();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cm_words = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.WordsReboot = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_comp = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.cm_history.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cm_words.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя ПК";
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.IndianRed;
            this.bt_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_reset.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_reset.Location = new System.Drawing.Point(283, 10);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(122, 23);
            this.bt_reset.TabIndex = 2;
            this.bt_reset.Text = "Перезагрузить";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(2, 38);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 714);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 688);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задания";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 665);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Очистить все завершенные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ss_activ,
            this.ss_close,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 663);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(396, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ss_activ
            // 
            this.ss_activ.Name = "ss_activ";
            this.ss_activ.Size = new System.Drawing.Size(61, 17);
            this.ss_activ.Text = "Активные";
            this.ss_activ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ss_close
            // 
            this.ss_close.Name = "ss_close";
            this.ss_close.Size = new System.Drawing.Size(85, 17);
            this.ss_close.Text = "Завершенные";
            this.ss_close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(396, 657);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.bt_resetAll);
            this.tabPage2.Controls.Add(this.checkControl1);
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(402, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Справочник";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Все элементы";
            // 
            // bt_resetAll
            // 
            this.bt_resetAll.BackColor = System.Drawing.Color.IndianRed;
            this.bt_resetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_resetAll.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_resetAll.Location = new System.Drawing.Point(224, 6);
            this.bt_resetAll.Name = "bt_resetAll";
            this.bt_resetAll.Size = new System.Drawing.Size(168, 23);
            this.bt_resetAll.TabIndex = 1;
            this.bt_resetAll.Text = "Перезагрузить выделенное";
            this.bt_resetAll.UseVisualStyleBackColor = false;
            this.bt_resetAll.Click += new System.EventHandler(this.bt_resetAll_Click);
            // 
            // checkControl1
            // 
            this.checkControl1.Location = new System.Drawing.Point(14, 7);
            this.checkControl1.Name = "checkControl1";
            this.checkControl1.Size = new System.Drawing.Size(18, 18);
            this.checkControl1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.treeView1.Indent = 27;
            this.treeView1.ItemHeight = 24;
            this.treeView1.Location = new System.Drawing.Point(3, 32);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(396, 653);
            this.treeView1.StateImageList = this.imageList2;
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "11icon-24.png");
            this.imageList1.Images.SetKeyName(1, "16icon-24.png");
            this.imageList1.Images.SetKeyName(2, "12icon-24.png");
            this.imageList1.Images.SetKeyName(3, "13icon-24.png");
            this.imageList1.Images.SetKeyName(4, "14icon-24.png");
            this.imageList1.Images.SetKeyName(5, "15icon-24.png");
            this.imageList1.Images.SetKeyName(6, "17icon-24.png");
            this.imageList1.Images.SetKeyName(7, "17icon2-24.png");
            this.imageList1.Images.SetKeyName(8, "40icon-24.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "off.ico");
            this.imageList2.Images.SetKeyName(1, "on.ico");
            this.imageList2.Images.SetKeyName(2, "or.ico");
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.lb_history);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(402, 688);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "История";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 661);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(327, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Конец";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(269, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Статус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(112, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Время старта";
            // 
            // lb_history
            // 
            this.lb_history.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_history.ContextMenuStrip = this.cm_history;
            this.lb_history.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.lb_history.FormattingEnabled = true;
            this.lb_history.ItemHeight = 15;
            this.lb_history.Location = new System.Drawing.Point(3, 21);
            this.lb_history.Name = "lb_history";
            this.lb_history.Size = new System.Drawing.Size(396, 634);
            this.lb_history.TabIndex = 0;
            this.lb_history.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_history_MouseDown);
            this.lb_history.MouseLeave += new System.EventHandler(this.lb_history_MouseLeave);
            this.lb_history.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb_history_MouseMove);
            // 
            // cm_history
            // 
            this.cm_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cm_history.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sm_RebootItem,
            this.sm_SaveItem});
            this.cm_history.Name = "cm_history";
            this.cm_history.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cm_history.ShowImageMargin = false;
            this.cm_history.Size = new System.Drawing.Size(130, 48);
            this.cm_history.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.cm_history_Closed);
            this.cm_history.Opening += new System.ComponentModel.CancelEventHandler(this.cm_history_Opening);
            // 
            // sm_RebootItem
            // 
            this.sm_RebootItem.Name = "sm_RebootItem";
            this.sm_RebootItem.Size = new System.Drawing.Size(129, 22);
            this.sm_RebootItem.Text = "Перезагрузить";
            this.sm_RebootItem.Click += new System.EventHandler(this.sm_RebootItem_Click);
            // 
            // sm_SaveItem
            // 
            this.sm_SaveItem.Name = "sm_SaveItem";
            this.sm_SaveItem.Size = new System.Drawing.Size(129, 22);
            this.sm_SaveItem.Text = "Сохранить";
            this.sm_SaveItem.Click += new System.EventHandler(this.sm_SaveItem_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.settingRebootControl1);
            this.tabPage4.Controls.Add(this.settingSCCMControl1);
            this.tabPage4.Controls.Add(this.settingWordsControl1);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(402, 688);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Настройки";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // settingRebootControl1
            // 
            this.settingRebootControl1.Location = new System.Drawing.Point(6, 299);
            this.settingRebootControl1.Name = "settingRebootControl1";
            this.settingRebootControl1.Size = new System.Drawing.Size(391, 130);
            this.settingRebootControl1.TabIndex = 7;
            // 
            // settingSCCMControl1
            // 
            this.settingSCCMControl1.Location = new System.Drawing.Point(6, 115);
            this.settingSCCMControl1.Name = "settingSCCMControl1";
            this.settingSCCMControl1.Size = new System.Drawing.Size(391, 178);
            this.settingSCCMControl1.TabIndex = 6;
            // 
            // settingWordsControl1
            // 
            this.settingWordsControl1.Location = new System.Drawing.Point(6, 6);
            this.settingWordsControl1.Name = "settingWordsControl1";
            this.settingWordsControl1.Size = new System.Drawing.Size(391, 103);
            this.settingWordsControl1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(317, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Controls.Add(this.pictureBox1);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(402, 688);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "О программе";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(6, 496);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расшифровка статусов истории";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(237, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Check Net - Проверка связи с удаленным ПК";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Error NET- нету связи с удаленным ПК";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Succes - перезагрузка завершенна успешно";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Canceled - отмененно пользователем";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(329, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Error RST - ПК не начал перезагрузку после отправки команды";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Send RST - отправление команды перезагрузки удаленному ПК";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Rebooting - удаленный пк перезагружаеться";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Error UP - ПК не вышел на связь после перезагрузки";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Stop - остановленно пользователем";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Reseter2";
            // 
            // cm_words
            // 
            this.cm_words.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordsReboot});
            this.cm_words.Name = "cm_words";
            this.cm_words.ShowImageMargin = false;
            this.cm_words.Size = new System.Drawing.Size(125, 26);
            // 
            // WordsReboot
            // 
            this.WordsReboot.Name = "WordsReboot";
            this.WordsReboot.Size = new System.Drawing.Size(124, 22);
            this.WordsReboot.Text = "Перезарузить";
            this.WordsReboot.Click += new System.EventHandler(this.WordsReboot_Click);
            // 
            // tb_comp
            // 
            this.tb_comp.BackColor = System.Drawing.SystemColors.Window;
            this.tb_comp.Location = new System.Drawing.Point(67, 11);
            this.tb_comp.Name = "tb_comp";
            this.tb_comp.Size = new System.Drawing.Size(210, 20);
            this.tb_comp.TabIndex = 5;
            this.tb_comp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_comp_MouseClick);
            this.tb_comp.TextChanged += new System.EventHandler(this.cb_comp_TextUpdate);
            this.tb_comp.Enter += new System.EventHandler(this.tb_comp_Enter);
            this.tb_comp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_comp_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(325, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Многопоточная перезагрузка рабочих станций на ОС Windows";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Версия 2.0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(222, 640);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(170, 39);
            this.label19.TabIndex = 5;
            this.label19.Text = "Разработка\r\nСимаков Владимир Михайлович\r\nklavirshik@yandex.ru";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 640);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(159, 39);
            this.label20.TabIndex = 6;
            this.label20.Text = "Цензура, идеи, тестирование \r\nИлюхин Георгий Николаевич \r\ngeorgii.iliukhin@gmail." +
    "com";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(410, 753);
            this.Controls.Add(this.tb_comp);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reseter2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.cm_history.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cm_words.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lb_history;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip cm_history;
        private System.Windows.Forms.ToolStripMenuItem sm_RebootItem;
        private System.Windows.Forms.ToolStripMenuItem sm_SaveItem;
        private System.Windows.Forms.Button bt_resetAll;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private NewTreeView treeView1;
        private CheckControl checkControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private Setting.SettingWordsControl settingWordsControl1;
        private Setting.SettingRebootControl settingRebootControl1;
        private Setting.SettingSCCMControl settingSCCMControl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ss_activ;
        private System.Windows.Forms.ToolStripStatusLabel ss_close;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip cm_words;
        private System.Windows.Forms.ToolStripMenuItem WordsReboot;
        private System.Windows.Forms.TextBox tb_comp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

