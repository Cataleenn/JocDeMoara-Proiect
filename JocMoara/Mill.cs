using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JocMoara
{
    class Mill : Game

    {
        public int p1Pieces = 9, p2Pieces = 9, inGameP1Pieces = 9, inGameP2Pieces = 9;
        public bool del = false, delPiece = false, isGameOver = false, movable = false;
        public int ok = 0, isPlaceDone = 0;      
        private int ctPosiblePosition = 0;
        public Mill() //constructor care initializeaza tabla de joc
        {
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 7; j++)
                {
                    board[i, j] = new Board();

                }
            firstturn();

        }

        public bool gameStatus()
        {
            if (inGameP1Pieces < 3 || inGameP2Pieces < 3)
            {
                return true;

            }
            return false;
        }

        public void verifyPos(int x, int y, WindowsFormsApplication1.RoundButton roundButton)
        {
            if (board[x, y].pos == 0 && isPlaceDone == 1 && movable == false)
            {

                roundButton.BackColor = System.Drawing.Color.LightGreen;
                ctPosiblePosition++;

            }


        }

        public virtual void deletePiece(int x, int y, WindowsFormsApplication1.RoundButton roundButton)
        {
            roundButton.BackColor = System.Drawing.Color.Black;
            board[x, y].pos = 0;
            board[x, y].xpos = 0;
            board[x, y].ypos = 0;
            board[x, y].pcolor = 'q';
            del = false;

        }

        public void deleteCurrentPosition(int x, int y, WindowsFormsApplication1.RoundButton roundButton)
        {


            if (isPlaceDone == 1 && movable == false && ctPosiblePosition != 0)
            {
                deletePiece(x, y, roundButton);
                movable = true;
                ctPosiblePosition = 0;

            }

        }
        public void place(int x, int y, WindowsFormsApplication1.RoundButton roundButton) 
        {

            if (p1Pieces == 0 && p2Pieces == 0)
            {

                isPlaceDone = 1;

            }
            if (board[x, y].pos != 1 && (p1Pieces != 0 || p2Pieces != 0) && isPlaceDone == 0)
            {
                if (p1 == 1)
                {
                   
                    pieceRedOrBlue(x, y, roundButton);
                    p1Pieces--;
                    indicationText = "Randul jucatorului albastru !";
                    if (millVerifyRow(x, y) == 1 || millVerifyCol(x, y) == 1)
                    {
                        indicationText = "MOARA ROSIE ! Alege o piesa albastra pe care sa o scoti!";
                        inGameP2Pieces--;
                        del = true;
                    }


                }
                else
                {
                   
                    pieceRedOrBlue(x, y, roundButton);
                    p2Pieces--;
                    indicationText = "Randul jucatorului rosu !";
                    if (millVerifyRow(x, y) == 1 || millVerifyCol(x, y) == 1)
                    {
                        indicationText = "MOARA ALBASTRA ! Alege o piesa rosie pe care sa o scoti !";
                        inGameP1Pieces--;
                        del = true;
                    }


                }
            }
            else
                    if (del == true)
            {
                if (roundButton.BackColor == System.Drawing.Color.Blue)
                    indicationText = "Randul jucatorului albastru !";
                else
                    indicationText = "Randul jucatorului rosu !";
                deletePiece(x, y, roundButton);
                turn();
            }

            turn();

        }

               
        public void movePiece(int x, int y, WindowsFormsApplication1.RoundButton roundButton)
        {


            if (roundButton.BackColor == System.Drawing.Color.LightGreen && movable == true)
            {
                if (p1 == 1)
                {

                    pieceRedOrBlue(x, y, roundButton);
                    movable = false;
                    ok = 1;
                    if (millVerifyRow(x, y) == 1 || millVerifyCol(x, y) == 1)
                    {
                        indicationText = "MOARA ROSIE ! Alege o piesa albastra pe care sa o scoti!";
                        inGameP2Pieces--;
                        delPiece = true;
                    }
                }
                else
                {

                    pieceRedOrBlue(x, y, roundButton);
                    movable = false;
                    ok = 1;
                    if (millVerifyRow(x, y) == 1 || millVerifyCol(x, y) == 1)
                    {
                        indicationText = "MOARA ALBASTRA ! Alege o piesa rosie pe care sa o scoti!";
                        inGameP1Pieces--;
                        delPiece = true;
                    }
                }
                if (movable == false && delPiece == false)
                {
                    if (roundButton.BackColor == System.Drawing.Color.Red)
                        indicationText = "Jucatorul albastru muta o piesa !";
                    else
                        indicationText = "Jucatorul rosu muta o piesa !";
                }
                turn();
            }


        }

        private void pieceRedOrBlue(int x, int y, WindowsFormsApplication1.RoundButton roundButton)
        {
            if (p1 == 1)
            {
                roundButton.BackColor = System.Drawing.Color.Red;
                board[x, y].pcolor = 'R';
            }
            else
            {
                roundButton.BackColor = System.Drawing.Color.Blue;
                board[x, y].pcolor = 'B';
            }
            board[x, y].pos = 1;
            board[x, y].xpos = x;
            board[x, y].ypos = y;
            

        }
        private int millVerifyRow(int x1, int y1) 
        {
            int i, j, ct1 = 0;
            if (x1 != 3)
            {
                for (i = 0; i < 7; i++)
                {

                    if (board[x1, i].pos == 1 && board[x1, i].pcolor == board[x1, y1].pcolor)
                    {
                        ct1++;
                    }

                }
            }
            if (x1 == 3 && y1 < 3)
            {
                for (i = 0; i < 3; i++)
                {
                    if (board[x1, i].pos == 1 && board[x1, i].pcolor == board[x1, y1].pcolor)
                    {
                        ct1++;
                    }
                }
            }
            if (x1 == 3 && y1 > 3)
            {
                for (i = 4; i < 7; i++)
                {
                    if (board[x1, i].pos == 1 && board[x1, i].pcolor == board[x1, y1].pcolor)
                    {
                        ct1++;
                    }
                }
            }

            if (ct1 == 3) 
            {

                return 1;

            }
            return 0;

        }
        private int millVerifyCol(int x1, int y1) 
        {
            int i, j, ct1 = 0;
            if (y1 != 3)
            {
                for (i = 0; i < 7; i++)
                {

                    if (board[i, y1].pos == 1 && board[i, y1].pcolor == board[x1, y1].pcolor)
                    {
                        ct1++;
                    }

                }
            }
            if (y1 == 3 && x1 < 3)
            {
                for (i = 0; i < 3; i++)
                {
                    if (board[i, y1].pos == 1 && board[i, y1].pcolor == board[x1, y1].pcolor)
                    {
                        ct1++;
                    }
                }
            }
            if (y1 == 3 && x1 > 3)
            {
                for (i = 4; i < 7; i++)
                {
                    if (board[i, y1].pos == 1 && board[i, y1].pcolor == board[x1, y1].pcolor)
                    {
                        ct1++;
                    }
                }
            }

            if (ct1 == 3) 
            {

                return 1;
            }
            return 0;

        }






    }
}
