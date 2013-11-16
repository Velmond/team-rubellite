namespace WFAgenda
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTaskType = new System.Windows.Forms.ComboBox();
            this.groupBoxExtras = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxExtDuration = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonGetAllByTag = new System.Windows.Forms.Button();
            this.listBoxGetAllByTags = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSortByDateCreated = new System.Windows.Forms.Button();
            this.buttonSortByDateToComplete = new System.Windows.Forms.Button();
            this.buttonSortByName = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBoxExtras.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Full agenda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(606, 342);
            this.listBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tasks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(574, 305);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(574, 305);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Meetings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Controls.Add(this.listBoxGetAllByTags);
            this.tabPage5.Controls.Add(this.buttonGetAllByTag);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(702, 305);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Get by tags";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.richTextBoxDescription);
            this.tabPage6.Controls.Add(this.buttonClearAll);
            this.tabPage6.Controls.Add(this.buttonCancel);
            this.tabPage6.Controls.Add(this.buttonAdd);
            this.tabPage6.Controls.Add(this.groupBoxExtras);
            this.tabPage6.Controls.Add(this.comboBoxTaskType);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.textBoxTitle);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(702, 305);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Add  new ";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(84, 21);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // comboBoxTaskType
            // 
            this.comboBoxTaskType.FormattingEnabled = true;
            this.comboBoxTaskType.Items.AddRange(new object[] {
            "",
            "Goal",
            "Meeting",
            "Note",
            "Task"});
            this.comboBoxTaskType.Location = new System.Drawing.Point(308, 25);
            this.comboBoxTaskType.Name = "comboBoxTaskType";
            this.comboBoxTaskType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTaskType.TabIndex = 5;
            this.comboBoxTaskType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTaskType_SelectedIndexChanged);
            // 
            // groupBoxExtras
            // 
            this.groupBoxExtras.Controls.Add(this.textBoxEnd);
            this.groupBoxExtras.Controls.Add(this.label7);
            this.groupBoxExtras.Controls.Add(this.label6);
            this.groupBoxExtras.Controls.Add(this.comboBoxExtDuration);
            this.groupBoxExtras.Controls.Add(this.label5);
            this.groupBoxExtras.Controls.Add(this.comboBoxPriority);
            this.groupBoxExtras.Controls.Add(this.label4);
            this.groupBoxExtras.Location = new System.Drawing.Point(435, 25);
            this.groupBoxExtras.Name = "groupBoxExtras";
            this.groupBoxExtras.Size = new System.Drawing.Size(261, 209);
            this.groupBoxExtras.TabIndex = 6;
            this.groupBoxExtras.TabStop = false;
            this.groupBoxExtras.Text = "Extras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Priority";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "",
            "None",
            "Urgent",
            "Important"});
            this.comboBoxPriority.Location = new System.Drawing.Point(104, 36);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(73, 21);
            this.comboBoxPriority.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mins";
            // 
            // comboBoxExtDuration
            // 
            this.comboBoxExtDuration.FormattingEnabled = true;
            this.comboBoxExtDuration.Items.AddRange(new object[] {
            "",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.comboBoxExtDuration.Location = new System.Drawing.Point(104, 71);
            this.comboBoxExtDuration.Name = "comboBoxExtDuration";
            this.comboBoxExtDuration.Size = new System.Drawing.Size(73, 21);
            this.comboBoxExtDuration.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Extend duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "End";
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(104, 104);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnd.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(84, 265);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(354, 265);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(603, 252);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(93, 48);
            this.buttonClearAll.TabIndex = 9;
            this.buttonClearAll.Text = "Clear all";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(84, 67);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(345, 167);
            this.richTextBoxDescription.TabIndex = 10;
            this.richTextBoxDescription.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tag name";
            // 
            // buttonGetAllByTag
            // 
            this.buttonGetAllByTag.Location = new System.Drawing.Point(87, 57);
            this.buttonGetAllByTag.Name = "buttonGetAllByTag";
            this.buttonGetAllByTag.Size = new System.Drawing.Size(100, 23);
            this.buttonGetAllByTag.TabIndex = 2;
            this.buttonGetAllByTag.Text = "Get all";
            this.buttonGetAllByTag.UseVisualStyleBackColor = true;
            // 
            // listBoxGetAllByTags
            // 
            this.listBoxGetAllByTags.FormattingEnabled = true;
            this.listBoxGetAllByTags.Location = new System.Drawing.Point(232, 18);
            this.listBoxGetAllByTags.Name = "listBoxGetAllByTags";
            this.listBoxGetAllByTags.Size = new System.Drawing.Size(464, 277);
            this.listBoxGetAllByTags.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSortByDateCreated);
            this.groupBox1.Controls.Add(this.buttonSortByDateToComplete);
            this.groupBox1.Controls.Add(this.buttonSortByName);
            this.groupBox1.Location = new System.Drawing.Point(9, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 195);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort options";
            // 
            // buttonSortByDateCreated
            // 
            this.buttonSortByDateCreated.Location = new System.Drawing.Point(6, 33);
            this.buttonSortByDateCreated.Name = "buttonSortByDateCreated";
            this.buttonSortByDateCreated.Size = new System.Drawing.Size(111, 23);
            this.buttonSortByDateCreated.TabIndex = 5;
            this.buttonSortByDateCreated.Text = "By date created";
            this.buttonSortByDateCreated.UseVisualStyleBackColor = true;
            this.buttonSortByDateCreated.Click += new System.EventHandler(this.buttonSortByDateCreated_Click);
            // 
            // buttonSortByDateToComplete
            // 
            this.buttonSortByDateToComplete.Location = new System.Drawing.Point(6, 96);
            this.buttonSortByDateToComplete.Name = "buttonSortByDateToComplete";
            this.buttonSortByDateToComplete.Size = new System.Drawing.Size(111, 23);
            this.buttonSortByDateToComplete.TabIndex = 6;
            this.buttonSortByDateToComplete.Text = "By date to complete";
            this.buttonSortByDateToComplete.UseVisualStyleBackColor = true;
            // 
            // buttonSortByName
            // 
            this.buttonSortByName.Location = new System.Drawing.Point(6, 150);
            this.buttonSortByName.Name = "buttonSortByName";
            this.buttonSortByName.Size = new System.Drawing.Size(111, 23);
            this.buttonSortByName.TabIndex = 7;
            this.buttonSortByName.Text = "By name";
            this.buttonSortByName.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 355);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.groupBoxExtras.ResumeLayout(false);
            this.groupBoxExtras.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxTaskType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxExtras;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxExtDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSortByDateCreated;
        private System.Windows.Forms.Button buttonSortByDateToComplete;
        private System.Windows.Forms.Button buttonSortByName;
        private System.Windows.Forms.ListBox listBoxGetAllByTags;
        private System.Windows.Forms.Button buttonGetAllByTag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
    }
}

