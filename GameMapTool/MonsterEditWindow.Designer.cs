namespace GameMapTool
{
    partial class MonsterEditWindow
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
            this.MonsterPic = new System.Windows.Forms.PictureBox();
            this.monster_id_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CommandList = new System.Windows.Forms.ListBox();
            this.CmdAddBtn = new System.Windows.Forms.Button();
            this.CmdDeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CmdSelector = new System.Windows.Forms.ComboBox();
            this.CmdAmount = new System.Windows.Forms.TextBox();
            this.MonsterIdInput = new System.Windows.Forms.TextBox();
            this.MonsterTypeSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InitXPos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InitYPos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPic)).BeginInit();
            this.SuspendLayout();
            // 
            // MonsterPic
            // 
            this.MonsterPic.Location = new System.Drawing.Point(12, 12);
            this.MonsterPic.Name = "MonsterPic";
            this.MonsterPic.Size = new System.Drawing.Size(96, 96);
            this.MonsterPic.TabIndex = 0;
            this.MonsterPic.TabStop = false;
            // 
            // monster_id_label
            // 
            this.monster_id_label.AutoSize = true;
            this.monster_id_label.Font = new System.Drawing.Font("굴림", 12F);
            this.monster_id_label.Location = new System.Drawing.Point(125, 23);
            this.monster_id_label.Name = "monster_id_label";
            this.monster_id_label.Size = new System.Drawing.Size(74, 16);
            this.monster_id_label.TabIndex = 1;
            this.monster_id_label.Text = "몬스터ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(125, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "몬스터Type:";
            // 
            // CommandList
            // 
            this.CommandList.FormattingEnabled = true;
            this.CommandList.ItemHeight = 12;
            this.CommandList.Location = new System.Drawing.Point(19, 171);
            this.CommandList.Name = "CommandList";
            this.CommandList.Size = new System.Drawing.Size(369, 208);
            this.CommandList.TabIndex = 3;
            // 
            // CmdAddBtn
            // 
            this.CmdAddBtn.Location = new System.Drawing.Point(214, 132);
            this.CmdAddBtn.Name = "CmdAddBtn";
            this.CmdAddBtn.Size = new System.Drawing.Size(75, 23);
            this.CmdAddBtn.TabIndex = 4;
            this.CmdAddBtn.Text = "추가";
            this.CmdAddBtn.UseVisualStyleBackColor = true;
            this.CmdAddBtn.Click += new System.EventHandler(this.CmdAddBtn_Click);
            // 
            // CmdDeleteBtn
            // 
            this.CmdDeleteBtn.Location = new System.Drawing.Point(313, 132);
            this.CmdDeleteBtn.Name = "CmdDeleteBtn";
            this.CmdDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.CmdDeleteBtn.TabIndex = 5;
            this.CmdDeleteBtn.Text = "삭제";
            this.CmdDeleteBtn.UseVisualStyleBackColor = true;
            this.CmdDeleteBtn.Click += new System.EventHandler(this.CmdDeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(80, 396);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "저장";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtnClick);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(185, 396);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "취소";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtnClick);
            // 
            // CmdSelector
            // 
            this.CmdSelector.FormattingEnabled = true;
            this.CmdSelector.Location = new System.Drawing.Point(19, 132);
            this.CmdSelector.Name = "CmdSelector";
            this.CmdSelector.Size = new System.Drawing.Size(113, 20);
            this.CmdSelector.TabIndex = 8;
            // 
            // CmdAmount
            // 
            this.CmdAmount.Location = new System.Drawing.Point(138, 131);
            this.CmdAmount.Name = "CmdAmount";
            this.CmdAmount.Size = new System.Drawing.Size(47, 21);
            this.CmdAmount.TabIndex = 9;
            this.CmdAmount.Text = "1";
            // 
            // MonsterIdInput
            // 
            this.MonsterIdInput.Location = new System.Drawing.Point(205, 23);
            this.MonsterIdInput.MaxLength = 10;
            this.MonsterIdInput.Name = "MonsterIdInput";
            this.MonsterIdInput.Size = new System.Drawing.Size(143, 21);
            this.MonsterIdInput.TabIndex = 10;
            // 
            // MonsterTypeSelector
            // 
            this.MonsterTypeSelector.FormattingEnabled = true;
            this.MonsterTypeSelector.Location = new System.Drawing.Point(228, 51);
            this.MonsterTypeSelector.Name = "MonsterTypeSelector";
            this.MonsterTypeSelector.Size = new System.Drawing.Size(121, 20);
            this.MonsterTypeSelector.TabIndex = 11;
            this.MonsterTypeSelector.SelectedIndexChanged += new System.EventHandler(this.MonsterTypeSelector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(133, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "X: ";
            // 
            // InitXPos
            // 
            this.InitXPos.Location = new System.Drawing.Point(157, 83);
            this.InitXPos.Name = "InitXPos";
            this.InitXPos.Size = new System.Drawing.Size(41, 21);
            this.InitXPos.TabIndex = 13;
            this.InitXPos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(210, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Y: ";
            // 
            // InitYPos
            // 
            this.InitYPos.Location = new System.Drawing.Point(231, 83);
            this.InitYPos.Name = "InitYPos";
            this.InitYPos.Size = new System.Drawing.Size(41, 21);
            this.InitYPos.TabIndex = 15;
            this.InitYPos.Text = "0";
            // 
            // MonsterEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 435);
            this.Controls.Add(this.InitYPos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InitXPos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MonsterTypeSelector);
            this.Controls.Add(this.MonsterIdInput);
            this.Controls.Add(this.CmdAmount);
            this.Controls.Add(this.CmdSelector);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CmdDeleteBtn);
            this.Controls.Add(this.CmdAddBtn);
            this.Controls.Add(this.CommandList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monster_id_label);
            this.Controls.Add(this.MonsterPic);
            this.Name = "MonsterEditWindow";
            this.Text = "MonsterEditWindow";
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MonsterPic;
        private System.Windows.Forms.Label monster_id_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CommandList;
        private System.Windows.Forms.Button CmdAddBtn;
        private System.Windows.Forms.Button CmdDeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ComboBox CmdSelector;
        private System.Windows.Forms.TextBox CmdAmount;
        public System.Windows.Forms.TextBox MonsterIdInput;
        public System.Windows.Forms.ComboBox MonsterTypeSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox InitXPos;
        public System.Windows.Forms.TextBox InitYPos;
    }
}