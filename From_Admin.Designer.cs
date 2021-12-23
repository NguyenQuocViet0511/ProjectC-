namespace Login.FromMain
{
    partial class From_Admin
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
            this.panelside = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelheader = new System.Windows.Forms.Panel();
            this.panelmain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btndeactivateuser = new System.Windows.Forms.Button();
            this.btnresetpassword = new System.Windows.Forms.Button();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.panelside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelheader.SuspendLayout();
            this.panelmain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.MediumPurple;
            this.panelside.Controls.Add(this.btnaddnew);
            this.panelside.Controls.Add(this.pictureBox1);
            this.panelside.Controls.Add(this.btnresetpassword);
            this.panelside.Controls.Add(this.btnrefresh);
            this.panelside.Controls.Add(this.btndeactivateuser);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 0);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(210, 843);
            this.panelside.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Login.Properties.Resources.user_groups_64px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.MediumPurple;
            this.panelheader.Controls.Add(this.label1);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(210, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1198, 100);
            this.panelheader.TabIndex = 1;
            // 
            // panelmain
            // 
            this.panelmain.Controls.Add(this.panel1);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(210, 0);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1198, 843);
            this.panelmain.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("MV Boli", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1198, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager User ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 843);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // btnrefresh
            // 
            this.btnrefresh.AutoSize = true;
            this.btnrefresh.FlatAppearance.BorderSize = 0;
            this.btnrefresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Location = new System.Drawing.Point(0, 218);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(202, 89);
            this.btnrefresh.TabIndex = 1;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btndeactivateuser
            // 
            this.btndeactivateuser.AutoSize = true;
            this.btndeactivateuser.FlatAppearance.BorderSize = 0;
            this.btndeactivateuser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeactivateuser.Location = new System.Drawing.Point(0, 490);
            this.btndeactivateuser.Name = "btndeactivateuser";
            this.btndeactivateuser.Size = new System.Drawing.Size(202, 88);
            this.btndeactivateuser.TabIndex = 2;
            this.btndeactivateuser.Text = "Deactivate User";
            this.btndeactivateuser.UseVisualStyleBackColor = true;
            this.btndeactivateuser.Click += new System.EventHandler(this.btndeactivateuser_Click);
            // 
            // btnresetpassword
            // 
            this.btnresetpassword.AutoSize = true;
            this.btnresetpassword.FlatAppearance.BorderSize = 0;
            this.btnresetpassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetpassword.Location = new System.Drawing.Point(0, 397);
            this.btnresetpassword.Name = "btnresetpassword";
            this.btnresetpassword.Size = new System.Drawing.Size(202, 87);
            this.btnresetpassword.TabIndex = 3;
            this.btnresetpassword.Text = "ResetPassword";
            this.btnresetpassword.UseVisualStyleBackColor = true;
            this.btnresetpassword.Click += new System.EventHandler(this.btnresetpassword_Click);
            // 
            // btnaddnew
            // 
            this.btnaddnew.AutoSize = true;
            this.btnaddnew.FlatAppearance.BorderSize = 0;
            this.btnaddnew.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnew.Location = new System.Drawing.Point(0, 313);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(202, 78);
            this.btnaddnew.TabIndex = 4;
            this.btnaddnew.Text = "Add new user";
            this.btnaddnew.UseVisualStyleBackColor = true;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // From_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 843);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panelside);
            this.Name = "From_Admin";
            this.Text = "From_Admin";
            this.panelside.ResumeLayout(false);
            this.panelside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelheader.ResumeLayout(false);
            this.panelmain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.Button btnresetpassword;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btndeactivateuser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}