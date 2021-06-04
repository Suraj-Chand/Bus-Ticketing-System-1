
namespace Bus_Ticketing_System_1
{
    partial class Forgot_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot_Password));
            this.verifybtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.mail = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showpass = new System.Windows.Forms.Button();
            this.errorProvideremployeename = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvideremail = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvideremployeename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvideremail)).BeginInit();
            this.SuspendLayout();
            // 
            // verifybtn
            // 
            this.verifybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.verifybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.verifybtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifybtn.ForeColor = System.Drawing.Color.Black;
            this.verifybtn.Location = new System.Drawing.Point(258, 205);
            this.verifybtn.Name = "verifybtn";
            this.verifybtn.Size = new System.Drawing.Size(159, 38);
            this.verifybtn.TabIndex = 3;
            this.verifybtn.Text = "Change Password";
            this.verifybtn.UseVisualStyleBackColor = false;
            this.verifybtn.Click += new System.EventHandler(this.verifybtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.exitbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.Color.Black;
            this.exitbtn.Location = new System.Drawing.Point(433, 205);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(126, 38);
            this.exitbtn.TabIndex = 4;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // mail
            // 
            this.errorProvideremail.SetError(this.mail, "Please Enter Email Address.");
            this.mail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(250, 125);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(309, 25);
            this.mail.TabIndex = 1;
            this.mail.TextChanged += new System.EventHandler(this.mail_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.errorProvideremployeename.SetError(this.txtUserName, "Please Enter Employee Name");
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(250, 61);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(309, 25);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email Address:-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter Employee Name:-";
            // 
            // showpass
            // 
            this.showpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.showpass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass.ForeColor = System.Drawing.Color.Black;
            this.showpass.Location = new System.Drawing.Point(89, 205);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(153, 38);
            this.showpass.TabIndex = 2;
            this.showpass.Text = "Show Password";
            this.showpass.UseVisualStyleBackColor = false;
            this.showpass.Click += new System.EventHandler(this.showpass_Click);
            // 
            // errorProvideremployeename
            // 
            this.errorProvideremployeename.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvideremployeename.ContainerControl = this;
            this.errorProvideremployeename.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvideremployeename.Icon")));
            this.errorProvideremployeename.Tag = "";
            // 
            // errorProvideremail
            // 
            this.errorProvideremail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvideremail.ContainerControl = this;
            this.errorProvideremail.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvideremail.Icon")));
            // 
            // Forgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(641, 305);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.verifybtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Forgot_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot_Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Forgot_Password_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Forgot_Password_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvideremployeename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvideremail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verifybtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showpass;
        private System.Windows.Forms.ErrorProvider errorProvideremployeename;
        private System.Windows.Forms.ErrorProvider errorProvideremail;
    }
}