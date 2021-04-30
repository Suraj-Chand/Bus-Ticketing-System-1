
namespace Bus_Ticketing_System_1
{
    partial class LOG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOG));
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.forgotpasswordbtn = new System.Windows.Forms.Button();
            this.signupbtn = new System.Windows.Forms.Button();
            this.comboBoxUserName = new System.Windows.Forms.ComboBox();
            this.employeeTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxRole.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.ItemHeight = 17;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Administrator",
            "Receptionist"});
            this.comboBoxRole.Location = new System.Drawing.Point(436, 359);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(288, 25);
            this.comboBoxRole.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "User Name:-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Role/Designation:-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(959, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(157)))), ((int)(((byte)(54)))));
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(436, 512);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(104, 34);
            this.loginbtn.TabIndex = 15;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // forgotpasswordbtn
            // 
            this.forgotpasswordbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(157)))), ((int)(((byte)(54)))));
            this.forgotpasswordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forgotpasswordbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpasswordbtn.Location = new System.Drawing.Point(523, 569);
            this.forgotpasswordbtn.Name = "forgotpasswordbtn";
            this.forgotpasswordbtn.Size = new System.Drawing.Size(124, 26);
            this.forgotpasswordbtn.TabIndex = 17;
            this.forgotpasswordbtn.Text = "Forgot Password?";
            this.forgotpasswordbtn.UseVisualStyleBackColor = false;
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(157)))), ((int)(((byte)(54)))));
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.Location = new System.Drawing.Point(620, 512);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(104, 34);
            this.signupbtn.TabIndex = 16;
            this.signupbtn.Text = "SignUp";
            this.signupbtn.UseVisualStyleBackColor = false;
            // 
            // comboBoxUserName
            // 
            this.comboBoxUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUserName.DisplayMember = "role";
            this.comboBoxUserName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserName.FormattingEnabled = true;
            this.comboBoxUserName.ItemHeight = 17;
            this.comboBoxUserName.Location = new System.Drawing.Point(436, 411);
            this.comboBoxUserName.Name = "comboBoxUserName";
            this.comboBoxUserName.Size = new System.Drawing.Size(288, 25);
            this.comboBoxUserName.TabIndex = 13;
            this.comboBoxUserName.ValueMember = "role";
            // 
            // employeeTBBindingSource
            // 
            this.employeeTBBindingSource.DataMember = "EmployeeTB";
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Location = new System.Drawing.Point(436, 456);
            this.passwordtxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.Size = new System.Drawing.Size(288, 26);
            this.passwordtxtbox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 42);
            this.label4.TabIndex = 19;
            this.label4.Text = "Bus Ticketing  System";
            // 
            // LOG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(959, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordtxtbox);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.forgotpasswordbtn);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.comboBoxUserName);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LOG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG IN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.BindingSource employeeTBBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button forgotpasswordbtn;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.ComboBox comboBoxUserName;
        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.Label label4;
    }
}

