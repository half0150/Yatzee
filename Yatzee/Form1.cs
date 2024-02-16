namespace Yatzee
{
    public partial class Form1 : Form
    {

        private YatzeeScoreCard player1;
        private YatzeeScoreCard player2;
        private YatzeeScoreCard currentPlayer;
        private YatzeeDice dice;
        public Form1()
        {
            InitializeComponent();
            newGame();
        }

        private void newDice()
        {
            dice = new YatzeeDice();

            die1Label.Text = "";
            die2Label.Text = "";
            die3Label.Text = "";
            die4Label.Text = "";
            die5Label.Text = "";

            holdDie1Checkbox.Checked = false;
            holdDie2Checkbox.Checked = false;
            holdDie3Checkbox.Checked = false;
            holdDie4Checkbox.Checked = false;
            holdDie5Checkbox.Checked = false;

            score1sButton.Enabled = false;
            score2sButton.Enabled = false;
        }

        private void UpdateLabels()
        {
            currentPlayerLabel.Text = $"Current Player: " + (currentPlayer == player1 ? "Player 1" : "Player 2");

            rollsRemainingLabel.Text = (3 - dice.NumberOfTimesRolled).ToString();

            YatzeeScoreCard possibleScores = dice.GetPossibleScores();

            if (currentPlayer.OnesScore == null)
            {
                onesScoreLabel.Text = possibleScores.OnesScore.ToString();
            }
            if (currentPlayer.TwosScore == null)
            {
                twosScoreLabel.Text = possibleScores.TwosScore.ToString();
            }

            score1sButton.Enabled = currentPlayer.OnesScore == null;
            score2sButton.Enabled = currentPlayer.TwosScore == null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dice.Roll();

            die1Label.Text = dice.Die1Value.ToString();
            die2Label.Text = dice.Die2Value.ToString();
            die3Label.Text = dice.Die3Value.ToString();
            die4Label.Text = dice.Die4Value.ToString();
            die5Label.Text = dice.Die5Value.ToString();

            UpdateLabels();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void holdDie1Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            dice.HoldDie1 = holdDie1Checkbox.Checked;
        }

        private void holdDie2Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            dice.HoldDie2 = holdDie2Checkbox.Checked;
        }

        private void holdDie3Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            dice.HoldDie3 = holdDie3Checkbox.Checked;
        }

        private void holdDie4Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            dice.HoldDie4 = holdDie4Checkbox.Checked;
        }

        private void holdDie5Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            dice.HoldDie5 = holdDie5Checkbox.Checked;
        }

        private void score1sButton_Click(object sender, EventArgs e)
        {
            currentPlayer.OnesScore = dice.GetPossibleScores().OnesScore;

            nextPlayer();
        }

        private void nextPlayer()
        {
            //currentPlayer = currentPlayer == player1 ? player2 : player1;
            if (currentPlayer == player1)
            {
                currentPlayer = player2;
            }
            else
            {
                currentPlayer = player1;
            }



            onesScoreLabel.Text = currentPlayer.OnesScore == null ? "" : currentPlayer.OnesScore.ToString();
            twosScoreLabel.Text = currentPlayer.TwosScore == null ? "" : currentPlayer.TwosScore.ToString();


            newDice();
            UpdateLabels();
        }

        private void score2sButton_Click(object sender, EventArgs e)
        {
            currentPlayer.TwosScore = dice.GetPossibleScores().TwosScore;
            nextPlayer();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void newGame()
        {
            player1 = new YatzeeScoreCard();
            player2 = new YatzeeScoreCard();
            currentPlayer = player1;
            newDice();
            UpdateLabels();


            score1sButton.Enabled = false;
            score2sButton.Enabled = false;
        }
    }
}
