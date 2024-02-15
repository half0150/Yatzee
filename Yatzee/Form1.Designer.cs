namespace Yatzee
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
            rollButton = new Button();
            die1Label = new Label();
            die2Label = new Label();
            die3Label = new Label();
            die4Label = new Label();
            die5Label = new Label();
            holdDie1Checkbox = new CheckBox();
            holdDie2Checkbox = new CheckBox();
            holdDie3Checkbox = new CheckBox();
            holdDie4Checkbox = new CheckBox();
            holdDie5Checkbox = new CheckBox();
            score1sButton = new Button();
            score2sButton = new Button();
            onesScoreLabel = new Label();
            twosScoreLabel = new Label();
            rollsRemainingLabel = new Label();
            currentPlayerLabel = new Label();
            newGameButton = new Button();
            SuspendLayout();
            // 
            // rollButton
            // 
            rollButton.AccessibleName = "";
            rollButton.Location = new Point(158, 390);
            rollButton.Name = "rollButton";
            rollButton.Size = new Size(75, 23);
            rollButton.TabIndex = 0;
            rollButton.Text = "Roll";
            rollButton.UseVisualStyleBackColor = true;
            rollButton.Click += button1_Click;
            // 
            // die1Label
            // 
            die1Label.AutoSize = true;
            die1Label.Location = new Point(82, 326);
            die1Label.Name = "die1Label";
            die1Label.Size = new Size(38, 15);
            die1Label.TabIndex = 1;
            die1Label.Text = "label1";
            // 
            // die2Label
            // 
            die2Label.AutoSize = true;
            die2Label.Location = new Point(140, 326);
            die2Label.Name = "die2Label";
            die2Label.Size = new Size(38, 15);
            die2Label.TabIndex = 2;
            die2Label.Text = "label1";
            // 
            // die3Label
            // 
            die3Label.AutoSize = true;
            die3Label.Location = new Point(195, 326);
            die3Label.Name = "die3Label";
            die3Label.Size = new Size(38, 15);
            die3Label.TabIndex = 3;
            die3Label.Text = "label1";
            // 
            // die4Label
            // 
            die4Label.AutoSize = true;
            die4Label.Location = new Point(251, 326);
            die4Label.Name = "die4Label";
            die4Label.Size = new Size(38, 15);
            die4Label.TabIndex = 4;
            die4Label.Text = "label2";
            // 
            // die5Label
            // 
            die5Label.AutoSize = true;
            die5Label.Location = new Point(306, 326);
            die5Label.Name = "die5Label";
            die5Label.Size = new Size(38, 15);
            die5Label.TabIndex = 5;
            die5Label.Text = "label3";
            die5Label.Click += label3_Click;
            // 
            // holdDie1Checkbox
            // 
            holdDie1Checkbox.AutoSize = true;
            holdDie1Checkbox.Location = new Point(68, 356);
            holdDie1Checkbox.Name = "holdDie1Checkbox";
            holdDie1Checkbox.Size = new Size(52, 19);
            holdDie1Checkbox.TabIndex = 6;
            holdDie1Checkbox.Text = "Hold";
            holdDie1Checkbox.UseVisualStyleBackColor = true;
            holdDie1Checkbox.CheckedChanged += holdDie1Checkbox_CheckedChanged;
            // 
            // holdDie2Checkbox
            // 
            holdDie2Checkbox.AutoSize = true;
            holdDie2Checkbox.Location = new Point(126, 356);
            holdDie2Checkbox.Name = "holdDie2Checkbox";
            holdDie2Checkbox.Size = new Size(52, 19);
            holdDie2Checkbox.TabIndex = 7;
            holdDie2Checkbox.Text = "Hold";
            holdDie2Checkbox.UseVisualStyleBackColor = true;
            holdDie2Checkbox.CheckedChanged += holdDie2Checkbox_CheckedChanged;
            // 
            // holdDie3Checkbox
            // 
            holdDie3Checkbox.AutoSize = true;
            holdDie3Checkbox.Location = new Point(184, 356);
            holdDie3Checkbox.Name = "holdDie3Checkbox";
            holdDie3Checkbox.Size = new Size(52, 19);
            holdDie3Checkbox.TabIndex = 8;
            holdDie3Checkbox.Text = "Hold";
            holdDie3Checkbox.UseVisualStyleBackColor = true;
            holdDie3Checkbox.CheckedChanged += holdDie3Checkbox_CheckedChanged;
            // 
            // holdDie4Checkbox
            // 
            holdDie4Checkbox.AutoSize = true;
            holdDie4Checkbox.Location = new Point(242, 356);
            holdDie4Checkbox.Name = "holdDie4Checkbox";
            holdDie4Checkbox.Size = new Size(52, 19);
            holdDie4Checkbox.TabIndex = 9;
            holdDie4Checkbox.Text = "Hold";
            holdDie4Checkbox.UseVisualStyleBackColor = true;
            holdDie4Checkbox.CheckedChanged += holdDie4Checkbox_CheckedChanged;
            // 
            // holdDie5Checkbox
            // 
            holdDie5Checkbox.AutoSize = true;
            holdDie5Checkbox.Location = new Point(300, 356);
            holdDie5Checkbox.Name = "holdDie5Checkbox";
            holdDie5Checkbox.Size = new Size(52, 19);
            holdDie5Checkbox.TabIndex = 10;
            holdDie5Checkbox.Text = "Hold";
            holdDie5Checkbox.UseVisualStyleBackColor = true;
            holdDie5Checkbox.CheckedChanged += holdDie5Checkbox_CheckedChanged;
            // 
            // score1sButton
            // 
            score1sButton.Location = new Point(673, 72);
            score1sButton.Name = "score1sButton";
            score1sButton.Size = new Size(75, 23);
            score1sButton.TabIndex = 11;
            score1sButton.Text = "score 1s";
            score1sButton.UseVisualStyleBackColor = true;
            score1sButton.Click += score1sButton_Click;
            // 
            // score2sButton
            // 
            score2sButton.Location = new Point(673, 121);
            score2sButton.Name = "score2sButton";
            score2sButton.Size = new Size(75, 23);
            score2sButton.TabIndex = 12;
            score2sButton.Text = "score 2s";
            score2sButton.UseVisualStyleBackColor = true;
            score2sButton.Click += score2sButton_Click;
            // 
            // onesScoreLabel
            // 
            onesScoreLabel.AutoSize = true;
            onesScoreLabel.Location = new Point(796, 74);
            onesScoreLabel.Name = "onesScoreLabel";
            onesScoreLabel.Size = new Size(38, 15);
            onesScoreLabel.TabIndex = 13;
            onesScoreLabel.Text = "label1";
            // 
            // twosScoreLabel
            // 
            twosScoreLabel.AutoSize = true;
            twosScoreLabel.Location = new Point(796, 121);
            twosScoreLabel.Name = "twosScoreLabel";
            twosScoreLabel.Size = new Size(38, 15);
            twosScoreLabel.TabIndex = 14;
            twosScoreLabel.Text = "label1";
            // 
            // rollsRemainingLabel
            // 
            rollsRemainingLabel.AutoSize = true;
            rollsRemainingLabel.Location = new Point(271, 395);
            rollsRemainingLabel.Name = "rollsRemainingLabel";
            rollsRemainingLabel.Size = new Size(38, 15);
            rollsRemainingLabel.TabIndex = 15;
            rollsRemainingLabel.Text = "label1";
            // 
            // currentPlayerLabel
            // 
            currentPlayerLabel.AutoSize = true;
            currentPlayerLabel.Location = new Point(217, 97);
            currentPlayerLabel.Name = "currentPlayerLabel";
            currentPlayerLabel.Size = new Size(85, 15);
            currentPlayerLabel.TabIndex = 16;
            currentPlayerLabel.Text = "Current Player:";
            // 
            // newGameButton
            // 
            newGameButton.Location = new Point(914, 475);
            newGameButton.Name = "newGameButton";
            newGameButton.Size = new Size(75, 23);
            newGameButton.TabIndex = 17;
            newGameButton.Text = "New Game";
            newGameButton.UseVisualStyleBackColor = true;
            newGameButton.Click += newGameButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 543);
            Controls.Add(newGameButton);
            Controls.Add(currentPlayerLabel);
            Controls.Add(rollsRemainingLabel);
            Controls.Add(twosScoreLabel);
            Controls.Add(onesScoreLabel);
            Controls.Add(score2sButton);
            Controls.Add(score1sButton);
            Controls.Add(holdDie5Checkbox);
            Controls.Add(holdDie4Checkbox);
            Controls.Add(holdDie3Checkbox);
            Controls.Add(holdDie2Checkbox);
            Controls.Add(holdDie1Checkbox);
            Controls.Add(die5Label);
            Controls.Add(die4Label);
            Controls.Add(die3Label);
            Controls.Add(die2Label);
            Controls.Add(die1Label);
            Controls.Add(rollButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rollButton;
        private Label die1Label;
        private Label die2Label;
        private Label die3Label;
        private Label die4Label;
        private Label die5Label;
        private CheckBox holdDie1Checkbox;
        private CheckBox holdDie2Checkbox;
        private CheckBox holdDie3Checkbox;
        private CheckBox holdDie4Checkbox;
        private CheckBox holdDie5Checkbox;
        private Button score1sButton;
        private Button score2sButton;
        private Label onesScoreLabel;
        private Label twosScoreLabel;
        private Label rollsRemainingLabel;
        private Label currentPlayerLabel;
        private Button newGameButton;
    }
}
