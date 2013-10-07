namespace HorseTracker
{
    partial class Register
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
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_confirm = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.b_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_reg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_fullname
            // 
            this.tb_fullname.Location = new System.Drawing.Point(35, 85);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(186, 20);
            this.tb_fullname.TabIndex = 0;
            this.tb_fullname.Text = "Enter Full Name";
            this.tb_fullname.Enter += new System.EventHandler(this.tb_fullname_Enter);
            this.tb_fullname.Leave += new System.EventHandler(this.tb_fullname_Leave);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(35, 122);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(186, 20);
            this.tb_username.TabIndex = 1;
            this.tb_username.Text = "Enter Username";
            this.tb_username.Enter += new System.EventHandler(this.tb_username_Enter);
            this.tb_username.Leave += new System.EventHandler(this.tb_username_Leave);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(35, 160);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(186, 20);
            this.tb_pass.TabIndex = 2;
            this.tb_pass.Text = "Enter Password";
            this.tb_pass.Enter += new System.EventHandler(this.tb_pass_Enter);
            this.tb_pass.Leave += new System.EventHandler(this.tb_pass_Leave);
            // 
            // tb_confirm
            // 
            this.tb_confirm.Location = new System.Drawing.Point(35, 198);
            this.tb_confirm.Name = "tb_confirm";
            this.tb_confirm.Size = new System.Drawing.Size(186, 20);
            this.tb_confirm.TabIndex = 3;
            this.tb_confirm.Text = "Confirm Password";
            this.tb_confirm.Enter += new System.EventHandler(this.tb_confirm_Enter);
            this.tb_confirm.Leave += new System.EventHandler(this.tb_confirm_Leave);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(35, 237);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(186, 20);
            this.tb_email.TabIndex = 4;
            this.tb_email.Text = "Enter Email";
            this.tb_email.Enter += new System.EventHandler(this.tb_email_Enter);
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // b_date
            // 
            this.b_date.CustomFormat = "YYYY-MM-DD";
            this.b_date.Location = new System.Drawing.Point(35, 279);
            this.b_date.Name = "b_date";
            this.b_date.Size = new System.Drawing.Size(186, 20);
            this.b_date.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date of Birth";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(146, 305);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 7;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // bt_reg
            // 
            this.bt_reg.Location = new System.Drawing.Point(65, 305);
            this.bt_reg.Name = "bt_reg";
            this.bt_reg.Size = new System.Drawing.Size(75, 23);
            this.bt_reg.TabIndex = 8;
            this.bt_reg.Text = "Register";
            this.bt_reg.UseVisualStyleBackColor = true;
            this.bt_reg.Click += new System.EventHandler(this.bt_reg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Registration";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_reg);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_date);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_confirm);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_fullname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_fullname;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_confirm;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.DateTimePicker b_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_reg;
        private System.Windows.Forms.Label label2;
    }
}