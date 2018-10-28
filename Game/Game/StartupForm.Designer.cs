namespace Game
{
    partial class StartupForm
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
            this.StartGame = new System.Windows.Forms.Button();
            this.JoinGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(553, 122);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(265, 83);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Start game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // JoinGame
            // 
            this.JoinGame.Location = new System.Drawing.Point(553, 239);
            this.JoinGame.Name = "JoinGame";
            this.JoinGame.Size = new System.Drawing.Size(265, 92);
            this.JoinGame.TabIndex = 1;
            this.JoinGame.Text = "Join game";
            this.JoinGame.UseVisualStyleBackColor = true;
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 481);
            this.Controls.Add(this.JoinGame);
            this.Controls.Add(this.StartGame);
            this.Name = "StartupForm";
            this.Text = "StartupForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button JoinGame;
    }
}