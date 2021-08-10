using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalNoticiasNovo.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;

        /*
            É estático para não precisar instanciar a classe RepositórioNoticias
            para obter essa lista, podemos acessar essa lista diretamente
            por meio da classe.
         */

        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null)
                {
                    CriarNoticias();
                }
                return noticias;
            }
        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();
            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Amazônia",
                Autor = "Carlos Vieira",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = " é uma floresta latifoliada úmida que cobre a maior parte da Bacia Amazônica da América do Sul. " +
            "Esta bacia abrange 7 milhões de quilômetros quadrados, " +
            "dos quais 5 milhões e meio de quilômetros quadrados são cobertos pela floresta tropical."
            });

            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "ICMBio alerta para alimentação irregular de tubarões feita em passeios de barco em Noronha",
                Autor = "G1",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "O Instituto Chico Mendes da Biodiversidade (ICMBio) divulgou, nesta quarta (2), " +
                "um ofício sobre alimentação irregular de tubarões em Fernando de Noronha. " +
                "O documento faz um alerta aos donos de embarcações para a prática, considerada crime ambiental. " +
                "Segundo o órgão, essa atividade vem sendo feita, " +
                "na região do Porto de Santo Antônio, por pessoas que realizam passeios turísticos em barcos."
            });

            noticias.Add(new Noticia
            {
                Id = 3,
                Titulo = "Vasco relaciona Marquinhos Gabriel e Michel para duelo contra a Ponte Preta",
                Autor = "Vasco da Gama",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "O Vasco terá duas novidades para o jogo contra a Ponte Preta, " +
                "neste domingo, pela Série B do Campeonato Brasileiro. " +
                "O meia Marquinhos Gabriel e o volante Michel foram relacionados pelo técnico Marcelo Cabo para a partida. " +
                "A delegação viaja para Campinas no início da tarde deste sábado."
            });

            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "Anvisa analisa nesta sexta-feira novos pedidos de liberação das vacinas Covaxin e Sputnik V",
                Autor = "Bem estar",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "A Agência Nacional de Vigilância Sanitária (Anvisa) se reúne na tarde desta sexta-feira (4) para analisar novos pedidos de liberação de duas vacinas contra a Covid-19: a russa Sputnik V e a indiana Covaxin. O encontro está previsto para começar às 14h."
            });

            noticias.Add(new Noticia
            {
                Id = 5,
                Titulo = "Entenda os principais pontos do acordo do G7 para tributar multinacionais",
                Autor = "Economia mundo",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "As potências do G7 chegaram, neste sábado (5), a um acordo histórico sobre um imposto para as grandes empresas. Além disso, comprometeram-se com as mudanças climáticas, a ajuda aos países pobres e a recuperação da pandemia."
            });
        }
    }
}