
namespace JocMoara
{
    partial class PlayersRegister
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
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.Player1Male = new System.Windows.Forms.CheckBox();
            this.Player1Female = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.Player2Male = new System.Windows.Forms.CheckBox();
            this.Player2Female = new System.Windows.Forms.CheckBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1 name :";
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(184, 51);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(141, 22);
            this.textBoxPlayer1.TabIndex = 1;
            // 
            // Player1Male
            // 
            this.Player1Male.AutoSize = true;
            this.Player1Male.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Male.Location = new System.Drawing.Point(49, 93);
            this.Player1Male.Name = "Player1Male";
            this.Player1Male.Size = new System.Drawing.Size(65, 25);
            this.Player1Male.TabIndex = 2;
            this.Player1Male.Text = "Male";
            this.Player1Male.UseVisualStyleBackColor = true;
            this.Player1Male.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Player1Male_MouseClick);
            // 
            // Player1Female
            // 
            this.Player1Female.AutoSize = true;
            this.Player1Female.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Female.Location = new System.Drawing.Point(184, 93);
            this.Player1Female.Name = "Player1Female";
            this.Player1Female.Size = new System.Drawing.Size(81, 25);
            this.Player1Female.TabIndex = 3;
            this.Player1Female.Text = "Female";
            this.Player1Female.UseVisualStyleBackColor = true;
            this.Player1Female.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Player1Female_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player 2 name :";
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Location = new System.Drawing.Point(184, 173);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(141, 22);
            this.textBoxPlayer2.TabIndex = 5;
            // 
            // Player2Male
            // 
            this.Player2Male.AutoSize = true;
            this.Player2Male.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Male.Location = new System.Drawing.Point(49, 235);
            this.Player2Male.Name = "Player2Male";
            this.Player2Male.Size = new System.Drawing.Size(65, 25);
            this.Player2Male.TabIndex = 6;
            this.Player2Male.Text = "Male";
            this.Player2Male.UseVisualStyleBackColor = true;
            this.Player2Male.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Player2Male_MouseClick);
            // 
            // Player2Female
            // 
            this.Player2Female.AutoSize = true;
            this.Player2Female.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Female.Location = new System.Drawing.Point(184, 235);
            this.Player2Female.Name = "Player2Female";
            this.Player2Female.Size = new System.Drawing.Size(81, 25);
            this.Player2Female.TabIndex = 7;
            this.Player2Female.Text = "Female";
            this.Player2Female.UseVisualStyleBackColor = true;
            this.Player2Female.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Player2Female_MouseClick);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(107, 311);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(121, 47);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "PLAY !";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(107, 398);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(121, 45);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReturn_MouseClick);
            // 
            // PlayersRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 503);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.Player2Female);
            this.Controls.Add(this.Player2Male);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Player1Female);
            this.Controls.Add(this.Player1Male);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayersRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewGame";
            this.Load += new System.EventHandler(this.PlayersRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Player1Male;
        private System.Windows.Forms.CheckBox Player1Female;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Player2Male;
        private System.Windows.Forms.CheckBox Player2Female;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnReturn;
        public System.Windows.Forms.TextBox textBoxPlayer1;
        public System.Windows.Forms.TextBox textBoxPlayer2;
    }
}