using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolkoikrzyzyk
{
    enum CurrentPlayer
    {
        cross,
        circle,
    }
    public partial class Form1 : Form
    {
        CurrentPlayer currentPlayer;
        public Form1()
        {
            InitializeComponent();
            currentPlayer = CurrentPlayer.cross;
            changeLabel();
        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderbutton = (Button)sender;
            if (currentPlayer == CurrentPlayer.cross)
            {
                senderbutton.Text = "X";
                currentPlayer = CurrentPlayer.circle;

            }
            else
            {
                senderbutton.Text = "O";
                currentPlayer = CurrentPlayer.cross;
            }
            checkForWinner();
            changeLabel();

            

        }
        public void changeLabel()
        {
            if (currentPlayer == CurrentPlayer.circle)
            {
                currentPlayerLabel.Text = "Kółko";
            }
            else
            {
                currentPlayerLabel.Text = "Krzyżyk";
            }
        }
        public void checkForWinner()
        {
            if ((tl.Text == tc.Text) && (tc.Text == tr.Text) && tl.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();
            }
            else if ((cl.Text == cc.Text) && (cc.Text == cr.Text) && cl.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = cl.Text;
                victoryScreen.Show();
            }
            else if ((bl.Text == bc.Text) && (bc.Text == br.Text) && bl.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = bl.Text;
                victoryScreen.Show();
            }

            if ((tl.Text == cl.Text) && (cl.Text == bl.Text) && tl.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();
            }
            else if ((tc.Text == cc.Text) && (cc.Text == bc.Text) && tc.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tc.Text;
                victoryScreen.Show();
            }
            else if ((tr.Text == br.Text) && (br.Text == cr.Text) && tr.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tr.Text;
                victoryScreen.Show();
            }

            if ((tl.Text == cc.Text) && (cc.Text == br.Text) && tl.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();
            }
            else if ((tr.Text == cc.Text) && (cc.Text == bl.Text) && tr.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tr.Text;
                victoryScreen.Show();
            }
        }
        

            
        public void clearBoard()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;

            for(int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i] is Button)
                    buttons[i].Text = "";
            }

            currentPlayer = CurrentPlayer.cross;

        }
    }
}
