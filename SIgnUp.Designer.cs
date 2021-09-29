
namespace Bus_Ticketing_System_1
{
    partial class SIgnUp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIgnUp));
            this.employeenametxtbox = new System.Windows.Forms.TextBox();
            this.mailtextBox = new System.Windows.Forms.TextBox();
            this.eppassbox = new System.Windows.Forms.TextBox();
            this.cppassbox = new System.Windows.Forms.TextBox();
            this.signupbtn = new System.Windows.Forms.Button();
            this.rolecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.employeeidtxtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.employeeaddresstxtbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.employeephonenotxtbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.employeefatherstxtbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.employeemothersnametxtbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cno = new System.Windows.Forms.TextBox();
            this.empid = new System.Windows.Forms.ErrorProvider(this.components);
            this.ename = new System.Windows.Forms.ErrorProvider(this.components);
            this.erole = new System.Windows.Forms.ErrorProvider(this.components);
            this.eadd = new System.Windows.Forms.ErrorProvider(this.components);
            this.eph = new System.Windows.Forms.ErrorProvider(this.components);
            this.efn = new System.Windows.Forms.ErrorProvider(this.components);
            this.emn = new System.Windows.Forms.ErrorProvider(this.components);
            this.ecno = new System.Windows.Forms.ErrorProvider(this.components);
            this.email = new System.Windows.Forms.ErrorProvider(this.components);
            this.epass = new System.Windows.Forms.ErrorProvider(this.components);
            this.ecpass = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.empid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.efn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecpass)).BeginInit();
            this.SuspendLayout();
            // 
            // employeenametxtbox
            // 
            this.employeenametxtbox.AllowDrop = true;
            this.employeenametxtbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ename.SetError(this.employeenametxtbox, "Enter Employee Name.");
            this.employeenametxtbox.Location = new System.Drawing.Point(229, 138);
            this.employeenametxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeenametxtbox.Multiline = true;
            this.employeenametxtbox.Name = "employeenametxtbox";
            this.employeenametxtbox.Size = new System.Drawing.Size(294, 25);
            this.employeenametxtbox.TabIndex = 1;
            this.employeenametxtbox.TextChanged += new System.EventHandler(this.employeenametxtbox_TextChanged);
            this.employeenametxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employeenametxtbox_KeyPress);
            // 
            // mailtextBox
            // 
            this.mailtextBox.AllowDrop = true;
            this.mailtextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.email.SetError(this.mailtextBox, "Enter Employee E-Mail Address.");
            this.mailtextBox.Location = new System.Drawing.Point(229, 479);
            this.mailtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mailtextBox.Multiline = true;
            this.mailtextBox.Name = "mailtextBox";
            this.mailtextBox.Size = new System.Drawing.Size(294, 25);
            this.mailtextBox.TabIndex = 8;
            this.mailtextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mailtextBox_KeyUp);
            // 
            // eppassbox
            // 
            this.eppassbox.AllowDrop = true;
            this.eppassbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.epass.SetError(this.eppassbox, "Enter Password.");
            this.eppassbox.Location = new System.Drawing.Point(229, 526);
            this.eppassbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eppassbox.Multiline = true;
            this.eppassbox.Name = "eppassbox";
            this.eppassbox.Size = new System.Drawing.Size(294, 25);
            this.eppassbox.TabIndex = 9;
            this.eppassbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.eppassbox_KeyUp);
            // 
            // cppassbox
            // 
            this.cppassbox.AllowDrop = true;
            this.cppassbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ecpass.SetError(this.cppassbox, "Enter Confirm Password.");
            this.cppassbox.Location = new System.Drawing.Point(229, 573);
            this.cppassbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cppassbox.Multiline = true;
            this.cppassbox.Name = "cppassbox";
            this.cppassbox.Size = new System.Drawing.Size(294, 25);
            this.cppassbox.TabIndex = 10;
            this.cppassbox.TextChanged += new System.EventHandler(this.cppassbox_TextChanged);
            this.cppassbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cppassbox_KeyUp);
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(157)))), ((int)(((byte)(54)))));
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.Location = new System.Drawing.Point(279, 615);
            this.signupbtn.Margin = new System.Windows.Forms.Padding(4);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(166, 45);
            this.signupbtn.TabIndex = 11;
            this.signupbtn.Text = "Create Account";
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // rolecomboBox
            // 
            this.rolecomboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrator",
            "Receptionist"});
            this.rolecomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rolecomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rolecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.erole.SetError(this.rolecomboBox, "Select Employee Role.");
            this.rolecomboBox.FormattingEnabled = true;
            this.rolecomboBox.Location = new System.Drawing.Point(229, 189);
            this.rolecomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.rolecomboBox.Name = "rolecomboBox";
            this.rolecomboBox.Size = new System.Drawing.Size(294, 25);
            this.rolecomboBox.TabIndex = 2;
            this.rolecomboBox.SelectedIndexChanged += new System.EventHandler(this.rolecomboBox_SelectedIndexChanged);
           // this.rolecomboBox.SelectedValueChanged += new System.EventHandler(this.rolecomboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Employee Role:-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Employee Name:-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "E-Mail Address:-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Enter Password:-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Confirm Password:-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 42);
            this.label6.TabIndex = 23;
            this.label6.Text = "Create Your Account";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Employee ID:-";
            // 
            // employeeidtxtbox
            // 
            this.employeeidtxtbox.AllowDrop = true;
            this.employeeidtxtbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.empid.SetError(this.employeeidtxtbox, "Enter Employee ID.");
            this.employeeidtxtbox.Location = new System.Drawing.Point(229, 91);
            this.employeeidtxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeidtxtbox.Multiline = true;
            this.employeeidtxtbox.Name = "employeeidtxtbox";
            this.employeeidtxtbox.Size = new System.Drawing.Size(294, 25);
            this.employeeidtxtbox.TabIndex = 0;
            this.employeeidtxtbox.TextChanged += new System.EventHandler(this.employeeidtxtbox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Employee Address:-";
            // 
            // employeeaddresstxtbox
            // 
            this.employeeaddresstxtbox.AllowDrop = true;
            this.employeeaddresstxtbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.eadd.SetError(this.employeeaddresstxtbox, "Enter Employee Address.");
            this.employeeaddresstxtbox.Location = new System.Drawing.Point(229, 239);
            this.employeeaddresstxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeaddresstxtbox.Multiline = true;
            this.employeeaddresstxtbox.Name = "employeeaddresstxtbox";
            this.employeeaddresstxtbox.Size = new System.Drawing.Size(294, 25);
            this.employeeaddresstxtbox.TabIndex = 3;
            this.employeeaddresstxtbox.TextChanged += new System.EventHandler(this.employeeaddresstxtbox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Phone Number:-";
            // 
            // employeephonenotxtbox
            // 
            this.employeephonenotxtbox.AllowDrop = true;
            this.employeephonenotxtbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.eph.SetError(this.employeephonenotxtbox, "Enter Employee Phone No.");
            this.employeephonenotxtbox.Location = new System.Drawing.Point(229, 287);
            this.employeephonenotxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeephonenotxtbox.Multiline = true;
            this.employeephonenotxtbox.Name = "employeephonenotxtbox";
            this.employeephonenotxtbox.Size = new System.Drawing.Size(294, 25);
            this.employeephonenotxtbox.TabIndex = 4;
            this.employeephonenotxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employeephonenotxtbox_KeyPress);
            this.employeephonenotxtbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.employeephonenotxtbox_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Father\'s Name:-";
            // 
            // employeefatherstxtbox
            // 
            this.employeefatherstxtbox.AllowDrop = true;
            this.employeefatherstxtbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.efn.SetError(this.employeefatherstxtbox, "Enter Employee Father\'s Name.");
            this.employeefatherstxtbox.Location = new System.Drawing.Point(229, 335);
            this.employeefatherstxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeefatherstxtbox.Multiline = true;
            this.employeefatherstxtbox.Name = "employeefatherstxtbox";
            this.employeefatherstxtbox.Size = new System.Drawing.Size(294, 25);
            this.employeefatherstxtbox.TabIndex = 5;
            this.employeefatherstxtbox.TextChanged += new System.EventHandler(this.employeefatherstxtbox_TextChanged);
            this.employeefatherstxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employeefatherstxtbox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Mother\'s Name:-";
            // 
            // employeemothersnametxtbox
            // 
            this.employeemothersnametxtbox.AllowDrop = true;
            this.employeemothersnametxtbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.emn.SetError(this.employeemothersnametxtbox, "Enter Employee Mother\'s Name.");
            this.employeemothersnametxtbox.Location = new System.Drawing.Point(229, 382);
            this.employeemothersnametxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeemothersnametxtbox.Multiline = true;
            this.employeemothersnametxtbox.Name = "employeemothersnametxtbox";
            this.employeemothersnametxtbox.Size = new System.Drawing.Size(294, 25);
            this.employeemothersnametxtbox.TabIndex = 6;
            this.employeemothersnametxtbox.TextChanged += new System.EventHandler(this.employeemothersnametxtbox_TextChanged);
            this.employeemothersnametxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employeemothersnametxtbox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 435);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 17);
            this.label12.TabIndex = 40;
            this.label12.Text = "Citizenship No:-";
            // 
            // cno
            // 
            this.cno.AllowDrop = true;
            this.cno.Cursor = System.Windows.Forms.Cursors.Default;
            this.ecno.SetError(this.cno, "Enter Citizenship No.");
            this.cno.Location = new System.Drawing.Point(229, 432);
            this.cno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cno.Multiline = true;
            this.cno.Name = "cno";
            this.cno.Size = new System.Drawing.Size(294, 25);
            this.cno.TabIndex = 7;
            this.cno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cno_KeyUp);
            // 
            // empid
            // 
            this.empid.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.empid.ContainerControl = this;
            this.empid.Icon = ((System.Drawing.Icon)(resources.GetObject("empid.Icon")));
            // 
            // ename
            // 
            this.ename.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ename.ContainerControl = this;
            this.ename.Icon = ((System.Drawing.Icon)(resources.GetObject("ename.Icon")));
            // 
            // erole
            // 
            this.erole.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erole.ContainerControl = this;
            this.erole.Icon = ((System.Drawing.Icon)(resources.GetObject("erole.Icon")));
            // 
            // eadd
            // 
            this.eadd.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.eadd.ContainerControl = this;
            this.eadd.Icon = ((System.Drawing.Icon)(resources.GetObject("eadd.Icon")));
            // 
            // eph
            // 
            this.eph.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.eph.ContainerControl = this;
            this.eph.Icon = ((System.Drawing.Icon)(resources.GetObject("eph.Icon")));
            // 
            // efn
            // 
            this.efn.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.efn.ContainerControl = this;
            this.efn.Icon = ((System.Drawing.Icon)(resources.GetObject("efn.Icon")));
            // 
            // emn
            // 
            this.emn.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.emn.ContainerControl = this;
            this.emn.Icon = ((System.Drawing.Icon)(resources.GetObject("emn.Icon")));
            // 
            // ecno
            // 
            this.ecno.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ecno.ContainerControl = this;
            this.ecno.Icon = ((System.Drawing.Icon)(resources.GetObject("ecno.Icon")));
            // 
            // email
            // 
            this.email.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.email.ContainerControl = this;
            this.email.Icon = ((System.Drawing.Icon)(resources.GetObject("email.Icon")));
            // 
            // epass
            // 
            this.epass.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epass.ContainerControl = this;
            this.epass.Icon = ((System.Drawing.Icon)(resources.GetObject("epass.Icon")));
            // 
            // ecpass
            // 
            this.ecpass.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ecpass.ContainerControl = this;
            this.ecpass.Icon = ((System.Drawing.Icon)(resources.GetObject("ecpass.Icon")));
            // 
            // SIgnUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(625, 683);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.employeemothersnametxtbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.employeefatherstxtbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.employeephonenotxtbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.employeeaddresstxtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.employeeidtxtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rolecomboBox);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.cppassbox);
            this.Controls.Add(this.eppassbox);
            this.Controls.Add(this.mailtextBox);
            this.Controls.Add(this.employeenametxtbox);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SIgnUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  SignUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SIgnUp_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SIgnUp_FormClosed);
            this.Load += new System.EventHandler(this.SIgnUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.efn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecpass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox employeenametxtbox;
        private System.Windows.Forms.TextBox mailtextBox;
        private System.Windows.Forms.TextBox eppassbox;
        private System.Windows.Forms.TextBox cppassbox;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.ComboBox rolecomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox employeeidtxtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox employeeaddresstxtbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox employeephonenotxtbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox employeefatherstxtbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox employeemothersnametxtbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cno;
        private System.Windows.Forms.ErrorProvider empid;
        private System.Windows.Forms.ErrorProvider ename;
        private System.Windows.Forms.ErrorProvider erole;
        private System.Windows.Forms.ErrorProvider eadd;
        private System.Windows.Forms.ErrorProvider eph;
        private System.Windows.Forms.ErrorProvider efn;
        private System.Windows.Forms.ErrorProvider emn;
        private System.Windows.Forms.ErrorProvider ecno;
        private System.Windows.Forms.ErrorProvider email;
        private System.Windows.Forms.ErrorProvider epass;
        private System.Windows.Forms.ErrorProvider ecpass;
    }
}