using System.Collections.Generic;

namespace ReportCCPChekBilance
{
    public class StringConnectionParse
    {
        //Restituisce i valori
        public readonly List<Parser> Parses = new List<Parser>();

        /// <summary>
        ///     Passare tutta la stringa di connessione
        /// </summary>
        /// <param name="ConnectionString"></param>
        public void Parse(string ConnectionString)
        {
            var splitOne = ConnectionString.Split(';');

            foreach (var t in splitOne)
            {
                var splitTwo = t.Split('=');

                var parser = new Parser {Parametro = splitTwo[0], Valore = splitTwo[1]};

                Parses.Add(parser);
            }
        }

        public class Parser
        {
            public string Parametro { get; set; }
            public string Valore { get; set; }
        }
    }
}
