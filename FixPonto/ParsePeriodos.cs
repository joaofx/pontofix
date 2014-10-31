namespace FixPonto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ParsePeriodos
    {
        public static List<string> Parse(string batidas)
        {
            var linhas = Regex.Split(batidas, "\r\n|\r|\n");
            return linhas.Select(LimparLinha).ToList();
        }

		public static Intervalo ParseLinha(string linha)
		{
			var campos = linha.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
			return new Intervalo(campos[1], campos[2]);
		}

		private static string LimparLinha(string linha)
		{
			return linha.Replace("\"", "").Trim();
		}
    }
}
