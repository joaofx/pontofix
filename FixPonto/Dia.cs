namespace FixPonto
{
    using System;
    using System.Collections.Generic;
	using System.Linq;

    public class Dia
    {
		private string batidasTexto;
		private string periodosTexto;

		public Dia(string batidasTexto, string periodosTexto)
		{
			this.batidasTexto = batidasTexto;
			this.periodosTexto = periodosTexto;

			this.Almoco = this.ObterAlmoco(periodosTexto);
			this.Intervalos = this.ParseIntervalos(batidasTexto);

			this.MinutosDeDesconto = this.CalcularMinutosDeDesconto();
        }

        public string Data
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
				return this.Almoco.Volta.Add(TimeSpan.FromMinutes(this.MinutosDeDesconto));
			}
		}

		public double MinutosDeDesconto 
		{
			get;
			private set;
		}

		private double CalcularMinutosDeDesconto()
		{
			return this.Intervalos.Sum(
				intervalo => intervalo.EhAlmoco(this.Almoco) == false ? intervalo.MinutosIntervaloDescontaveis : 0);
		}

		private Intervalo ObterAlmoco(string periodosTexto)
		{
			return this.ParseIntervalos(periodosTexto, 0).SingleOrDefault();
		}

        private List<Intervalo> ParseIntervalos(string texto, int startIndex = 1)
		{
			var batidas = new List<string>();

			var campos = texto
				.Replace("\t", " ")
				.Split(new[] { " " }, System.StringSplitOptions.RemoveEmptyEntries);

			if (campos.Length == 0)
			{
				return new List<Intervalo>();
			}

			this.Data = campos[0];

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