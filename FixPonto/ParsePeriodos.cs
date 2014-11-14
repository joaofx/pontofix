namespace FixPonto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ParsePeriodos
    {
        public static List<string> Parse(string conteudo)
        {
			var periodos = new List<string>();
			var linhas = conteudo.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

			foreach (var linha in linhas)
			{
				var linhaLimpa = LimparLinha(linha);

				if (string.IsNullOrEmpty(linhaLimpa) == false)
				{
					periodos.Add(linhaLimpa);
				}

				Console.WriteLine(linhaLimpa);
			}

			return periodos.Select(LimparLinha).ToList();
        }

		public static Intervalo ParseLinha(string linha)
		{
			var campos = linha.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
			return new Intervalo(campos[1], campos[2]);
		}

		private static string LimparLinha(string linha)
		{
			return linha.Replace("\"", "").Replace(" ", "").Trim();
		}
    }
}
