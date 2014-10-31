using System;

namespace FixPonto.Tests
{
    using NUnit.Framework;
    using Should;

    [TestFixture]
    public class PontoDiaAcceptanceTest
    {
		[Test]
		public void Deve_calcular_dia_com_um_intervalo_descontavel()
		{
			var dia = new PontoDia(
				"01/10 09:16  09:30  09:31  09:46  09:47  11:27  12:51  16:10  16:19  19:20  19:20  19:21",
				"09:16\t11:27\t12:51\t19:21");

			dia.Dia.ShouldEqual("01/10");

			dia.Intervalos[0].SaidaTexto.ShouldEqual("09:30");
			dia.Intervalos[0].VoltaTexto.ShouldEqual("09:31");
			dia.Intervalos[0].MinutosIntervalo.ShouldEqual(1);
			dia.Intervalos[0].MinutosIntervaloDescontaveis.ShouldEqual(0);

			dia.Intervalos[1].SaidaTexto.ShouldEqual("09:46");
			dia.Intervalos[1].VoltaTexto.ShouldEqual("09:47");
			dia.Intervalos[1].MinutosIntervalo.ShouldEqual(1);
			dia.Intervalos[0].MinutosIntervaloDescontaveis.ShouldEqual(0);

			dia.Intervalos[2].SaidaTexto.ShouldEqual("11:27");
			dia.Intervalos[2].VoltaTexto.ShouldEqual("12:51");
			dia.Intervalos[2].MinutosIntervalo.ShouldEqual(84);
			dia.Intervalos[2].MinutosIntervaloDescontaveis.ShouldEqual(84);

			dia.Intervalos[3].SaidaTexto.ShouldEqual("16:10");
			dia.Intervalos[3].VoltaTexto.ShouldEqual("16:19");
			dia.Intervalos[3].MinutosIntervalo.ShouldEqual(9);
			dia.Intervalos[3].MinutosIntervaloDescontaveis.ShouldEqual(9);

			dia.Almoco.SaidaTexto.ShouldEqual("11:27");
			dia.Almoco.VoltaTexto.ShouldEqual("12:51");

			dia.MinutosDesconto.ShouldEqual(9);
			dia.NovaEntradaAlmoco.ShouldEqual(TimeSpan.Parse("13:00"));
		}

		[Test]
		public void Deve_calcular_dia_com_um_almoco_ajustado()
		{
			var dia = new PontoDia(
				"14/10 09:37  09:42  09:43  09:43  09:44  11:51  12:49  16:33 16:45  19:53",
				"09:37\t11:51\t12:51\t19:53");

			dia.Dia.ShouldEqual("14/10");
			dia.Intervalos.Count.ShouldEqual(4);

			dia.Intervalos[0].MinutosIntervalo.ShouldEqual(1);
			dia.Intervalos[0].MinutosIntervaloDescontaveis.ShouldEqual(0);

			dia.Intervalos[1].MinutosIntervalo.ShouldEqual(1);
			dia.Intervalos[1].MinutosIntervaloDescontaveis.ShouldEqual(0);

			dia.Intervalos[3].MinutosIntervalo.ShouldEqual(12);
			dia.Intervalos[3].MinutosIntervaloDescontaveis.ShouldEqual(12);

			dia.Almoco.SaidaTexto.ShouldEqual("11:51");
			dia.Almoco.VoltaTexto.ShouldEqual("12:51");

			dia.MinutosDesconto.ShouldEqual(12);
			dia.NovaEntradaAlmoco.ShouldEqual(TimeSpan.Parse("13:03"));
		}
    }
}
