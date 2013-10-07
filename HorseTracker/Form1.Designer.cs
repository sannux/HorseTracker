namespace HorseTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_reg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(41, 181);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(173, 20);
            this.tb_username.TabIndex = 0;
            this.tb_username.Text = "username";
            this.tb_username.Enter += new System.EventHandler(this.tb_username_Enter);
            this.tb_username.Leave += new System.EventHandler(this.tb_username_Leave);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(41, 207);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(173, 20);
            this.tb_pass.TabIndex = 1;
            this.tb_pass.Text = "password";
            this.tb_pass.Enter += new System.EventHandler(this.tb_pass_Enter);
            this.tb_pass.Leave += new System.EventHandler(this.tb_pass_Leave);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(139, 233);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = "Login";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bt_reg
            // 
            this.bt_reg.Location = new System.Drawing.Point(139, 263);
            this.bt_reg.Name = "bt_reg";
            this.bt_reg.Size = new System.Drawing.Size(75, 23);
            this.bt_reg.TabIndex = 4;
            this.bt_reg.Text = "Register";
            this.bt_reg.UseVisualStyleBackColor = true;
            this.bt_reg.Click += new System.EventHandler(this.bt_reg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 381);
            this.Controls.Add(this.bt_reg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_reg;
    }
}

