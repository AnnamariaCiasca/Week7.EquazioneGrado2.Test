using System;

namespace Equazione
{
    public class Equation
    {
        public double[] RisolviEquazioneSecondoGrado(double a, double b, double c)
        {
            //Calcolo del Delta

            double delta = Math.Pow(b, 2) - (4 * a * c);
            double[] risultato;
           
            if(delta == 0)
            {
                risultato = new double[1]; //un'unica soluzione
                risultato[0] = -b/(2*a);
               
                return risultato;
            }
            if (delta > 0)
            {
                risultato = new double[2];  //2 soluzioni
                risultato[0] = (- b - Math.Sqrt(delta))/(2 * a);  //prima soluzione
                risultato[1] = (- b + Math.Sqrt(delta)) / (2 * a);  //seconda soluzione

                return risultato;
            }

            return null;

        }
    }
}
