using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    class HoraClass
    {
        private string Hora;

        /// <summary>
        /// Entrada da hora de normalização a ser calculada (00:00:00)
        /// </summary>
        /// <param name="Entrada">Inserir hora de normalização - do Router)</param>
        public void Entrada(string Entrada)

        { this.Hora = Entrada; }  // Faz a Entrada dos dados e carrega na variavel Hora


        /// <summary>
        /// Saida com data e hora da normalização (aa/dd/aaaa 00:00:00)
        /// </summary>
        /// <returns></returns>
        public string Saida()

        {
            LocalizaTexto();
            Hora = CalcularHora();

            return Hora;
        }

        /// <summary>
        /// O metodo localiza as letras entre as hora (00h00m00s),
        /// caso tenha substitui por dois pontos e retornar no o formato(00:00:00)
        /// </summary>
        private void LocalizaTexto()

        {
            string h = Hora;

            string horaAntes;
            string horaDepois;

            if ( h.IndexOf("m") >= 0 )

            // testa se tem a letra 'm' e substitui por ':'

            {
                int mostrar;
                mostrar = h.IndexOf("m");
                h = h.Substring(0, mostrar);
                //horaAntes = h.Substring(0, mostrar);
                //h = horaAntes + ":00";

                Debug.WriteLine("Minuto e segundo convertido " + h);
            }


            if ( h.IndexOf("h") >= 0 )

            // testa se tem a letra 'h' e substitui por ':'

            {
                int mostrar = h.IndexOf("h");           // carrega na variavel a 'posição' da letra 'h' na string hora 1 com base no 1 caracter
                horaAntes = h.Substring(0, mostrar);    // carrega na variavel o conteudo da hora1 com base na (posição onde inicia a captura, quantidade de caracter)
                horaDepois = h.Substring(mostrar + 1);  // como não tem quantidade de caracteres foi ate o final
                h = horaAntes + ":" + horaDepois;      // retorna ao metodo o resuldado convertido

                Debug.WriteLine("Hora convertida " + h);
            }

            Hora = h;
            Debug.WriteLine("Variavel Hora no final no metodo localiza texto: " + Hora);

        } // Fim do LocalizaTexto()


        /// <summary>
        /// Calcula a data em que o circuito foi normalizado de acordo com o tempo de normalização
        /// </summary>
        private string CalcularHora()

        {

            string[] vetHora = Hora.Split(':');

            //int s = int.Parse(vetHora[2]);
            int h = int.Parse(vetHora[0]);           
            int m = int.Parse(vetHora[1]); 
                
            int d = DateTime.Now.Day;
            int hr = DateTime.Now.Hour - h;
            int mm = DateTime.Now.Minute - m;
            //int ss = DateTime.Now.Second - s;

            //while ( ss < 0 )
            //{
            //    ss = ss + 60;

            //    mm = mm - 1;
            //}

            while ( mm < 0 )
            {
                mm = mm + 60;

                hr = hr - 1;
            }

            while ( hr < 0 )
            {
                hr = hr + 24;

                d = d - 1;                
            }

           return ( d + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + hr + ":" + mm + ":00");

        } // Fim do ConverterHora
    }
}