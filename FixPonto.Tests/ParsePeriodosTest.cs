namespace FixPonto.Tests
{
    using NUnit.Framework;
    using Should;

    [TestFixture]
    public class ParsePeriodosTest
    {
        const string Conteudo = @"09:16	11:27	12:51	19:21
09:20	11:33	12:42	18:56
09:25	11:37	12:44	19:28
			
			
09:13	11:49	12:56	19:38
09:18	11:51	13:00	19:21
09:09	12:09	13:11	18:39
09:12	11:38	12:44	19:30
09:37	11:41	13:01	19:18
			
			
09:55	11:37	12:53	19:37
09:37	11:51	12:51	19:53
09:20	11:35	12:41	19:15
09:25	11:39	12:39	19:01
09:40	11:47	12:47	17:49
			
			
09:11	11:56	12:56	20:10
09:17	11:59	13:07	19:49
09:26	11:39	12:39	20:38
09:21	11:56	12:56	18:14
10:14	11:47	13:11	19:42
			
			
09:33	11:43	12:43	20:02
09:32	12:16	13:16	19:57
09:44	11:54	12:54	20:22
09:43	11:55	13:10	20:16
			

";

        [Test]
        public void Deve_fazer_parse_dos_periodos_retornando_linhas()
        {
			var linhas = ParsePeriodos.Parse(Conteudo);
            linhas.Count.ShouldEqual(33);
			linhas[0].ShouldEqual("09:16\t11:27\t12:51\t19:21");
			linhas[1].ShouldEqual("09:20\t11:33\t12:42\t18:56");
			linhas[29].ShouldEqual("09:43\t11:55\t13:10\t20:16");
        }

		[Test]
		public void Deve_fazer_parse_da_linha_retornando_intervalos()
		{
			var intervalo = ParsePeriodos.ParseLinha("09:16\t11:27\t12:51\t19:21");
			intervalo.SaidaTexto.ShouldEqual("11:27");
			intervalo.VoltaTexto.ShouldEqual("12:51");
		}
    }
}
