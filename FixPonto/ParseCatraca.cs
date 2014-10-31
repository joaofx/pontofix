namespace FixPonto
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ParseCatraca
    {
        public static List<string> Parse(string batidas)
        {
            var linhas = Regex.Split(batidas, "\r\n|\r|\n");
			var dias = new List<string>();

            foreach (var linha in linhas)
            {
                if (string.IsNullOrEmpty(linha) || string.IsNullOrEmpty(linha.Trim()))
                {
                    continue;
                }

                //// se a linha do dia foi quebrada, adiciona no dia anterior
                if (linha.StartsWith(" ") && linha.Substring(3, 1).Equals(":"))
                {
					dias[dias.Count - 1] += "  " + LimparLinha(linha);
                    continue;
                }

				dias.Add(LimparLinha(linha));
            }

            return dias;
        }
			
		private static string LimparLinha(string linha)
		{
			return linha.Replace("\"", "").Replace("\t", "").Trim();
		}
    }
}
