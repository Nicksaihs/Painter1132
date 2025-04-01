namespace Painter1132
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            畫筆色彩ToolStripMenuItem = new ToolStripMenuItem();
            藍ToolStripMenuItem = new ToolStripMenuItem();
            黑ToolStripMenuItem = new ToolStripMenuItem();
            紅ToolStripMenuItem = new ToolStripMenuItem();
            線條粗細ToolStripMenuItem = new ToolStripMenuItem();
            粗ToolStripMenuItem = new ToolStripMenuItem();
            中ToolStripMenuItem = new ToolStripMenuItem();
            細ToolStripMenuItem = new ToolStripMenuItem();
            線條樣式ToolStripMenuItem = new ToolStripMenuItem();
            直線ToolStripMenuItem = new ToolStripMenuItem();
            點短虛線ToolStripMenuItem = new ToolStripMenuItem();
            長短虛線ToolStripMenuItem = new ToolStripMenuItem();
            常虛線ToolStripMenuItem = new ToolStripMenuItem();
            儲存檔案ToolStripMenuItem = new ToolStripMenuItem();
            橡皮擦ToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 畫筆色彩ToolStripMenuItem, 線條粗細ToolStripMenuItem, 線條樣式ToolStripMenuItem, 儲存檔案ToolStripMenuItem, 橡皮擦ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 畫筆色彩ToolStripMenuItem
            // 
            畫筆色彩ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 藍ToolStripMenuItem, 黑ToolStripMenuItem, 紅ToolStripMenuItem });
            畫筆色彩ToolStripMenuItem.Name = "畫筆色彩ToolStripMenuItem";
            畫筆色彩ToolStripMenuItem.Size = new Size(67, 20);
            畫筆色彩ToolStripMenuItem.Text = "畫筆色彩";
            // 
            // 藍ToolStripMenuItem
            // 
            藍ToolStripMenuItem.Name = "藍ToolStripMenuItem";
            藍ToolStripMenuItem.Size = new Size(86, 22);
            藍ToolStripMenuItem.Text = "藍";
            藍ToolStripMenuItem.Click += 藍ToolStripMenuItem_Click;
            // 
            // 黑ToolStripMenuItem
            // 
            黑ToolStripMenuItem.Name = "黑ToolStripMenuItem";
            黑ToolStripMenuItem.Size = new Size(86, 22);
            黑ToolStripMenuItem.Text = "黑";
            // 
            // 紅ToolStripMenuItem
            // 
            紅ToolStripMenuItem.Name = "紅ToolStripMenuItem";
            紅ToolStripMenuItem.Size = new Size(86, 22);
            紅ToolStripMenuItem.Text = "紅";
            // 
            // 線條粗細ToolStripMenuItem
            // 
            線條粗細ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 粗ToolStripMenuItem, 中ToolStripMenuItem, 細ToolStripMenuItem });
            線條粗細ToolStripMenuItem.Name = "線條粗細ToolStripMenuItem";
            線條粗細ToolStripMenuItem.Size = new Size(67, 20);
            線條粗細ToolStripMenuItem.Text = "線條粗細";
            // 
            // 粗ToolStripMenuItem
            // 
            粗ToolStripMenuItem.Name = "粗ToolStripMenuItem";
            粗ToolStripMenuItem.Size = new Size(86, 22);
            粗ToolStripMenuItem.Text = "粗";
            粗ToolStripMenuItem.Click += 粗ToolStripMenuItem_Click;
            // 
            // 中ToolStripMenuItem
            // 
            中ToolStripMenuItem.Name = "中ToolStripMenuItem";
            中ToolStripMenuItem.Size = new Size(86, 22);
            中ToolStripMenuItem.Text = "中";
            // 
            // 細ToolStripMenuItem
            // 
            細ToolStripMenuItem.Name = "細ToolStripMenuItem";
            細ToolStripMenuItem.Size = new Size(86, 22);
            細ToolStripMenuItem.Text = "細";
            細ToolStripMenuItem.Click += 細ToolStripMenuItem_Click;
            // 
            // 線條樣式ToolStripMenuItem
            // 
            線條樣式ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 直線ToolStripMenuItem, 點短虛線ToolStripMenuItem, 長短虛線ToolStripMenuItem, 常虛線ToolStripMenuItem });
            線條樣式ToolStripMenuItem.Name = "線條樣式ToolStripMenuItem";
            線條樣式ToolStripMenuItem.Size = new Size(67, 20);
            線條樣式ToolStripMenuItem.Text = "線條樣式";
            // 
            // 直線ToolStripMenuItem
            // 
            直線ToolStripMenuItem.Name = "直線ToolStripMenuItem";
            直線ToolStripMenuItem.Size = new Size(134, 22);
            直線ToolStripMenuItem.Text = "直線";
            直線ToolStripMenuItem.Click += 直線ToolStripMenuItem_Click;
            // 
            // 點短虛線ToolStripMenuItem
            // 
            點短虛線ToolStripMenuItem.Name = "點短虛線ToolStripMenuItem";
            點短虛線ToolStripMenuItem.Size = new Size(134, 22);
            點短虛線ToolStripMenuItem.Text = "點、短虛線";
            點短虛線ToolStripMenuItem.Click += 點短虛線ToolStripMenuItem_Click;
            // 
            // 長短虛線ToolStripMenuItem
            // 
            長短虛線ToolStripMenuItem.Name = "長短虛線ToolStripMenuItem";
            長短虛線ToolStripMenuItem.Size = new Size(134, 22);
            長短虛線ToolStripMenuItem.Text = "長短虛線";
            長短虛線ToolStripMenuItem.Click += 長短虛線ToolStripMenuItem_Click;
            // 
            // 常虛線ToolStripMenuItem
            // 
            常虛線ToolStripMenuItem.Name = "常虛線ToolStripMenuItem";
            常虛線ToolStripMenuItem.Size = new Size(134, 22);
            常虛線ToolStripMenuItem.Text = "長虛線";
            常虛線ToolStripMenuItem.Click += 常虛線ToolStripMenuItem_Click;
            // 
            // 儲存檔案ToolStripMenuItem
            // 
            儲存檔案ToolStripMenuItem.Name = "儲存檔案ToolStripMenuItem";
            儲存檔案ToolStripMenuItem.Size = new Size(67, 20);
            儲存檔案ToolStripMenuItem.Text = "儲存檔案";
            儲存檔案ToolStripMenuItem.Click += 儲存檔案ToolStripMenuItem_Click;
            // 
            // 橡皮擦ToolStripMenuItem
            // 
            橡皮擦ToolStripMenuItem.Image = Properties.Resources.eraser;
            橡皮擦ToolStripMenuItem.Name = "橡皮擦ToolStripMenuItem";
            橡皮擦ToolStripMenuItem.Size = new Size(71, 20);
            橡皮擦ToolStripMenuItem.Text = "橡皮擦";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Location = new Point(14, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 293);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // button1
            // 
            button1.Location = new Point(520, 195);
            button1.Name = "button1";
            button1.Size = new Size(105, 84);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 56);
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = Properties.Resources.eraser;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.MouseDownBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(64, 54);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImage = Properties.Resources.pencil;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.MouseDownBackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(70, 0);
            button3.Name = "button3";
            button3.Size = new Size(64, 54);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "小畫家";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 畫筆色彩ToolStripMenuItem;
        private ToolStripMenuItem 藍ToolStripMenuItem;
        private ToolStripMenuItem 黑ToolStripMenuItem;
        private ToolStripMenuItem 紅ToolStripMenuItem;
        private ToolStripMenuItem 線條粗細ToolStripMenuItem;
        private ToolStripMenuItem 粗ToolStripMenuItem;
        private ToolStripMenuItem 中ToolStripMenuItem;
        private ToolStripMenuItem 細ToolStripMenuItem;
        private ToolStripMenuItem 線條樣式ToolStripMenuItem;
        private ToolStripMenuItem 直線ToolStripMenuItem;
        private ToolStripMenuItem 點短虛線ToolStripMenuItem;
        private ToolStripMenuItem 長短虛線ToolStripMenuItem;
        private ToolStripMenuItem 常虛線ToolStripMenuItem;
        private ToolStripMenuItem 儲存檔案ToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button button1;
        private ToolStripMenuItem 橡皮擦ToolStripMenuItem;
        private Panel panel1;
        private Button button2;
        private Button button3;
    }
}