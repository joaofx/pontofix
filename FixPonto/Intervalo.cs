namespace FixPonto
{
    using System;

    public class Intervalo
	{
		private const double MinutosIntervaloAceitavel = 5;

		public Intervalo(string saidaTexto, string voltaTexto)
		{
			this.SaidaTexto = saidaTexto;
			this.VoltaTexto = voltaTexto;
		
			this.Saida = TimeSpan.Parse(this.SaidaTexto);
			this.Volta = TimeSpan.Parse(this.VoltaTexto);
		}

		public string SaidaTexto { get; private set; }
		public string VoltaTexto { get; private set; }

		public TimeSpan Saida { get; private set; }
		public TimeSpan Volta { get; private set; }

		public double MinutosIntervalo
		{
			get 
			{ 
				return this.Volta.Subtract(this.Saida).TotalMinutes;
			}
		}

		public double MinutosIntervaloDescontaveis
		{
			get
			{
				if (this.MinutosIntervalo > MinutosIntervaloAceitavel)
				{
					return this.MinutosIntervalo;
				}

				return 0;
			}
		}

		public bool EhAlmoco(Intervalo intervaloAlmoco)
		{
			return this.SaidaTexto.Equals(intervaloAlmoco.SaidaTexto);
		}
	}
}