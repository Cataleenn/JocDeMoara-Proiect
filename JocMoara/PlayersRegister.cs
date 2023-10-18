using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocMoara
{
    public partial class PlayersRegister : Form
    {
        Menu menu;
        public bool M1, M2,F1,F2;
        public string player1Name,player2Name;
          
       public PlayersRegister(Form f)
        {
            InitializeComponent();
            menu = (Menu)f;
            player1Name = textBoxPlayer1.Text;
            player2Name = textBoxPlayer2.Text;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            JocMoara_Game jocMoaraGame = new JocMoara_Game(this);
            jocMoaraGame.Show();
        }

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void PlayersRegister_Load(object sender, EventArgs e)
        {

        }

        private void Player1Male_MouseClick(object sender, MouseEventArgs e)
        {
             M1 = true;
            
        }

        private void Player1Female_MouseClick(object sender, MouseEventArgs e)
        {
             M1 = false;
             F1 = true;
        }

        private void Player2Male_MouseClick(object sender, MouseEventArgs e)
        {
            M2 = true;
           
        }

        private void Player2Female_MouseClick(object sender, MouseEventArgs e)
        {
            M2 = false;
           
        }
    }
}
