namespace HorseTracker
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.list_horses = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fav_list = new System.Windows.Forms.ListBox();
            this.bt_favOK = new System.Windows.Forms.Button();
            this.txt_favsearch = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(258, 380);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.list_horses);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(250, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Horses";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // list_horses
            // 
            this.list_horses.FormattingEnabled = true;
            this.list_horses.Location = new System.Drawing.Point(4, 34);
            this.list_horses.Name = "list_horses";
            this.list_horses.Size = new System.Drawing.Size(241, 316);
            this.list_horses.TabIndex = 3;
            this.list_horses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_horses_MouseClick);
            this.list_horses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_horses_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Search";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fav_list);
            this.tabPage2.Controls.Add(this.bt_favOK);
            this.tabPage2.Controls.Add(this.txt_favsearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(248, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fav_Horses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fav_list
            // 
            this.fav_list.FormattingEnabled = true;
            this.fav_list.Location = new System.Drawing.Point(4, 34);
            this.fav_list.Name = "fav_list";
            this.fav_list.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.fav_list.Size = new System.Drawing.Size(241, 316);
            this.fav_list.TabIndex = 6;
            // 
            // bt_favOK
            // 
            this.bt_favOK.Location = new System.Drawing.Point(207, 6);
            this.bt_favOK.Name = "bt_favOK";
            this.bt_favOK.Size = new System.Drawing.Size(38, 23);
            this.bt_favOK.TabIndex = 5;
            this.bt_favOK.Text = "OK";
            this.bt_favOK.UseVisualStyleBackColor = true;
            this.bt_favOK.Click += new System.EventHandler(this.bt_favOK_Click);
            // 
            // txt_favsearch
            // 
            this.txt_favsearch.Location = new System.Drawing.Point(7, 7);
            this.txt_favsearch.Name = "txt_favsearch";
            this.txt_favsearch.Size = new System.Drawing.Size(197, 20);
            this.txt_favsearch.TabIndex = 4;
            this.txt_favsearch.Text = "Search";
            this.txt_favsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_favsearch_KeyDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(248, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fav_Jockey";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(248, 354);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Profile";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 381);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox list_horses;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox fav_list;
        private System.Windows.Forms.Button bt_favOK;
        private System.Windows.Forms.TextBox txt_favsearch;
    }
}