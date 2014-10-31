namespace FixPonto.Tests
{
    using NUnit.Framework;
    using Should;

    [TestFixture]
    public class IntervaloTest
    {
		[Test]
		public void Deve_reconhecer_intervalos_de_almoco()
		{
			var intervalo = new Intervalo("11:27", "12:51");

			var intervaloAlmoco = new Intervalo("11:27", "12:47");
			intervalo.EhAlmoco(intervaloAlmoco).ShouldBeTrue();

			var outroIntervalo = new Intervalo("11:30", "12:47");
			intervalo.EhAlmoco(outroIntervalo).ShouldBeFalse();
		}

		[Test]
		public void Deve_retornar_intervalos_descontaveis()
		{
			var intervalo1 = new Intervalo("16:10", "16:19");
			intervalo1.MinutosIntervalo.ShouldEqual(9);
			intervalo1.MinutosIntervaloDescontaveis.ShouldEqual(9);

			var intervalo2 = new Intervalo("09:30", "09:31");
			intervalo2.MinutosIntervalo.ShouldEqual(1);
			intervalo2.MinutosIntervaloDescontaveis.ShouldEqual(0);
		}
    }
}
