namespace Game
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayerName = new System.Windows.Forms.Label();
            this.StrongBaloon = new System.Windows.Forms.Button();
            this.IntermediateBaloon = new System.Windows.Forms.Button();
            this.WeakBaloon = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ArrowTower = new System.Windows.Forms.Button();
            this.PlayerMoney = new System.Windows.Forms.Label();
            this.WrapperExample = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Location = new System.Drawing.Point(12, 459);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(0, 13);
            this.PlayerName.TabIndex = 1;
            // 
            // StrongBaloon
            // 
            this.StrongBaloon.BackColor = System.Drawing.Color.Black;
            this.StrongBaloon.ForeColor = System.Drawing.Color.White;
            this.StrongBaloon.Location = new System.Drawing.Point(26, 390);
            this.StrongBaloon.Name = "StrongBaloon";
            this.StrongBaloon.Size = new System.Drawing.Size(60, 60);
            this.StrongBaloon.TabIndex = 2;
            this.StrongBaloon.Text = "STR";
            this.StrongBaloon.UseVisualStyleBackColor = false;
            this.StrongBaloon.Click += new System.EventHandler(this.StrongBaloon_Click);
            // 
            // IntermediateBaloon
            // 
            this.IntermediateBaloon.BackColor = System.Drawing.Color.Black;
            this.IntermediateBaloon.ForeColor = System.Drawing.Color.White;
            this.IntermediateBaloon.Location = new System.Drawing.Point(26, 324);
            this.IntermediateBaloon.Name = "IntermediateBaloon";
            this.IntermediateBaloon.Size = new System.Drawing.Size(60, 60);
            this.IntermediateBaloon.TabIndex = 3;
            this.IntermediateBaloon.Text = "INT";
            this.IntermediateBaloon.UseVisualStyleBackColor = false;
            this.IntermediateBaloon.Click += new System.EventHandler(this.IntermediateBaloon_Click);
            // 
            // WeakBaloon
            // 
            this.WeakBaloon.BackColor = System.Drawing.Color.Black;
            this.WeakBaloon.ForeColor = System.Drawing.Color.White;
            this.WeakBaloon.Location = new System.Drawing.Point(26, 258);
            this.WeakBaloon.Name = "WeakBaloon";
            this.WeakBaloon.Size = new System.Drawing.Size(60, 60);
            this.WeakBaloon.TabIndex = 4;
            this.WeakBaloon.Text = "WEAK";
            this.WeakBaloon.UseVisualStyleBackColor = false;
            this.WeakBaloon.Click += new System.EventHandler(this.WeakBaloon_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.TimeLabel.Location = new System.Drawing.Point(646, 456);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(60, 24);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "00:00";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 1;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // ArrowTower
            // 
            this.ArrowTower.BackColor = System.Drawing.Color.Black;
            this.ArrowTower.ForeColor = System.Drawing.Color.White;
            this.ArrowTower.Location = new System.Drawing.Point(92, 390);
            this.ArrowTower.Name = "ArrowTower";
            this.ArrowTower.Size = new System.Drawing.Size(60, 60);
            this.ArrowTower.TabIndex = 6;
            this.ArrowTower.Text = "ARRW";
            this.ArrowTower.UseVisualStyleBackColor = false;
            this.ArrowTower.Click += new System.EventHandler(this.ArrowTower_Click);
            // 
            // PlayerMoney
            // 
            this.PlayerMoney.AutoSize = true;
            this.PlayerMoney.BackColor = System.Drawing.Color.Black;
            this.PlayerMoney.ForeColor = System.Drawing.Color.White;
            this.PlayerMoney.Location = new System.Drawing.Point(92, 459);
            this.PlayerMoney.Name = "PlayerMoney";
            this.PlayerMoney.Size = new System.Drawing.Size(68, 13);
            this.PlayerMoney.TabIndex = 7;
            this.PlayerMoney.Text = "PlayerMoney";
            // 
            // WrapperExample
            // 
            this.WrapperExample.BackColor = System.Drawing.Color.Black;
            this.WrapperExample.Location = new System.Drawing.Point(171, 390);
            this.WrapperExample.Name = "WrapperExample";
            this.WrapperExample.Size = new System.Drawing.Size(78, 60);
            this.WrapperExample.TabIndex = 8;
            this.WrapperExample.Text = "Wrapper";
            this.WrapperExample.UseVisualStyleBackColor = false;
            this.WrapperExample.Click += new System.EventHandler(this.WrapperExample_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 481);
            this.Controls.Add(this.WrapperExample);
            this.Controls.Add(this.PlayerMoney);
            this.Controls.Add(this.ArrowTower);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.WeakBaloon);
            this.Controls.Add(this.IntermediateBaloon);
            this.Controls.Add(this.StrongBaloon);
            this.Controls.Add(this.PlayerName);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Button StrongBaloon;
        private System.Windows.Forms.Button IntermediateBaloon;
        private System.Windows.Forms.Button WeakBaloon;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button ArrowTower;
        private System.Windows.Forms.Label PlayerMoney;
        private System.Windows.Forms.Button WrapperExample;
    }
}

