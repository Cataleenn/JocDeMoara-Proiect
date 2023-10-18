using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JocMoara
{
    class Game
    {

        private int var, num, x, y;
        public int p1, p2;
        public Board[,] board = new Board[7, 7];
        Random rnd = new Random();
        public string indicationText;

        protected void firstturn() //Decide random care jucator incepe
        {

            num = rnd.Next(0, 100);
            if (num > 50)
            {
                p1 = 1; p2 = 0;

                indicationText = "Jucatorul rosu va incepe jocul !";
            }
            else
            {
                p2 = 1; p1 = 0;


                indicationText = "Jucatorul albastru va incepe jocul !";
            }
        }
        public void turn() // Schimba randul jucatorilor
        {

            var = p1;
            p1 = p2;
            p2 = var;
            

        }

        private void fillboard() //umple pozitiile inutile
        {
            for (int x = 0; x < 7; x++)
                for (int y = 0; y < 7; y++)
                    board[x, y].pos = 99;

        }






    }
}
