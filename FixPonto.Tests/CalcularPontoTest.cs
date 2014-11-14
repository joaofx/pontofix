using System;
using NUnit.Framework;
using Should;

namespace FixPonto.Tests
{
	[TestFixture]
	public class CalcularPontoTest
	{
		[Test]
		public void Deve_calcular_ponto_com_todas_as_batidas_e_periodos()
		{
			var dias = new CalcularPonto().Calcular(Fixtures.CatracaDefault, Fixtures.PeriodosDefault);
			dias.Count.ShouldEqual(31);
		}

		[Test]
		[ExpectedException(typeof(ParseException))]
		public void Catraca_nao_deve_comecar_com_linha_em_branco()
		{
			var catraca = @"

09:16	11:27	12:51	19:21
09:20	11:33	12:42	18:56";		

			new CalcularPonto().Calcular(catraca, Fixtures.PeriodosDefault);
		}

		[Test]
		[ExpectedException(typeof(ParseException))]
		public void Periodo_nao_deve_comecar_com_linha_em_branco()
		{
			var periodo = @"

09:16	11:27	12:51	19:21
09:20	11:33	12:42	18:56";		

			new CalcularPonto().Calcular(Fixtures.CatracaDefault, periodo);
		}


		[Test]
		[ExpectedException(typeof(ParseException))]
		public void Catraca_nao_pode_ser_vazio()
		{
			new CalcularPonto().Calcular(string.Empty, Fixtures.PeriodosDefault);
		}

		[Test]
		[ExpectedException(typeof(ParseException))]
		public void Periodos_nao_pode_ser_vazio()
		{
			new CalcularPonto().Calcular(Fixtures.CatracaDefault, string.Empty);
		}
	}
}

