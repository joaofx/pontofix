using System;

namespace FixPonto.Tests
{
    using NUnit.Framework;
    using Should;

    [TestFixture]
    public class DiaTest
    {
//		[Test]
//		public void Deve_calcular_dia_com_um_intervalo_descontavel()
//		{
//			var dia = new Dia(
//				"01/10 09:16  09:30  09:31  09:46  09:47  11:27  12:51  16:10  16:19  19:20  19:20  19:21",
//				"09:16\t11:27\t12:51\t19:21");
//
//			dia.Data.ShouldEqual("01/10");
//
//			dia.Intervalos[0].SaidaTexto.ShouldEqual("09:30");
//			dia.Intervalos[0].VoltaTexto.ShouldEqual("09:31");
//			dia.Intervalos[0].MinutosIntervalo.ShouldEqual(1);
//			dia.Intervalos[0].MinutosIntervaloDescontaveis.ShouldEqual(0);
//
//			dia.Intervalos[1].SaidaTexto.ShouldEqual("09:46");
//			dia.Intervalos[1].VoltaTexto.ShouldEqual("09:47");
//			dia.Intervalos[1].MinutosIntervalo.ShouldEqual(1);
//			dia.Intervalos[0].MinutosIntervaloDescontaveis.ShouldEqual(0);
//
//			dia.Intervalos[2].SaidaTexto.ShouldEqual("11:27");
//			dia.Intervalos[2].VoltaTexto.ShouldEqual("12:51");
//			dia.Intervalos[2].MinutosIntervalo.ShouldEqual(84);
//			dia.Intervalos[2].MinutosIntervaloDescontaveis.ShouldEqual(84);
//
//			dia.Intervalos[3].SaidaTexto.ShouldEqual("16:10");
//			dia.Intervalos[3].VoltaTexto.ShouldEqual("16:19");
//			dia.Intervalos[3].MinutosIntervalo.ShouldEqual(9);
//			dia.Intervalos[3].MinutosIntervaloDescontaveis.ShouldEqual(9);
//
//			dia.Almoco.SaidaTexto.ShouldEqual("11:27");
//			dia.Almoco.VoltaTexto.ShouldEqual("12:51");
//
//			dia.MinutosDeDesconto.ShouldEqual(9);
//			dia.NovaEntradaAlmoco.ShouldEqual(TimeSpan.Parse("13:00"));
//		}
//
//		[Test]
//		public void Deve_calcular_dia_com_um_almoco_ajustado()
//		{
//			var dia = new Dia(
//				"14/10 09:37  09:42  09:43  09:43  09:44  11:51  12:49  16:33 16:45  19:53",
//				"09:37\t11:51\t12:51\t19:53");
//
//			dia.Data.ShouldEqual("14/10");
//			dia.Intervalos.Count.ShouldEqual(4);
//
//			dia.Intervalos[0].MinutosIntervalo.ShouldEqual(1);
//			dia.Intervalos[0].MinutosIntervaloDescontaveis.ShouldEqual(0);
//
//			dia.Intervalos[1].MinutosIntervalo.ShouldEqual(1);
//			dia.Intervalos[1].MinutosIntervaloDescontaveis.ShouldEqual(0);
//
//			dia.Intervalos[3].MinutosIntervalo.ShouldEqual(12);
//			dia.Intervalos[3].MinutosIntervaloDescontaveis.ShouldEqual(12);
//
//			dia.Almoco.SaidaTexto.ShouldEqual("11:51");
//			dia.Almoco.VoltaTexto.ShouldEqual("12:51");
//
//			dia.MinutosDeDesconto.ShouldEqual(12);
//			dia.NovaEntradaAlmoco.ShouldEqual(TimeSpan.Parse("13:03"));
//		}
//
//		[Test]
//		public void Bug_nao_calculou_corretamente_ponto_do_rafael()
//		{
//			var dia = new Dia(
//				"31/10 06:57 07:51 08:00 11:43 12:56 17:53",
//				"06:57 11:43 12:56 17:53");
//
//			dia.Data.ShouldEqual("31/10");
//			dia.Intervalos.Count.ShouldEqual(2);
//
//			dia.Intervalos[0].MinutosIntervalo.ShouldEqual(9);
//			dia.Intervalos[0].MinutosIntervaloDescontaveis.ShouldEqual(9);
//
//			dia.NovaEntradaAlmoco.ShouldEqual(TimeSpan.Parse("13:05"));
//		}
//
//		[Test]
//		public void Bug_nao_calculou_corretamente_ponto_da_rayanne()
//		{
//			var dia = new Dia(
//				"01/10 09:20 09:30 09:31 09:46 09:47 11:29 12:51 16:10 16:19 19:30",
//				"09:20 11:29 12:51 19:30");
//
//			dia.Intervalos[3].MinutosIntervalo.ShouldEqual(9);
//			dia.Intervalos[3].MinutosIntervaloDescontaveis.ShouldEqual(9);
//
//			dia.NovaEntradaAlmoco.ShouldEqual(TimeSpan.Parse("13:00"));
//		}
//
//		[Test]
//		public void Bug_nao_calculou_corretamente_ponto_do_rogerio()
//		{
//			var dia = new Dia(
//				"22/10 09:28 10:02 10:03 10:14 10:15 11:39 12:27 15:50 16:08 18:40",
//				"09:28 11:39 12:39 18:40");
//
//			dia.Intervalos[3].MinutosIntervalo.ShouldEqual(18);
//			dia.Intervalos[3].MinutosIntervaloDescontaveis.ShouldEqual(18);
//
//			dia.NovaEntradaAlmoco.ShouldEqual(TimeSpan.Parse("12:57"));
//		}
//
//		[Test]
//		public void Deve_tratar_dia_sem_batidas()
//		{
//			var dia = new Dia("30/10				", "    ");
//			dia.Intervalos.Count.ShouldEqual(0);
//		}
    }
}
