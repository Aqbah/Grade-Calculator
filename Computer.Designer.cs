namespace MultiWindowApp
{
    partial class Computer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Computer));
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnGrade = new System.Windows.Forms.Button();
            this.BtnPerc = new System.Windows.Forms.Button();
            this.LblChem = new System.Windows.Forms.Label();
            this.LblPhy = new System.Windows.Forms.Label();
            this.LblCS = new System.Windows.Forms.Label();
            this.LblIsl = new System.Windows.Forms.Label();
            this.TbChem = new System.Windows.Forms.TextBox();
            this.TbPhy = new System.Windows.Forms.TextBox();
            this.TbCS = new System.Windows.Forms.TextBox();
            this.Grade = new System.Windows.Forms.Label();
            this.Percentage = new System.Windows.Forms.Label();
            this.LblPak = new System.Windows.Forms.Label();
            this.LblMath = new System.Windows.Forms.Label();
            this.LblUrdu = new System.Windows.Forms.Label();
            this.LblEng = new System.Windows.Forms.Label();
            this.TbIsl = new System.Windows.Forms.TextBox();
            this.TbPak = new System.Windows.Forms.TextBox();
            this.TbMath = new System.Windows.Forms.TextBox();
            this.TbUrdu = new System.Windows.Forms.TextBox();
            this.TbEnglish = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.businessSubjectGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerSubjectGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biologySubjectGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.Location = new System.Drawing.Point(530, 422);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(1);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(143, 23);
            this.BtnClear.TabIndex = 43;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnGrade
            // 
            this.BtnGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.BtnGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGrade.FlatAppearance.BorderSize = 0;
            this.BtnGrade.Location = new System.Drawing.Point(350, 422);
            this.BtnGrade.Margin = new System.Windows.Forms.Padding(1);
            this.BtnGrade.Name = "BtnGrade";
            this.BtnGrade.Size = new System.Drawing.Size(143, 23);
            this.BtnGrade.TabIndex = 41;
            this.BtnGrade.Text = "Calculate Grade";
            this.BtnGrade.UseVisualStyleBackColor = false;
            this.BtnGrade.Click += new System.EventHandler(this.BtnGrade_Click);
            // 
            // BtnPerc
            // 
            this.BtnPerc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.BtnPerc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPerc.FlatAppearance.BorderSize = 0;
            this.BtnPerc.Location = new System.Drawing.Point(170, 422);
            this.BtnPerc.Margin = new System.Windows.Forms.Padding(1);
            this.BtnPerc.Name = "BtnPerc";
            this.BtnPerc.Size = new System.Drawing.Size(143, 23);
            this.BtnPerc.TabIndex = 40;
            this.BtnPerc.Text = "Calculate Percentage";
            this.BtnPerc.UseVisualStyleBackColor = false;
            this.BtnPerc.Click += new System.EventHandler(this.BtnPerc_Click);
            // 
            // LblChem
            // 
            this.LblChem.AutoSize = true;
            this.LblChem.BackColor = System.Drawing.Color.Transparent;
            this.LblChem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblChem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LblChem.Location = new System.Drawing.Point(473, 315);
            this.LblChem.Name = "LblChem";
            this.LblChem.Size = new System.Drawing.Size(63, 15);
            this.LblChem.TabIndex = 39;
            this.LblChem.Text = "Chemistry";
            // 
            // LblPhy
            // 
            this.LblPhy.AutoSize = true;
            this.LblPhy.BackColor = System.Drawing.Color.Transparent;
            this.LblPhy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPhy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LblPhy.Location = new System.Drawing.Point(125, 315);
            this.LblPhy.Name = "LblPhy";
            this.LblPhy.Size = new System.Drawing.Size(46, 15);
            this.LblPhy.TabIndex = 38;
            this.LblPhy.Text = "Physics";
            // 
            // LblCS
            // 
            this.LblCS.AutoSize = true;
            this.LblCS.BackColor = System.Drawing.Color.Transparent;
            this.LblCS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LblCS.Location = new System.Drawing.Point(473, 223);
            this.LblCS.Name = "LblCS";
            this.LblCS.Size = new System.Drawing.Size(109, 15);
            this.LblCS.TabIndex = 37;
            this.LblCS.Text = "Computer Science";
            // 
            // LblIsl
            // 
            this.LblIsl.AutoSize = true;
            this.LblIsl.BackColor = System.Drawing.Color.Transparent;
            this.LblIsl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblIsl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LblIsl.Location = new System.Drawing.Point(125, 223);
            this.LblIsl.Name = "LblIsl";
            this.LblIsl.Size = new System.Drawing.Size(50, 15);
            this.LblIsl.TabIndex = 36;
            this.LblIsl.Text = "Islamiat";
            // 
            // TbChem
            // 
            this.TbChem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.TbChem.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbChem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TbChem.Location = new System.Drawing.Point(473, 343);
            this.TbChem.Multiline = true;
            this.TbChem.Name = "TbChem";
            this.TbChem.Size = new System.Drawing.Size(225, 50);
            this.TbChem.TabIndex = 31;
            // 
            // TbPhy
            // 
            this.TbPhy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.TbPhy.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbPhy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TbPhy.Location = new System.Drawing.Point(125, 343);
            this.TbPhy.Multiline = true;
            this.TbPhy.Name = "TbPhy";
            this.TbPhy.Size = new System.Drawing.Size(225, 50);
            this.TbPhy.TabIndex = 30;
            // 
            // TbCS
            // 
            this.TbCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.TbCS.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TbCS.Location = new System.Drawing.Point(473, 251);
            this.TbCS.Multiline = true;
            this.TbCS.Name = "TbCS";
            this.TbCS.Size = new System.Drawing.Size(225, 50);
            this.TbCS.TabIndex = 29;
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Location = new System.Drawing.Point(22, 155);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(0, 15);
            this.Grade.TabIndex = 44;
            this.Grade.Visible = false;
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Location = new System.Drawing.Point(22, 90);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(0, 15);
            this.Percentage.TabIndex = 42;
            this.Percentage.Visible = false;
            // 
            // LblPak
            // 
            this.LblPak.AutoSize = true;
            this.LblPak.BackColor = System.Drawing.Color.Transparent;
            this.LblPak.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LblPak.Location = new System.Drawing.Point(473, 131);
            this.LblPak.Name = "LblPak";
            this.LblPak.Size = new System.Drawing.Size(71, 15);
            this.LblPak.TabIndex = 35;
            this.LblPak.Text = "Pak Studies";
            // 
            // LblMath
            // 
            this.LblMath.AutoSize = true;
            this.LblMath.BackColor = System.Drawing.Color.Transparent;
            this.LblMath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LblMath.Location = new System.Drawing.Point(125, 131);
            this.LblMath.Name = "LblMath";
            this.LblMath.Size = new System.Drawing.Size(79, 15);
            this.LblMath.TabIndex = 34;
            this.LblMath.Text = "Mathematics";
            // 
            // LblUrdu
            // 
            this.LblUrdu.AutoSize = true;
            this.LblUrdu.BackColor = System.Drawing.Color.Transparent;
            this.LblUrdu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUrdu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LblUrdu.Location = new System.Drawing.Point(473, 38);
            this.LblUrdu.Name = "LblUrdu";
            this.LblUrdu.Size = new System.Drawing.Size(35, 15);
            this.LblUrdu.TabIndex = 33;
            this.LblUrdu.Text = "Urdu";
            // 
            // LblEng
            // 
            this.LblEng.AutoSize = true;
            this.LblEng.BackColor = System.Drawing.Color.Transparent;
            this.LblEng.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LblEng.Location = new System.Drawing.Point(125, 38);
            this.LblEng.Name = "LblEng";
            this.LblEng.Size = new System.Drawing.Size(45, 15);
            this.LblEng.TabIndex = 32;
            this.LblEng.Text = "English";
            // 
            // TbIsl
            // 
            this.TbIsl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.TbIsl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbIsl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TbIsl.Location = new System.Drawing.Point(125, 251);
            this.TbIsl.Multiline = true;
            this.TbIsl.Name = "TbIsl";
            this.TbIsl.Size = new System.Drawing.Size(225, 50);
            this.TbIsl.TabIndex = 28;
            // 
            // TbPak
            // 
            this.TbPak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.TbPak.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbPak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TbPak.Location = new System.Drawing.Point(473, 158);
            this.TbPak.Multiline = true;
            this.TbPak.Name = "TbPak";
            this.TbPak.Size = new System.Drawing.Size(225, 50);
            this.TbPak.TabIndex = 27;
            // 
            // TbMath
            // 
            this.TbMath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.TbMath.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbMath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TbMath.Location = new System.Drawing.Point(125, 158);
            this.TbMath.Multiline = true;
            this.TbMath.Name = "TbMath";
            this.TbMath.Size = new System.Drawing.Size(225, 50);
            this.TbMath.TabIndex = 26;
            // 
            // TbUrdu
            // 
            this.TbUrdu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.TbUrdu.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbUrdu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TbUrdu.Location = new System.Drawing.Point(473, 67);
            this.TbUrdu.Multiline = true;
            this.TbUrdu.Name = "TbUrdu";
            this.TbUrdu.Size = new System.Drawing.Size(225, 50);
            this.TbUrdu.TabIndex = 25;
            // 
            // TbEnglish
            // 
            this.TbEnglish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.TbEnglish.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbEnglish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TbEnglish.Location = new System.Drawing.Point(125, 67);
            this.TbEnglish.Multiline = true;
            this.TbEnglish.Name = "TbEnglish";
            this.TbEnglish.Size = new System.Drawing.Size(225, 50);
            this.TbEnglish.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SubMenu
            // 
            this.SubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.businessSubjectGroupToolStripMenuItem,
            this.computerSubjectGroupToolStripMenuItem,
            this.biologySubjectGroupToolStripMenuItem});
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(63, 20);
            this.SubMenu.Text = "Subjects";
            // 
            // businessSubjectGroupToolStripMenuItem
            // 
            this.businessSubjectGroupToolStripMenuItem.Name = "businessSubjectGroupToolStripMenuItem";
            this.businessSubjectGroupToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.businessSubjectGroupToolStripMenuItem.Text = "Business Subject Group";
            this.businessSubjectGroupToolStripMenuItem.Click += new System.EventHandler(this.businessSubjectGroupToolStripMenuItem_Click);
            // 
            // computerSubjectGroupToolStripMenuItem
            // 
            this.computerSubjectGroupToolStripMenuItem.Name = "computerSubjectGroupToolStripMenuItem";
            this.computerSubjectGroupToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.computerSubjectGroupToolStripMenuItem.Text = "Computer Subject Group";
            this.computerSubjectGroupToolStripMenuItem.Click += new System.EventHandler(this.computerSubjectGroupToolStripMenuItem_Click);
            // 
            // biologySubjectGroupToolStripMenuItem
            // 
            this.biologySubjectGroupToolStripMenuItem.Name = "biologySubjectGroupToolStripMenuItem";
            this.biologySubjectGroupToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.biologySubjectGroupToolStripMenuItem.Text = "Biology Subject Group";
            this.biologySubjectGroupToolStripMenuItem.Click += new System.EventHandler(this.biologySubjectGroupToolStripMenuItem_Click);
            // 
            // Computer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(108)))));
            this.CancelButton = this.BtnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnGrade);
            this.Controls.Add(this.BtnPerc);
            this.Controls.Add(this.LblChem);
            this.Controls.Add(this.LblPhy);
            this.Controls.Add(this.LblCS);
            this.Controls.Add(this.LblIsl);
            this.Controls.Add(this.TbChem);
            this.Controls.Add(this.TbPhy);
            this.Controls.Add(this.TbCS);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.LblPak);
            this.Controls.Add(this.LblMath);
            this.Controls.Add(this.LblUrdu);
            this.Controls.Add(this.LblEng);
            this.Controls.Add(this.TbIsl);
            this.Controls.Add(this.TbPak);
            this.Controls.Add(this.TbMath);
            this.Controls.Add(this.TbUrdu);
            this.Controls.Add(this.TbEnglish);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Computer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnClear;
        private Button BtnGrade;
        private Button BtnPerc;
        private Label LblChem;
        private Label LblPhy;
        private Label LblCS;
        private Label LblIsl;
        private TextBox TbChem;
        private TextBox TbPhy;
        private TextBox TbCS;
        private Label Grade;
        private Label Percentage;
        private Label LblPak;
        private Label LblMath;
        private Label LblUrdu;
        private Label LblEng;
        private TextBox TbIsl;
        private TextBox TbPak;
        private TextBox TbMath;
        private TextBox TbUrdu;
        private TextBox TbEnglish;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem SubMenu;
        private ToolStripMenuItem businessSubjectGroupToolStripMenuItem;
        private ToolStripMenuItem computerSubjectGroupToolStripMenuItem;
        private ToolStripMenuItem biologySubjectGroupToolStripMenuItem;
    }
}