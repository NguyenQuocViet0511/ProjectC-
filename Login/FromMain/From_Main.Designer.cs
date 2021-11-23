
namespace Login.FromMain
{
    partial class From_Main
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
            this.TimerPanelMenu = new System.Windows.Forms.Timer(this.components);
            this.Menu = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerPanelMenu
            // 
            this.TimerPanelMenu.Interval = 1;
            this.TimerPanelMenu.Tick += new System.EventHandler(this.TimerPanelMenu_Tick);
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu.Image = global::Login.Properties.Resources.menu_30px;
            this.Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Menu.Location = new System.Drawing.Point(152, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(40, 46);
            this.Menu.TabIndex = 0;
            this.Menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMenu.Controls.Add(this.Menu);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 613);
            this.PanelMenu.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 46);
            this.panel1.TabIndex = 4;
            // 
            // From_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMenu);
            this.Name = "From_Main";
            this.Text = "From_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.From_Main_Load);
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TimerPanelMenu;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panel1;
    }
}