using System;

namespace PalestraLibrary
{
    public class Gestione
    {
        public static string RichiestaUtente(int a)
        {
            if (a == 1)
            {
                return "La tariffa più conveniente è quella da un mese";
            }
            else if (a >= 3 && a < 12)
            {
                return "La tariffa più conveniente è quella da tre mesi";
            }
            else if (a >= 12)
            {
                return "La tariffa più conveniente è quella da dodici mesi";
            }
            else
            {
                return "La tariffa non è rispettata";
            }
        }
    }
}
