namespace demo_Hospital_scheduling
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonHost1 = new System.Windows.Forms.RibbonHost();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.scheduling_Interface = new System.Windows.Forms.RibbonTab();
            this.scheduling_Management = new System.Windows.Forms.RibbonPanel();
            this.existing_Sform = new System.Windows.Forms.RibbonButton();
            this.new_Sform = new System.Windows.Forms.RibbonButton();
            this.modify_Sform = new System.Windows.Forms.RibbonButton();
            this.application_Management = new System.Windows.Forms.RibbonPanel();
            this.manage_application = new System.Windows.Forms.RibbonButton();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsedUnit = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_jobtitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_office = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonHost1
            // 
            this.ribbonHost1.HostedControl = null;
            // 
            // ribbon1
            // 
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.Size = new System.Drawing.Size(1360, 120);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.scheduling_Interface);
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.ribbon1.Text = "ribbon1";
            // 
            // scheduling_Interface
            // 
            this.scheduling_Interface.Panels.Add(this.scheduling_Management);
            this.scheduling_Interface.Panels.Add(this.application_Management);
            this.scheduling_Interface.Text = "排班业务";
            this.scheduling_Interface.ToolTipImage = global::demo_Hospital_scheduling.Properties.Resources.ooopic_1381464674;
            // 
            // scheduling_Management
            // 
            this.scheduling_Management.Items.Add(this.existing_Sform);
            this.scheduling_Management.Items.Add(this.new_Sform);
            this.scheduling_Management.Items.Add(this.modify_Sform);
            this.scheduling_Management.Text = "排班管理";
            // 
            // existing_Sform
            // 
            this.existing_Sform.CheckOnClick = true;
            this.existing_Sform.Image = global::demo_Hospital_scheduling.Properties.Resources.ooopic_1381465595;
            this.existing_Sform.SmallImage = ((System.Drawing.Image)(resources.GetObject("existing_Sform.SmallImage")));
            this.existing_Sform.Tag = "Existing_Sform";
            this.existing_Sform.Text = "已有排班表";
            this.existing_Sform.Click += new System.EventHandler(this.existing_Sform_Click_1);
            // 
            // new_Sform
            // 
            this.new_Sform.CheckOnClick = true;
            this.new_Sform.Image = global::demo_Hospital_scheduling.Properties.Resources.ooopic_1381481519;
            this.new_Sform.SmallImage = ((System.Drawing.Image)(resources.GetObject("new_Sform.SmallImage")));
            this.new_Sform.Tag = "New_Sform";
            this.new_Sform.Text = "新建排班表";
            this.new_Sform.Click += new System.EventHandler(this.new_Sform_Click);
            // 
            // modify_Sform
            // 
            this.modify_Sform.CheckOnClick = true;
            this.modify_Sform.Image = global::demo_Hospital_scheduling.Properties.Resources.ooopic_1381464184;
            this.modify_Sform.SmallImage = ((System.Drawing.Image)(resources.GetObject("modify_Sform.SmallImage")));
            this.modify_Sform.Tag = "Modify_Sform";
            this.modify_Sform.Text = "修改排班表";
            this.modify_Sform.Click += new System.EventHandler(this.modify_Sform_Click);
            // 
            // application_Management
            // 
            this.application_Management.Items.Add(this.manage_application);
            this.application_Management.Text = "申请管理";
            // 
            // manage_application
            // 
            this.manage_application.CheckOnClick = true;
            this.manage_application.Image = global::demo_Hospital_scheduling.Properties.Resources.ooopic_1381464139;
            this.manage_application.SmallImage = ((System.Drawing.Image)(resources.GetObject("manage_application.SmallImage")));
            this.manage_application.Tag = "Manage_application";
            this.manage_application.Text = "查看并处理申请";
            this.manage_application.Click += new System.EventHandler(this.manage_application_Click);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel5);
            this.ribbonTab1.Text = "查询业务";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.ribbonButton1);
            this.ribbonPanel5.Text = "查询排班";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.CheckOnClick = true;
            this.ribbonButton1.Image = global::demo_Hospital_scheduling.Properties.Resources.jobsearch;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Tag = "Query_scheduling_form";
            this.ribbonButton1.Text = "查询并申请";
            this.ribbonButton1.Click += new System.EventHandler(this.ribbonButton1_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Text = null;
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Text = null;
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Text = null;
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Text = null;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblUsedUnit);
            this.panel2.Location = new System.Drawing.Point(12, 673);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1336, 45);
            this.panel2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(1169, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(819, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(137, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "南方医科大学";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(464, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "office";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(1086, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "当前日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(736, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(400, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "科室：";
            // 
            // lblUsedUnit
            // 
            this.lblUsedUnit.AutoSize = true;
            this.lblUsedUnit.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUsedUnit.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblUsedUnit.Location = new System.Drawing.Point(36, 18);
            this.lblUsedUnit.Name = "lblUsedUnit";
            this.lblUsedUnit.Size = new System.Drawing.Size(77, 13);
            this.lblUsedUnit.TabIndex = 1;
            this.lblUsedUnit.Text = "使用单位：";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(291, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1057, 541);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(12, 323);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 344);
            this.panel4.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "公告栏";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 286);
            this.textBox1.TabIndex = 3;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(149, 21);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "与我相关";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(82, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "科室";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "医院";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.label_jobtitle);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label_id);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label_office);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label_name);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 180);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "职工信息";
            // 
            // label_jobtitle
            // 
            this.label_jobtitle.AutoSize = true;
            this.label_jobtitle.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_jobtitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_jobtitle.Location = new System.Drawing.Point(193, 140);
            this.label_jobtitle.Name = "label_jobtitle";
            this.label_jobtitle.Size = new System.Drawing.Size(63, 13);
            this.label_jobtitle.TabIndex = 12;
            this.label_jobtitle.Text = "jobtitle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(146, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "职称：";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_id.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_id.Location = new System.Drawing.Point(193, 72);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 13);
            this.label_id.TabIndex = 10;
            this.label_id.Text = "id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(146, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "ID：";
            // 
            // label_office
            // 
            this.label_office.AutoSize = true;
            this.label_office.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_office.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_office.Location = new System.Drawing.Point(193, 106);
            this.label_office.Name = "label_office";
            this.label_office.Size = new System.Drawing.Size(49, 13);
            this.label_office.TabIndex = 8;
            this.label_office.Text = "office";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(146, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "科室：";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_name.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_name.Location = new System.Drawing.Point(193, 38);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(146, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "姓名：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::demo_Hospital_scheduling.Properties.Resources.ooopic_1381464799;
            this.pictureBox1.Location = new System.Drawing.Point(9, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(12, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 191);
            this.panel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1360, 730);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "排班系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RibbonHost ribbonHost1;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab scheduling_Interface;
        private System.Windows.Forms.RibbonPanel scheduling_Management;
        private System.Windows.Forms.RibbonButton existing_Sform;
        private System.Windows.Forms.RibbonButton new_Sform;
        private System.Windows.Forms.RibbonButton modify_Sform;
        private System.Windows.Forms.RibbonPanel application_Management;
        private System.Windows.Forms.RibbonButton manage_application;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUsedUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_jobtitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_office;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
    }
}

