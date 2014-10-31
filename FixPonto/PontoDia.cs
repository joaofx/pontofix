namespace FixPonto
{
    using System;
    using System.Collections.Generic;

    public class PontoDia
    {
		public PontoDia(string batidasTexto, string periodosTexto)
		{
			this.BatidasTexto = batidasTexto;
			this.PeriodoTexto = periodosTexto;

			this.Almoco = this.ParseBatidas(periodosTexto, 0)[0];

			this.Batidas = new List<string>();
			this.Intervalos = this.ParseBatidas(batidasTexto);
        }

		public string BatidasTexto
        {
            get;
            private set;
        }

		public string PeriodoTexto
		{
			get;
			private set;
		}

        public string Dia
        {
            get;
            set;
        }

		public List<string> Batidas
        {
            get;
            set;
        }

		public List<Intervalo> Intervalos
		{
			get;
			set;
		}

		public Intervalo Almoco
		{
			get;
			set;
		}

		public TimeSpan NovaEntradaAlmoco 
		{
			get
			{
				return this.Almoco.Volta.Add(TimeSpan.FromMinutes(this.MinutosDesconto));
			}
		}

		public double MinutosDesconto 
		{
			get 
			{
				double total = 0;

				foreach (var intervalo in this.Intervalos)
				{
					if (intervalo.EhAlmoco(this.Almoco) == false)
					{
						total += intervalo.MinutosIntervaloDescontaveis;
					}
				}

				return total;
			}
		}

        public string NovaEntradaAlmocoTexto
        {
            get
            {
                return new DateTime(this.NovaEntradaAlmoco.Ticks).ToString("HH:mm"); 
            }
        }

        private List<Intervalo> ParseBatidas(string texto, int startIndex = 1)
		{
			var batidas = new List<string>();

			var campos = texto
				.Replace("\t", " ")
				.Split(new[] { " " }, System.StringSplitOptions.RemoveEmptyEntries);

			this.Dia = campos[0];

			for (var i = startIndex; i < campos.Length; i++) 
			{
				batidas.Add(campos[i]);
			}

			return this.IdentificarIntervalos(batidas);
		}

		private List<Intervalo> IdentificarIntervalos(List<string> batidas)
		{
			var intervalos = new List<Intervalo>();

			for (var i = 1; i < batidas.Count - 1; i++)
			{
				var saida = batidas[i];
				var volta = batidas[i + 1];

				intervalos.Add(new Intervalo(saida, volta));

				i++;
			}

			return intervalos;
		}
    }
}