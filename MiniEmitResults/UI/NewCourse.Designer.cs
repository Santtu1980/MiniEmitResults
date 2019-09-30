namespace MiniEmitResults.UI
{
    partial class NewCourse
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
            this.lbl_ConrtolsHeading = new System.Windows.Forms.Label();
            this.txt_checkPoints = new System.Windows.Forms.TextBox();
            this.lbl_courseName = new System.Windows.Forms.Label();
            this.txt_courseName = new System.Windows.Forms.TextBox();
            this.txt_courseLength = new System.Windows.Forms.TextBox();
            this.lbl_CourseLength = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ConrtolsHeading
            // 
            this.lbl_ConrtolsHeading.AutoSize = true;
            this.lbl_ConrtolsHeading.Location = new System.Drawing.Point(15, 34);
            this.lbl_ConrtolsHeading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_ConrtolsHeading.Name = "lbl_ConrtolsHeading";
            this.lbl_ConrtolsHeading.Size = new System.Drawing.Size(475, 24);
            this.lbl_ConrtolsHeading.TabIndex = 0;
            this.lbl_ConrtolsHeading.Text = "Add checkpoint numbers to below separated with dot [,]";
            // 
            // txt_checkPoints
            // 
            this.txt_checkPoints.Location = new System.Drawing.Point(12, 61);
            this.txt_checkPoints.Name = "txt_checkPoints";
            this.txt_checkPoints.Size = new System.Drawing.Size(815, 29);
            this.txt_checkPoints.TabIndex = 1;
            // 
            // lbl_courseName
            // 
            this.lbl_courseName.AutoSize = true;
            this.lbl_courseName.Location = new System.Drawing.Point(8, 120);
            this.lbl_courseName.Name = "lbl_courseName";
            this.lbl_courseName.Size = new System.Drawing.Size(129, 24);
            this.lbl_courseName.TabIndex = 2;
            this.lbl_courseName.Text = " Course name";
            // 
            // txt_courseName
            // 
            this.txt_courseName.Location = new System.Drawing.Point(12, 147);
            this.txt_courseName.Name = "txt_courseName";
            this.txt_courseName.Size = new System.Drawing.Size(815, 29);
            this.txt_courseName.TabIndex = 3;
            // 
            // txt_courseLength
            // 
            this.txt_courseLength.Location = new System.Drawing.Point(12, 241);
            this.txt_courseLength.Name = "txt_courseLength";
            this.txt_courseLength.Size = new System.Drawing.Size(815, 29);
            this.txt_courseLength.TabIndex = 4;
            // 
            // lbl_CourseLength
            // 
            this.lbl_CourseLength.AutoSize = true;
            this.lbl_CourseLength.Location = new System.Drawing.Point(15, 214);
            this.lbl_CourseLength.Name = "lbl_CourseLength";
            this.lbl_CourseLength.Size = new System.Drawing.Size(202, 24);
            this.lbl_CourseLength.TabIndex = 5;
            this.lbl_CourseLength.Text = "Course length (meters)";
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(677, 312);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(150, 65);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(12, 312);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 65);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // NewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(839, 389);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_CourseLength);
            this.Controls.Add(this.txt_courseLength);
            this.Controls.Add(this.txt_courseName);
            this.Controls.Add(this.lbl_courseName);
            this.Controls.Add(this.txt_checkPoints);
            this.Controls.Add(this.lbl_ConrtolsHeading);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCourse";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "New Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ConrtolsHeading;
        private System.Windows.Forms.TextBox txt_checkPoints;
        private System.Windows.Forms.Label lbl_courseName;
        private System.Windows.Forms.TextBox txt_courseName;
        private System.Windows.Forms.TextBox txt_courseLength;
        private System.Windows.Forms.Label lbl_CourseLength;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}