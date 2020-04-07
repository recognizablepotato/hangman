namespace project2blauria
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
            this.grpPlayerTwo = new System.Windows.Forms.GroupBox();
            this.btnEnterLetter = new System.Windows.Forms.Button();
            this.lblGuessesRemaining = new System.Windows.Forms.Label();
            this.txtGuessesRemaining = new System.Windows.Forms.TextBox();
            this.lblWordToGuess = new System.Windows.Forms.Label();
            this.txtWordToGuess = new System.Windows.Forms.TextBox();
            this.lstYouGuessed = new System.Windows.Forms.ListBox();
            this.grpPlayerOne = new System.Windows.Forms.GroupBox();
            this.cboNumberOfGuesses = new System.Windows.Forms.ComboBox();
            this.btnEnterWordToGuess = new System.Windows.Forms.Button();
            this.txtEnterLetter = new System.Windows.Forms.TextBox();
            this.txtEnterWordToGuess = new System.Windows.Forms.TextBox();
            this.grpPlayerTwo.SuspendLayout();
            this.grpPlayerOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPlayerTwo
            // 
            this.grpPlayerTwo.Controls.Add(this.txtEnterLetter);
            this.grpPlayerTwo.Controls.Add(this.btnEnterLetter);
            this.grpPlayerTwo.Controls.Add(this.lblGuessesRemaining);
            this.grpPlayerTwo.Controls.Add(this.txtGuessesRemaining);
            this.grpPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlayerTwo.Location = new System.Drawing.Point(13, 13);
            this.grpPlayerTwo.Name = "grpPlayerTwo";
            this.grpPlayerTwo.Size = new System.Drawing.Size(452, 130);
            this.grpPlayerTwo.TabIndex = 0;
            this.grpPlayerTwo.TabStop = false;
            this.grpPlayerTwo.Text = "Player 2";
            // 
            // btnEnterLetter
            // 
            this.btnEnterLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterLetter.Location = new System.Drawing.Point(44, 80);
            this.btnEnterLetter.Name = "btnEnterLetter";
            this.btnEnterLetter.Size = new System.Drawing.Size(117, 33);
            this.btnEnterLetter.TabIndex = 3;
            this.btnEnterLetter.Text = "Enter Letter";
            this.btnEnterLetter.UseVisualStyleBackColor = true;
            this.btnEnterLetter.Click += new System.EventHandler(this.btnEnterLetter_Click);
            // 
            // lblGuessesRemaining
            // 
            this.lblGuessesRemaining.AutoSize = true;
            this.lblGuessesRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessesRemaining.Location = new System.Drawing.Point(240, 80);
            this.lblGuessesRemaining.Name = "lblGuessesRemaining";
            this.lblGuessesRemaining.Size = new System.Drawing.Size(153, 20);
            this.lblGuessesRemaining.TabIndex = 2;
            this.lblGuessesRemaining.Text = "Guesses Remaining";
            // 
            // txtGuessesRemaining
            // 
            this.txtGuessesRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuessesRemaining.Location = new System.Drawing.Point(290, 36);
            this.txtGuessesRemaining.Name = "txtGuessesRemaining";
            this.txtGuessesRemaining.Size = new System.Drawing.Size(50, 26);
            this.txtGuessesRemaining.TabIndex = 0;
            // 
            // lblWordToGuess
            // 
            this.lblWordToGuess.AutoSize = true;
            this.lblWordToGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordToGuess.Location = new System.Drawing.Point(153, 146);
            this.lblWordToGuess.Name = "lblWordToGuess";
            this.lblWordToGuess.Size = new System.Drawing.Size(140, 24);
            this.lblWordToGuess.TabIndex = 1;
            this.lblWordToGuess.Text = "Word to Guess!";
            // 
            // txtWordToGuess
            // 
            this.txtWordToGuess.Location = new System.Drawing.Point(57, 173);
            this.txtWordToGuess.Name = "txtWordToGuess";
            this.txtWordToGuess.Size = new System.Drawing.Size(335, 20);
            this.txtWordToGuess.TabIndex = 2;
            // 
            // lstYouGuessed
            // 
            this.lstYouGuessed.FormattingEnabled = true;
            this.lstYouGuessed.Location = new System.Drawing.Point(57, 212);
            this.lstYouGuessed.Name = "lstYouGuessed";
            this.lstYouGuessed.Size = new System.Drawing.Size(335, 121);
            this.lstYouGuessed.TabIndex = 3;
            // 
            // grpPlayerOne
            // 
            this.grpPlayerOne.Controls.Add(this.txtEnterWordToGuess);
            this.grpPlayerOne.Controls.Add(this.cboNumberOfGuesses);
            this.grpPlayerOne.Controls.Add(this.btnEnterWordToGuess);
            this.grpPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlayerOne.Location = new System.Drawing.Point(13, 351);
            this.grpPlayerOne.Name = "grpPlayerOne";
            this.grpPlayerOne.Size = new System.Drawing.Size(452, 122);
            this.grpPlayerOne.TabIndex = 4;
            this.grpPlayerOne.TabStop = false;
            this.grpPlayerOne.Text = "Player 1";
            // 
            // cboNumberOfGuesses
            // 
            this.cboNumberOfGuesses.AutoCompleteCustomSource.AddRange(new string[] {
            "3",
            "5",
            "10",
            "15"});
            this.cboNumberOfGuesses.FormattingEnabled = true;
            this.cboNumberOfGuesses.Items.AddRange(new object[] {
            "3",
            "5",
            "10",
            "15"});
            this.cboNumberOfGuesses.Location = new System.Drawing.Point(265, 37);
            this.cboNumberOfGuesses.Name = "cboNumberOfGuesses";
            this.cboNumberOfGuesses.Size = new System.Drawing.Size(168, 28);
            this.cboNumberOfGuesses.TabIndex = 2;
            this.cboNumberOfGuesses.Text = "Select # of Guesses";
            this.cboNumberOfGuesses.SelectedIndexChanged += new System.EventHandler(this.cboNumberOfGuesses_SelectedIndexChanged);
            // 
            // btnEnterWordToGuess
            // 
            this.btnEnterWordToGuess.Location = new System.Drawing.Point(44, 73);
            this.btnEnterWordToGuess.Name = "btnEnterWordToGuess";
            this.btnEnterWordToGuess.Size = new System.Drawing.Size(184, 38);
            this.btnEnterWordToGuess.TabIndex = 0;
            this.btnEnterWordToGuess.Text = "Enter Word To Guess";
            this.btnEnterWordToGuess.UseVisualStyleBackColor = true;
            this.btnEnterWordToGuess.Click += new System.EventHandler(this.btnEnterWordToGuess_Click);
            // 
            // txtEnterLetter
            // 
            this.txtEnterLetter.Location = new System.Drawing.Point(44, 36);
            this.txtEnterLetter.Name = "txtEnterLetter";
            this.txtEnterLetter.Size = new System.Drawing.Size(117, 26);
            this.txtEnterLetter.TabIndex = 4;
            // 
            // txtEnterWordToGuess
            // 
            this.txtEnterWordToGuess.Location = new System.Drawing.Point(44, 26);
            this.txtEnterWordToGuess.Name = "txtEnterWordToGuess";
            this.txtEnterWordToGuess.Size = new System.Drawing.Size(184, 26);
            this.txtEnterWordToGuess.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 485);
            this.Controls.Add(this.grpPlayerOne);
            this.Controls.Add(this.lstYouGuessed);
            this.Controls.Add(this.txtWordToGuess);
            this.Controls.Add(this.lblWordToGuess);
            this.Controls.Add(this.grpPlayerTwo);
            this.Name = "Form1";
            this.Text = "Guess the Word!";
            this.grpPlayerTwo.ResumeLayout(false);
            this.grpPlayerTwo.PerformLayout();
            this.grpPlayerOne.ResumeLayout(false);
            this.grpPlayerOne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlayerTwo;
        private System.Windows.Forms.Button btnEnterLetter;
        private System.Windows.Forms.Label lblGuessesRemaining;
        private System.Windows.Forms.TextBox txtGuessesRemaining;
        private System.Windows.Forms.Label lblWordToGuess;
        private System.Windows.Forms.TextBox txtWordToGuess;
        private System.Windows.Forms.ListBox lstYouGuessed;
        private System.Windows.Forms.GroupBox grpPlayerOne;
        private System.Windows.Forms.ComboBox cboNumberOfGuesses;
        private System.Windows.Forms.Button btnEnterWordToGuess;
        private System.Windows.Forms.TextBox txtEnterLetter;
        private System.Windows.Forms.TextBox txtEnterWordToGuess;
    }
}

