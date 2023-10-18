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

    public partial class JocMoara_Game : Form
    {
        PlayersRegister reg;
        Game x;
        Mill m = new MillMoves();
        public JocMoara_Game(Form f)
        {
            InitializeComponent();
            x = new Game();
            reg = (PlayersRegister)f;
            afisareAvatar();
            p1Name.Text = reg.textBoxPlayer1.Text;
            p2Name.Text = reg.textBoxPlayer2.Text;
            p1PiecesNr.Text = m.p1Pieces.ToString();
            p2PiecesNr.Text = m.p2Pieces.ToString();
            textBoxIndication.Text = m.indicationText;
            if (textBoxIndication.Text == "Rosu incepe")
                textBoxIndication.ForeColor = Color.Red;
            else
                textBoxIndication.ForeColor = Color.Blue;


        }
        public void afisareAvatar()
        {
            if (reg.M1 == true)

                player1MIcon.BringToFront();

            if (reg.M2 == true)

                player2MIcon.BringToFront();


        }


        private void JocMoara_Game_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitGameDialog exit = new ExitGameDialog();
            if (exit.ShowDialog() == DialogResult.OK)
                Environment.Exit(0);

        }


        private void render() //da updateuri pentru tabla de joc,mutari etc
        {
            turnBlackBoard();
            p1PiecesNr.Text = m.p1Pieces.ToString();
            p2PiecesNr.Text = m.p2Pieces.ToString();
            textBoxIndication.Text = m.indicationText;
            if (m.isPlaceDone == 1)
            {
                textBox1.Text = "Piese ramase";
                p1PiecesNr.Text = m.inGameP1Pieces.ToString();
                p2PiecesNr.Text = m.inGameP2Pieces.ToString();
            }
            if (textBoxIndication.Text == "Randul jucatorului rosu !" || textBoxIndication.Text == "MOARA ROSIE ! Alege o piesa albastra pe care sa o scoti!" || textBoxIndication.Text == "Jucatorul rosu muta o piesa !" || textBoxIndication.Text == "Jucatorul rosu va incepe jocul !" || textBoxIndication.Text == "Jucatorul rosu va incepe jocul !")
                textBoxIndication.ForeColor = Color.Red;
            else
                textBoxIndication.ForeColor = Color.Blue;
            if (m.gameStatus() == true)
            {
                GameOver gameOver = new GameOver();
                if (m.inGameP1Pieces == 2)
                    gameOver.textGameOver.Text = p2Name.Text + " a castigat ! Felicitari !";
                else
                    gameOver.textGameOver.Text = p1Name.Text + " a castigat ! Felicitari !";
                gameOver.Show();
            }


        }

        private void turnBlackBoard()
        {
            foreach (Control control in this.Controls)
            {
                if (control is WindowsFormsApplication1.RoundButton)
                {
                    WindowsFormsApplication1.RoundButton button = (WindowsFormsApplication1.RoundButton)control;

                    {
                        if (m.ok == 1)
                            if (button.BackColor == System.Drawing.Color.LightGreen)
                            {
                                button.BackColor = System.Drawing.Color.Black;

                            }

                    }

                }

            }
            m.ok = 0;

        }

        /*   private void verificare_Click(object sender, EventArgs e)
           {

           }*/
        private void btn1A_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {
                m.deletePiece(6, 0, btn1A);
                render();
            }
            else
            {
                m.place(6, 0, btn1A);
                m.verifyPos(3, 0, btn4A);
                m.verifyPos(6, 3, btn1D);
                m.deleteCurrentPosition(6, 0, btn1A);
                m.movePiece(6, 0, btn1A);
                render();
            }


        }
        private void btn1D_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {
                m.deletePiece(6, 3, btn1D);
                render();
            }
            else
            {
                m.place(6, 3, btn1D);
                m.verifyPos(6, 0, btn1A);
                m.verifyPos(6, 6, btn1G);
                m.verifyPos(5, 3, btn2D);
                m.deleteCurrentPosition(6, 3, btn1D);
                m.movePiece(6, 3, btn1D);
                render();
            }
        }

        private void btn1G_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {

                m.deletePiece(6, 6, btn1G);
                render();
            }
            else
            {
                m.place(6, 6, btn1G);
                m.verifyPos(6, 3, btn1D);
                m.verifyPos(3, 6, btn4G);
                m.deleteCurrentPosition(6, 6, btn1G);
                m.movePiece(6, 6, btn1G);
                render();
            }

        }

        private void btn2B_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {
   
                m.deletePiece(5, 1, btn2B);
                render();
            }
            else
            {
                m.place(5, 1, btn2B);
                m.verifyPos(3, 1, btn4B);
                m.verifyPos(5, 3, btn2D);
                m.deleteCurrentPosition(5, 1, btn2B); 
                m.movePiece(5, 1, btn2B);
                render();
            }
        }

        private void btn2D_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {

                m.deletePiece(5, 3, btn2D);
                render();
            }
            else
            {
                m.place(5, 3, btn2D);
                m.verifyPos(4, 3, btn3D);
                m.verifyPos(5, 1, btn2B);
                m.verifyPos(5, 5, btn2F);
                m.verifyPos(6, 3, btn1D);
                m.deleteCurrentPosition(5, 3, btn2D);
                m.movePiece(5, 3, btn2D);
                render();
            }
        }

        private void btn2F_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {
   
                m.deletePiece(5, 5, btn2F);
                render();
            }
            else
            {
                m.place(5, 5, btn2F);
                m.verifyPos(3, 5, btn4F);
                m.verifyPos(5, 3, btn2D);
                m.deleteCurrentPosition(5, 5, btn2F);
                m.movePiece(5, 5, btn2F);
                render();
            }
        }

        private void btn3C_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {

                m.deletePiece(4, 2, btn3C);
                render();
            }
            else
            {
                m.place(4, 2, btn3C);
                m.verifyPos(3, 2, btn4C);
                m.verifyPos(4, 3, btn3D);
                m.deleteCurrentPosition(4, 2, btn3C);
                m.movePiece(4, 2, btn3C);
                render();
            }
        }

        private void btn3D_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {

                m.deletePiece(4, 3, btn3D);
                render();
            }
            else
            {
                m.place(4, 3, btn3D);
                m.verifyPos(4, 2, btn3C);
                m.verifyPos(4, 4, btn3E);
                m.verifyPos(5, 3, btn2D);
                 m.deleteCurrentPosition(4, 3, btn3D);
                m.movePiece(4, 3, btn3D);
                render();
            }
        }

        private void btn3E_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {

                m.deletePiece(4, 4, btn3E);
                render();
            }
            else
            {
                m.place(4, 4, btn3E);
                m.verifyPos(3, 4, btn4E);
                m.verifyPos(4, 3, btn3D);
                m.deleteCurrentPosition(4, 4, btn3E);
                m.movePiece(4, 4, btn3E);
                render();
            }
        }

        private void btn4A_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {
    
                m.deletePiece(3, 0, btn4A);
                render();
            }
            else
            {
                m.place(3, 0, btn4A);
                m.verifyPos(0, 0, btn7A);
                m.verifyPos(3, 1, btn4B);
                m.verifyPos(6, 0, btn1A);
                m.deleteCurrentPosition(3, 0, btn4A);
                m.movePiece(3, 0, btn4A);
                render();
            }
        }

        private void btn4B_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {

                m.deletePiece(3, 1, btn4B);
                render();
            }
            else
            {
                m.place(3, 1, btn4B);
                m.verifyPos(1, 1, btn6B);
                m.verifyPos(3, 0, btn4A);
                m.verifyPos(3, 2, btn4C);
                m.verifyPos(5, 1, btn2B);
                 m.deleteCurrentPosition(3, 1, btn4B);
                m.movePiece(3, 1, btn4B);
                render();
            }
        }

        private void btn4C_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {
       
                m.deletePiece(3, 2, btn4C);
                render();
            }
            else
            {
                m.place(3, 2, btn4C);
                m.verifyPos(2, 2, btn5C);
                m.verifyPos(3, 1, btn4B);
                m.verifyPos(4, 2, btn3C);
                m.deleteCurrentPosition(3, 2, btn4C);
                m.movePiece(3, 2, btn4C);
                render();
            }

        }

        private void btn4E_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {
   
                m.deletePiece(3, 4, btn4E);
                render();
            }
            else
            {
                m.place(3, 4, btn4E);
                m.verifyPos(2, 4, btn5E);
                m.verifyPos(3, 5, btn4F);
                m.verifyPos(4, 4, btn3E);
                m.deleteCurrentPosition(3, 4, btn4E);
                m.movePiece(3, 4, btn4E);
                render();
            }
        }

        private void btn4F_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {
 
                m.deletePiece(3, 5, btn4F);
                render();
            }
            else
            {
                m.place(3, 5, btn4F);
                m.verifyPos(1, 5, btn6F);
                m.verifyPos(3, 4, btn4E);
                m.verifyPos(3, 6, btn4G);
                m.verifyPos(5, 5, btn2F);
                m.deleteCurrentPosition(3, 5, btn4F);
                m.movePiece(3, 5, btn4F);
                render();
            }
        }

        private void btn4G_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {
  
                m.deletePiece(3, 6, btn4G);
                render();
            }
            else
            {
                m.place(3, 6, btn4G);
                m.verifyPos(0, 6, btn7G);
                m.verifyPos(3, 5, btn4F);
                m.verifyPos(6, 6, btn1G);
                 m.deleteCurrentPosition(3, 6, btn4G);
                m.movePiece(3, 6, btn4G);
                render();
            }
        }

        private void btn5C_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {
 
                m.deletePiece(2, 2, btn5C);
                render();
            }
            else
            {
                m.place(2, 2, btn5C);
                m.verifyPos(2, 3, btn5D);
                m.verifyPos(3, 2, btn4C);
                m.deleteCurrentPosition(2, 2, btn5C);
                m.movePiece(2, 2, btn5C);
                render();

            }
        }

        private void btn5D_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {
 
                m.deletePiece(2, 3, btn5D);
                render();
            }
            else
            {
                m.place(2, 3, btn5D);
                m.verifyPos(1, 3, btn6D);
                m.verifyPos(2, 2, btn5C);
                m.verifyPos(2, 4, btn5E);
                 m.deleteCurrentPosition(2, 3, btn5D);
                m.movePiece(2, 3, btn5D);
                render();
            }
        }

        private void btn5E_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {
   
                m.deletePiece(2, 4, btn5E);
                render();
            }
            else
            {
                m.place(2, 4, btn5E);
                m.verifyPos(2, 3, btn5D);
                m.verifyPos(3, 4, btn4E);
                 m.deleteCurrentPosition(2, 4, btn5E);
                m.movePiece(2, 4, btn5E);
                render();
            }
        }

        private void btn6B_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {

                m.deletePiece(1, 1, btn6B);
                render();
            }
            else
            {
                m.place(1, 1, btn6B);
                m.verifyPos(1, 3, btn6D);
                m.verifyPos(3, 1, btn4B);
                m.deleteCurrentPosition(1, 1, btn6B);
                m.movePiece(1, 1, btn6B);
                render();
            }
        }

        private void btn6D_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {

                m.deletePiece(1, 3, btn6D);
                render();
            }
            else
            {
                m.place(1, 3, btn6D);
                m.verifyPos(0, 3, btn7D);
                m.verifyPos(1, 1, btn6B);
                m.verifyPos(1, 5, btn6F);
                m.verifyPos(2, 3, btn5D);
                m.deleteCurrentPosition(1, 3, btn6D); 
                m.movePiece(1, 3, btn6D);
                render();
            }
        }

        private void btn6F_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {

                m.deletePiece(1, 5, btn6F);
                render();
            }
            else
            {
                m.place(1, 5, btn6F);
                m.verifyPos(1, 3, btn6D);
                m.verifyPos(3, 5, btn4F);
                m.deleteCurrentPosition(1, 5, btn6F);
                m.movePiece(1, 5, btn6F);
                render();
            }
        }

        private void btn7A_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {
  
                m.deletePiece(0, 0, btn7A);
                render();
            }
            else
            {
                m.place(0, 0, btn7A);
                m.verifyPos(0, 3, btn7D);
                m.verifyPos(3, 0, btn4A);
                m.deleteCurrentPosition(0, 0, btn7A);  
                m.movePiece(0, 0, btn7A);
                render();
            }
        }

        private void btn7D_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {

                m.deletePiece(0, 3, btn7D);
                render();
            }
            else
            {
                m.place(0, 3, btn7D);
                m.verifyPos(0, 0, btn7A);
                m.verifyPos(0, 6, btn7G);
                m.verifyPos(1, 3, btn6D);
                 m.deleteCurrentPosition(0, 3, btn7D); 
                m.movePiece(0, 3, btn7D);
                render();
            }
        }

        private void btn7G_Click(object sender, EventArgs e)
        {
            if (m.delPiece == true)
            {

                m.deletePiece(0, 6, btn7G);
                render();
            }
            else
            {
                m.place(0, 6, btn7G);
                m.verifyPos(0, 3, btn7D);
                m.verifyPos(3, 6, btn4G);
                m.deleteCurrentPosition(0, 6, btn7G);         
                m.movePiece(0, 6, btn7G);
                render();
            }
        }
    }
}




