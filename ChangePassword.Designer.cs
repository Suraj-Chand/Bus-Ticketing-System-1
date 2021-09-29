
namespace Bus_Ticketing_System_1
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.exitbtn = new System.Windows.Forms.Button();
            this.coppsw = new System.Windows.Forms.Button();
            this.confpass = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.empuser = new System.Windows.Forms.TextBox();
            this.errorProvideremployeename = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvidernewpass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderconfirmnewpass = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvideremployeename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidernewpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderconfirmnewpass)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.exitbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(344, 221);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(110, 47);
            this.exitbtn.TabIndex = 4;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // coppsw
            // 
            this.coppsw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            this.coppsw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.coppsw.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coppsw.Location = new System.Drawing.Point(153, 221);
            this.coppsw.Name = "coppsw";
            this.coppsw.Size = new System.Drawing.Size(168, 47);
            this.coppsw.TabIndex = 3;
            this.coppsw.Text = "Change Old Password";
            this.coppsw.UseVisualStyleBackColor = false;
            this.coppsw.Click += new System.EventHandler(this.coppsw_Click);
            // 
            // confpass
            // 
            this.errorProviderconfirmnewpass.SetError(this.confpass, "Enter Confirm Password");
            this.confpass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confpass.Location = new System.Drawing.Point(287, 161);
            this.confpass.Name = "confpass";
            this.confpass.Size = new System.Drawing.Size(214, 25);
            this.confpass.TabIndex = 2;
            this.confpass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.confpass_KeyUp);
            // 
            // newpass
            // 
            this.errorProvidernewpass.SetError(this.newpass, "Enter New Password");
            this.newpass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass.Location = new System.Drawing.Point(287, 109);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(214, 25);
            this.newpass.TabIndex = 1;
            this.newpass.TextChanged += new System.EventHandler(this.newpass_TextChanged);
            this.newpass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.newpass_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Confirm New Password:-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter New Password:-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter User Name:-";
            // 
            // empuser
            // 
            this.empuser.Enabled = false;
            this.errorProvideremployeename.SetError(this.empuser, "Enter Employee Name First");
            this.empuser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empuser.Location = new System.Drawing.Point(287, 59);
            this.empuser.Name = "empuser";
            this.empuser.Size = new System.Drawing.Size(214, 25);
            this.empuser.TabIndex = 0;
            this.empuser.TextChanged += new System.EventHandler(this.empuser_TextChanged);
            // 
            // errorProvideremployeename
            // 
            this.errorProvideremployeename.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvideremployeename.ContainerControl = this;
            this.errorProvideremployeename.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvideremployeename.Icon")));
            // 
            // errorProvidernewpass
            // 
            this.errorProvidernewpass.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvidernewpass.ContainerControl = this;
            this.errorProvidernewpass.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvidernewpass.Icon")));
            // 
            // errorProviderconfirmnewpass
            // 
            this.errorProviderconfirmnewpass.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderconfirmnewpass.ContainerControl = this;
            this.errorProviderconfirmnewpass.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderconfirmnewpass.Icon")));
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(583, 324);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.coppsw);
            this.Controls.Add(this.confpass);
            this.Controls.Add(this.empuser);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePassword_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangePassword_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvideremployeename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidernewpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderconfirmnewpass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button coppsw;
        private System.Windows.Forms.TextBox confpass;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empuser;
        private System.Windows.Forms.ErrorProvider errorProvideremployeename;
        private System.Windows.Forms.ErrorProvider errorProvidernewpass;
        private System.Windows.Forms.ErrorProvider errorProviderconfirmnewpass;
    }
}