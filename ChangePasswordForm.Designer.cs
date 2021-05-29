
namespace Bus_Ticketing_System_1
{
    partial class ChangePasswordForm
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
            this.confpas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usn = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.TextBox();
            this.confpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // confpas
            // 
            this.confpas.BackColor = System.Drawing.Color.Lime;
            this.confpas.Location = new System.Drawing.Point(206, 266);
            this.confpas.Name = "confpas";
            this.confpas.Size = new System.Drawing.Size(156, 35);
            this.confpas.TabIndex = 0;
            this.confpas.Text = "Change Password";
            this.confpas.UseVisualStyleBackColor = false;
            this.confpas.Click += new System.EventHandler(this.confpas_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(436, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name:-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password:-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password:-";
            // 
            // usn
            // 
            this.usn.Location = new System.Drawing.Point(301, 59);
            this.usn.Name = "usn";
            this.usn.Size = new System.Drawing.Size(100, 25);
            this.usn.TabIndex = 5;
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(301, 106);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(100, 25);
            this.newpass.TabIndex = 6;
            // 
            // confpass
            // 
            this.confpass.Location = new System.Drawing.Point(301, 154);
            this.confpass.Name = "confpass";
            this.confpass.Size = new System.Drawing.Size(100, 25);
            this.confpass.TabIndex = 7;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(655, 325);
            this.Controls.Add(this.confpass);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.usn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.confpas);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confpas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usn;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.TextBox confpass;
    }
}