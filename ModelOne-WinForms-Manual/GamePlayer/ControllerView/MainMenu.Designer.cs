namespace ControllerView
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.Box2 = new System.Windows.Forms.PictureBox();
            this.Box1 = new System.Windows.Forms.PictureBox();
            this.btn_loadGame = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.levelSelector = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_startGame = new System.Windows.Forms.Button();
            this.levels = new System.Windows.Forms.ListBox();
            this.Heading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).BeginInit();
            this.levelSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(273, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sokoban";
            // 
            // btn_newGame
            // 
            this.btn_newGame.BackgroundImage = global::ControllerView.Properties.Resources.btn_back;
            this.btn_newGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_newGame.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newGame.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_newGame.Location = new System.Drawing.Point(289, 130);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(236, 47);
            this.btn_newGame.TabIndex = 3;
            this.btn_newGame.TabStop = false;
            this.btn_newGame.Text = "New Game";
            this.btn_newGame.UseVisualStyleBackColor = true;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // Box2
            // 
            this.Box2.Image = global::ControllerView.Properties.Resources.box;
            this.Box2.Location = new System.Drawing.Point(542, 12);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(70, 70);
            this.Box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box2.TabIndex = 1;
            this.Box2.TabStop = false;
            // 
            // Box1
            // 
            this.Box1.Image = global::ControllerView.Properties.Resources.box;
            this.Box1.Location = new System.Drawing.Point(193, 16);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(70, 70);
            this.Box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box1.TabIndex = 0;
            this.Box1.TabStop = false;
            // 
            // btn_loadGame
            // 
            this.btn_loadGame.BackgroundImage = global::ControllerView.Properties.Resources.btn_back;
            this.btn_loadGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_loadGame.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadGame.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_loadGame.Location = new System.Drawing.Point(289, 202);
            this.btn_loadGame.Name = "btn_loadGame";
            this.btn_loadGame.Size = new System.Drawing.Size(236, 47);
            this.btn_loadGame.TabIndex = 4;
            this.btn_loadGame.TabStop = false;
            this.btn_loadGame.Text = "Load Game";
            this.btn_loadGame.UseVisualStyleBackColor = true;
            this.btn_loadGame.Click += new System.EventHandler(this.btn_loadGame_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::ControllerView.Properties.Resources.btn_back;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_exit.Location = new System.Drawing.Point(289, 273);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(236, 47);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.TabStop = false;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // levelSelector
            // 
            this.levelSelector.Controls.Add(this.btn_cancel);
            this.levelSelector.Controls.Add(this.btn_startGame);
            this.levelSelector.Controls.Add(this.levels);
            this.levelSelector.Controls.Add(this.Heading);
            this.levelSelector.Location = new System.Drawing.Point(218, 109);
            this.levelSelector.Name = "levelSelector";
            this.levelSelector.Size = new System.Drawing.Size(381, 268);
            this.levelSelector.TabIndex = 6;
            this.levelSelector.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::ControllerView.Properties.Resources.btn_back;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_cancel.Location = new System.Drawing.Point(123, 190);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(128, 38);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_startGame
            // 
            this.btn_startGame.BackgroundImage = global::ControllerView.Properties.Resources.btn_back;
            this.btn_startGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_startGame.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startGame.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_startGame.Location = new System.Drawing.Point(123, 146);
            this.btn_startGame.Name = "btn_startGame";
            this.btn_startGame.Size = new System.Drawing.Size(128, 38);
            this.btn_startGame.TabIndex = 2;
            this.btn_startGame.Text = "Start Game";
            this.btn_startGame.UseVisualStyleBackColor = true;
            this.btn_startGame.Click += new System.EventHandler(this.btn_startGame_Click);
            // 
            // levels
            // 
            this.levels.AllowDrop = true;
            this.levels.BackColor = System.Drawing.Color.DarkKhaki;
            this.levels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.levels.CausesValidation = false;
            this.levels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.levels.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levels.ForeColor = System.Drawing.Color.Maroon;
            this.levels.FormattingEnabled = true;
            this.levels.ItemHeight = 31;
            this.levels.Items.AddRange(new object[] {
            "Level One ( 8 X 8 )",
            "Level Two ( 8 X 6 )"});
            this.levels.Location = new System.Drawing.Point(81, 59);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(222, 62);
            this.levels.TabIndex = 1;
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(94, 19);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(192, 23);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Select a Level";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.levelSelector);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_loadGame);
            this.Controls.Add(this.btn_newGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).EndInit();
            this.levelSelector.ResumeLayout(false);
            this.levelSelector.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Box1;
        private System.Windows.Forms.PictureBox Box2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_newGame;
        private System.Windows.Forms.Button btn_loadGame;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel levelSelector;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.ListBox levels;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_startGame;
    }
}