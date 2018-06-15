using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutor
{
        public class Time
        {
            public string Nome { get; set; }

            public int QuantidadeGols { get; set; }

            public string Pais { get; set; }

            public int QuantidadeGolsSofridos { get; set; }
                       
            public int QuantidadeCartoesAmarelos { get; set; }
                       
            public int QuantidadesSusbtituicoes { get; set; }
                       
            public short quantidadeFinais { get; set; }

            public short quantidadeSemiFinais { get; set; }

            public short quantidadeVitorias { get; set; }

            public decimal faturamento { get; set; }

            public string Serie { get; set; }

            public string quantidadeDerrotas { get; set; }

            public string quantidadeGolsContras { get; set; }

            public Time(string nome, string pais, string serie)
            {
                Nome = nome;
                Pais = pais;
                Serie = serie;
            }

            public Time(string nome, string pais)
            {
                Nome = nome;
                Pais = pais;
            }

            public Time(string nome, string serie, decimal faturamento)
            {


            }
            // quantidadeGolsFeitos
            //país
            //quantidadeGolsSofridos
            //quantidadeCartoesAmarelos
            //quantidadesSusbtituicoes
            //quantidadeFinais
            //quantidadeSemiFinais
            //quantidadeVitorias
            //faturamento decimal
            //serie
            //
        }
    }

