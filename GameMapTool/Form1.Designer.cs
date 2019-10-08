namespace GameMapTool
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MapCanvas = new System.Windows.Forms.Panel();
            this.BlockPalette = new System.Windows.Forms.Panel();
            this.Tile51 = new System.Windows.Forms.Button();
            this.Tile50 = new System.Windows.Forms.Button();
            this.TileEraser = new System.Windows.Forms.Button();
            this.Tile41 = new System.Windows.Forms.Button();
            this.Tile40 = new System.Windows.Forms.Button();
            this.Tile31 = new System.Windows.Forms.Button();
            this.Tile30 = new System.Windows.Forms.Button();
            this.Tile21 = new System.Windows.Forms.Button();
            this.Tile20 = new System.Windows.Forms.Button();
            this.Tile11 = new System.Windows.Forms.Button();
            this.Tile10 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.Label();
            this.MonsterList = new System.Windows.Forms.ListBox();
            this.MonsterAddBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BlockPalette.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapCanvas
            // 
            this.MapCanvas.BackColor = System.Drawing.SystemColors.ControlText;
            this.MapCanvas.Location = new System.Drawing.Point(12, 26);
            this.MapCanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MapCanvas.Name = "MapCanvas";
            this.MapCanvas.Size = new System.Drawing.Size(480, 400);
            this.MapCanvas.TabIndex = 0;
            // 
            // BlockPalette
            // 
            this.BlockPalette.AutoScroll = true;
            this.BlockPalette.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BlockPalette.Controls.Add(this.Tile51);
            this.BlockPalette.Controls.Add(this.Tile50);
            this.BlockPalette.Controls.Add(this.TileEraser);
            this.BlockPalette.Controls.Add(this.Tile41);
            this.BlockPalette.Controls.Add(this.Tile40);
            this.BlockPalette.Controls.Add(this.Tile31);
            this.BlockPalette.Controls.Add(this.Tile30);
            this.BlockPalette.Controls.Add(this.Tile21);
            this.BlockPalette.Controls.Add(this.Tile20);
            this.BlockPalette.Controls.Add(this.Tile11);
            this.BlockPalette.Controls.Add(this.Tile10);
            this.BlockPalette.Location = new System.Drawing.Point(510, 26);
            this.BlockPalette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BlockPalette.Name = "BlockPalette";
            this.BlockPalette.Size = new System.Drawing.Size(307, 80);
            this.BlockPalette.TabIndex = 1;
            // 
            // Tile51
            // 
            this.Tile51.Image = ((System.Drawing.Image)(resources.GetObject("Tile51.Image")));
            this.Tile51.Location = new System.Drawing.Point(126, 40);
            this.Tile51.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tile51.Name = "Tile51";
            this.Tile51.Size = new System.Drawing.Size(35, 32);
            this.Tile51.TabIndex = 10;
            this.Tile51.Text = "\r\n";
            this.Tile51.UseVisualStyleBackColor = true;
            // 
            // Tile50
            // 
            this.Tile50.Image = ((System.Drawing.Image)(resources.GetObject("Tile50.Image")));
            this.Tile50.Location = new System.Drawing.Point(85, 40);
            this.Tile50.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tile50.Name = "Tile50";
            this.Tile50.Size = new System.Drawing.Size(35, 32);
            this.Tile50.TabIndex = 9;
            this.Tile50.Text = "\r\n";
            this.Tile50.UseVisualStyleBackColor = true;
            // 
            // TileEraser
            // 
            this.TileEraser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TileEraser.ForeColor = System.Drawing.Color.Red;
            this.TileEraser.Location = new System.Drawing.Point(3, 3);
            this.TileEraser.Name = "TileEraser";
            this.TileEraser.Size = new System.Drawing.Size(35, 32);
            this.TileEraser.TabIndex = 8;
            this.TileEraser.Text = "X";
            this.TileEraser.UseVisualStyleBackColor = false;
            // 
            // Tile41
            // 
            this.Tile41.Image = ((System.Drawing.Image)(resources.GetObject("Tile41.Image")));
            this.Tile41.Location = new System.Drawing.Point(208, 4);
            this.Tile41.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tile41.Name = "Tile41";
            this.Tile41.Size = new System.Drawing.Size(35, 32);
            this.Tile41.TabIndex = 7;
            this.Tile41.Text = "\r\n";
            this.Tile41.UseVisualStyleBackColor = true;
            // 
            // Tile40
            // 
            this.Tile40.Image = ((System.Drawing.Image)(resources.GetObject("Tile40.Image")));
            this.Tile40.Location = new System.Drawing.Point(249, 4);
            this.Tile40.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tile40.Name = "Tile40";
            this.Tile40.Size = new System.Drawing.Size(35, 32);
            this.Tile40.TabIndex = 6;
            this.Tile40.Text = "\r\n";
            this.Tile40.UseVisualStyleBackColor = true;
            // 
            // Tile31
            // 
            this.Tile31.Image = ((System.Drawing.Image)(resources.GetObject("Tile31.Image")));
            this.Tile31.Location = new System.Drawing.Point(44, 40);
            this.Tile31.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tile31.Name = "Tile31";
            this.Tile31.Size = new System.Drawing.Size(35, 32);
            this.Tile31.TabIndex = 5;
            this.Tile31.Text = "\r\n";
            this.Tile31.UseVisualStyleBackColor = true;
            // 
            // Tile30
            // 
            this.Tile30.Image = ((System.Drawing.Image)(resources.GetObject("Tile30.Image")));
            this.Tile30.Location = new System.Drawing.Point(3, 40);
            this.Tile30.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tile30.Name = "Tile30";
            this.Tile30.Size = new System.Drawing.Size(35, 32);
            this.Tile30.TabIndex = 4;
            this.Tile30.Text = "\r\n";
            this.Tile30.UseVisualStyleBackColor = true;
            // 
            // Tile21
            // 
            this.Tile21.Image = ((System.Drawing.Image)(resources.GetObject("Tile21.Image")));
            this.Tile21.Location = new System.Drawing.Point(167, 4);
            this.Tile21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tile21.Name = "Tile21";
            this.Tile21.Size = new System.Drawing.Size(35, 32);
            this.Tile21.TabIndex = 3;
            this.Tile21.Text = "\r\n";
            this.Tile21.UseVisualStyleBackColor = true;
            // 
            // Tile20
            // 
            this.Tile20.Image = ((System.Drawing.Image)(resources.GetObject("Tile20.Image")));
            this.Tile20.Location = new System.Drawing.Point(126, 4);
            this.Tile20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tile20.Name = "Tile20";
            this.Tile20.Size = new System.Drawing.Size(35, 32);
            this.Tile20.TabIndex = 2;
            this.Tile20.Text = "\r\n";
            this.Tile20.UseVisualStyleBackColor = true;
            // 
            // Tile11
            // 
            this.Tile11.Image = ((System.Drawing.Image)(resources.GetObject("Tile11.Image")));
            this.Tile11.Location = new System.Drawing.Point(85, 4);
            this.Tile11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tile11.Name = "Tile11";
            this.Tile11.Size = new System.Drawing.Size(35, 32);
            this.Tile11.TabIndex = 1;
            this.Tile11.Text = "\r\n";
            this.Tile11.UseVisualStyleBackColor = true;
            // 
            // Tile10
            // 
            this.Tile10.Image = ((System.Drawing.Image)(resources.GetObject("Tile10.Image")));
            this.Tile10.Location = new System.Drawing.Point(44, 4);
            this.Tile10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tile10.Name = "Tile10";
            this.Tile10.Size = new System.Drawing.Size(35, 32);
            this.Tile10.TabIndex = 0;
            this.Tile10.Text = " ";
            this.Tile10.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSave,
            this.MenuLoad});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // MenuSave
            // 
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Size = new System.Drawing.Size(122, 22);
            this.MenuSave.Text = "저장하기";
            // 
            // MenuLoad
            // 
            this.MenuLoad.Name = "MenuLoad";
            this.MenuLoad.Size = new System.Drawing.Size(122, 22);
            this.MenuLoad.Text = "불러오기";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(12, 428);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(38, 12);
            this.Status.TabIndex = 4;
            this.Status.Text = "label1";
            // 
            // MonsterList
            // 
            this.MonsterList.FormattingEnabled = true;
            this.MonsterList.ItemHeight = 12;
            this.MonsterList.Location = new System.Drawing.Point(513, 148);
            this.MonsterList.Name = "MonsterList";
            this.MonsterList.Size = new System.Drawing.Size(304, 280);
            this.MonsterList.TabIndex = 5;
            this.MonsterList.DoubleClick += new System.EventHandler(this.MonsterList_DoubleClick);
            // 
            // MonsterAddBtn
            // 
            this.MonsterAddBtn.Location = new System.Drawing.Point(621, 119);
            this.MonsterAddBtn.Name = "MonsterAddBtn";
            this.MonsterAddBtn.Size = new System.Drawing.Size(91, 23);
            this.MonsterAddBtn.TabIndex = 6;
            this.MonsterAddBtn.Text = "몬스터 추가";
            this.MonsterAddBtn.UseVisualStyleBackColor = true;
            this.MonsterAddBtn.Click += new System.EventHandler(this.MonsterAddBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(718, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "몬스터 삭제";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(844, 531);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MonsterAddBtn);
            this.Controls.Add(this.MonsterList);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BlockPalette);
            this.Controls.Add(this.MapCanvas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BlockPalette.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel BlockPalette;
        private System.Windows.Forms.Button Tile11;
        private System.Windows.Forms.Button Tile10;
        private System.Windows.Forms.Button Tile21;
        private System.Windows.Forms.Button Tile20;
        private System.Windows.Forms.Button Tile41;
        private System.Windows.Forms.Button Tile40;
        private System.Windows.Forms.Button Tile31;
        private System.Windows.Forms.Button Tile30;
        public System.Windows.Forms.Panel MapCanvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuLoad;
        public System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button TileEraser;
        private System.Windows.Forms.Button Tile51;
        private System.Windows.Forms.Button Tile50;
        private System.Windows.Forms.ListBox MonsterList;
        private System.Windows.Forms.Button MonsterAddBtn;
        private System.Windows.Forms.Button button2;
    }
}

