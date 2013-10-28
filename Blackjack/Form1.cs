// Simple blackjack game

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        User user = new User();
        Dealer dealer = new Dealer();
        Game game = new Game();

        int[] dollarAmounts = { 1, 5, 10, 20, 50, 100 };

        Button[] AddButtons = new Button[6];
        Button[] RemoveButtons = new Button[6];

        public Form1()
        {
            InitializeComponent();
            UpdatePlayerStats();

            for (int i = 0; i < 6; i++)
            {
                AddButtons[i] = new Button();
                AddButtons[i].SetBounds(6 + 42 * i, 19, 42, 23);
                AddButtons[i].Text = "$" + dollarAmounts[i].ToString();
                AddButtons[i].Click += new EventHandler(this.AddButton_Click);

                RemoveButtons[i] = new Button();
                RemoveButtons[i].SetBounds(6 + 42 * i, 19, 42, 23);
                RemoveButtons[i].Text = "$" + dollarAmounts[i].ToString();
                RemoveButtons[i].Click += new EventHandler(this.RemoveButton_Click);
            }

            for (int i = 0; i < 6; ++i)
            {
                AddBetGroupBox.Controls.Add(AddButtons[i]);
                RemoveBetGroupBox.Controls.Add(RemoveButtons[i]);
            }

            AddButtons[0].Focus();
            HitButton.Enabled = false;
            StandButton.Enabled = false;
            DealButton.Enabled = false;
        }

        void AddButton_Click(object sender, EventArgs e)
        {
            int buttonAddAmount = GetButtonAmount(sender);
            AddBet(buttonAddAmount);
            UpdateBetButtons();
        }

        void RemoveButton_Click(object sender, EventArgs e)
        {
            int buttonRemoveAmount = GetButtonAmount(sender);
            AddBet(-buttonRemoveAmount);
            UpdateBetButtons();
        }

        int GetButtonAmount(object button)
        {
            string temp = ((Button)button).Text.Remove(0, 1);
            int buttonAddAmount = int.Parse(temp);
            return buttonAddAmount;
        }

        void AddBet(int amount)
        {
            user.CurrentBet += amount;
            user.Bankroll -= amount;
            UpdateForm();
        }

        void UpdateBetButtons()
        {
            if (user.Bankroll > 0)
            {
                AddBetGroupBox.Enabled = true;
                for (int i = 0; i < 6; ++i)
                {
                    if (dollarAmounts[i] > user.Bankroll) { AddButtons[i].Enabled = false; }
                    else { AddButtons[i].Enabled = true; }
                }
            }
            else { AddBetGroupBox.Enabled = false; }

            if (user.CurrentBet > 0)
            {
                RemoveBetGroupBox.Enabled = true;
                for (int i = 0; i < 6; ++i)
                {
                    if (dollarAmounts[i] > user.CurrentBet) { RemoveButtons[i].Enabled = false; }
                    else { RemoveButtons[i].Enabled = true; }
                }
            }
            else { RemoveBetGroupBox.Enabled = false; }
        }

        void UpdatePlayerStats()
        {
            CurrentBetTextBox.Text = "$" + user.CurrentBet.ToString();
            BankrollTextBox.Text = "$" + user.Bankroll.ToString();
        }

        void UpdateUserHandTextBoxes()
        {
            PlayerHandTextBox.Clear();
            PlayerHandTextBox.Lines = user.getHandString();
        }

        void RevealDealerHand()
        {
            DealerHandTextBox.Lines = dealer.getHandString();
        }

        void UpdateDealButton()
        {
            if (user.CurrentBet > 0)
                DealButton.Enabled = true;
            else
                DealButton.Enabled = false;
        }

        void UpdateForm()
        {
            UpdatePlayerStats();
            UpdateBetButtons();
            UpdateDealButton();
        }

        void ResetForm()
        {
            PlayerHandTextBox.Clear();
            DealerHandTextBox.Clear();
            HitButton.Enabled = false;
            StandButton.Enabled = false;
            DealButton.Enabled = true;
            UpdateBetButtons();
            UpdatePlayerStats();
            UpdateDealButton();
            AddButtons[0].Focus();
        }

        void ResetGame()
        {
            user.Bankroll = 500;
            user.CurrentBet = 0;
            UpdatePlayerStats();
            UpdateBetButtons();
            UpdateDealButton();

            HitButton.Enabled = false;
            StandButton.Enabled = false;
        }

        private void NewGameMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            game.Hit(user);
            PlayerHandTextBox.Lines = user.getHandString();

            if (user.IsBust())
            {
                MessageBox.Show("Hand total is " + user.getHandValue() + ".", "BUST!");
                user.CurrentBet = 0;
                ResetForm();
            }

        }

        private void DealButton_Click(object sender, EventArgs e)
        {
            AddBetGroupBox.Enabled = false;
            RemoveBetGroupBox.Enabled = false;
            DealButton.Enabled = false;
            HitButton.Enabled = true;
            StandButton.Enabled = true;
            game.Restart(user, dealer);
            UpdateUserHandTextBoxes();
            DealerHandTextBox.Text = dealer.getHandString()[0];

            if (user.HasBlackJack() && !dealer.HasBlackJack())
            {
                RevealDealerHand();
                MessageBox.Show("You win!", "Blackjack");
                game.Payout(user);
            }
            else if (user.HasBlackJack() && !dealer.HasBlackJack())
            {
                RevealDealerHand();
                MessageBox.Show("You both have blackjack.", "Draw");
            }
        }

        private void StandButton_Click(object sender, EventArgs e)
        {
            game.DealersTurn(dealer, user);
            RevealDealerHand();

            if (dealer.IsBust())
            {
                MessageBox.Show("Dealer Busted.", "You Win!");
                game.Payout(user);
            }
            else if (dealer.getHandValue() < user.getHandValue())
            {
                MessageBox.Show("Your hand: " + user.getHandValue() + "\n"
                    + "Dealer's hand: " + dealer.getHandValue(), "You win!");
                game.Payout(user);
            }
            else if (dealer.getHandValue() == user.getHandValue())
            {
                MessageBox.Show("Draw", "Draw");
                user.Bankroll += user.CurrentBet;
                user.CurrentBet = 0;
            }
            else
            {
                MessageBox.Show("You lose :(", "You lose");
                user.CurrentBet = 0;
            }
            ResetForm();
        }
    }
}
