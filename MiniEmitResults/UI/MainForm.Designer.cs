namespace MiniEmitResults
{
    partial class MainForm
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
            if(disposing && (components != null))
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_OpenSerialPort = new System.Windows.Forms.Button();
            this.btn_closeSerialPort = new System.Windows.Forms.Button();
            this.btn_readStatus = new System.Windows.Forms.Button();
            this.btn_readPorts = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.dgv_Results = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_reRead = new System.Windows.Forms.Button();
            this.tabControl_Courses = new System.Windows.Forms.TabControl();
            this.tab_course1 = new System.Windows.Forms.TabPage();
            this.btn_createCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Results)).BeginInit();
            this.tabControl_Courses.SuspendLayout();
            this.tab_course1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OpenSerialPort
            // 
            this.btn_OpenSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenSerialPort.Location = new System.Drawing.Point(89, 9);
            this.btn_OpenSerialPort.Name = "btn_OpenSerialPort";
            this.btn_OpenSerialPort.Size = new System.Drawing.Size(168, 61);
            this.btn_OpenSerialPort.TabIndex = 0;
            this.btn_OpenSerialPort.Text = "Open Serial Port";
            this.btn_OpenSerialPort.UseVisualStyleBackColor = true;
            this.btn_OpenSerialPort.Click += new System.EventHandler(this.btn_OpenSerialPort_Click);
            // 
            // btn_closeSerialPort
            // 
            this.btn_closeSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeSerialPort.Location = new System.Drawing.Point(89, 76);
            this.btn_closeSerialPort.Name = "btn_closeSerialPort";
            this.btn_closeSerialPort.Size = new System.Drawing.Size(168, 61);
            this.btn_closeSerialPort.TabIndex = 1;
            this.btn_closeSerialPort.Text = "Close serial port";
            this.btn_closeSerialPort.UseVisualStyleBackColor = true;
            this.btn_closeSerialPort.Click += new System.EventHandler(this.btn_closeSerialPort_Click);
            // 
            // btn_readStatus
            // 
            this.btn_readStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_readStatus.Location = new System.Drawing.Point(12, 162);
            this.btn_readStatus.Name = "btn_readStatus";
            this.btn_readStatus.Size = new System.Drawing.Size(245, 61);
            this.btn_readStatus.TabIndex = 2;
            this.btn_readStatus.Text = "Read file";
            this.btn_readStatus.UseVisualStyleBackColor = true;
            this.btn_readStatus.Click += new System.EventHandler(this.btn_readStatus_Click);
            // 
            // btn_readPorts
            // 
            this.btn_readPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_readPorts.Location = new System.Drawing.Point(12, 229);
            this.btn_readPorts.Name = "btn_readPorts";
            this.btn_readPorts.Size = new System.Drawing.Size(245, 61);
            this.btn_readPorts.TabIndex = 4;
            this.btn_readPorts.Text = "Read ports";
            this.btn_readPorts.UseVisualStyleBackColor = true;
            this.btn_readPorts.Click += new System.EventHandler(this.btn_readPorts_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 296);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 128);
            this.label1.TabIndex = 6;
            this.label1.Text = "CLOSED";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(0, 785);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1130, 31);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // dgv_Results
            // 
            this.dgv_Results.AllowUserToAddRows = false;
            this.dgv_Results.AllowUserToDeleteRows = false;
            this.dgv_Results.AllowUserToResizeColumns = false;
            this.dgv_Results.AllowUserToResizeRows = false;
            this.dgv_Results.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Results.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Results.Enabled = false;
            this.dgv_Results.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Results.Location = new System.Drawing.Point(3, 3);
            this.dgv_Results.MultiSelect = false;
            this.dgv_Results.Name = "dgv_Results";
            this.dgv_Results.ReadOnly = true;
            this.dgv_Results.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Results.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Results.ShowCellErrors = false;
            this.dgv_Results.ShowCellToolTips = false;
            this.dgv_Results.ShowEditingIcon = false;
            this.dgv_Results.ShowRowErrors = false;
            this.dgv_Results.Size = new System.Drawing.Size(829, 703);
            this.dgv_Results.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Top results";
            // 
            // btn_reRead
            // 
            this.btn_reRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reRead.Location = new System.Drawing.Point(12, 354);
            this.btn_reRead.Name = "btn_reRead";
            this.btn_reRead.Size = new System.Drawing.Size(245, 61);
            this.btn_reRead.TabIndex = 4;
            this.btn_reRead.Text = "Reread";
            this.btn_reRead.UseVisualStyleBackColor = true;
            this.btn_reRead.Click += new System.EventHandler(this.btn_readPorts_Click);
            // 
            // tabControl_Courses
            // 
            this.tabControl_Courses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Courses.Controls.Add(this.tab_course1);
            this.tabControl_Courses.Location = new System.Drawing.Point(287, 44);
            this.tabControl_Courses.Name = "tabControl_Courses";
            this.tabControl_Courses.SelectedIndex = 0;
            this.tabControl_Courses.Size = new System.Drawing.Size(843, 735);
            this.tabControl_Courses.TabIndex = 12;
            this.tabControl_Courses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabControl_Courses_MouseClick);
            // 
            // tab_course1
            // 
            this.tab_course1.Controls.Add(this.dgv_Results);
            this.tab_course1.Location = new System.Drawing.Point(4, 22);
            this.tab_course1.Name = "tab_course1";
            this.tab_course1.Padding = new System.Windows.Forms.Padding(3);
            this.tab_course1.Size = new System.Drawing.Size(835, 709);
            this.tab_course1.TabIndex = 1;
            this.tab_course1.Text = "Rata 1";
            this.tab_course1.UseVisualStyleBackColor = true;
            this.tab_course1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tab_course1_MouseClick);
            // 
            // btn_createCourse
            // 
            this.btn_createCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createCourse.Location = new System.Drawing.Point(12, 421);
            this.btn_createCourse.Name = "btn_createCourse";
            this.btn_createCourse.Size = new System.Drawing.Size(245, 61);
            this.btn_createCourse.TabIndex = 13;
            this.btn_createCourse.Text = "Create a new course";
            this.btn_createCourse.UseVisualStyleBackColor = true;
            this.btn_createCourse.Click += new System.EventHandler(this.Btn_createCourse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 816);
            this.Controls.Add(this.btn_createCourse);
            this.Controls.Add(this.tabControl_Courses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_reRead);
            this.Controls.Add(this.btn_readPorts);
            this.Controls.Add(this.btn_readStatus);
            this.Controls.Add(this.btn_closeSerialPort);
            this.Controls.Add(this.btn_OpenSerialPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Results)).EndInit();
            this.tabControl_Courses.ResumeLayout(false);
            this.tab_course1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenSerialPort;
        private System.Windows.Forms.Button btn_closeSerialPort;
        private System.Windows.Forms.Button btn_readStatus;
        private System.Windows.Forms.Button btn_readPorts;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataGridView dgv_Results;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_reRead;
        private System.Windows.Forms.TabControl tabControl_Courses;
        private System.Windows.Forms.TabPage tab_course1;
        private System.Windows.Forms.Button btn_createCourse;
    }
}

