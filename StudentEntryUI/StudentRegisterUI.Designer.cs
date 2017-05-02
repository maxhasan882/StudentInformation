namespace StudentEntryUI
{
    partial class StudentRegisterUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegisterUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DepartmentNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.studentRegisteredNoTextBos = new System.Windows.Forms.TextBox();
            this.Rlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentEmailTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.showDetailsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.studentRegisterdButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.DepartmentNameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.departmentCodeTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.DepartmentLabel);
            this.panel1.Location = new System.Drawing.Point(2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 166);
            this.panel1.TabIndex = 0;
            // 
            // DepartmentNameTextBox
            // 
            this.DepartmentNameTextBox.Location = new System.Drawing.Point(137, 93);
            this.DepartmentNameTextBox.Name = "DepartmentNameTextBox";
            this.DepartmentNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.DepartmentNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(76, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // departmentCodeTextBox
            // 
            this.departmentCodeTextBox.Location = new System.Drawing.Point(137, 44);
            this.departmentCodeTextBox.Name = "departmentCodeTextBox";
            this.departmentCodeTextBox.Size = new System.Drawing.Size(173, 20);
            this.departmentCodeTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(76, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code";
            // 
            // saveButton
            // 
            this.saveButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.BorderRadius = 0;
            this.saveButton.ButtonText = "Save";
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.DisabledColor = System.Drawing.Color.Gray;
            this.saveButton.Iconcolor = System.Drawing.Color.Transparent;
            this.saveButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveButton.Iconimage")));
            this.saveButton.Iconimage_right = null;
            this.saveButton.Iconimage_right_Selected = null;
            this.saveButton.Iconimage_Selected = null;
            this.saveButton.IconMarginLeft = 0;
            this.saveButton.IconMarginRight = 0;
            this.saveButton.IconRightVisible = true;
            this.saveButton.IconRightZoom = 0D;
            this.saveButton.IconVisible = true;
            this.saveButton.IconZoom = 90D;
            this.saveButton.IsTab = false;
            this.saveButton.Location = new System.Drawing.Point(386, 61);
            this.saveButton.Name = "saveButton";
            this.saveButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.saveButton.selected = false;
            this.saveButton.Size = new System.Drawing.Size(107, 36);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Textcolor = System.Drawing.Color.White;
            this.saveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DepartmentLabel.Location = new System.Drawing.Point(197, 6);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(72, 13);
            this.DepartmentLabel.TabIndex = 0;
            this.DepartmentLabel.Text = "Department";
            // 
            // studentRegisteredNoTextBos
            // 
            this.studentRegisteredNoTextBos.Location = new System.Drawing.Point(137, 38);
            this.studentRegisteredNoTextBos.Name = "studentRegisteredNoTextBos";
            this.studentRegisteredNoTextBos.Size = new System.Drawing.Size(173, 20);
            this.studentRegisteredNoTextBos.TabIndex = 7;
            // 
            // Rlabel
            // 
            this.Rlabel.AutoSize = true;
            this.Rlabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Rlabel.Location = new System.Drawing.Point(59, 41);
            this.Rlabel.Name = "Rlabel";
            this.Rlabel.Size = new System.Drawing.Size(63, 13);
            this.Rlabel.TabIndex = 6;
            this.Rlabel.Text = "Register No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(82, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(137, 87);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.studentNameTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(76, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // studentEmailTextBox
            // 
            this.studentEmailTextBox.Location = new System.Drawing.Point(137, 140);
            this.studentEmailTextBox.Name = "studentEmailTextBox";
            this.studentEmailTextBox.Size = new System.Drawing.Size(173, 20);
            this.studentEmailTextBox.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.showDetailsButton);
            this.panel2.Controls.Add(this.studentRegisterdButton);
            this.panel2.Controls.Add(this.studentEmailTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.studentNameTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Rlabel);
            this.panel2.Controls.Add(this.studentRegisteredNoTextBos);
            this.panel2.Location = new System.Drawing.Point(2, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 267);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(200, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student Info";
            // 
            // showDetailsButton
            // 
            this.showDetailsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.showDetailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.showDetailsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showDetailsButton.BorderRadius = 0;
            this.showDetailsButton.ButtonText = "Show Details";
            this.showDetailsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showDetailsButton.DisabledColor = System.Drawing.Color.Gray;
            this.showDetailsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.showDetailsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("showDetailsButton.Iconimage")));
            this.showDetailsButton.Iconimage_right = null;
            this.showDetailsButton.Iconimage_right_Selected = null;
            this.showDetailsButton.Iconimage_Selected = null;
            this.showDetailsButton.IconMarginLeft = 0;
            this.showDetailsButton.IconMarginRight = 0;
            this.showDetailsButton.IconRightVisible = true;
            this.showDetailsButton.IconRightZoom = 0D;
            this.showDetailsButton.IconVisible = true;
            this.showDetailsButton.IconZoom = 90D;
            this.showDetailsButton.IsTab = false;
            this.showDetailsButton.Location = new System.Drawing.Point(149, 197);
            this.showDetailsButton.Name = "showDetailsButton";
            this.showDetailsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.showDetailsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.showDetailsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.showDetailsButton.selected = false;
            this.showDetailsButton.Size = new System.Drawing.Size(140, 36);
            this.showDetailsButton.TabIndex = 12;
            this.showDetailsButton.Text = "Show Details";
            this.showDetailsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showDetailsButton.Textcolor = System.Drawing.Color.White;
            this.showDetailsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsButton.Click += new System.EventHandler(this.showDetailsButton_Click);
            // 
            // studentRegisterdButton
            // 
            this.studentRegisterdButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.studentRegisterdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.studentRegisterdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.studentRegisterdButton.BorderRadius = 0;
            this.studentRegisterdButton.ButtonText = "Register";
            this.studentRegisterdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentRegisterdButton.DisabledColor = System.Drawing.Color.Gray;
            this.studentRegisterdButton.Iconcolor = System.Drawing.Color.Transparent;
            this.studentRegisterdButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("studentRegisterdButton.Iconimage")));
            this.studentRegisterdButton.Iconimage_right = null;
            this.studentRegisterdButton.Iconimage_right_Selected = null;
            this.studentRegisterdButton.Iconimage_Selected = null;
            this.studentRegisterdButton.IconMarginLeft = 0;
            this.studentRegisterdButton.IconMarginRight = 0;
            this.studentRegisterdButton.IconRightVisible = true;
            this.studentRegisterdButton.IconRightZoom = 0D;
            this.studentRegisterdButton.IconVisible = true;
            this.studentRegisterdButton.IconZoom = 90D;
            this.studentRegisterdButton.IsTab = false;
            this.studentRegisterdButton.Location = new System.Drawing.Point(386, 78);
            this.studentRegisterdButton.Name = "studentRegisterdButton";
            this.studentRegisterdButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.studentRegisterdButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.studentRegisterdButton.OnHoverTextColor = System.Drawing.Color.White;
            this.studentRegisterdButton.selected = false;
            this.studentRegisterdButton.Size = new System.Drawing.Size(107, 36);
            this.studentRegisterdButton.TabIndex = 6;
            this.studentRegisterdButton.Text = "Register";
            this.studentRegisterdButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentRegisterdButton.Textcolor = System.Drawing.Color.White;
            this.studentRegisterdButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRegisterdButton.Click += new System.EventHandler(this.studentRegisterdButton_Click);
            // 
            // StudentRegisterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 430);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentRegisterUI";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.TextBox DepartmentNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox departmentCodeTextBox;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton saveButton;
        private System.Windows.Forms.TextBox studentRegisteredNoTextBos;
        private System.Windows.Forms.Label Rlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentEmailTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton showDetailsButton;
        private Bunifu.Framework.UI.BunifuFlatButton studentRegisterdButton;
    }
}

