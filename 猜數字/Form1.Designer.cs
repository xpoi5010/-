namespace 猜數字
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.d1 = new System.Windows.Forms.TextBox();
            this.d2 = new System.Windows.Forms.TextBox();
            this.d3 = new System.Windows.Forms.TextBox();
            this.d4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.開始遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // d1
            // 
            this.d1.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.d1.Location = new System.Drawing.Point(3, 3);
            this.d1.MaxLength = 1;
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(83, 93);
            this.d1.TabIndex = 0;
            this.d1.Text = "5";
            this.d1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.d1.TextChanged += new System.EventHandler(this.d_TextChanged);
            this.d1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.d_KeyDown);
            // 
            // d2
            // 
            this.d2.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.d2.Location = new System.Drawing.Point(92, 3);
            this.d2.MaxLength = 1;
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(83, 93);
            this.d2.TabIndex = 1;
            this.d2.Text = "7";
            this.d2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.d2.TextChanged += new System.EventHandler(this.d_TextChanged);
            this.d2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.d_KeyDown);
            // 
            // d3
            // 
            this.d3.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.d3.Location = new System.Drawing.Point(181, 3);
            this.d3.MaxLength = 1;
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(83, 93);
            this.d3.TabIndex = 2;
            this.d3.Text = "4";
            this.d3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.d3.TextChanged += new System.EventHandler(this.d_TextChanged);
            this.d3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.d_KeyDown);
            // 
            // d4
            // 
            this.d4.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.d4.Location = new System.Drawing.Point(270, 3);
            this.d4.MaxLength = 1;
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(83, 93);
            this.d4.TabIndex = 3;
            this.d4.Text = "3";
            this.d4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.d4.TextChanged += new System.EventHandler(this.d_TextChanged);
            this.d4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.d_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.d1);
            this.panel1.Controls.Add(this.d4);
            this.panel1.Controls.Add(this.d2);
            this.panel1.Controls.Add(this.d3);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 98);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(12, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "猜測";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(392, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(408, 426);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "0";
            this.columnHeader1.Width = 208;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "1";
            this.columnHeader2.Width = 199;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開始遊戲ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 開始遊戲ToolStripMenuItem
            // 
            this.開始遊戲ToolStripMenuItem.Name = "開始遊戲ToolStripMenuItem";
            this.開始遊戲ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.開始遊戲ToolStripMenuItem.Text = "開始遊戲";
            this.開始遊戲ToolStripMenuItem.Click += new System.EventHandler(this.開始遊戲ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "猜數字";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox d1;
        private System.Windows.Forms.TextBox d2;
        private System.Windows.Forms.TextBox d3;
        private System.Windows.Forms.TextBox d4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 開始遊戲ToolStripMenuItem;
    }
}

