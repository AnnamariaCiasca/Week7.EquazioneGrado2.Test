using Equazione;
using System;
using Xunit;

namespace Week7.EquazioneGrado2.Test
{
    public class EquazioneTest
    {
        [Fact]
        public void Test1()
        {
            // 1) Fase di Arrange: fase di predispozione del Test
            //Dobbiamo chiamare classe Equation

            Equation equazione = new Equation();

            // 2) Fase di ACT: chiamata alla funzione da testare

            double[] risultato = equazione.RisolviEquazioneSecondoGrado(1, -3, 2);

            // 3) Fase di Assert: verifica del risultato

            Assert.True(risultato.Length == 2);
            Assert.Equal(1, risultato[0]);  //primo risultato --> potrei scrivere anche Assert.True(risultato[0] == 1)
            Assert.Equal(2, risultato[1]);  //secondo risultato

        }

        [Fact]
        public void Test2()
        {
            // 1) Fase di Arrange: fase di predispozione del Test
            //Dobbiamo chiamare classe Equation

            Equation equazione = new Equation();

            // 2) Fase di ACT: chiamata alla funzione da testare

            double[] risultato = equazione.RisolviEquazioneSecondoGrado(1, -5, 6);

            // 3) Fase di Assert: verifica del risultato

            Assert.True(risultato.Length == 2);
            Assert.Equal(2, risultato[0]);  //primo risultato --> potrei scrivere anche Assert.True(risultato[0] == 1)
            Assert.Equal(3, risultato[1]);  //secondo risultato

        }
      
        
        [Fact]
        public void Test3()
        {
            // 1) Fase di Arrange: fase di predispozione del Test
            //Dobbiamo chiamare classe Equation

            Equation equazione = new Equation();

            // 2) Fase di ACT: chiamata alla funzione da testare

            double[] risultato = equazione.RisolviEquazioneSecondoGrado(1, 2, 1);

            // 3) Fase di Assert: verifica del risultato

            Assert.True(risultato.Length == 1);
            Assert.Equal(-1, risultato[0]);  //primo risultato --> potrei scrivere anche Assert.True(risultato[0] == 1)
           

        }


        [Fact]
        public void Test4()
        {
            // 1) Fase di Arrange: fase di predispozione del Test
            //Dobbiamo chiamare classe Equation

            Equation equazione = new Equation();

            // 2) Fase di ACT: chiamata alla funzione da testare

            double[] risultato = equazione.RisolviEquazioneSecondoGrado(1, -3, 10);

            // 3) Fase di Assert: verifica del risultato

            Assert.True(risultato == null);
          


        }
    }
}
