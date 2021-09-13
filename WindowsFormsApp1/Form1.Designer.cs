
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxsalary = new System.Windows.Forms.MaskedTextBox();
            this.button_graph = new System.Windows.Forms.Button();
            this.button_stat = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBoxjob = new System.Windows.Forms.ComboBox();
            this.comboBoxcity = new System.Windows.Forms.ComboBox();
            this.maskedTc = new System.Windows.Forms.MaskedTextBox();
            this.textsname = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_update2 = new System.Windows.Forms.Button();
            this.button_remove2 = new System.Windows.Forms.Button();
            this.button_add2 = new System.Windows.Forms.Button();
            this.textBoxjob = new System.Windows.Forms.TextBox();
            this.textBoxidd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxsalary);
            this.groupBox1.Controls.Add(this.button_graph);
            this.groupBox1.Controls.Add(this.button_stat);
            this.groupBox1.Controls.Add(this.button_update);
            this.groupBox1.Controls.Add(this.button_remove);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.comboBoxjob);
            this.groupBox1.Controls.Add(this.comboBoxcity);
            this.groupBox1.Controls.Add(this.maskedTc);
            this.groupBox1.Controls.Add(this.textsname);
            this.groupBox1.Controls.Add(this.textname);
            this.groupBox1.Controls.Add(this.textid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Informations";
            // 
            // maskedTextBoxsalary
            // 
            this.maskedTextBoxsalary.Location = new System.Drawing.Point(137, 299);
            this.maskedTextBoxsalary.Name = "maskedTextBoxsalary";
            this.maskedTextBoxsalary.Size = new System.Drawing.Size(121, 23);
            this.maskedTextBoxsalary.TabIndex = 23;
            // 
            // button_graph
            // 
            this.button_graph.Location = new System.Drawing.Point(354, 306);
            this.button_graph.Name = "button_graph";
            this.button_graph.Size = new System.Drawing.Size(75, 23);
            this.button_graph.TabIndex = 22;
            this.button_graph.Text = "Graph";
            this.button_graph.UseVisualStyleBackColor = true;
            this.button_graph.Click += new System.EventHandler(this.button_graph_Click);
            // 
            // button_stat
            // 
            this.button_stat.Location = new System.Drawing.Point(354, 277);
            this.button_stat.Name = "button_stat";
            this.button_stat.Size = new System.Drawing.Size(75, 23);
            this.button_stat.TabIndex = 21;
            this.button_stat.Text = "Statistics";
            this.button_stat.UseVisualStyleBackColor = true;
            this.button_stat.Click += new System.EventHandler(this.button_stat_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(354, 249);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 20;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(354, 220);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 19;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(354, 189);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 18;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(278, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(238, 347);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 19);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Single";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(116, 347);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 19);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Married";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBoxjob
            // 
            this.comboBoxjob.FormattingEnabled = true;
            this.comboBoxjob.Location = new System.Drawing.Point(137, 251);
            this.comboBoxjob.Name = "comboBoxjob";
            this.comboBoxjob.Size = new System.Drawing.Size(121, 23);
            this.comboBoxjob.TabIndex = 14;
            // 
            // comboBoxcity
            // 
            this.comboBoxcity.FormattingEnabled = true;
            this.comboBoxcity.Items.AddRange(new object[] {
            "Ankara",
            "Antalya",
            "Adana",
            "İstanbul",
            "Konya",
            "İzmir",
            "Rize",
            "Trabzon",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Düzce"});
            this.comboBoxcity.Location = new System.Drawing.Point(137, 208);
            this.comboBoxcity.Name = "comboBoxcity";
            this.comboBoxcity.Size = new System.Drawing.Size(121, 23);
            this.comboBoxcity.TabIndex = 13;
            // 
            // maskedTc
            // 
            this.maskedTc.Location = new System.Drawing.Point(137, 165);
            this.maskedTc.Mask = "00000000000";
            this.maskedTc.Name = "maskedTc";
            this.maskedTc.Size = new System.Drawing.Size(121, 23);
            this.maskedTc.TabIndex = 12;
            this.maskedTc.ValidatingType = typeof(int);
            // 
            // textsname
            // 
            this.textsname.Location = new System.Drawing.Point(137, 122);
            this.textsname.Name = "textsname";
            this.textsname.Size = new System.Drawing.Size(121, 23);
            this.textsname.TabIndex = 10;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(137, 79);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(121, 23);
            this.textname.TabIndex = 9;
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(137, 36);
            this.textid.Name = "textid";
            this.textid.ReadOnly = true;
            this.textid.Size = new System.Drawing.Size(121, 23);
            this.textid.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Martial Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Profession";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "T.C No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button_update2);
            this.groupBox2.Controls.Add(this.button_remove2);
            this.groupBox2.Controls.Add(this.button_add2);
            this.groupBox2.Controls.Add(this.textBoxjob);
            this.groupBox2.Controls.Add(this.textBoxidd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(503, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 360);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Profession";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(276, 171);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_update2
            // 
            this.button_update2.Location = new System.Drawing.Point(197, 146);
            this.button_update2.Name = "button_update2";
            this.button_update2.Size = new System.Drawing.Size(75, 23);
            this.button_update2.TabIndex = 16;
            this.button_update2.Text = "Update";
            this.button_update2.UseVisualStyleBackColor = true;
            this.button_update2.Click += new System.EventHandler(this.button_update2_Click);
            // 
            // button_remove2
            // 
            this.button_remove2.Location = new System.Drawing.Point(116, 146);
            this.button_remove2.Name = "button_remove2";
            this.button_remove2.Size = new System.Drawing.Size(75, 23);
            this.button_remove2.TabIndex = 15;
            this.button_remove2.Text = "Remove";
            this.button_remove2.UseVisualStyleBackColor = true;
            this.button_remove2.Click += new System.EventHandler(this.button_remove2_Click);
            // 
            // button_add2
            // 
            this.button_add2.Location = new System.Drawing.Point(35, 146);
            this.button_add2.Name = "button_add2";
            this.button_add2.Size = new System.Drawing.Size(75, 23);
            this.button_add2.TabIndex = 14;
            this.button_add2.Text = "Add";
            this.button_add2.UseVisualStyleBackColor = true;
            this.button_add2.Click += new System.EventHandler(this.button_add2_Click);
            // 
            // textBoxjob
            // 
            this.textBoxjob.Location = new System.Drawing.Point(104, 79);
            this.textBoxjob.Name = "textBoxjob";
            this.textBoxjob.Size = new System.Drawing.Size(121, 23);
            this.textBoxjob.TabIndex = 13;
            // 
            // textBoxidd
            // 
            this.textBoxidd.Location = new System.Drawing.Point(104, 36);
            this.textBoxidd.Name = "textBoxidd";
            this.textBoxidd.ReadOnly = true;
            this.textBoxidd.Size = new System.Drawing.Size(121, 23);
            this.textBoxidd.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Profession";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_search);
            this.groupBox3.Controls.Add(this.textBoxsearch);
            this.groupBox3.Location = new System.Drawing.Point(481, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 61);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // button_search
            // 
            this.button_search.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_search.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_search.Location = new System.Drawing.Point(234, 10);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(60, 45);
            this.button_search.TabIndex = 1;
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Location = new System.Drawing.Point(37, 22);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(191, 23);
            this.textBoxsearch.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(12, 438);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(795, 149);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Information Table";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(789, 127);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(829, 587);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxsalary;
        private System.Windows.Forms.Button button_graph;
        private System.Windows.Forms.Button button_stat;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBoxjob;
        private System.Windows.Forms.ComboBox comboBoxcity;
        private System.Windows.Forms.MaskedTextBox maskedTc;
        private System.Windows.Forms.TextBox textsname;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textBoxjob;
        private System.Windows.Forms.TextBox textBoxidd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_update2;
        private System.Windows.Forms.Button button_remove2;
        private System.Windows.Forms.Button button_add2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button_search;
    }
}

