namespace PDF_Resume_Creator
{
    partial class PDFGen
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
            this.LBpsc = new System.Windows.Forms.Label();
            this.achievements6 = new System.Windows.Forms.TextBox();
            this.skills5 = new System.Windows.Forms.TextBox();
            this.Education8 = new System.Windows.Forms.TextBox();
            this.BasicDetails3 = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.ReadBx = new System.Windows.Forms.TextBox();
            this.FirstName1 = new System.Windows.Forms.TextBox();
            this.Gpdf = new System.Windows.Forms.Button();
            this.CharR = new System.Windows.Forms.TextBox();
            this.MStrip = new System.Windows.Forms.MenuStrip();
            this.HMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBpsc
            // 
            this.LBpsc.AutoSize = true;
            this.LBpsc.BackColor = System.Drawing.Color.FloralWhite;
            this.LBpsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBpsc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBpsc.Location = new System.Drawing.Point(229, 24);
            this.LBpsc.Name = "LBpsc";
            this.LBpsc.Size = new System.Drawing.Size(261, 29);
            this.LBpsc.TabIndex = 10;
            this.LBpsc.Text = "PDF Resume Creator";
            this.LBpsc.Click += new System.EventHandler(this.label6_Click);
            // 
            // achievements6
            // 
            this.achievements6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achievements6.Location = new System.Drawing.Point(321, 336);
            this.achievements6.Multiline = true;
            this.achievements6.Name = "achievements6";
            this.achievements6.Size = new System.Drawing.Size(237, 71);
            this.achievements6.TabIndex = 37;
            // 
            // skills5
            // 
            this.skills5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skills5.Location = new System.Drawing.Point(321, 245);
            this.skills5.Multiline = true;
            this.skills5.Name = "skills5";
            this.skills5.Size = new System.Drawing.Size(237, 80);
            this.skills5.TabIndex = 36;
            // 
            // Education8
            // 
            this.Education8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Education8.Location = new System.Drawing.Point(587, 106);
            this.Education8.Multiline = true;
            this.Education8.Name = "Education8";
            this.Education8.Size = new System.Drawing.Size(237, 171);
            this.Education8.TabIndex = 35;
            // 
            // BasicDetails3
            // 
            this.BasicDetails3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicDetails3.Location = new System.Drawing.Point(321, 157);
            this.BasicDetails3.Multiline = true;
            this.BasicDetails3.Name = "BasicDetails3";
            this.BasicDetails3.Size = new System.Drawing.Size(237, 72);
            this.BasicDetails3.TabIndex = 34;
            this.BasicDetails3.TextChanged += new System.EventHandler(this.BasicDetails3_TextChanged);
            // 
            // Convert
            // 
            this.Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Convert.Location = new System.Drawing.Point(492, 56);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(148, 39);
            this.Convert.TabIndex = 33;
            this.Convert.Text = "Convert Json File";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Read
            // 
            this.Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Read.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Read.Location = new System.Drawing.Point(95, 56);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(132, 34);
            this.Read.TabIndex = 32;
            this.Read.Text = "Read Json File";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // ReadBx
            // 
            this.ReadBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadBx.Location = new System.Drawing.Point(33, 106);
            this.ReadBx.Multiline = true;
            this.ReadBx.Name = "ReadBx";
            this.ReadBx.Size = new System.Drawing.Size(257, 301);
            this.ReadBx.TabIndex = 29;
            // 
            // FirstName1
            // 
            this.FirstName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName1.Location = new System.Drawing.Point(321, 106);
            this.FirstName1.Multiline = true;
            this.FirstName1.Name = "FirstName1";
            this.FirstName1.Size = new System.Drawing.Size(237, 36);
            this.FirstName1.TabIndex = 28;
            // 
            // Gpdf
            // 
            this.Gpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpdf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gpdf.Location = new System.Drawing.Point(644, 373);
            this.Gpdf.Name = "Gpdf";
            this.Gpdf.Size = new System.Drawing.Size(126, 34);
            this.Gpdf.TabIndex = 27;
            this.Gpdf.Text = "Generate PDF";
            this.Gpdf.UseVisualStyleBackColor = true;
            this.Gpdf.Click += new System.EventHandler(this.Gpdf_Click);
            // 
            // CharR
            // 
            this.CharR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharR.Location = new System.Drawing.Point(587, 287);
            this.CharR.Multiline = true;
            this.CharR.Name = "CharR";
            this.CharR.Size = new System.Drawing.Size(237, 71);
            this.CharR.TabIndex = 38;
            // 
            // MStrip
            // 
            this.MStrip.BackColor = System.Drawing.Color.PapayaWhip;
            this.MStrip.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HMenu,
            this.AMenu});
            this.MStrip.Location = new System.Drawing.Point(0, 0);
            this.MStrip.Name = "MStrip";
            this.MStrip.Size = new System.Drawing.Size(858, 24);
            this.MStrip.TabIndex = 39;
            this.MStrip.Text = "menuStrip1";
            // 
            // HMenu
            // 
            this.HMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EMenu});
            this.HMenu.Name = "HMenu";
            this.HMenu.Size = new System.Drawing.Size(48, 20);
            this.HMenu.Text = "Help";
            // 
            // EMenu
            // 
            this.EMenu.Name = "EMenu";
            this.EMenu.Size = new System.Drawing.Size(152, 22);
            this.EMenu.Text = "Exit";
            this.EMenu.Click += new System.EventHandler(this.EMenu_Click);
            // 
            // AMenu
            // 
            this.AMenu.BackColor = System.Drawing.Color.PapayaWhip;
            this.AMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PMenu});
            this.AMenu.Name = "AMenu";
            this.AMenu.Size = new System.Drawing.Size(57, 20);
            this.AMenu.Text = "About";
            // 
            // PMenu
            // 
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(188, 22);
            this.PMenu.Text = "Program Town Inc.";
            this.PMenu.Click += new System.EventHandler(this.PMenu_Click);
            // 
            // PDFGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(858, 431);
            this.Controls.Add(this.CharR);
            this.Controls.Add(this.achievements6);
            this.Controls.Add(this.skills5);
            this.Controls.Add(this.Education8);
            this.Controls.Add(this.BasicDetails3);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.ReadBx);
            this.Controls.Add(this.FirstName1);
            this.Controls.Add(this.Gpdf);
            this.Controls.Add(this.LBpsc);
            this.Controls.Add(this.MStrip);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MStrip;
            this.MaximizeBox = false;
            this.Name = "PDFGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Generator";
            this.MStrip.ResumeLayout(false);
            this.MStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBpsc;
        private System.Windows.Forms.TextBox achievements6;
        private System.Windows.Forms.TextBox skills5;
        private System.Windows.Forms.TextBox Education8;
        private System.Windows.Forms.TextBox BasicDetails3;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.TextBox ReadBx;
        private System.Windows.Forms.TextBox FirstName1;
        private System.Windows.Forms.Button Gpdf;
        private System.Windows.Forms.TextBox CharR;
        private System.Windows.Forms.MenuStrip MStrip;
        private System.Windows.Forms.ToolStripMenuItem HMenu;
        private System.Windows.Forms.ToolStripMenuItem EMenu;
        private System.Windows.Forms.ToolStripMenuItem AMenu;
        private System.Windows.Forms.ToolStripMenuItem PMenu;
    }
}

