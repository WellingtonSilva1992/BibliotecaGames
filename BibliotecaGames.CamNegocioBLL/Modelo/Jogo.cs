using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.CamNegocioBLL.Modelo
{
    public class Jogo
    {
        public int id_Jogo { get; set; }
        public String Titulo_Jogo { get; set; }
        public double ValorPago_Jogo { get; set; }
        public string Imagem_Jogo { get; set; }
        public DateTime DataCompra_Jogo { get; set; }

    }
}
