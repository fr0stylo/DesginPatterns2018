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
            this.StrongBaloon.Location = new System.Drawing.Point(600, 437);
            this.StrongBaloon.Name = "StrongBaloon";
            this.StrongBaloon.Size = new System.Drawing.Size(75, 34);
            this.StrongBaloon.TabIndex = 2;
            this.StrongBaloon.Text = "STRONG";
            this.StrongBaloon.UseVisualStyleBackColor = true;
            this.StrongBaloon.Click += new System.EventHandler(this.StrongBaloon_Click);
            // 
            // IntermediateBaloon
            // 
            this.IntermediateBaloon.Location = new System.Drawing.Point(491, 437);
            this.IntermediateBaloon.Name = "IntermediateBaloon";
            this.IntermediateBaloon.Size = new System.Drawing.Size(102, 34);
            this.IntermediateBaloon.TabIndex = 3;
            this.IntermediateBaloon.Text = "INTERMEDIATE";
            this.IntermediateBaloon.UseVisualStyleBackColor = true;
            this.IntermediateBaloon.Click += new System.EventHandler(this.IntermediateBaloon_Click);
            // 
            // WeakBaloon
            // 
            this.WeakBaloon.Location = new System.Drawing.Point(406, 437);
            this.WeakBaloon.Name = "WeakBaloon";
            this.WeakBaloon.Size = new System.Drawing.Size(79, 34);
            this.WeakBaloon.TabIndex = 4;
            this.WeakBaloon.Text = "WEAK";
            this.WeakBaloon.UseVisualStyleBackColor = true;
            this.WeakBaloon.Click += new System.EventHandler(this.WeakBaloon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.WeakBaloon);
            this.Controls.Add(this.IntermediateBaloon);
            this.Controls.Add(this.StrongBaloon);
            this.Controls.Add(this.PlayerName);
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
    }
}

