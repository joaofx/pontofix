using System;
using System.Collections.Generic;

namespace FixPonto
{
	public class CalcularPonto
	{
		public List<Dia> Calcular(string catraca, string periodos)
		{
			this.DispararExcecaoCasoEntradaSejaInvalida("Catraca", catraca);
			this.DispararExcecaoCasoEntradaSejaInvalida("Periodos", periodos);

			return new List<Dia>();

//			var catracaDias = this.ExtrairDiasDaCatraca(catraca);
//			var periodoDias = ParsePeriodos.Parse(periodos);
//
//			var dias = new List<Dia>();
//
//			for (int index = 0; index < catracaDias.Count; index++)
//			{
//				var catracaDia = catracaDias[index];
//				var periodoDia = periodoDias[index];
//
//				dias.Add(new Dia(catracaDia, periodoDia));
//			}
//
//			return dias;
		}

		private List<string> ExtrairDiasDaCatraca(string catraca)
		{
			return new List<string>();
		}

		private void DispararExcecaoCasoEntradaSejaInvalida(string campo, string valor)
		{
			if (string.IsNullOrEmpty(valor))
			{
				throw new ParseException(string.Format("{0} nao pode ser vazio", campo));
			}

			if (char.IsDigit(valor[0]) == false)
			{
				throw new ParseException(string.Format("{0} deve começar com um numero (data ou hora)", campo));
			}
		}
	}
}

