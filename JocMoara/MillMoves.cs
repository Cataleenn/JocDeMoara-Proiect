using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JocMoara
{
    class MillMoves:Mill
    {

        public override void deletePiece(int x, int y, WindowsFormsApplication1.RoundButton roundButton)
        {
           
            if (delPiece == true)
            {
                if (roundButton.BackColor == System.Drawing.Color.Red)
                    base.indicationText = "Jucatorul rosu muta o piesa !";
                else
                    base.indicationText = "Jucatorul albastru muta o piesa !";

                base.deletePiece(x, y, roundButton);
                delPiece = false;
            }         
            else
                base.deletePiece(x, y, roundButton);     

        }



    }
}
